using System;

class Program
{
    static void Main(string[] args)
    {
        // Videos
        List<Video> videos = new List<Video> ();
        Console.Clear();

        /**  Test Videos  **/
        Video video1 = new Video("How to bake a Cake", "Emilio Sosa", "21m");
        video1.AddComment("John Doe", "Can I use baking soda?");
        video1.AddComment("John Smith", "I loved the recipte");
        video1.AddComment("Lisa Doe", "I will prepare it for my sister's birthday");
        videos.Add(video1);

        Video video2 = new Video("Are You Really There?", "The Church of Jesus Christ of Latter-day Saints", "3m 45s");
        video2.AddComment("V Smith", "I miss my husband so much!  This popped up on my phone today. It brought tears to me.");
        video2.AddComment("Brother Wester", "Thank you for showing the easily overlooked and silent everyday struggles that Heavenly Father sees. Surely, He is eager to bless those who would simply look to Him and pray. He is there.");
        video2.AddComment("Janet Johnson", "This is true");
        videos.Add(video2);

        Video video3 = new Video("How Pathway Works", "BYU-Pathway Worldwide", "2m 30s");
        video3.AddComment("Edita Amante", "I just started this winter semester, and it’s been a blessing for me!!!");
        video3.AddComment("Edson Arao", "It's a great blessing.");
        video3.AddComment("Ariel Kezele", "I'm so excited to start this journey! Thank you BYU Pathway!❤️🙏🏻");
        video3.AddComment("DongsTVs", "One step at a time , thank you BYU Pathway ! Now i am in my second semester in BYUi :)");
        videos.Add(video3);

        //Display Results
        foreach(Video video in videos)
        {
            // Display the details of the video in the console.
            video.DisplayVideoDetails();

            // Get the Number of Comments.
            Console.WriteLine($"Number of Comments: {video.GetCommentNumber()} \n");

            // Display the comments
            video.DisplayComments();
        }

        
    }
}