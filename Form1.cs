using SergxloveCoin.resourse;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;

namespace SergxloveCoin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            if (File.Exists("userdata.db"))
            {
                isCreateDatabase = true;
            }
            else
            {
                isCreateDatabase = false;
            }
            myBalance = new();

            commonmouse = new("Обычная мышь", 500, 3, 0);
            economymouse = new("Эконом мышь", 2000, 9, 0);
            budgetmouse = new("Бюджетная мышь", 10000, 20, 0);
            standartmouse = new("Стандартная мышь", 50000, 45, 0);
            universalmouse = new("Универсальная мышь", 250000, 110, 0);
            classicalmouse = new("Классическая мышь", 1000000, 250, 0);
            professionalmouse = new("Профессиональная мышь", 4000000, 650, 0);
            premiummouse = new("Премиум мышь", 20000000, 1000, 0);
            elitemouse = new("Элитеая мышь", 100000000, 2100, 0);
            legendarymouse = new("Легендарная мышь", 250000000, 4000, 0);

            commonvideocard = new("Обычная видеокарта", 150, 5, 0);
            economyvideocard = new("Эконом видеокарта", 500, 10, 0);
            budgetvideocard = new("Бюджетная видеокарта", 3000, 20, 0);
            standartvideocard = new("Стандартная видеокарта", 10000, 35, 0);
            universalvideocard = new("Универсальная видеокарта", 50000, 60, 0);
            classicalvideocard = new("Классическая видеокарта", 300000, 100, 0);
            professionalvideocard = new("Профессиональная видеокарта", 1000000, 250, 0);
            premiumvideocard = new("Премиум видеокарта", 2500000, 400, 0);
            elitevideocard = new("Элитная видеокарта", 10000000, 700, 0);
            legendaryvideocard = new("Легендарная видоекарта", 45000000, 1000, 0);

            commonprocessor = new("Обычный процессор", 30, 2, 0);
            economyprocessor = new("Эконом процессор", 1500, 3, 0);
            budgetprocessor = new("Бюджетный процессор", 6000, 5, 0);
            standartprocessor = new("Стандартный процессор", 25000, 8, 0);
            universalprocessor = new("Универсальный процессор", 100000, 13, 0);
            classicalprocessor = new("Классический процессор", 500000, 25, 0);
            professionalprocessor = new("Профкссиональный процессор", 2000000, 40, 0);
            premiumprocessor = new("Премиум процессор", 10000000, 65, 0);
            eliteprocessor = new("Элитный прцессор", 30000000, 100, 0);
            legendaryprocessor = new("Легендарный процессор", 50000000, 130, 0);

            dictionaryMouse = new Dictionary<string, Mouse>()
            {
                ["buycommonmouse"] = commonmouse,
                ["buyeconomymouse"] = economymouse,
                ["buybudgetmouse"] = budgetmouse,
                ["buystandartmouse"] = standartmouse,
                ["buyuniversalmouse"] = universalmouse,
                ["buyclassicalmouse"] = classicalmouse,
                ["buyprofessionalmouse"] = professionalmouse,
                ["buypremiummouse"] = premiummouse,
                ["buyelitemouse"] = elitemouse,
                ["buylegendarymouse"] = legendarymouse
            };
            dictionaryVideoCard = new Dictionary<string, VideoCard>()
            {
                ["buycommonvideocard"] = commonvideocard,
                ["buyeconomyvideocard"] = economyvideocard,
                ["buybudgetvideocard"] = budgetvideocard,
                ["buystandartvideocard"] = standartvideocard,
                ["buyuniversalvideocard"] = universalvideocard,
                ["buyclassicalvideocard"] = classicalvideocard,
                ["buyprofessionalvideocard"] = professionalvideocard,
                ["buypremiumvideocard"] = premiumvideocard,
                ["buyelitevideocard"] = elitevideocard,
                ["buylegendaryvideocard"] = legendaryvideocard
            };
            dictionaryProcessor = new Dictionary<string, Processor>()
            {
                ["buycommonprocessor"] = commonprocessor,
                ["buyeconomyprocessor"] = economyprocessor,
                ["buybudgetprocessor"] = budgetprocessor,
                ["buystandartprocessor"] = standartprocessor,
                ["buyuniversalprocessor"] = universalprocessor,
                ["buyclassicalprocessor"] = classicalprocessor,
                ["buyprofessionalprocessor"] = professionalprocessor,
                ["buypremiumprocessor"] = premiumprocessor,
                ["buyeliteprocessor"] = eliteprocessor,
                ["buylegendaryprocessor"] = legendaryprocessor
            };
            namesMouse = new List<string>()
            {
                "buycommonmouse", "buyeconomymouse", "buybudgetmouse", "buystandartmouse", "buyuniversalmouse",
                "buyclassicalmouse", "buyprofessionalmouse", "buypremiummouse", "buyelitemouse", "buylegendarymouse"
            };
            namesVideoCard = new List<string>()
            {
                "buycommonvideocard", "buyeconomyvideocard", "buybudgetvideocard", "buystandartvideocard", "buyuniversalvideocard",
                "buyclassicalvideocard", "buyprofessionalvideocard", "buypremiumvideocard", "buyelitevideocard", "buylegendaryvideocard"
            };
            namesProcessor = new List<string>()
            {
                "buycommonprocessor", "buyeconomyprocessor", "buybudgetprocessor", "buystandartprocessor", "buyuniversalprocessor",
                "buyclassicalprocessor", "buyprofessionalprocessor",  "buypremiumprocessor", "buyeliteprocessor", "buylegendaryprocessor"
            };
            sqlConnection = "Data source=userdata.db";

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

        private SergxloveCoin.resourse.Mouse commonmouse;
        private SergxloveCoin.resourse.Mouse economymouse;
        private SergxloveCoin.resourse.Mouse budgetmouse;
        private SergxloveCoin.resourse.Mouse standartmouse;
        private SergxloveCoin.resourse.Mouse universalmouse;
        private SergxloveCoin.resourse.Mouse classicalmouse;
        private SergxloveCoin.resourse.Mouse professionalmouse;
        private SergxloveCoin.resourse.Mouse premiummouse;
        private SergxloveCoin.resourse.Mouse elitemouse;
        private SergxloveCoin.resourse.Mouse legendarymouse;

        private SergxloveCoin.resourse.VideoCard commonvideocard;
        private SergxloveCoin.resourse.VideoCard economyvideocard;
        private SergxloveCoin.resourse.VideoCard budgetvideocard;
        private SergxloveCoin.resourse.VideoCard standartvideocard;
        private SergxloveCoin.resourse.VideoCard universalvideocard;
        private SergxloveCoin.resourse.VideoCard classicalvideocard;
        private SergxloveCoin.resourse.VideoCard professionalvideocard;
        private SergxloveCoin.resourse.VideoCard premiumvideocard;
        private SergxloveCoin.resourse.VideoCard elitevideocard;
        private SergxloveCoin.resourse.VideoCard legendaryvideocard;

        private SergxloveCoin.resourse.Processor commonprocessor;
        private SergxloveCoin.resourse.Processor economyprocessor;
        private SergxloveCoin.resourse.Processor budgetprocessor;
        private SergxloveCoin.resourse.Processor standartprocessor;
        private SergxloveCoin.resourse.Processor universalprocessor;
        private SergxloveCoin.resourse.Processor classicalprocessor;
        private SergxloveCoin.resourse.Processor professionalprocessor;
        private SergxloveCoin.resourse.Processor premiumprocessor;
        private SergxloveCoin.resourse.Processor eliteprocessor;
        private SergxloveCoin.resourse.Processor legendaryprocessor;

        private Dictionary<string, Mouse> dictionaryMouse;
        private Dictionary<string, VideoCard> dictionaryVideoCard;
        private Dictionary<string, Processor> dictionaryProcessor;
        private List<string> namesMouse;
        private List<string> namesVideoCard;
        private List<string> namesProcessor;

        private string sqlConnection;
        bool isCreateDatabase;

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
            myBalance.upBalanse(myBalance.SpeedClick);
            label2.Text = myBalance.BalansePlayer.ToString();

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
            label5.Text = myBalance.SpeedClick.ToString();
            label6.Text = myBalance.SpeedAutoString;
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
            button3_Click(sender, e);
        }

        private void button34_Click(object sender, EventArgs e)
        {
            button3_Click(sender, e);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            if (isCreateDatabase)
            {
                using (var connection = new SqliteConnection(sqlConnection))
                {
                    connection.Open();
                    string sqlCommand = "SELECT * FROM Mouses;";
                    int countComponent = 0;
                    SqliteCommand command = connection.CreateCommand();
                    command.Connection = connection;
                    command.CommandText = sqlCommand;
                    using (SqliteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                dictionaryMouse[namesMouse[countComponent]].ChangeData(reader.GetInt32(1), reader.GetInt32(2), reader.GetInt32(3));
                                countComponent++;
                            }
                        }
                    }
                    countComponent = 0;
                    sqlCommand = "SELECT * FROM Videocards;";
                    command.CommandText = sqlCommand;
                    using (SqliteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                dictionaryVideoCard[namesVideoCard[countComponent]].ChangeData(reader.GetInt32(1), reader.GetInt32(2), reader.GetInt32(3));
                                countComponent++;
                            }
                        }
                    }
                    countComponent = 0;
                    sqlCommand = "SELECT * FROM Processors;";
                    command.CommandText = sqlCommand;
                    using (SqliteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                dictionaryProcessor[namesProcessor[countComponent]].ChangeData(reader.GetInt32(1), reader.GetInt32(2), reader.GetInt32(3));
                                countComponent++;
                            }
                        }
                    }
                    sqlCommand = "SELECT * FROM StatsPlayer;";
                    command.CommandText = sqlCommand;
                    using (SqliteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            reader.Read();
                            myBalance.changeData(reader.GetInt32(2), reader.GetInt64(1), reader.GetInt32(3), reader.GetInt32(4));
                        }
                    }
                }
            }
            else
            {
                using (var connection = new SqliteConnection(sqlConnection))
                {

                    connection.Open();
                    string sqlCommand = "CREATE TABLE StatsPlayer( idPlayer INT PRIMARY KEY NOT NULL, balancePlayer BIGINT NOT NULL, speedClick INT NOT NULL, speedVideoCard INT NOT NULL, speedProcessor INT NOT NULL);";
                    SqliteCommand command = connection.CreateCommand();
                    command.Connection = connection;
                    command.CommandText = sqlCommand;
                    command.ExecuteNonQuery();
                    sqlCommand = "CREATE TABLE Mouses(idMouse INT PRIMARY KEY NOT NULL,price INT NOT NULL,speed INT NOT NULL,quantity INT NOT NULL);";
                    command.CommandText = sqlCommand;
                    command.ExecuteNonQuery();
                    sqlCommand = "CREATE TABLE Videocards(idVideocard INT PRIMARY KEY NOT NULL, price INT NOT NULL, speed INT NOT NULL, quantity INT NOT NULL);";
                    command.CommandText = sqlCommand;
                    command.ExecuteNonQuery();
                    sqlCommand = "CREATE TABLE Processors(idProcessor INT PRIMARY KEY NOT NULL, price INT NOT NULL, speed INT NOT NULL, quantity INT NOT NULL);";
                    command.CommandText = sqlCommand;
                    command.ExecuteNonQuery();
                    sqlCommand = $@"INSERT INTO StatsPlayer(idPlayer, balancePlayer, speedClick, speedVideoCard, speedProcessor) VALUES(1, 100, 5, 0, 0);";
                    command.CommandText = sqlCommand;
                    command.ExecuteNonQuery();
                    sqlCommand = $@"INSERT INTO Mouses(idMouse, price, speed, quantity) VALUES
                    (1, 500, 3, 0),
                    (2, 2000, 9, 0),
                    (3, 10000, 20, 0),
                    (4, 50000, 45, 0),
                    (5, 250000, 110, 0),
                    (6, 1000000, 250, 0),
                    (7, 4000000, 650, 0),
                    (8, 20000000, 1000, 0),
                    (9, 100000000, 2100, 0),
                    (10, 250000000, 4000, 0);";
                    command.CommandText = sqlCommand;
                    command.ExecuteNonQuery();
                    sqlCommand = $@"INSERT INTO Videocards(idVideocard, price, speed, quantity) VALUES
                    (1, 150, 5, 0),
                    (2, 500, 10, 0),
                    (3, 3000, 20, 0),
                    (4, 10000, 35, 0),
                    (5, 50000, 60, 0),
                    (6, 300000, 100, 0),
                    (7, 1000000, 250, 0),
                    (8, 2500000, 400, 0),
                    (9, 10000000, 700, 0),
                    (10, 45000000, 1000, 0);";
                    command.CommandText = sqlCommand;
                    command.ExecuteNonQuery();
                    sqlCommand = $@"INSERT INTO Processors(idProcessor, price, speed, quantity) VALUES
                    (1, 300, 2, 0),
                    (2, 1500, 3, 0),
                    (3, 6000, 5, 0),
                    (4, 25000, 8, 0),
                    (5, 100000, 13, 0),
                    (6, 500000, 25, 0),
                    (7, 2000000, 40, 0),
                    (8, 10000000, 65, 0),
                    (9, 30000000, 100, 0),
                    (10, 50000000, 130, 0);";
                    command.CommandText = sqlCommand;
                    command.ExecuteNonQuery();
                }
            }
            label2.Text = myBalance.BalansePlayer.ToString();
            label5.Text = myBalance.SpeedClick.ToString();
            label6.Text = myBalance.SpeedAutoString;
        }
        private void buyComponentMouse(object sender, EventArgs e)
        {
            Button selectButton = (Button)sender;
            if (dictionaryMouse.ContainsKey(selectButton.Name))
            {
                Mouse newmouse = dictionaryMouse[selectButton.Name];
                if (myBalance.BalansePlayer < newmouse.Price)
                {
                    MessageBox.Show("Недостаточно средств");
                }
                else
                {
                    newmouse.Quantity += 1;
                    newmouse.Price += Convert.ToInt32(Convert.ToDouble(newmouse.Price) * 0.60);
                    newmouse.SpeedClick += Convert.ToInt32(Convert.ToDouble(newmouse.SpeedClick) * 0.25);
                    myBalance.SpeedClick += newmouse.SpeedClick;
                    myBalance.downBalanse(newmouse.Price);
                    label2.Text = myBalance.BalansePlayer.ToString();
                }
            }
            else
            {
                MessageBox.Show("No found key");
            }
        }
        private void buyComponentVideoCard(object sender, EventArgs e)
        {
            Button selectButton = (Button)sender;
            if (dictionaryVideoCard.ContainsKey(selectButton.Name))
            {
                VideoCard newvideocard = dictionaryVideoCard[selectButton.Name];
                if (myBalance.BalansePlayer < newvideocard.Price)
                {
                    MessageBox.Show("Недостаточно средств");
                }
                else
                {
                    newvideocard.Quantity += 1;
                    newvideocard.Price += Convert.ToInt32(Convert.ToDouble(newvideocard.Price) * 0.60);
                    newvideocard.Speed += Convert.ToInt32(Convert.ToDouble(newvideocard.Speed) * 0.25);
                    myBalance.SpeedVideoCard += newvideocard.Speed;
                    myBalance.downBalanse(newvideocard.Price);
                    label2.Text = myBalance.BalansePlayer.ToString();
                }
            }
            else
            {
                MessageBox.Show("No found key");
            }
        }
        private void buyComponentProcessor(object sender, EventArgs e)
        {
            Button selectButton = (Button)sender;
            if (dictionaryProcessor.ContainsKey(selectButton.Name))
            {
                Processor newprocessor = dictionaryProcessor[selectButton.Name];
                if (myBalance.BalansePlayer < newprocessor.Price)
                {
                    MessageBox.Show("Недостаточно средств");
                }
                else
                {
                    newprocessor.Quantity += 1;
                    newprocessor.Price += Convert.ToInt32(Convert.ToDouble(newprocessor.Price) * 0.60);
                    newprocessor.Speed += Convert.ToInt32(Convert.ToDouble(newprocessor.Speed) * 0.25);
                    myBalance.SpeedProcessor += newprocessor.Speed;
                    myBalance.downBalanse(newprocessor.Price);
                    label2.Text = myBalance.BalansePlayer.ToString();
                }
            }
            else
            {
                MessageBox.Show("No found key");
            }
        }
    }
}
