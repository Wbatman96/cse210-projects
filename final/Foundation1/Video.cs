public class Video
{
    private List<Comment> _comments = new List<Comment>();
    private string _title = "";
    private string _author = "";
    private float _length = 0;

    public Video(string title, string author, float length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public int CountComments()
    {
        return _comments.Count;
    }

    public void Display()
    {
        Console.WriteLine($"{_title} by {_author} Length in sec: {_length} This Video has {CountComments}");
        
    }

    public void ShowComments()
    {
        foreach (Comment comment in _comments)
        {
            comment.Display();
        }
    }
}