using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loginpicturelist
{
    
    public partial class Main : Form
    {
        int x, y, xVal, yVal;
        Timer tm;
        private EventHandler display;
        public Main()
        {
            InitializeComponent();
            x = 10;
            y = 10;
            xVal = 5;
            yVal = 5;
            tm = new Timer();
            tm.Interval = 60;
            tm.Tick += new EventHandler(Display);
            tm.Enabled = true;
        }
        int intImgNum = 0;

        private void tmrChangeImage_Tick(object sender, EventArgs e)
        {
            PbX.Image = imageList.Images[intImgNum];
            if (intImgNum == imageList.Images.Count - 1)
            {
                intImgNum = 0;
            }
            else
            {
                intImgNum++;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Display(sender, e);
        }
        private void Display(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(787, 426);
            Graphics g = Graphics.FromImage(bmp);
            g.FillEllipse(Brushes.Blue, new Rectangle(x, y, 50, 50));
            x += xVal;
            y += yVal;
            pictureBox2.Image = bmp;
            if (x <= 0 || x >= (pictureBox2.Width - 50))
            {
                xVal = xVal * (-1);
            }
            if (y <= 0 || y >= (pictureBox2.Height - 50))
            {
                yVal *= -1;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(787, 426);
        }
    }
}
