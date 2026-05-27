class Video
{
    private string _title;
    private string _author;
    private int _seconds;
    private List<Comment> _comments = [];

    public Video(string title, string author, int seconds)
    {
        _title = title;
        _author = author;
        _seconds = seconds;
    }

    public string GetDisplayText()
    {
        List<string> commentStrings = [];
        foreach (Comment comment in _comments)
        {
            commentStrings.Add(comment.GetDisplayText());
        }
        return $"{_title} by {_author} ({_seconds / 60}:{_seconds % 60})\n"
            + $"Comments ({GetCommentCount()}):\n"
            + String.Join("\n", commentStrings);
    }

    public int GetCommentCount()
    {
        return _comments.Count;
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }
}