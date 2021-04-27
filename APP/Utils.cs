using System.Drawing;
using System.Windows.Forms;

namespace SpeakRec
{
    class Utils
    {
        public static Bitmap ConvertToGrayscale(Bitmap source)
        {
            var bm = new Bitmap(source.Width, source.Height);
            for (int y = 0; y < bm.Height; y++)
            {
                for (int x = 0; x < bm.Width; x++)
                {
                    Color c = source.GetPixel(x, y);
                    var luma = (int)(c.R * 0.3 + c.G * 0.59 + c.B * 0.11);
                    if (c.A != 0)
                        bm.SetPixel(x, y, Color.FromArgb(luma, luma, luma));
                }
            }
            return bm;
        }

        public static void disableButton(Button button, Bitmap bitmap, ToolStripMenuItem toolStripMenuItem)
        {
            button.BackgroundImage = ConvertToGrayscale(bitmap);
            toolStripMenuItem.Enabled = false;
            button.Enabled = false;
        }

        public static void enableButton(Button button, Bitmap bitmap, ToolStripMenuItem toolStripMenuItem)
        {
            button.BackgroundImage = bitmap;
            toolStripMenuItem.Enabled = true;
            button.Enabled = true;
        }
    }
}
