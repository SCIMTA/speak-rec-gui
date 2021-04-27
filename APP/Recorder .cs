using NAudio.Gui;
using NAudio.Wave;
using System;
using System.IO;
using System.Windows.Forms;

namespace SpeakRec
{
    public class Recorder
    {
        WaveIn sourceStream;
        WaveFileWriter waveWriter;
        readonly String FilePath;
        readonly String FileName;
        readonly int InputDeviceIndex;
        public delegate void OnRecord(string text);
        OnRecord onRecord = null;
        Label label = null;
        public Recorder(int inputDeviceIndex, String filePath, String fileName, OnRecord onRecord)
        {
            this.onRecord = onRecord;
            this.InputDeviceIndex = inputDeviceIndex;
            this.FileName = fileName;
            this.FilePath = filePath;
        }

        public Recorder(int inputDeviceIndex, String filePath, String fileName, Label label)
        {
            this.label = label;
            this.InputDeviceIndex = inputDeviceIndex;
            this.FileName = fileName;
            this.FilePath = filePath;
        }

        public void StartRecording()
        {
            sourceStream = new WaveIn
            {
                DeviceNumber = this.InputDeviceIndex,
                WaveFormat =
                    new WaveFormat(16000, 1)
            };
            sourceStream.DataAvailable += this.SourceStreamDataAvailable;
            if (!Directory.Exists(FilePath))
            {
                Directory.CreateDirectory(FilePath);
            }

            waveWriter = new WaveFileWriter(FilePath + FileName, sourceStream.WaveFormat);
            sourceStream.StartRecording();
        }

        public void SourceStreamDataAvailable(object sender, WaveInEventArgs e)
        {
            if (waveWriter == null) return;
            waveWriter.Write(e.Buffer, 0, e.BytesRecorded);
            waveWriter.Flush();
            if (onRecord != null)
                onRecord(new TimeSpan(waveWriter.Length * 10000 / 32).ToString().Split('.')[0]);
            else
            {
                label.Text = new TimeSpan(waveWriter.Length * 10000 / 32).ToString().Split('.')[0];
            }
        }

        public void RecordEnd()
        {
            if (sourceStream != null)
            {
                sourceStream.StopRecording();
                sourceStream.Dispose();
                sourceStream = null;
            }
            if (this.waveWriter == null)
            {
                return;
            }
            this.waveWriter.Dispose();
            this.waveWriter = null;
        }
    }
}
