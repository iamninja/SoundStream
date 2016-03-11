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
    }
}
