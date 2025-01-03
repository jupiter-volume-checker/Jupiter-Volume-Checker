using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clickerBlum.Tools
{
    public class Clicker
    {
        public Clicker(Rectangle gameArea)
        {
            _gameArea = gameArea;
        }
        private Rectangle _gameArea;
        private Bitmap screenCapture;
        private bool IsActive = false;

        public async void Start()
        {
            await Task.Run(() => IsActive = true);
            Thread clickThred = new Thread(ClickArea);
            clickThred.Start();
        }
        public async void Stop()
        {
            await Task.Run(() => IsActive = false);
        }

        private void ClickArea()
        {
            while (IsActive)
            {
                try
                {
                    Bitmap screenCapture = CaptureScreenArea(_gameArea);

                    for (int x = 0; x < screenCapture.Width; x++)
                    {
                        for (int y = 0; y < screenCapture.Height; y++)
                        {
                            var selectedPixel = screenCapture.GetPixel(x, y);

                            if (selectedPixel.R >= 115 && selectedPixel.R <= 140 && selectedPixel.G >= 240 && selectedPixel.G <= 255 && selectedPixel.B >= 25 && selectedPixel.B <= 35)
                            {
                                ExternMouse.MouseClick(x, y, _gameArea.Left, _gameArea.Top);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Unexpected error: {ex.Message}");
                }

                Task.Delay(1).Wait();
            }
        }

        private Bitmap CaptureScreenArea(Rectangle captureRect)
        {
            Bitmap bitmap = new Bitmap(captureRect.Width, captureRect.Height);

                using (Graphics g = Graphics.FromImage(bitmap))
                {
                    g.CopyFromScreen(captureRect.Location, Point.Empty, captureRect.Size);
                }

            return bitmap;
        }

        
    }
}
