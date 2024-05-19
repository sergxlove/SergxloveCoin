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

            label2.DataBindings.Add(new Binding(nameof(Text), myBalance, nameof(myBalance.BalanceCoinString), true, DataSourceUpdateMode.OnPropertyChanged));
            label5.DataBindings.Add(new Binding(nameof(Text), myBalance, nameof(myBalance.SpeedClickString), true, DataSourceUpdateMode.OnPropertyChanged));
            label6.DataBindings.Add(new Binding(nameof(Text), myBalance, nameof(myBalance.SpeedAutoString), true, DataSourceUpdateMode.OnPropertyChanged));

            //12,16,17,18
            label12.DataBindings.Add(new Binding(nameof(Text), commonmouse, nameof(commonmouse.Name), true, DataSourceUpdateMode.OnPropertyChanged));
            label16.DataBindings.Add(new Binding(nameof(Text), commonmouse, nameof(commonmouse.Price), true, DataSourceUpdateMode.OnPropertyChanged));
            label17.DataBindings.Add(new Binding(nameof(Text), commonmouse, nameof(commonmouse.SpeedClick), true, DataSourceUpdateMode.OnPropertyChanged));
            label18.DataBindings.Add(new Binding(nameof(Text), commonmouse, nameof(commonmouse.Quantity), true, DataSourceUpdateMode.OnPropertyChanged));
            //25,21,20,19
            label25.DataBindings.Add(new Binding(nameof(Text), economymouse, nameof(economymouse.Name), true, DataSourceUpdateMode.OnPropertyChanged));
            label21.DataBindings.Add(new Binding(nameof(Text), economymouse, nameof(economymouse.Price), true, DataSourceUpdateMode.OnPropertyChanged));
            label20.DataBindings.Add(new Binding(nameof(Text), economymouse, nameof(economymouse.SpeedClick), true, DataSourceUpdateMode.OnPropertyChanged));
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
            label46.DataBindings.Add(new Binding(nameof(Text), universalmouse, nameof(universalmouse.Name), true, DataSourceUpdateMode.OnPropertyChanged));
            label42.DataBindings.Add(new Binding(nameof(Text), universalmouse, nameof(universalmouse.Price), true, DataSourceUpdateMode.OnPropertyChanged));
            label41.DataBindings.Add(new Binding(nameof(Text), universalmouse, nameof(universalmouse.SpeedClick), true, DataSourceUpdateMode.OnPropertyChanged));
            label40.DataBindings.Add(new Binding(nameof(Text), universalmouse, nameof(universalmouse.Quantity), true, DataSourceUpdateMode.OnPropertyChanged));
            //53, 49, 48, 47
            label53.DataBindings.Add(new Binding(nameof(Text), classicalmouse, nameof(classicalmouse.Name), true, DataSourceUpdateMode.OnPropertyChanged));
            label49.DataBindings.Add(new Binding(nameof(Text), classicalmouse, nameof(classicalmouse.Price), true, DataSourceUpdateMode.OnPropertyChanged));
            label48.DataBindings.Add(new Binding(nameof(Text), classicalmouse, nameof(classicalmouse.SpeedClick), true, DataSourceUpdateMode.OnPropertyChanged));
            label47.DataBindings.Add(new Binding(nameof(Text), classicalmouse, nameof(classicalmouse.Quantity), true, DataSourceUpdateMode.OnPropertyChanged));
            //60, 56, 55, 54
            label60.DataBindings.Add(new Binding(nameof(Text), professionalmouse, nameof(professionalmouse.Name), true, DataSourceUpdateMode.OnPropertyChanged));
            label56.DataBindings.Add(new Binding(nameof(Text), professionalmouse, nameof(professionalmouse.Price), true, DataSourceUpdateMode.OnPropertyChanged));
            label55.DataBindings.Add(new Binding(nameof(Text), professionalmouse, nameof(professionalmouse.SpeedClick), true, DataSourceUpdateMode.OnPropertyChanged));
            label54.DataBindings.Add(new Binding(nameof(Text), professionalmouse, nameof(professionalmouse.Quantity), true, DataSourceUpdateMode.OnPropertyChanged));
            //67, 63, 62, 61
            label67.DataBindings.Add(new Binding(nameof(Text), premiummouse, nameof(premiummouse.Name), true, DataSourceUpdateMode.OnPropertyChanged));
            label63.DataBindings.Add(new Binding(nameof(Text), premiummouse, nameof(premiummouse.Price), true, DataSourceUpdateMode.OnPropertyChanged));
            label62.DataBindings.Add(new Binding(nameof(Text), premiummouse, nameof(premiummouse.SpeedClick), true, DataSourceUpdateMode.OnPropertyChanged));
            label61.DataBindings.Add(new Binding(nameof(Text), premiummouse, nameof(premiummouse.Quantity), true, DataSourceUpdateMode.OnPropertyChanged));
            //74, 70, 69, 68
            label74.DataBindings.Add(new Binding(nameof(Text), elitemouse, nameof(elitemouse.Name), true, DataSourceUpdateMode.OnPropertyChanged));
            label70.DataBindings.Add(new Binding(nameof(Text), elitemouse, nameof(elitemouse.Price), true, DataSourceUpdateMode.OnPropertyChanged));
            label69.DataBindings.Add(new Binding(nameof(Text), elitemouse, nameof(elitemouse.SpeedClick), true, DataSourceUpdateMode.OnPropertyChanged));
            label68.DataBindings.Add(new Binding(nameof(Text), elitemouse, nameof(elitemouse.Quantity), true, DataSourceUpdateMode.OnPropertyChanged));
            //81, 77, 76, 75
            label81.DataBindings.Add(new Binding(nameof(Text), legendarymouse, nameof(legendarymouse.Name), true, DataSourceUpdateMode.OnPropertyChanged));
            label77.DataBindings.Add(new Binding(nameof(Text), legendarymouse, nameof(legendarymouse.Price), true, DataSourceUpdateMode.OnPropertyChanged));
            label76.DataBindings.Add(new Binding(nameof(Text), legendarymouse, nameof(legendarymouse.SpeedClick), true, DataSourceUpdateMode.OnPropertyChanged));
            label75.DataBindings.Add(new Binding(nameof(Text), legendarymouse, nameof(legendarymouse.Quantity), true, DataSourceUpdateMode.OnPropertyChanged));

            //152, 148, 147, 146
            label152.DataBindings.Add(new Binding(nameof(Text), commonvideocard, nameof(commonvideocard.Name), true, DataSourceUpdateMode.OnPropertyChanged));
            label148.DataBindings.Add(new Binding(nameof(Text), commonvideocard, nameof(commonvideocard.Price), true, DataSourceUpdateMode.OnPropertyChanged));
            label147.DataBindings.Add(new Binding(nameof(Text), commonvideocard, nameof(commonvideocard.Speed), true, DataSourceUpdateMode.OnPropertyChanged));
            label146.DataBindings.Add(new Binding(nameof(Text), commonvideocard, nameof(commonvideocard.Quantity), true, DataSourceUpdateMode.OnPropertyChanged));
            //144, 140, 139 , 138
            label144.DataBindings.Add(new Binding(nameof(Text), economyvideocard, nameof(economyvideocard.Name), true, DataSourceUpdateMode.OnPropertyChanged));
            label140.DataBindings.Add(new Binding(nameof(Text), economyvideocard, nameof(economyvideocard.Price), true, DataSourceUpdateMode.OnPropertyChanged));
            label139.DataBindings.Add(new Binding(nameof(Text), economyvideocard, nameof(economyvideocard.Speed), true, DataSourceUpdateMode.OnPropertyChanged));
            label138.DataBindings.Add(new Binding(nameof(Text), economyvideocard, nameof(economyvideocard.Quantity), true, DataSourceUpdateMode.OnPropertyChanged));
            //137, 133, 132, 131
            label137.DataBindings.Add(new Binding(nameof(Text), budgetvideocard, nameof(budgetvideocard.Name), true, DataSourceUpdateMode.OnPropertyChanged));
            label133.DataBindings.Add(new Binding(nameof(Text), budgetvideocard, nameof(budgetvideocard.Price), true, DataSourceUpdateMode.OnPropertyChanged));
            label132.DataBindings.Add(new Binding(nameof(Text), budgetvideocard, nameof(budgetvideocard.Speed), true, DataSourceUpdateMode.OnPropertyChanged));
            label131.DataBindings.Add(new Binding(nameof(Text), budgetvideocard, nameof(budgetvideocard.Quantity), true, DataSourceUpdateMode.OnPropertyChanged));
            //130, 126, 125, 124
            label130.DataBindings.Add(new Binding(nameof(Text), standartvideocard, nameof(standartvideocard.Name), true, DataSourceUpdateMode.OnPropertyChanged));
            label126.DataBindings.Add(new Binding(nameof(Text), standartvideocard, nameof(standartvideocard.Price), true, DataSourceUpdateMode.OnPropertyChanged));
            label125.DataBindings.Add(new Binding(nameof(Text), standartvideocard, nameof(standartvideocard.Speed), true, DataSourceUpdateMode.OnPropertyChanged));
            label124.DataBindings.Add(new Binding(nameof(Text), standartvideocard, nameof(standartvideocard.Quantity), true, DataSourceUpdateMode.OnPropertyChanged));
            //123, 119, 118, 117
            label123.DataBindings.Add(new Binding(nameof(Text), universalvideocard, nameof(universalvideocard.Name), true, DataSourceUpdateMode.OnPropertyChanged));
            label119.DataBindings.Add(new Binding(nameof(Text), universalvideocard, nameof(universalvideocard.Price), true, DataSourceUpdateMode.OnPropertyChanged));
            label118.DataBindings.Add(new Binding(nameof(Text), universalvideocard, nameof(universalvideocard.Speed), true, DataSourceUpdateMode.OnPropertyChanged));
            label117.DataBindings.Add(new Binding(nameof(Text), universalvideocard, nameof(universalvideocard.Quantity), true, DataSourceUpdateMode.OnPropertyChanged));
            //116, 112, 111, 110
            label116.DataBindings.Add(new Binding(nameof(Text), classicalvideocard, nameof(classicalvideocard.Name), true, DataSourceUpdateMode.OnPropertyChanged));
            label112.DataBindings.Add(new Binding(nameof(Text), classicalvideocard, nameof(classicalvideocard.Price), true, DataSourceUpdateMode.OnPropertyChanged));
            label111.DataBindings.Add(new Binding(nameof(Text), classicalvideocard, nameof(classicalvideocard.Speed), true, DataSourceUpdateMode.OnPropertyChanged));
            label110.DataBindings.Add(new Binding(nameof(Text), classicalvideocard, nameof(classicalvideocard.Quantity), true, DataSourceUpdateMode.OnPropertyChanged));
            //109, 105, 104, 103
            label109.DataBindings.Add(new Binding(nameof(Text), professionalvideocard, nameof(professionalvideocard.Name), true, DataSourceUpdateMode.OnPropertyChanged));
            label105.DataBindings.Add(new Binding(nameof(Text), professionalvideocard, nameof(professionalvideocard.Price), true, DataSourceUpdateMode.OnPropertyChanged));
            label104.DataBindings.Add(new Binding(nameof(Text), professionalvideocard, nameof(professionalvideocard.Speed), true, DataSourceUpdateMode.OnPropertyChanged));
            label103.DataBindings.Add(new Binding(nameof(Text), professionalvideocard, nameof(professionalvideocard.Quantity), true, DataSourceUpdateMode.OnPropertyChanged));
            //102, 98, 97, 96
            label102.DataBindings.Add(new Binding(nameof(Text), premiumvideocard, nameof(premiumvideocard.Name), true, DataSourceUpdateMode.OnPropertyChanged));
            label98.DataBindings.Add(new Binding(nameof(Text), premiumvideocard, nameof(premiumvideocard.Price), true, DataSourceUpdateMode.OnPropertyChanged));
            label97.DataBindings.Add(new Binding(nameof(Text), premiumvideocard, nameof(premiumvideocard.Speed), true, DataSourceUpdateMode.OnPropertyChanged));
            label96.DataBindings.Add(new Binding(nameof(Text), premiumvideocard, nameof(premiumvideocard.Quantity), true, DataSourceUpdateMode.OnPropertyChanged));
            //95, 91, 90, 89
            label95.DataBindings.Add(new Binding(nameof(Text), elitevideocard, nameof(elitevideocard.Name), true, DataSourceUpdateMode.OnPropertyChanged));
            label91.DataBindings.Add(new Binding(nameof(Text), elitevideocard, nameof(elitevideocard.Price), true, DataSourceUpdateMode.OnPropertyChanged));
            label90.DataBindings.Add(new Binding(nameof(Text), elitevideocard, nameof(elitevideocard.Speed), true, DataSourceUpdateMode.OnPropertyChanged));
            label89.DataBindings.Add(new Binding(nameof(Text), elitevideocard, nameof(elitevideocard.Quantity), true, DataSourceUpdateMode.OnPropertyChanged));
            //88, 84, 83, 82
            label88.DataBindings.Add(new Binding(nameof(Text), legendaryvideocard, nameof(legendaryvideocard.Name), true, DataSourceUpdateMode.OnPropertyChanged));
            label84.DataBindings.Add(new Binding(nameof(Text), legendaryvideocard, nameof(legendaryvideocard.Price), true, DataSourceUpdateMode.OnPropertyChanged));
            label83.DataBindings.Add(new Binding(nameof(Text), legendaryvideocard, nameof(legendaryvideocard.Speed), true, DataSourceUpdateMode.OnPropertyChanged));
            label82.DataBindings.Add(new Binding(nameof(Text), legendaryvideocard, nameof(legendaryvideocard.Quantity), true, DataSourceUpdateMode.OnPropertyChanged));
            //223 , 219, 218, 217
            label223.DataBindings.Add(new Binding(nameof(Text), commonprocessor, nameof(commonprocessor.Name), true, DataSourceUpdateMode.OnPropertyChanged));
            label219.DataBindings.Add(new Binding(nameof(Text), commonprocessor, nameof(commonprocessor.Price), true, DataSourceUpdateMode.OnPropertyChanged));
            label218.DataBindings.Add(new Binding(nameof(Text), commonprocessor, nameof(commonprocessor.Speed), true, DataSourceUpdateMode.OnPropertyChanged));
            label217.DataBindings.Add(new Binding(nameof(Text), commonprocessor, nameof(commonprocessor.Quantity), true, DataSourceUpdateMode.OnPropertyChanged));
            //215, 211, 210, 209
            label215.DataBindings.Add(new Binding(nameof(Text), economyprocessor, nameof(economyprocessor.Name), true, DataSourceUpdateMode.OnPropertyChanged));
            label211.DataBindings.Add(new Binding(nameof(Text), economyprocessor, nameof(economyprocessor.Price), true, DataSourceUpdateMode.OnPropertyChanged));
            label210.DataBindings.Add(new Binding(nameof(Text), economyprocessor, nameof(economyprocessor.Speed), true, DataSourceUpdateMode.OnPropertyChanged));
            label209.DataBindings.Add(new Binding(nameof(Text), economyprocessor, nameof(economyprocessor.Quantity), true, DataSourceUpdateMode.OnPropertyChanged));
            //208, 204, 203, 202
            label208.DataBindings.Add(new Binding(nameof(Text), budgetprocessor, nameof(budgetprocessor.Name), true, DataSourceUpdateMode.OnPropertyChanged));
            label204.DataBindings.Add(new Binding(nameof(Text), budgetprocessor, nameof(budgetprocessor.Price), true, DataSourceUpdateMode.OnPropertyChanged));
            label203.DataBindings.Add(new Binding(nameof(Text), budgetprocessor, nameof(budgetprocessor.Speed), true, DataSourceUpdateMode.OnPropertyChanged));
            label202.DataBindings.Add(new Binding(nameof(Text), budgetprocessor, nameof(budgetprocessor.Quantity), true, DataSourceUpdateMode.OnPropertyChanged));
            //201, 197, 196, 195
            label201.DataBindings.Add(new Binding(nameof(Text), standartprocessor, nameof(standartprocessor.Name), true, DataSourceUpdateMode.OnPropertyChanged));
            label197.DataBindings.Add(new Binding(nameof(Text), standartprocessor, nameof(standartprocessor.Price), true, DataSourceUpdateMode.OnPropertyChanged));
            label196.DataBindings.Add(new Binding(nameof(Text), standartprocessor, nameof(standartprocessor.Speed), true, DataSourceUpdateMode.OnPropertyChanged));
            label195.DataBindings.Add(new Binding(nameof(Text), standartprocessor, nameof(standartprocessor.Quantity), true, DataSourceUpdateMode.OnPropertyChanged));
            //194, 190, 189, 188
            label194.DataBindings.Add(new Binding(nameof(Text), universalprocessor, nameof(universalprocessor.Name), true, DataSourceUpdateMode.OnPropertyChanged));
            label190.DataBindings.Add(new Binding(nameof(Text), universalprocessor, nameof(universalprocessor.Price), true, DataSourceUpdateMode.OnPropertyChanged));
            label189.DataBindings.Add(new Binding(nameof(Text), universalprocessor, nameof(universalprocessor.Speed), true, DataSourceUpdateMode.OnPropertyChanged));
            label188.DataBindings.Add(new Binding(nameof(Text), universalprocessor, nameof(universalprocessor.Quantity), true, DataSourceUpdateMode.OnPropertyChanged));
            //187, 183, 182, 181
            label187.DataBindings.Add(new Binding(nameof(Text), classicalprocessor, nameof(classicalprocessor.Name), true, DataSourceUpdateMode.OnPropertyChanged));
            label183.DataBindings.Add(new Binding(nameof(Text), classicalprocessor, nameof(classicalprocessor.Price), true, DataSourceUpdateMode.OnPropertyChanged));
            label182.DataBindings.Add(new Binding(nameof(Text), classicalprocessor, nameof(classicalprocessor.Speed), true, DataSourceUpdateMode.OnPropertyChanged));
            label181.DataBindings.Add(new Binding(nameof(Text), classicalprocessor, nameof(classicalprocessor.Quantity), true, DataSourceUpdateMode.OnPropertyChanged));
            //180, 176, 175, 174
            label180.DataBindings.Add(new Binding(nameof(Text), professionalprocessor, nameof(professionalprocessor.Name), true, DataSourceUpdateMode.OnPropertyChanged));
            label176.DataBindings.Add(new Binding(nameof(Text), professionalprocessor, nameof(professionalprocessor.Price), true, DataSourceUpdateMode.OnPropertyChanged));
            label175.DataBindings.Add(new Binding(nameof(Text), professionalprocessor, nameof(professionalprocessor.Speed), true, DataSourceUpdateMode.OnPropertyChanged));
            label174.DataBindings.Add(new Binding(nameof(Text), professionalprocessor, nameof(professionalprocessor.Quantity), true, DataSourceUpdateMode.OnPropertyChanged));
            //173, 169 , 168, 167
            label173.DataBindings.Add(new Binding(nameof(Text), premiumprocessor, nameof(premiumprocessor.Name), true, DataSourceUpdateMode.OnPropertyChanged));
            label169.DataBindings.Add(new Binding(nameof(Text), premiumprocessor, nameof(premiumprocessor.Price), true, DataSourceUpdateMode.OnPropertyChanged));
            label168.DataBindings.Add(new Binding(nameof(Text), premiumprocessor, nameof(premiumprocessor.Speed), true, DataSourceUpdateMode.OnPropertyChanged));
            label167.DataBindings.Add(new Binding(nameof(Text), premiumprocessor, nameof(premiumprocessor.Quantity), true, DataSourceUpdateMode.OnPropertyChanged));
            //166, 162, 161, 160
            label166.DataBindings.Add(new Binding(nameof(Text), eliteprocessor, nameof(eliteprocessor.Name), true, DataSourceUpdateMode.OnPropertyChanged));
            label162.DataBindings.Add(new Binding(nameof(Text), eliteprocessor, nameof(eliteprocessor.Price), true, DataSourceUpdateMode.OnPropertyChanged));
            label161.DataBindings.Add(new Binding(nameof(Text), eliteprocessor, nameof(eliteprocessor.Speed), true, DataSourceUpdateMode.OnPropertyChanged));
            label160.DataBindings.Add(new Binding(nameof(Text), eliteprocessor, nameof(eliteprocessor.Quantity), true, DataSourceUpdateMode.OnPropertyChanged));
            //159, 155, 154, 153
            label159.DataBindings.Add(new Binding(nameof(Text), legendaryprocessor, nameof(legendaryprocessor.Name), true, DataSourceUpdateMode.OnPropertyChanged));
            label155.DataBindings.Add(new Binding(nameof(Text), legendaryprocessor, nameof(legendaryprocessor.Price), true, DataSourceUpdateMode.OnPropertyChanged));
            label154.DataBindings.Add(new Binding(nameof(Text), legendaryprocessor, nameof(legendaryprocessor.Speed), true, DataSourceUpdateMode.OnPropertyChanged));
            label153.DataBindings.Add(new Binding(nameof(Text), legendaryprocessor, nameof(legendaryprocessor.Quantity), true, DataSourceUpdateMode.OnPropertyChanged));
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

        private void button4_Click(object sender, EventArgs e)
        {
            commonmouse.Quantity += 1;
            myBalance.BalansePlayer -= commonmouse.Price;
            myBalance.SpeedClick += commonmouse.SpeedClick;
            myBalance.OnPropertyChanged();
        }
    }
}
 