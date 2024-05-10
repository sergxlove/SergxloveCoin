using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace SergxloveCoin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            myBalance = new();
            commonmouse = new();
            economymouse = new();
            budgetmouse = new();
            standartmouse = new();
            universalmouse = new();
            classicalmouse = new();
            professionalmouse = new();
            premiummouse = new();
            elitemouse = new();
            legendarymouse = new();
            label2.DataBindings.Add(new Binding("Text", myBalance, "BalanceCoinString", true, DataSourceUpdateMode.OnPropertyChanged));
            //12,16,17,18
            label12.DataBindings.Add(new Binding("Text", commonmouse, "Name", true, DataSourceUpdateMode.OnPropertyChanged));
            label16.DataBindings.Add(new Binding("Text", commonmouse, "Price", true, DataSourceUpdateMode.OnPropertyChanged));
            label17.DataBindings.Add(new Binding("Text", commonmouse, "SpeedClick", true, DataSourceUpdateMode.OnPropertyChanged));
            label18.DataBindings.Add(new Binding("Text", commonmouse, "Quantity", true, DataSourceUpdateMode.OnPropertyChanged));
            //25,21,20,19
            label25.DataBindings.Add(new Binding("Text", economymouse, "Name", true, DataSourceUpdateMode.OnPropertyChanged));
            label21.DataBindings.Add(new Binding("Text", economymouse, "Price", true, DataSourceUpdateMode.OnPropertyChanged));
            label20.DataBindings.Add(new Binding("Text", economymouse, "SpeedClick",true, DataSourceUpdateMode.OnPropertyChanged));
            label19.DataBindings.Add(new Binding("Text", economymouse, "Quantity", true, DataSourceUpdateMode.OnPropertyChanged));
            //32,28,27,26
            label32.DataBindings.Add(new Binding("Text", budgetmouse, "Name", true, DataSourceUpdateMode.OnPropertyChanged));
            label28.DataBindings.Add(new Binding("Text", budgetmouse, "Price", true, DataSourceUpdateMode.OnPropertyChanged));
            label27.DataBindings.Add(new Binding("Text", budgetmouse, "SpeedClick", true, DataSourceUpdateMode.OnPropertyChanged));
            label26.DataBindings.Add(new Binding("Text", budgetmouse, "Quantity", true, DataSourceUpdateMode.OnPropertyChanged));
            //39, 35, 34, 33
            label39.DataBindings.Add(new Binding("Text", standartmouse, "Name", true, DataSourceUpdateMode.OnPropertyChanged));
            label35.DataBindings.Add(new Binding("Text", standartmouse, "Price", true, DataSourceUpdateMode.OnPropertyChanged));
            label34.DataBindings.Add(new Binding("Text", standartmouse, "SpeedClick", true, DataSourceUpdateMode.OnPropertyChanged));
            label33.DataBindings.Add(new Binding("Text", standartmouse, "Quantity", true, DataSourceUpdateMode.OnPropertyChanged));
            //46, 42, 41, 40
            label46.DataBindings.Add(new Binding("Text", universalmouse, "Name", true, DataSourceUpdateMode.OnPropertyChanged));
            label42.DataBindings.Add(new Binding("Text", universalmouse, "Price", true, DataSourceUpdateMode.OnPropertyChanged));
            label41.DataBindings.Add(new Binding("Text", universalmouse, "SpeedClick", true, DataSourceUpdateMode.OnPropertyChanged));
            label40.DataBindings.Add(new Binding("Text", universalmouse, "Quantity", true, DataSourceUpdateMode.OnPropertyChanged));
            //53, 49, 48, 47
            label53.DataBindings.Add(new Binding("Text", classicalmouse, "Name", true, DataSourceUpdateMode.OnPropertyChanged));
            label49.DataBindings.Add(new Binding("Text", classicalmouse, "Price", true, DataSourceUpdateMode.OnPropertyChanged));
            label48.DataBindings.Add(new Binding("Text", classicalmouse, "SpeedClick", true, DataSourceUpdateMode.OnPropertyChanged));
            label47.DataBindings.Add(new Binding("Text", classicalmouse, "Quantity", true, DataSourceUpdateMode.OnPropertyChanged));
            //60, 56, 55, 54
            label60.DataBindings.Add(new Binding("Text", professionalmouse, "Name", true, DataSourceUpdateMode.OnPropertyChanged));
            label56.DataBindings.Add(new Binding("Text", professionalmouse, "Price", true, DataSourceUpdateMode.OnPropertyChanged));
            label55.DataBindings.Add(new Binding("Text", professionalmouse, "SpeedClick", true, DataSourceUpdateMode.OnPropertyChanged));
            label54.DataBindings.Add(new Binding("Text", professionalmouse, "Quantity", true, DataSourceUpdateMode.OnPropertyChanged));
            //67, 63, 62, 61
            label67.DataBindings.Add(new Binding("Text", premiummouse, "Name", true, DataSourceUpdateMode.OnPropertyChanged));
            label63.DataBindings.Add(new Binding("Text", premiummouse, "Price", true, DataSourceUpdateMode.OnPropertyChanged));
            label62.DataBindings.Add(new Binding("Text", premiummouse, "SpeedClick", true, DataSourceUpdateMode.OnPropertyChanged));
            label61.DataBindings.Add(new Binding("Text", premiummouse, "Quantity", true, DataSourceUpdateMode.OnPropertyChanged));
            //74, 70, 69, 68
            label74.DataBindings.Add(new Binding("Text", elitemouse, "Name", true, DataSourceUpdateMode.OnPropertyChanged));
            label70.DataBindings.Add(new Binding("Text", elitemouse, "Price", true, DataSourceUpdateMode.OnPropertyChanged));
            label69.DataBindings.Add(new Binding("Text", elitemouse, "SpeedClick", true, DataSourceUpdateMode.OnPropertyChanged));
            label68.DataBindings.Add(new Binding("Text", elitemouse, "Quantity", true, DataSourceUpdateMode.OnPropertyChanged));
            //81, 77, 76, 75
            label81.DataBindings.Add(new Binding("Text", legendarymouse, "Name", true, DataSourceUpdateMode.OnPropertyChanged));
            label77.DataBindings.Add(new Binding("Text", legendarymouse, "Price", true, DataSourceUpdateMode.OnPropertyChanged));
            label76.DataBindings.Add(new Binding("Text", legendarymouse, "SpeedClick", true, DataSourceUpdateMode.OnPropertyChanged));
            label75.DataBindings.Add(new Binding("Text", legendarymouse, "Quantity", true, DataSourceUpdateMode.OnPropertyChanged));
        }
        private SergxloveCoin.resourse.StatsPlayer myBalance;
        
        private SergxloveCoin.resourse.CommonMouse commonmouse;
        private SergxloveCoin.resourse.EconomyMouse economymouse;
        private SergxloveCoin.resourse.BudgetMouse budgetmouse;
        private SergxloveCoin.resourse.StandartMouse standartmouse;
        private SergxloveCoin.resourse.UniversalMouse universalmouse;
        private SergxloveCoin.resourse.ClassicalMouse classicalmouse;
        private SergxloveCoin.resourse.ProfessionalMouse professionalmouse;
        private SergxloveCoin.resourse.PremiumMouse premiummouse;
        private SergxloveCoin.resourse.EliteMouse elitemouse;
        private SergxloveCoin.resourse.LegendaryMouse legendarymouse;
        private int frameCount = 0;
        private int sizeY = 0;
        private int coordPointY = 0;
        private bool showAnimation = false;
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            myBalance.upBalanse(myBalance.SpeedClick.ToString());
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
            if (showAnimation)
            {
                if (frameCount <= 5)
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
                if (frameCount <= 5)
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

        private void button23_Click(object sender, EventArgs e)
        {
            timer1.Interval = 7;
            frameCount = 0;
            coordPointY = 155;
            sizeY = 650;
            showAnimation = false;
            timer1.Start();
        }

        private void button34_Click(object sender, EventArgs e)
        {
            timer1.Interval = 7;
            frameCount = 0;
            coordPointY = 155;
            sizeY = 650;
            showAnimation = false;
            timer1.Start();
        }
    }
}
 