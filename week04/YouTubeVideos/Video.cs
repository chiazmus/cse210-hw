class Video
{
    // _title : str, _author : str, _duration : int, _comments : List<Comment>
    // NumberOfComments() : int, AddComment(Comment) : Void, Display() : Void
    private string _title;
    private string _author;
    private int _duration;
    private List<Comment> _comments;

    public Video(string title, string author, int duration)
    {
        _title = title;
        _author = author;
        _duration = duration;
        _comments = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public int NumberOfComments()
    {
        return _comments.Count;
    }

    public void Display()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Duration: {_duration}");
        Console.WriteLine($"Comments ({NumberOfComments()}):");
        foreach (Comment comment in _comments)
        {
            Console.WriteLine(comment.GetDisplayString());
        }
    }

}