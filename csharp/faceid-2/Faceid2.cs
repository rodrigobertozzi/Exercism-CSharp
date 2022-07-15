using System;
using System.Collections.Generic;

public class FacialFeatures
{
    public string EyeColor { get; }
    public decimal PhiltrumWidth { get; }

    public FacialFeatures(string eyeColor, decimal philtrumWidth)
    {
        EyeColor = eyeColor;
        PhiltrumWidth = philtrumWidth;
    }
    public override bool Equals(object obj) => Object.ReferenceEquals(this, obj) || Equals(obj as FacialFeatures);

    public bool Equals(FacialFeatures otherFacial)
        => (otherFacial != null && this.EyeColor == otherFacial.EyeColor && this.PhiltrumWidth == PhiltrumWidth);

    public override int GetHashCode() => HashCode.Combine(this.EyeColor, this.PhiltrumWidth);
}
public class Identity
{
    public string Email { get; }
    public FacialFeatures FacialFeatures { get; }

    public Identity(string email, FacialFeatures facialFeatures)
    {
        Email = email;
        FacialFeatures = facialFeatures;
    }

    public override bool Equals(object obj) => Object.ReferenceEquals(this, obj) || Equals(obj as Identity);

    public bool Equals(Identity otherIdentity)
    => (otherIdentity != null && this.Email.Equals(otherIdentity.Email) && this.FacialFeatures.Equals(otherIdentity.FacialFeatures));

    public override int GetHashCode() => HashCode.Combine(this.Email, this.FacialFeatures);
}

public class Authenticator
{
    private HashSet<Identity> _registeredIdentity = new();
    public static bool AreSameFace(FacialFeatures faceA, FacialFeatures faceB) => Equals(faceA, faceB);
    public bool IsAdmin(Identity identity) => identity.Equals(new Identity("admin@exerc.ism", new FacialFeatures("green", 0.9m)));
    public bool Register(Identity identity) => !IsRegistered(identity) && _registeredIdentity.Add(identity);
    public bool IsRegistered(Identity identity) => _registeredIdentity.Contains(identity);
    public static bool AreSameObject(Identity identityA, Identity identityB) => ReferenceEquals(identityA, identityB);
}

