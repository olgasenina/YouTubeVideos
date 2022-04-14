using System;
using System.Collections.Generic;
using System.Text;

namespace YouTubeVideos
{
    /// <summary>
    /// Команда загрузки
    /// </summary>
    class PlayerDownloadAction : IAction
    {
        Player _player;
        string _videoUrl;

        public PlayerDownloadAction(Player playerSet, string videoUrl)
        {
            _player = playerSet;
            _videoUrl = videoUrl;
        }

        public void Run()
        {
            _player.DownloadAsync(_videoUrl);
        }
    }
}
