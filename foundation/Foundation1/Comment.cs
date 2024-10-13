
class Comment
{
    public string _userName;
    public string _comment;

    public void DisplayCommentDetails()
    {
        Console.WriteLine($" - {_userName}: {_comment}");
    }
}
