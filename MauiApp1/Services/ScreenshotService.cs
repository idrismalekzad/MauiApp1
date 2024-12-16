using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Services
{
    internal class ScreenshotService : IScreenshotService
    {
        public void CaptureScreen(string savePath)
        {
            try
            {
                Rectangle bounds = Screen.GetBounds(Point.Empty);
            }
        }
    }
}
