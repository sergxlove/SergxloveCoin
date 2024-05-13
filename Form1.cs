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

            commonvideocard = new();
            economyvideocard = new();
            budgetvideocard = new();
            standartvideocard = new();
            universalvideocard = new();
            classicalvideocard = new();
            professionalvideocard = new();
            premiumvideocard = new();
            elitevideocard = new();
            legendaryvideocard = new();

            commonprocessor = new();
            economyprocessor = new();
            budgetprocessor = new();
            standartprocessor = new();
            universalprocessor = new();
            classicalprocessor = new();
            professionalprocessor = new();
            premiumprocessor = new();
            eliteprocessor = new();
            legendaryprocessor = new();

            label2.DataBindings.Add(new Binding(nameof(Text), myBalance, "BalanceCoinString", true, DataSourceUpdateMode.OnPropertyChanged));

            //12,16,17,18
            label12.DataBindings.Add(new Binding(nameof(Text), commonmouse, nameof(commonmouse.Name), true, DataSourceUpdateMode.OnPropertyChanged));
            label16.DataBindings.Add(new Binding(nameof(Text), commonmouse, nameof(commonmouse.Price), true, DataSourceUpdateMode.OnPropertyChanged));
            label17.DataBindings.Add(new Binding(nameof(Text), commonmouse, nameof(commonmouse.SpeedClick), true, DataSourceUpdateMode.OnPropertyChanged));
            label18.DataBindings.Add(new Binding(nameof(Text), commonmouse, nameof(commonmouse.Quantity), true, DataSourceUpdateMode.OnPropertyChanged));
            //25,21,20,19
            label25.DataBindings.Add(new Binding(nameof(Text), economymouse, nameof(economymouse.Name), true, DataSourceUpdateMode.OnPropertyChanged));
            label21.DataBindings.Add(new Binding(nameof(Text), economymouse, nameof(economymouse.Price), true, DataSourceUpdateMode.OnPropertyChanged));
            label20.DataBindings.Add(new Binding(nameof(Text), economymouse, nameof(economymouse.SpeedClick),true, DataSourceUpdateMode.OnPropertyChanged));
            label19.DataBindings.Add(new Binding(nameof(Text), economymouse, nameof(economymouse.Quantity), true, DataSourceUpdateMode.OnPropertyChanged));
            //32,28,27,26
            label32.DataBindings.Add(new Binding(nameof(Text), budgetmouse, nameof(budgetmouse.Name), true, DataSourceUpdateMode.OnPropertyChanged));
            label28.DataBindings.Add(new Binding(nameof(Text), budgetmouse, nameof(budgetmouse.Price), true, DataSourceUpdateMode.OnPropertyChanged));
            label27.DataBindings.Add(new Binding(nameof(Text), budgetmouse, nameof(budgetmouse.SpeedClick), true, DataSourceUpdateMode.OnPropertyChanged));
            label26.DataBindings.Add(new Binding(nameof(Text), budgetmouse, nameof(budgetmouse.Quantity), true, DataSourceUpdateMode.OnPropertyChanged));
            //39, 35, 34, 33
            label39.DataBindings.Add(new Binding(nameof(Text), standartmouse, nameof(standartmouse.Name), true, DataSourceUpdateMode.OnPropertyChanged));
            label35.DataBindings.Add(new Binding(nameof(Text), standartmouse, nameof(standartmouse.Price), true, DataSourceUpdateMode.OnPropertyChanged));
            label34.DataBindings.Add(new Binding(nameof(Text), standartmouse, nameof(standartmouse.SpeedClick), true, DataSourceUpdateMode.OnPropertyChanged));
            label33.DataBindings.Add(new Binding(nameof(Text), standartmouse, nameof(standartmouse.Quantity), true, DataSourceUpdateMode.OnPropertyChanged));
            //46, 42, 41, 40
            label46.DataBindings.Add(new Binding(nameof(Text), universalmouse, "Name", true, DataSourceUpdateMode.OnPropertyChanged));
            label42.DataBindings.Add(new Binding(nameof(Text), universalmouse, "Price", true, DataSourceUpdateMode.OnPropertyChanged));
            label41.DataBindings.Add(new Binding(nameof(Text), universalmouse, "SpeedClick", true, DataSourceUpdateMode.OnPropertyChanged));
            label40.DataBindings.Add(new Binding(nameof(Text), universalmouse, "Quantity", true, DataSourceUpdateMode.OnPropertyChanged));
            //53, 49, 48, 47
            label53.DataBindings.Add(new Binding(nameof(Text), classicalmouse, "Name", true, DataSourceUpdateMode.OnPropertyChanged));
            label49.DataBindings.Add(new Binding(nameof(Text), classicalmouse, "Price", true, DataSourceUpdateMode.OnPropertyChanged));
            label48.DataBindings.Add(new Binding(nameof(Text), classicalmouse, "SpeedClick", true, DataSourceUpdateMode.OnPropertyChanged));
            label47.DataBindings.Add(new Binding(nameof(Text), classicalmouse, "Quantity", true, DataSourceUpdateMode.OnPropertyChanged));
            //60, 56, 55, 54
            label60.DataBindings.Add(new Binding(nameof(Text), professionalmouse, "Name", true, DataSourceUpdateMode.OnPropertyChanged));
            label56.DataBindings.Add(new Binding(nameof(Text), professionalmouse, "Price", true, DataSourceUpdateMode.OnPropertyChanged));
            label55.DataBindings.Add(new Binding(nameof(Text), professionalmouse, "SpeedClick", true, DataSourceUpdateMode.OnPropertyChanged));
            label54.DataBindings.Add(new Binding(nameof(Text), professionalmouse, "Quantity", true, DataSourceUpdateMode.OnPropertyChanged));
            //67, 63, 62, 61
            label67.DataBindings.Add(new Binding(nameof(Text), premiummouse, "Name", true, DataSourceUpdateMode.OnPropertyChanged));
            label63.DataBindings.Add(new Binding(nameof(Text), premiummouse, "Price", true, DataSourceUpdateMode.OnPropertyChanged));
            label62.DataBindings.Add(new Binding(nameof(Text), premiummouse, "SpeedClick", true, DataSourceUpdateMode.OnPropertyChanged));
            label61.DataBindings.Add(new Binding(nameof(Text), premiummouse, "Quantity", true, DataSourceUpdateMode.OnPropertyChanged));
            //74, 70, 69, 68
            label74.DataBindings.Add(new Binding(nameof(Text), elitemouse, "Name", true, DataSourceUpdateMode.OnPropertyChanged));
            label70.DataBindings.Add(new Binding(nameof(Text), elitemouse, "Price", true, DataSourceUpdateMode.OnPropertyChanged));
            label69.DataBindings.Add(new Binding(nameof(Text), elitemouse, "SpeedClick", true, DataSourceUpdateMode.OnPropertyChanged));
            label68.DataBindings.Add(new Binding(nameof(Text), elitemouse, "Quantity", true, DataSourceUpdateMode.OnPropertyChanged));
            //81, 77, 76, 75
            label81.DataBindings.Add(new Binding(nameof(Text), legendarymouse, "Name", true, DataSourceUpdateMode.OnPropertyChanged));
            label77.DataBindings.Add(new Binding(nameof(Text), legendarymouse, "Price", true, DataSourceUpdateMode.OnPropertyChanged));
            label76.DataBindings.Add(new Binding(nameof(Text), legendarymouse, "SpeedClick", true, DataSourceUpdateMode.OnPropertyChanged));
            label75.DataBindings.Add(new Binding(nameof(Text), legendarymouse, "Quantity", true, DataSourceUpdateMode.OnPropertyChanged));

            //152, 148, 147, 146
            label152.DataBindings.Add(new Binding(nameof(Text), commonvideocard, "Name", true, DataSourceUpdateMode.OnPropertyChanged));
            label148.DataBindings.Add(new Binding(nameof(Text), commonvideocard, "Price", true, DataSourceUpdateMode.OnPropertyChanged));
            label147.DataBindings.Add(new Binding(nameof(Text), commonvideocard, "Speed", true, DataSourceUpdateMode.OnPropertyChanged));
            label146.DataBindings.Add(new Binding(nameof(Text), commonvideocard, "Quantity", true, DataSourceUpdateMode.OnPropertyChanged));
            //144, 140, 139 , 138
            label144.DataBindings.Add(new Binding(nameof(Text), economyvideocard, "Name", true, DataSourceUpdateMode.OnPropertyChanged));
            label140.DataBindings.Add(new Binding(nameof(Text), economyvideocard, "Price", true, DataSourceUpdateMode.OnPropertyChanged));
            label139.DataBindings.Add(new Binding(nameof(Text), economyvideocard, "Speed", true, DataSourceUpdateMode.OnPropertyChanged));
            label138.DataBindings.Add(new Binding(nameof(Text), economyvideocard, "Quantity", true, DataSourceUpdateMode.OnPropertyChanged));
            //137, 133, 132, 131
            label137.DataBindings.Add(new Binding(nameof(Text), budgetvideocard, "Name", true, DataSourceUpdateMode.OnPropertyChanged));
            label133.DataBindings.Add(new Binding(nameof(Text), budgetvideocard, "Price", true, DataSourceUpdateMode.OnPropertyChanged));
            label132.DataBindings.Add(new Binding(nameof(Text), budgetvideocard, "Speed", true, DataSourceUpdateMode.OnPropertyChanged));
            label131.DataBindings.Add(new Binding(nameof(Text), budgetvideocard, "Quantity", true, DataSourceUpdateMode.OnPropertyChanged));
            //130, 126, 125, 124
            label130.DataBindings.Add(new Binding(nameof(Text), standartvideocard, "Name", true, DataSourceUpdateMode.OnPropertyChanged));
            label126.DataBindings.Add(new Binding(nameof(Text), standartvideocard, "Price", true, DataSourceUpdateMode.OnPropertyChanged));
            label125.DataBindings.Add(new Binding(nameof(Text), standartvideocard, "Speed", true, DataSourceUpdateMode.OnPropertyChanged));
            label124.DataBindings.Add(new Binding(nameof(Text), standartvideocard, "Quantity", true, DataSourceUpdateMode.OnPropertyChanged));
            //123, 119, 118, 117
            label123.DataBindings.Add(new Binding(nameof(Text), universalvideocard, "Name", true, DataSourceUpdateMode.OnPropertyChanged));
            label119.DataBindings.Add(new Binding(nameof(Text), universalvideocard, "Price", true, DataSourceUpdateMode.OnPropertyChanged));
            label118.DataBindings.Add(new Binding(nameof(Text), universalvideocard, "Speed", true, DataSourceUpdateMode.OnPropertyChanged));
            label117.DataBindings.Add(new Binding(nameof(Text), universalvideocard, "Quantity", true, DataSourceUpdateMode.OnPropertyChanged));
            //116, 112, 111, 110
            label116.DataBindings.Add(new Binding(nameof(Text), classicalvideocard, "Name", true, DataSourceUpdateMode.OnPropertyChanged));
            label112.DataBindings.Add(new Binding(nameof(Text), classicalvideocard, "Price", true, DataSourceUpdateMode.OnPropertyChanged));
            label111.DataBindings.Add(new Binding(nameof(Text), classicalvideocard, "Speed", true, DataSourceUpdateMode.OnPropertyChanged));
            label110.DataBindings.Add(new Binding(nameof(Text), classicalvideocard, "Quantity", true, DataSourceUpdateMode.OnPropertyChanged));
            //109, 105, 104, 103
            label109.DataBindings.Add(new Binding(nameof(Text), professionalvideocard, "Name", true, DataSourceUpdateMode.OnPropertyChanged));
            label105.DataBindings.Add(new Binding(nameof(Text), professionalvideocard, "Price", true, DataSourceUpdateMode.OnPropertyChanged));
            label104.DataBindings.Add(new Binding(nameof(Text), professionalvideocard, "Speed", true, DataSourceUpdateMode.OnPropertyChanged));
            label103.DataBindings.Add(new Binding(nameof(Text), professionalvideocard, "Quantity", true, DataSourceUpdateMode.OnPropertyChanged));
            //102, 98, 97, 96
            label102.DataBindings.Add(new Binding(nameof(Text), premiumvideocard, "Name", true, DataSourceUpdateMode.OnPropertyChanged));
            label98.DataBindings.Add(new Binding(nameof(Text), premiumvideocard, "Price", true, DataSourceUpdateMode.OnPropertyChanged));
            label97.DataBindings.Add(new Binding(nameof(Text), premiumvideocard, "Speed", true, DataSourceUpdateMode.OnPropertyChanged));
            label96.DataBindings.Add(new Binding(nameof(Text), premiumvideocard, "Quantity", true, DataSourceUpdateMode.OnPropertyChanged));
            //95, 91, 90, 89
            label95.DataBindings.Add(new Binding(nameof(Text), elitevideocard, "Name", true, DataSourceUpdateMode.OnPropertyChanged));
            label91.DataBindings.Add(new Binding(nameof(Text), elitevideocard, "Price", true, DataSourceUpdateMode.OnPropertyChanged));
            label90.DataBindings.Add(new Binding(nameof(Text), elitevideocard, "Speed", true, DataSourceUpdateMode.OnPropertyChanged));
            label89.DataBindings.Add(new Binding(nameof(Text), elitevideocard, "Quantity", true, DataSourceUpdateMode.OnPropertyChanged));
            //88, 84, 83, 82
            label88.DataBindings.Add(new Binding(nameof(Text), legendaryvideocard, "Name", true, DataSourceUpdateMode.OnPropertyChanged));
            label84.DataBindings.Add(new Binding(nameof(Text), legendaryvideocard, "Price", true, DataSourceUpdateMode.OnPropertyChanged));
            label83.DataBindings.Add(new Binding(nameof(Text), legendaryvideocard, "Speed", true, DataSourceUpdateMode.OnPropertyChanged));
            label82.DataBindings.Add(new Binding(nameof(Text), legendaryvideocard, "Quantity", true, DataSourceUpdateMode.OnPropertyChanged));
            //223 , 219, 218, 217

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

        private SergxloveCoin.resourse.CommonVideoCard commonvideocard;
        private SergxloveCoin.resourse.EconomyVideoCard economyvideocard;
        private SergxloveCoin.resourse.BudgetVideoCard budgetvideocard;
        private SergxloveCoin.resourse.StandartVideoCard standartvideocard;
        private SergxloveCoin.resourse.UniversalVideoCard universalvideocard;
        private SergxloveCoin.resourse.ClassicalVideoCard classicalvideocard;
        private SergxloveCoin.resourse.ProfessionalVideoCard professionalvideocard;
        private SergxloveCoin.resourse.PremiumVideoCard premiumvideocard;
        private SergxloveCoin.resourse.EliteVideoCard elitevideocard;
        private SergxloveCoin.resourse.LegendaryVideoCard legendaryvideocard;

        private SergxloveCoin.resourse.CommonProcessor commonprocessor;
        private SergxloveCoin.resourse.EconomyProcessor economyprocessor;
        private SergxloveCoin.resourse.BudgetProcessor budgetprocessor;
        private SergxloveCoin.resourse.StandartProcessor standartprocessor;
        private SergxloveCoin.resourse.UniversalProcessor universalprocessor;
        private SergxloveCoin.resourse.ClassicalProcessor classicalprocessor;
        private SergxloveCoin.resourse.ProfessionalProcessor professionalprocessor;
        private SergxloveCoin.resourse.PremiumProcessor premiumprocessor;
        private SergxloveCoin.resourse.EliteProcessor eliteprocessor;
        private SergxloveCoin.resourse.LegendaryProcessor legendaryprocessor;

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
 