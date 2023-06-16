using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.DataFormats;

namespace WF_PusleGame1
{
    public partial class Form1 : Form
    {       
        
        public Form1()
        {
            InitializeComponent();
            
            pictureBox2.Width = 405;
            pictureBox2.Height = 386;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        }
       
        private void toolStripComboBox3_Click(object sender, EventArgs e)
        {
            toolStripComboBox4.Text = "";
            Text = "";            
        }

        private void toolStripComboBox4_Click(object sender, EventArgs e)
        {
            toolStripComboBox3.Text = "";
            Text = "";
        }

        private void toolStripComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox2.Height = 386;            
            Text = toolStripComboBox3.Text.ToString();
            pictureBox2.Visible = true;
            if(pictureBox2.Width < 450)
            pictureBox2.Width = pictureBox2.Width + 210;
            pictureBox2.Image = Image.FromFile(@"..\..\..\HorizontalPuzles\"+ Text);
            DataGame.path = (@"..\..\..\HorizontalPuzles\" + Text);
            DataGame.width = pictureBox2.Width;
            DataGame.height = pictureBox2.Height;
        }

        private void toolStripComboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox2.Width = 405;            
            Text = toolStripComboBox4.Text.ToString();
            pictureBox2.Visible = true;
            if (pictureBox2.Height < 400)
            pictureBox2.Height = pictureBox2.Height + 190;
            pictureBox2.Image = Image.FromFile(@"..\..\..\VerticalPuzles\" + Text);
            DataGame.path = (@"..\..\..\VerticalPuzles\" + Text);
            DataGame.width = pictureBox2.Width;
            DataGame.height = pictureBox2.Height;
        }                
        
        private void button1_Click(object sender, EventArgs e)
        {           
                if (toolStripComboBox3.Text == "" && toolStripComboBox4.Text == "")
                {
                    MessageBox.Show($"��� ������� ��� � ����� File ������� �������", "� � � � �", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (toolStripComboBox1.Text != "")
                {
                    Form form2 = new Form2();
                    form2.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show($"��� ������� ��� ������ ������� ����� � ����� Size", "� � � � �", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);              
                }
                if (toolStripComboBox5.Text == "" && toolStripComboBox6.Text == "")
                {
                    MessageBox.Show($"� ����� \"Game mode\" �� �� ������ ����� ���. �� ������������� ��� �������������� � ����� \"Fifteen\" ", "� � � � �", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }    
        }

        private void open1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"��� ������� ��� � ����� File ������� �������, � ����� Size ������ ������� �����, � ����� \"Game mode\" ������ ����� ��� - \"Puzle\" ��� \"Fifteen\" �� �������� ������ ������ \"Game Begin\"", "� � � � �", MessageBoxButtons.OK);
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataGame.hor = byte.Parse(toolStripComboBox1.Text);
            DataGame.ver = DataGame.hor;
        }

        private void toolStripComboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (toolStripComboBox6.Text != "") 
            toolStripComboBox6.Text = "";
            DataGame.game_mode = true;
            MessageBox.Show($"� ����� Puzle ������� ����� ���������� � ����-��� �� �������. ", "� � � � �", MessageBoxButtons.OK);
        }

        private void toolStripComboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (toolStripComboBox5.Text != "")
            toolStripComboBox5.Text = "";
            DataGame.game_mode = false;
            MessageBox.Show($"� ����� Fifteen ������� ����� ���������� ���� � ������� �� �������. ", "� � � � �", MessageBoxButtons.OK);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();          
            toolTip1.ShowAlways = true;            
            toolTip1.SetToolTip(this.menuStrip1, "click to choice menu");
        }              
    }
}