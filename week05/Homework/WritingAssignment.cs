class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment(string student, string subject, string title) : base(student, subject)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
        return $"{_title} by {_studentName}";
    }
}