using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WF_PusleGame1
{
    public partial class Form2 : Form
    {
        Point moveStart;
        System.Drawing.Graphics g;
        Bitmap pics;        
        int nwid = DataGame.hor;
        int nhei = DataGame.ver;
        int[,] field = new int[DataGame.hor, DataGame.ver];
        int ex, ey, cw, ch;
        Boolean showNumbers = false;
        int countStap;
        Form form1 = new Form1();
        int k = 0; int l = 0;
        bool butt3Click = false;
        public Form2()
        {            
            InitializeComponent();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            button4.Visible = false;
            Animation();           
            try
            { 
                pics = new Bitmap(DataGame.path);
            }
            catch (Exception)
            {
                MessageBox.Show("File is not found.\n", "image", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            
            cw = (int)(pics.Width / nwid);
            ch = (int)(pics.Height / nhei);
            
            ClientSize = new System.Drawing.Size(/*cw * nwid*/720 + 1, ch * nhei + 1 + button3.Height + 10);
            
            g = CreateGraphics();
            StartGame();
        }
       
        async public void Animation()
        {           
            do
            {
                k++;
                if (butt3Click == false)
                {
                    switch (k)
                    {
                        case 1: { pictureBox1.Image = Image.FromFile(@"..\..\..\animation\frame-01.jpg"); await Task.Delay(100); break; }
                        case 2: { pictureBox1.Image = Image.FromFile(@"..\..\..\animation\frame-02.jpg"); await Task.Delay(100); break; }
                        case 3: { pictureBox1.Image = Image.FromFile(@"..\..\..\animation\frame-03.jpg"); await Task.Delay(100); break; }
                        case 4: { pictureBox1.Image = Image.FromFile(@"..\..\..\animation\frame-04.jpg"); await Task.Delay(100); break; }
                        case 5: { pictureBox1.Image = Image.FromFile(@"..\..\..\animation\frame-05.jpg"); await Task.Delay(100); break; }
                        case 6: { pictureBox1.Image = Image.FromFile(@"..\..\..\animation\frame-06.jpg"); await Task.Delay(100); break; }
                        case 7: { pictureBox1.Image = Image.FromFile(@"..\..\..\animation\frame-07.jpg"); await Task.Delay(100); break; }
                        case 8: { pictureBox1.Image = Image.FromFile(@"..\..\..\animation\frame-08.jpg"); await Task.Delay(100); break; }
                        case 9: { pictureBox1.Image = Image.FromFile(@"..\..\..\animation\frame-09.jpg"); await Task.Delay(100); break; }
                        case 10: { pictureBox1.Image = Image.FromFile(@"..\..\..\animation\frame-10.jpg"); await Task.Delay(100); break; }
                        case 11: { pictureBox1.Image = Image.FromFile(@"..\..\..\animation\frame-11.jpg"); await Task.Delay(100); break; }
                        default: { k = 0; break; }
                    }
                }
            } while (k < 100);            
        }
               
        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            form1.Close();
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form3 = new Form3();
            form3.Show();           
        }

        async private void button3_Click(object sender, EventArgs e)
        {
            countStap = 0;
            Text = $"S T E P S : {countStap}";
            butt3Click = true;
            pictureBox1.Image = Image.FromFile(DataGame.path); await Task.Delay(100);
            for (int i = pictureBox1.Width; i >= 0; i-=2, await Task.Delay(20))
                pictureBox1.Width = i;           
            StartGame();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
            form1.Show();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (butt3Click == true)
            {
                // 
                Pen pen = new Pen(Color.Black, 2);
                int tempW = pictureBox1.Width / nwid;
                int tempH = pictureBox1.Height / nhei;
                Point[] points = new Point[2];

                for (int i = 0; i <= nwid; i++)
                {
                    points[0] = new Point(tempW * i, 0); points[1] = new Point(tempW * i, pictureBox1.Height);
                    e.Graphics.DrawLines(pen, points);
                }
                for (int i = 0; i <= nhei; i++)
                {
                    points[0] = new Point(0, tempH * i); points[1] = new Point(pictureBox1.Width, tempH * i);
                    e.Graphics.DrawLines(pen, points);
                }
            }

        }

        public void StartGame()
        {           
            for (int i = 0; i < nhei; i++)            //   ////////////////////
                for (int j = 0; j < nwid; j++)
                    field[j, i] = j * nwid + i + 1;           
            field[nwid - 1, nhei - 1] = 0;
            ex = nwid - 1; ey = nhei - 1;
            Mixer();
            DrawField();
        }

        private void Mixer()
        {
            int d;
            int x, y;
            Random rnd = new Random();
            for (int i = 0; i < nwid * nhei * 10; i++)           
            {
                x = ex;
                y = ey;
                d = rnd.Next(4);
                switch (d)
                {
                    case 0: if (x > 0) x--; break;
                    case 1: if (x < nwid - 1) x++; break;
                    case 2: if (y > 0) y--; break;
                    case 3: if (y < nhei - 1) y++; break;
                }
                // визначення фішки яку потрібно перенести в пусту клітину
                field[ex, ey] = field[x, y];
                field[x, y] = 0;
                // запам'ятаємо координати пустоти
                ex = x; ey = y;
            }
        }

        public void DrawField()
        {          
            for (int i = 0; i < nwid; i++)
                for (int j = 0; j < nhei; j++)
                {
                    if (field[i, j] != 0)                                                                     
                        g.DrawImage(pics,
                           new Rectangle(i * cw, j * ch, cw, ch),
                           new Rectangle(((field[i, j] - 1) % nwid) * cw,
                                         ((field[i, j] - 1) / nwid) * ch,
                                         cw, ch),
                           GraphicsUnit.Pixel);

                    else
                        // виводимо пусту фішку
                        g.FillRectangle(SystemBrushes.Control, i * cw, j * ch, cw, ch);
                    // малюємо края
                    g.DrawRectangle(Pens.Black, i * cw, j * ch, cw, ch);
                    // номер фішки
                    if ((showNumbers) && field[i, j] != 0)
                        g.DrawString(Convert.ToString(field[i, j]), new Font("Tahoma", 10, FontStyle.Bold),
                            Brushes.Black, i * cw + 5, j * ch + 5);
                }
        }

        private Boolean Finish()
        {
            // координати клітин
            int i = 0;
            int j = 0;
            int c;            
            for (c = 1; c < nwid * nhei; c++)
            {
                if (field[i, j] != c) 
                    return false;                
                if (i < nwid - 1) i++;
                else { i = 0; j++; }
            }
            return true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
            form1.Show();
        }

        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Left)
                    moveStart = new Point(e.X, e.Y);
            }
            catch { }
        }

        private void Form2_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                if ((e.Button & MouseButtons.Left) != 0)
                {
                    // получаем новую точку положения формы
                    Point deltaPos = new Point(e.X - moveStart.X, e.Y - moveStart.Y);
                    // устанавливаем положение формы
                    this.Location = new Point(this.Location.X + deltaPos.X,
                      this.Location.Y + deltaPos.Y);
                }
            }
            catch { }
        }       

        private void Form2_MouseClick(object sender, MouseEventArgs e)
        {
            if (button4.Visible == false)
            {
                Move(e.X / cw, e.Y / ch);
                countStap++;
                label2.Text = $"{countStap}";
            }
        }

        private void Move(int cx, int cy)
        {
            if (DataGame.game_mode == false)
            {
                if (!(((Math.Abs(cx - ex) == 1) && (cy - ey == 0)) || ((Math.Abs(cy - ey) == 1) && (cx - ex == 0))))
                    return;
                field[ex, ey] = field[cx, cy];
                field[cx, cy] = 0;
                ex = cx; ey = cy;
                DrawField();                
            }
            else
            {
                try
                {
                    field[ex, ey] = field[cx, cy];
                    field[cx, cy] = 0;
                    ex = cx; ey = cy;
                    DrawField();
                }
                catch { }       
            }
            if(Finish() == true)
            {
                button4.Visible = true;
            }
        }
        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            DrawField();
        }
    }
}
