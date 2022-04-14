using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;
using YoutubeExplode.Converter;

namespace YouTubeVideos
{
    /// <summary>
    /// Действия с проигрывателем
    /// </summary>
    class Player
    {
        /// <summary>
        /// Загрузка файла 
        /// </summary>
        /// <param name="videoUrl">ссылка на скачиваемый файл</param>
        /// <returns></returns>
        public async Task DownloadAsync(string videoUrl)
        {
            var youtube = new YoutubeClient();

            // получить описание видео;
            var video = await youtube.Videos.GetAsync(videoUrl);

            var title = video.Title;
            var author = video.Author.Title;

            // Формируем наименование файла
            string outputFilePath = "C:/_МОЯ/Видео с YouTube/" + author + "." + title + ".mp4";

            Console.WriteLine($"Начинаем загружать файл {outputFilePath}...") ;

            // запустить скачивание видео
            try
            {
                await youtube.Videos.DownloadAsync(videoUrl, outputFilePath, builder => builder.SetPreset(ConversionPreset.UltraFast));
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Ошибка при загрузке файла: {ex.Message}");
                return;
            }
            

            // Финальное сообщение
            Console.WriteLine("Загрузка завершена."); 
        }
    }
}
