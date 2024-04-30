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
    }
    public class Balanse
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