using System;
using System.Collections.Generic;
using System.Text;

namespace YouTubeVideos
{
    /// <summary>
    /// Пользователь. Запускает скачивание файла
    /// </summary>
    class User
    {
        IAction _action;

        /// <summary>
        /// Инициализация команды
        /// </summary>
        /// <param name="action"></param>
        public void SetAction(IAction action)
        {
            _action = action;
        }

        /// <summary>
        /// запуск команды
        /// </summary>
        public void DownloadButton()
        {
            _action.Run();
        }
    }
}
