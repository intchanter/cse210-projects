class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

    public MathAssignment(string student, string subject, string section, string problems) : base(student, subject)
    {

        _textbookSection = section;
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        return $"Section {_textbookSection}, Problems {_problems}";
    }
}