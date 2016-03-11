using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSCore.CoreAudioAPI;
using CSCore.SoundIn;
using CSCore.Codecs.WAV;

namespace SoundStream
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void isSupported_Click(object sender, EventArgs e)
        {
            checkLabel.Text = "Checking...";
            if (WasapiCapture.IsSupportedOnCurrentPlatform)
            {
                checkLabel.Text = "WASAPI capture is supported.";
            }
            else
            {
                checkLabel.Text = "WASAPI capture is not supported.";
            }
        }

        private void recordTenWAVButton_Click(object sender, EventArgs e)
        {
            //recordTenWAVLabel.Text = "Recording...";
            WasapiLoopbackCapture capture = new WasapiLoopbackCapture();
            capture.Initialize();
            using (WaveWriter w = new WaveWriter("dump.wav", capture.WaveFormat))
            {
                //setup an eventhandler to receive the recorded data
                capture.DataAvailable += (s, f) =>
                {
                    //save the recorded audio
                    w.Write(f.Data, f.Offset, f.ByteCount);
                };

                //start recording
               
                capture.Start();

                System.Threading.Thread.Sleep(10000);

                //stop recording
                capture.Stop();
            }
            //recordTenWAVLabel.Text = "Ready";
        }
    }
}
