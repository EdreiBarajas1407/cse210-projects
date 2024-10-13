using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videosList = new List<Video>();

        Video video1 = new Video();
        video1._titleName = "Stick Season";
        video1._lengthVideo = "197";
        video1._authorName = "Noah Kahan";
        Comment video1Comment1 = new Comment();
        video1Comment1._userName = "Jacky Frost";
        video1Comment1._comment = "This song is what every song should be.  A poem set to music.";
        Comment video1Comment2 = new Comment();
        video1Comment2._userName = "bigkang13";
        video1Comment2._comment = "Nothing in this song applies to me, and it still makes me feel the emotions of all of it. Great song and great writing.";
        Comment video1Comment3 = new Comment();
        video1Comment3._userName = "RoDogs";
        video1Comment3._comment = "Once called me forever now you still can't call me back. This hits my heart";

        Video video2 = new Video();
        video2._titleName = "9 Cats in a Filthy Home in Florida 🥺 – Cleaning for Free!!💪🩷";
        video2._lengthVideo = "1728";
        video2._authorName = "Aurikatariina";
        Comment video2Comment1 = new Comment();
        video2Comment1._userName = "Jacqueline Villarreal";
        video2Comment1._comment = "3 generations working together to do good, out of the kindness of their hearts…✨💖✨";
        Comment video2Comment2 = new Comment();
        video2Comment2._userName = "Sophie Jetz";
        video2Comment2._comment = "I‘m from Germany and love you’re videos ♥️🍀";
        Comment video2Comment3 = new Comment();
        video2Comment3._userName = "Judy Reilly";
        video2Comment3._comment = "The whole world is in love with you. It’s your joy and beauty as much as your ability to clean the worst messes.";

        Video video3 = new Video();
        video3._titleName = "VINLAND SAGA SEASON 2 - Opening 1 | River";
        video3._lengthVideo = "100";
        video3._authorName = "Cruncyroll";
        Comment video3Comment1 = new Comment();
        video3Comment1._userName = "lil' barrel bomb";
        video3Comment1._comment = "Canute's scar turning into his father's eye is a really cool visual";
        Comment video3Comment2 = new Comment();
        video3Comment2._userName = "Lohengramm";
        video3Comment2._comment = "Its crazy how Vinland Saga already won Anime of the year, opening of the year and ending of the year";
        Comment video3Comment3 = new Comment();
        video3Comment3._userName = "Mr. King";
        video3Comment3._comment = "Now this is an opening that fits the arc of an anime perfectly. 100/100";
        Comment video3Comment4 = new Comment();
        video3Comment4._userName = "JR 22";
        video3Comment4._comment = "Love how mature this opening's presentation is. Very excited for this season!";

        video1._comment.Add(video1Comment1);
        video1._comment.Add(video1Comment2);
        video1._comment.Add(video1Comment3);

        video2._comment.Add(video2Comment1);
        video2._comment.Add(video2Comment2);
        video2._comment.Add(video2Comment3);

        video3._comment.Add(video3Comment1);
        video3._comment.Add(video3Comment2);
        video3._comment.Add(video3Comment3);
        video3._comment.Add(video3Comment4);

        videosList.Add(video1);
        videosList.Add(video2);
        videosList.Add(video3);

        foreach (Video video in videosList)
        {
            video.DisplayDetails();
            Console.WriteLine();
        }
    }

}