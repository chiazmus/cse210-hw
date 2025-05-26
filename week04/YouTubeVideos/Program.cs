using System;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");

        List<Video> videos = new List<Video>();

        Video video1 = new Video("This Is Video 1", "John Doe", 67);
        Video video2 = new Video("This Is Video 2", "Jane Smith", 90);
        Video video3 = new Video("This Is Video 3", "Bob Johnson", 45);

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        Comment comment1 = new Comment("Robert Robertson", "First comment!");
        Comment comment2 = new Comment("Bob Bobbington", "Another comment");
        Comment comment3 = new Comment("Johanne Johannesdotter", "This is a comment too!");

        foreach (Video video in videos)
        {
            video.AddComment(comment1);
            video.AddComment(comment2);
            video.AddComment(comment3);
        }

        foreach (Video video in videos)
        {
            Console.WriteLine("\n#######################################\n");
            video.Display();
        }

    }
}