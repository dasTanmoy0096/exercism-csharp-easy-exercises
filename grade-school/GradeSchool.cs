namespace grade_school;

public class GradeSchool
{
    Dictionary<string, int> studentDictionary = [];
    public bool Add(string student, int grade)
    {
        if (studentDictionary.ContainsKey(student))
        {
            return false;
        };
        studentDictionary.Add(student, grade);
        studentDictionary = studentDictionary
        .OrderBy(kvp => kvp.Value)
        .ThenBy(kvp => kvp.Key)
        .ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
        return true;
    }

    public string[] Roster() => [.. studentDictionary.Keys];

    public string[] Grade(int grade) => [.. studentDictionary
        .Where(kvp => kvp.Value == grade)
        .Select (kvp => kvp.Key)];
}
