using System;
using System.Collections.Generic;

class VideoLibrary
{
    private List<Video> _videos = new List<Video>();

    public void AddVideo(Video video)
    {
        _videos.Add(video);
    }

    public void DisplayAllVideos()
    {
        foreach (Video video in _videos)
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Duration} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.CommenterName}: {comment.Text}");
            }

            Console.WriteLine();
        }
    }
}
