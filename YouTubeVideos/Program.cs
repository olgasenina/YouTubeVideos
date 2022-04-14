using System;

namespace YouTubeVideos
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            User user = new User();

            // Ссылка на видео в YouTube
            string videoUrl = "https://www.youtube.com/watch?v=tCU10czSRQs&list=PL0xvSfWR74l-7wUAXZRyc6VjsaOnv4nKn&index=55";

            user.SetAction(new PlayerDownloadAction(player, videoUrl));
            user.DownloadButton();

            Console.ReadKey();
        }
    }
}
