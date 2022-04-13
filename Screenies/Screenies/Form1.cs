using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace Screenies
{
    public partial class Form1 : Form
    {
        int x;
        int y = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            x = Convert.ToInt32(textBox1.Text);
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (x > 0)
            {
                CaptureMyScreen();
                x--;
                y++;
            }
            else if (x == 0)
            {
                timer1.Enabled = false;
            }
        }
        private void CaptureMyScreen()
        {
            //Creating a new Bitmap object
            Bitmap captureBitmap = new Bitmap(231, 231, PixelFormat.Format64bppPArgb);

            //Creating a new Rectangle object
            Rectangle captureRectangle = Screen.AllScreens[0].Bounds;

            //Creating a New Graphics object
            Graphics captureGraphics = Graphics.FromImage(captureBitmap);

            captureGraphics.CopyFromScreen(captureRectangle.Left, captureRectangle.Top, -845, -238, captureRectangle.Size);

            //Saving the Image File
            captureBitmap.Save(@"C:\Users\alican0420\Desktop\Programs n Shit\Screenie\testTHREE"+Convert.ToString(y)+".jpg", ImageFormat.Jpeg);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            y = 1;
        }
    }
}
