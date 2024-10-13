
class Video
{
    public string _titleName;
    public string _authorName;
    public string _lengthVideo;        
    public List<Comment> _comment = new List<Comment>(); 

    public void DisplayDetails()
    {
        Console.WriteLine($"Title: {_titleName}");
        Console.WriteLine($"Author: {_authorName}");
        Console.WriteLine($"Length: {_lengthVideo} seconds");
        int commentCount = _comment.Count();
        Console.WriteLine($"Comments ({commentCount}):");

        foreach (Comment comment in _comment)
        {
            comment.DisplayCommentDetails();
        }
    }
}