class Comment
{
    // _author : Str, _comment : Str
    // GetDisplayString() : Str
    private string _author;
    private string _comment;

    public Comment(string author, string comment)
    {
        _author = author;
        _comment = comment;
    }

    public string GetDisplayString()
    {
        return $"{_author}: {_comment}";
    }
}