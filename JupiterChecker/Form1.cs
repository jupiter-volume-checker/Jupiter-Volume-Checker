using clickerBlum.Tools;
using Microsoft.VisualBasic.Logging;
using System.Runtime.InteropServices;

namespace clickerBlum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static Rectangle gameArea = new Rectangle(750, 400, 375, 90);
        private readonly Clicker _clicker = new Clicker(gameArea);
        private readonly Autoplay _autoplay = new Autoplay(gameArea);

        private async void startButton_Click(object sender, EventArgs e)
        {
            _clicker.Start();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            _clicker.Stop();
        }

        private void alignButton_Click(object sender, EventArgs e)
        {
            var alignWindowForm = new AlignWindowForm();

            alignWindowForm.Location = new Point(750, 400);

            alignWindowForm.Show();

            var alignWindowFormAutoplay = new AlignWindowFormAutoplay();

            alignWindowFormAutoplay.Location = new Point(750, 750);
            alignWindowFormAutoplay.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                _autoplay.Start();
            }
            else
            {
                _autoplay.Stop();
            }
        }
    }
}
