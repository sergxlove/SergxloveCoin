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
            MessageBox.Show("shop");
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
            pictureBox3_Click(sender,e);
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