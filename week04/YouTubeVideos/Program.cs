using System;

class Program
{
    
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();
    
        Video video1 = new Video("Another Love", "Allie Sherlock", 225);
        Video video2 = new Video("¡LLEGÓ LA NAVIDAD! AÑO 2024", "MÚSICA RELAJANTE", 12);
        Video video3 = new Video("Somewhere Only We Know", "Chill Cùng Meo", 3653);

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);


        video1.AddComment(new Comment("RobertJR","Great video, I love you."));
        video1.AddComment(new Comment("roselyn1443","I miss my kids. They're grown up now. I miss the simple days and simple happiness. The little giggles and comforting cuddles."));
        video1.AddComment(new Comment("carolinesantos6817","I miss my children. They have their own place away from us. I miss the times we used to share the same space and simple laughter would be enough to make everyone happy."));
        video1.AddComment(new Comment("Godlovesyou301","This song will open your soul and make you see reality of the world we live inn , wish everyone strength and may the universe heal your souls from the harsh reality."));



        video2.AddComment(new Comment("Acinorev6701","Excellent performance with style! Thank you."));
        video2.AddComment(new Comment("koalala5002","Absolutely beautiful in every way!!!"));
        video2.AddComment(new Comment("MRafay-jf5fk","A beautiful song, beautifully sung."));
        

        video3.AddComment(new Comment("leito1257","When I hear calm and sad covers like this it makes me sleepy and makes me forget about most things that was happening and makes me feel happy and smile"));
        video3.AddComment(new Comment("tangocyn","Thank you for this video."));
        video3.AddComment(new Comment("merlinthomas7869","I am addicted to this voice."));
        video3.AddComment(new Comment("Marges73","this song remind me of my husband Nathan and our baby boy Ethan we always sing this song all the time I miss them so much."));

        

        foreach(Video video in videos)
        {
        Console.WriteLine($"Title: {video._title}\nAuthor: {video._author}\nSeconds: {video._seconds} s\nNumber of Comments: {video.NumComments()}\nComments...\n{video.TheComment()}");
       
        }
       

    }


    
}