using System;

class Program
{
    static void Main(string[] args)
    {
        // Create videos
        Video video1 = new Video("Learning C# Basics", "Code Academy", 600);
        Video video2 = new Video("Top 10 Programming Tips", "DevWorld", 480);
        Video video3 = new Video("Understanding OOP", "Tech Explained", 720);

        // Add comments to video 1
        video1.AddComment(new Comment("Alice", "Great explanation!"));
        video1.AddComment(new Comment("Bob", "Very helpful."));
        video1.AddComment(new Comment("Charlie", "Easy to understand."));

        // Add comments to video 2
        video2.AddComment(new Comment("Diana", "Awesome tips."));
        video2.AddComment(new Comment("Ethan", "Loved this video."));
        video2.AddComment(new Comment("Fiona", "Straight to the point."));

        // Add comments to video 3
        video3.AddComment(new Comment("George", "OOP finally makes sense."));
        video3.AddComment(new Comment("Hannah", "Great examples."));
        video3.AddComment(new Comment("Ivan", "Very clear explanation."));

        // Create library and add videos
        VideoLibrary library = new VideoLibrary();
        library.AddVideo(video1);
        library.AddVideo(video2);
        library.AddVideo(video3);

        // Display all videos
        library.DisplayAllVideos();
    }
}
