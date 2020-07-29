using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;


namespace ImportingAudioResources
{
    public partial class AudioNotifier : Form
    {
        public AudioNotifier()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SoundPlayer notifier =
                new SoundPlayer(Properties.Resources.notify);
            //Notfying user GUI:
            label1.Text = "Notifying...";
            //Play music:
            notifier.Play();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
