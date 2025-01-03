using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clickerBlum.Tools
{
    public class Autoplay
    {
        public Autoplay(Rectangle gameArea)
        {
            _gameArea = gameArea;
        }
        private readonly Rectangle _gameArea;
        private bool IsAutoplay = false;

        private void AutoplayClick()
        {
            while (IsAutoplay)
            {
                ExternMouse.MouseClick(950, 775, 0, 0);
                Thread.Sleep(40000);
            }
        }

        public async void Start()
        {
            await Task.Run(() => IsAutoplay = true);

            Thread autoplayThread = new Thread(AutoplayClick);
            autoplayThread.Start();
        }
        public async void Stop()
        {
            await Task.Run(() => IsAutoplay = false);
        }
    }
}
