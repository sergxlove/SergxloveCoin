using System.Windows.Forms;

namespace SergxloveCoin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            myBalance = new();

        }
        private Balanse myBalance;
        private int frameCount = 0;
        private int sizeY = 0;
        private int coordPointY= 0;
        private bool showAnimation = false;
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            myBalance.BalansePlayer += myBalance.SpeedClick;
            label2.Text = Convert.ToString(myBalance.BalansePlayer);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Profile");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("levels");
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("list");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            timer1.Interval = 7;
            frameCount = 0;
            coordPointY = 805;
            sizeY = 0;
            showAnimation = true;
            timer1.Start();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            pictureBox4_Click(sender, e);
        }

        private void label8_Click(object sender, EventArgs e)
        {
            pictureBox5_Click(sender, e);
        }

        private void label9_Click(object sender, EventArgs e)
        {
            pictureBox6_Click(sender, e);
        }

        private void label10_Click(object sender, EventArgs e)
        {
            pictureBox3_Click(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Interval = 7;
            frameCount = 0;
            coordPointY = 155;
            sizeY = 650;
            showAnimation = false;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(showAnimation)
            {
                if(frameCount <= 5)
                {
                    tabControl1.Location = new Point(12, coordPointY);
                    tabControl1.Size = new Size(620, sizeY);
                    coordPointY -= 130;
                    sizeY += 130;
                    frameCount++;
                }
                else
                {
                    timer1.Stop();
                }
            }
            else
            {
                if(frameCount <= 5)
                {
                    tabControl1.Location = new Point(12, coordPointY);
                    tabControl1.Size = new Size(620, sizeY);
                    coordPointY += 130;
                    sizeY -= 130;
                    frameCount++;
                }
                else
                {
                    timer1.Stop();
                }
            }
        }
    }
    public sealed class Balanse
    {
        public Balanse()
        {
            _balanceCoin = 0.000f;
            _speedClick = 0.001f;
        }
        private float _speedClick;
        private float _balanceCoin;
        public float BalansePlayer
        {
            get
            {
                return _balanceCoin;
            }
            set 
            {
                _balanceCoin = value;
            }
        }
        public float SpeedClick
        {
            get 
            {
                return _speedClick;
            }
            set 
            {
                _speedClick = value;
            }
        }
    }
}