using System;
using System.Collections.Generic;
using System.Linq;

public class GradeSchool
{
    private SortedDictionary<int, SortedSet<string>> students = new SortedDictionary<int, SortedSet<string>>();

    public void Add(string student, int grade)
    {
        if(!students.ContainsKey(grade))
            students[grade] = new SortedSet<string>();
        students[grade].Add(student);
    }

    public IEnumerable<string> Roster() => students.Values.SelectMany(x => x);
    public IEnumerable<string> Grade(int grade) => students.TryGetValue(grade, out SortedSet<string> result) ? result : Enumerable.Empty<string>();

}
