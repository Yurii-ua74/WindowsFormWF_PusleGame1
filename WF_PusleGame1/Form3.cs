using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_PusleGame1
{
    public partial class Form3 : Form
    {
        Point moveStart;
        public Form3()
        {
            InitializeComponent();
            
            Width = pictureBox1.Width = DataGame.width;
            pictureBox1.Height = DataGame.height;
            Height = 627;             
            pictureBox1.Image = Image.FromFile(DataGame.path);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }    

        private void Form3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                moveStart = new Point(e.X, e.Y);
        }

        private void Form3_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) != 0)
            {               
                Point deltaPos = new Point(e.X - moveStart.X, e.Y - moveStart.Y);               
                this.Location = new Point(this.Location.X + deltaPos.X,
                  this.Location.Y + deltaPos.Y);
            }
        }
    }
}
