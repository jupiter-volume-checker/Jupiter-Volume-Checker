using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clickerBlum.Tools
{
    public static class Logger
    {
        public static void PrintRectangleInfo(Rectangle rectangle)
        {
            Console.WriteLine($"rectangle: w/h: {rectangle.Width};{rectangle.Height}\t|\t" +
                $"location: {rectangle.Location.X};{rectangle.Location.Y}\t|\t" +
                $"size{rectangle.Size}");
        }
        public static void PrintBitmapInfo(Bitmap bitmap)
        {
            Console.WriteLine($"bitmap: w/h: {bitmap.Width};{bitmap.Height}");
        }
    }
}
