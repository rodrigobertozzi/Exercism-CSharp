using System;
using System.Linq;

public static class TelemetryBuffer
{
    public static byte[] ToBuffer(long reading)
    {
        var toBuffer = reading switch
        {
            < Int32.MinValue => BitConverter.GetBytes((long)reading).Prepend((byte)(256 - 8)),
            < Int16.MinValue => BitConverter.GetBytes((int)reading).Prepend((byte)(256 - 4)),
            < UInt16.MinValue => BitConverter.GetBytes((short)reading).Prepend((byte)(256 - 2)),
            <= UInt16.MaxValue => BitConverter.GetBytes((ushort)reading).Prepend((byte)2),
            <= Int32.MaxValue => BitConverter.GetBytes((int)reading).Prepend((byte)(256 - 4)),
            <= UInt32.MaxValue => BitConverter.GetBytes((uint)reading).Prepend((byte)4),
            _ => BitConverter.GetBytes((long)reading).Prepend((byte)(256 - 8)),
        };
        return toBuffer.Concat(new byte[9 - toBuffer.Count()]).ToArray();
    }

    public static long FromBuffer(byte[] buffer)
    {
        switch ((sbyte)buffer[0])
        {
            case -8:
                return BitConverter.ToInt64(buffer, 1);
            case 4:
                return BitConverter.ToUInt32(buffer, 1);
            case -4:
                return BitConverter.ToInt32(buffer, 1);
            case 2:
                return BitConverter.ToUInt16(buffer, 1);
            case -2:
                return BitConverter.ToInt16(buffer, 1);
            default:
                return 0;

        }
    }

}
