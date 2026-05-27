class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = [];

        Video video1 = new Video("Music for Work - Deep Focus Mix for Programming, Coding", "Chill music Lab", 1775);
        video1.AddComment(new Comment("MusicLabChill", "How do you like the visuals? What would you change?"));
        video1.AddComment(new Comment("Brandleymotaung", "hi can i use this music for my stream?"));
        video1.AddComment(new Comment("idkanamebc", "One of the best Playlist I always listen to this when I am coding"));
        videos.Add(video1);

        Video video2 = new Video("Chillstep music for Programming / Cyber / Coding", "Chill Music Lab", 2543);
        video2.AddComment(new Comment("MusicLabChill", "What was your main source of inspiration today?"));
        video2.AddComment(new Comment("funnyigama803", "Stop reading the commends and start doing work."));
        video2.AddComment(new Comment("youssefr", "When the subtitles said [Music], I really felt that."));
        videos.Add(video2);

        Video video3 = new Video("3 A.M Coding Session - Chillstep Beats to Keep You Going", "Cosmic Hippo", 3331);
        video3.AddComment(new Comment("PugRest", "This mix is like a warm reminder that better times are ahead."));
        video3.AddComment(new Comment("alexplastow9496", "The momre monitors I collect, the more powerful I become"));
        video3.AddComment(new Comment("vytrixstudios2184", "Even though I am not a programmer, I'm glad I found this."));
        video3.AddComment(new Comment("hassanabdullahalsalihi8511", "This helped me get an A in coding."));
        videos.Add(video3);

        Console.Clear();
        foreach (Video video in videos)
        {
            Console.WriteLine(video.GetDisplayText());
            Console.WriteLine();
        }
    }
}