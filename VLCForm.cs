using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace SpeakRec
{
    public partial class VLCForm : Form
    {
        public VLCForm()
        {
            InitializeComponent();

        }
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

        private void button1_Click(object sender, EventArgs e)
        {

            string path = Path.Combine(Path.GetTempPath(), "vlc.exe");
            File.WriteAllBytes(path, Properties.Resources.vlc);
            Process process = Process.Start(path);
            process.WaitForInputIdle();

            //while (process.MainWindowHandle == IntPtr.Zero)
            //{
            //    Thread.Sleep(100);
            //    process.Refresh();
            //}
            Thread.Sleep(2000);
            SetParent(process.MainWindowHandle, this.printPreviewControl1.Handle);
        }
    }
}
