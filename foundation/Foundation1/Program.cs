using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation1 World!");
    }

    class Video
    {
        public string _titleName;
        public string _authorName;
        public int _lengthVideo;        
        public List<Comment> _comments = new List<Comment>(); 
    }

    public void DisplayDetails()
    {

    }

    class Comment
    {
        public string _userName;
        public string _comment;
    }

    public void DisplayCommentDetails()
    {

    }
}