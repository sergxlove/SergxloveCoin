using SergxloveCoin.resourse;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;
using System.Threading;
using System.Security.Cryptography;
using System.Collections.Generic;
using System.Diagnostics;

namespace SergxloveCoin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pathLog = "log.txt";
            if (File.Exists("userdata.db"))
            {
                isCreateDatabase = true;
            }
            else
            {
                isCreateDatabase = false;
            }
            if (!File.Exists(pathLog))
            {
                File.Create(pathLog);
            }
            writerLog = new StreamWriter(pathLog, true);
            myBalance = new();
            statisticsPlayer = new();

            commonmouse = new("������� ����");
            economymouse = new("������ ����");
            budgetmouse = new("��������� ����");
            standartmouse = new("����������� ����");
            universalmouse = new("������������� ����");
            classicalmouse = new("������������ ����");
            professionalmouse = new("���������������� ����");
            premiummouse = new("������� ����");
            elitemouse = new("������� ����");
            legendarymouse = new("����������� ����");

            commonvideocard = new("������� ����������");
            economyvideocard = new("������ ����������");
            budgetvideocard = new("��������� ����������");
            standartvideocard = new("����������� ����������");
            universalvideocard = new("������������� ����������");
            classicalvideocard = new("������������ ����������");
            professionalvideocard = new("���������������� ����������");
            premiumvideocard = new("������� ����������");
            elitevideocard = new("������� ����������");
            legendaryvideocard = new("����������� ����������");

            commonprocessor = new("������� ���������");
            economyprocessor = new("������ ���������");
            budgetprocessor = new("��������� ���������");
            standartprocessor = new("����������� ���������");
            universalprocessor = new("������������� ���������");
            classicalprocessor = new("������������ ���������");
            professionalprocessor = new("���������������� ���������");
            premiumprocessor = new("������� ���������");
            eliteprocessor = new("������� ��������");
            legendaryprocessor = new("����������� ���������");

            firstLevel = new();
            secondLevel = new();
            thirdLevel = new();
            fourLevel = new();
            fiveLevel = new();
            sixLevel = new();
            sevenLevel = new();

            firstAchive = new();
            secondAchive = new();
            thirdAchive = new();
            fourAchive = new();
            fiveAchive = new();
            sixAchive = new();
            sevenAchive = new();
            eightAchive = new();
            nineAchive = new();

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
            dictionaryLevel = new Dictionary<string, Level>()
            {
                ["getfirstlevel"] = firstLevel,
                ["getsecondlevel"] = secondLevel,
                ["getthirdlevel"] = thirdLevel,
                ["getfourlevel"] = fourLevel,
                ["getfivelevel"] = fiveLevel,
                ["getsixlevel"] = sixLevel,
                ["getsevenlevel"] = sevenLevel
            };
            dictionaryAchives = new Dictionary<string, Achives>()
            {
                ["getfirstachive"] = firstAchive,
                ["getsecondachive"] = secondAchive,
                ["getthirdachive"] = thirdAchive,
                ["getfourachive"] = fourAchive,
                ["getfiveachive"] = fiveAchive,
                ["getsixachive"] = sixAchive,
                ["getsevenachive"] = sevenAchive,
                ["geteightachive"] = eightAchive,
                ["getnineachive"] = nineAchive
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
            namesLevel = new List<string>()
            {
                "getfirstlevel", "getsecondlevel", "getthirdlevel", "getfourlevel",
                "getfivelevel", "getsixlevel", "getsevenlevel"
            };
            namesAchives = new List<string>()
            {
                "getfirstachive", "getsecondachive", "getthirdachive", "getfourachive", "getfiveachive",
                "getsixachive", "getsevenachive", "geteightachive", "getnineachive"
            };
            levelList = new List<Level>()
            {
                firstLevel, secondLevel, thirdLevel, fourLevel, fiveLevel, sixLevel, sevenLevel
            };
            dictionaryButtonLevel = new Dictionary<Level, Button>()
            {
                [firstLevel] = getfirstlevel,
                [secondLevel] = getsecondlevel,
                [thirdLevel] = getthirdlevel,
                [fourLevel] = getfourlevel,
                [fiveLevel] = getfivelevel,
                [sixLevel] = getsixlevel,
                [sevenLevel] = getsevenlevel
            };
            achivesList = new List<Achives>()
            {
                firstAchive, secondAchive, thirdAchive, fourAchive, fiveAchive, sixAchive, sevenAchive, eightAchive, nineAchive
            };
            dictionaryButtonAchives = new Dictionary<Achives, Button>()
            {
                [firstAchive] = getfirstachive,
                [secondAchive] = getsecondachive,
                [thirdAchive] = getthirdachive,
                [fourAchive] = getfourachive,
                [fiveAchive] = getfiveachive,
                [sixAchive] = getsixachive,
                [secondAchive] = getsevenachive,
                [eightAchive] = geteightachive,
                [nineAchive] = getnineachive,
            };
            sqlConnection = "Data source=userdata.db";
            baseData = new SqlQuery("Data source=userdata.db");
            updateBaseData = new SqlUpdateQuery("Data source=userdata.db");
            panels = new List<Panel> { panel4, panel5, panel6 };
            selectedPanel = 0;
            isChangedDataMouses = false;
            isChangedDataVideoCard = false;
            isChangedDataProcessor = false;
            isChangedDataLevel = false;
            isChangedDataAchive = false;
            threadUpBalanceInSecond = new Thread(AutoUpBalance);
            threadUpEnergyInSeconds = new Thread(AutoUpEnergy);
            threadCheckLevel = new Thread(CheckLevels);
            threadCheckAchive = new Thread(CheckAchives);
            isThreadingActive = true;
            showAnimation = false;
            showAnimationPanel = false;
            showAnimationNotify = true;
            tabControl1.BringToFront();
        }
        private StatsPlayer myBalance;
        private Statistics statisticsPlayer;

        private Mouse commonmouse;
        private Mouse economymouse;
        private Mouse budgetmouse;
        private Mouse standartmouse;
        private Mouse universalmouse;
        private Mouse classicalmouse;
        private Mouse professionalmouse;
        private Mouse premiummouse;
        private Mouse elitemouse;
        private Mouse legendarymouse;

        private VideoCard commonvideocard;
        private VideoCard economyvideocard;
        private VideoCard budgetvideocard;
        private VideoCard standartvideocard;
        private VideoCard universalvideocard;
        private VideoCard classicalvideocard;
        private VideoCard professionalvideocard;
        private VideoCard premiumvideocard;
        private VideoCard elitevideocard;
        private VideoCard legendaryvideocard;

        private Processor commonprocessor;
        private Processor economyprocessor;
        private Processor budgetprocessor;
        private Processor standartprocessor;
        private Processor universalprocessor;
        private Processor classicalprocessor;
        private Processor professionalprocessor;
        private Processor premiumprocessor;
        private Processor eliteprocessor;
        private Processor legendaryprocessor;

        private Level firstLevel;
        private Level secondLevel;
        private Level thirdLevel;
        private Level fourLevel;
        private Level fiveLevel;
        private Level sixLevel;
        private Level sevenLevel;
        private List<Level> levelList;

        private Achives firstAchive;
        private Achives secondAchive;
        private Achives thirdAchive;
        private Achives fourAchive;
        private Achives fiveAchive;
        private Achives sixAchive;
        private Achives sevenAchive;
        private Achives eightAchive;
        private Achives nineAchive;
        private List<Achives> achivesList;

        private Dictionary<string, Mouse> dictionaryMouse;
        private Dictionary<string, VideoCard> dictionaryVideoCard;
        private Dictionary<string, Processor> dictionaryProcessor;
        private Dictionary<string, Level> dictionaryLevel;
        private Dictionary<Level, Button> dictionaryButtonLevel;
        private Dictionary<string, Achives> dictionaryAchives;
        private Dictionary<Achives, Button> dictionaryButtonAchives;
        private List<string> namesMouse;
        private List<string> namesVideoCard;
        private List<string> namesProcessor;
        private List<string> namesLevel;
        private List<string> namesAchives;

        private bool isChangedDataMouses;
        private bool isChangedDataVideoCard;
        private bool isChangedDataProcessor;
        private bool isChangedDataLevel;
        private bool isChangedDataAchive;

        private string sqlConnection;
        private bool isCreateDatabase;
        private SqlQuery baseData;
        private SqlUpdateQuery updateBaseData;

        private int frameCount = 0;
        private int sizeX = 0;
        private int sizeY = 0;
        private int frameCountNotify = 0;
        private int sizeNotifyX = 0;
        private int sizeNotifyY = 0;
        private int coordPointY = 0;
        private bool showAnimation;
        private List<Panel> panels;
        private int selectedPanel;

        private bool showAnimationPanel;
        private bool showAnimationNotify;

        private Thread threadUpBalanceInSecond;
        private Thread threadUpEnergyInSeconds;
        private Thread threadCheckLevel;
        private Thread threadCheckAchive;
        private bool isThreadingActive;

        private string pathLog;
        StreamWriter writerLog;

        private async void Form1_Load(object sender, EventArgs e)
        {
            if (isCreateDatabase)
            {
                await baseData.ReadTableMouses(dictionaryMouse, namesMouse);
                await baseData.ReadTableVideoCard(dictionaryVideoCard, namesVideoCard);
                await baseData.ReadTableProcessor(dictionaryProcessor, namesProcessor);
                await baseData.ReadTableStatistics(statisticsPlayer);
                firstLevel.ChangeData(1, 1000, 250, false);
                secondLevel.ChangeData(2, 10000, 2500, false);
                thirdLevel.ChangeData(3, 50000, 9000, false);
                fourLevel.ChangeData(4, 400000, 75000, false);
                fiveLevel.ChangeData(5, 2000000, 350000, false);
                sixLevel.ChangeData(6, 10000000, 1300000, false);
                sevenLevel.ChangeData(7, 50000000, 8000000, false);
                await baseData.ReadTableLevel(dictionaryLevel, namesLevel);
                firstAchive.ChangeData(10000000, 1000000, false, VariationAchive.Money);
                secondAchive.ChangeData(100000000, 10000000, false, VariationAchive.Money);
                thirdAchive.ChangeData(1000000000, 100000000, false, VariationAchive.Money);
                fourAchive.ChangeData(1000, 100000, false, VariationAchive.SpeedClick);
                fiveAchive.ChangeData(10000, 1000000, false, VariationAchive.SpeedClick);
                sixAchive.ChangeData(100000, 10000000, false, VariationAchive.SpeedClick);
                sevenAchive.ChangeData(10000, 1000000, false, VariationAchive.SpeedAuto);
                eightAchive.ChangeData(100000, 10000000, false, VariationAchive.SpeedAuto);
                nineAchive.ChangeData(1000000, 100000000, false, VariationAchive.SpeedAuto);
                await baseData.ReadTableAchive(dictionaryAchives, namesAchives);
                await baseData.ReadTableStatsPlayer(myBalance);
                TimeSpan diffTime = DateTime.Now - myBalance.LastVisitDate;
                int needTimesForFullEnergy = (myBalance.MaxEnergy - myBalance.CurrentEnergy) * 3;
                int actualTimesForFullEnergy = Convert.ToInt32(diffTime.TotalHours * 3600.0);
                if (actualTimesForFullEnergy >= needTimesForFullEnergy)
                {
                    label235.Text = (myBalance.MaxEnergy - myBalance.CurrentEnergy).ToString();
                    myBalance.CurrentEnergy = myBalance.MaxEnergy;
                }
                else
                {
                    label235.Text = (actualTimesForFullEnergy / 3).ToString();
                    myBalance.CurrentEnergy += actualTimesForFullEnergy / 3;
                }
                if (actualTimesForFullEnergy > (3600 * 8))
                {
                    myBalance.BalansePlayer += (3600 * 8) * myBalance.SpeedProcessor;
                }
                else
                {
                    myBalance.BalansePlayer += actualTimesForFullEnergy * myBalance.SpeedProcessor;
                }
                label234.Text = (actualTimesForFullEnergy / 3 * myBalance.SpeedProcessor).ToString();
                await writerLog.WriteLineAsync($"database data read {DateTime.UtcNow}");
            }
            else
            {
                commonmouse.ChangeData(500, 3, 0);
                economymouse.ChangeData(2000, 9, 0);
                budgetmouse.ChangeData(10000, 20, 0);
                standartmouse.ChangeData(50000, 45, 0);
                universalmouse.ChangeData(250000, 110, 0);
                classicalmouse.ChangeData(1000000, 250, 0);
                professionalmouse.ChangeData(4000000, 650, 0);
                premiummouse.ChangeData(20000000, 1000, 0);
                elitemouse.ChangeData(100000000, 2100, 0);
                legendarymouse.ChangeData(250000000, 4000, 0);

                commonvideocard.ChangeData(150, 5, 0);
                economyvideocard.ChangeData(500, 10, 0);
                budgetvideocard.ChangeData(3000, 20, 0);
                standartvideocard.ChangeData(10000, 35, 0);
                universalvideocard.ChangeData(50000, 60, 0);
                classicalvideocard.ChangeData(300000, 100, 0);
                professionalvideocard.ChangeData(1000000, 250, 0);
                premiumvideocard.ChangeData(2500000, 400, 0);
                elitevideocard.ChangeData(10000000, 700, 0);
                legendaryvideocard.ChangeData(45000000, 1000, 0);

                commonprocessor.ChangeData(300, 2, 0);
                economyprocessor.ChangeData(1500, 3, 0);
                budgetprocessor.ChangeData(6000, 5, 0);
                standartprocessor.ChangeData(25000, 8, 0);
                universalprocessor.ChangeData(100000, 13, 0);
                classicalprocessor.ChangeData(500000, 25, 0);
                professionalprocessor.ChangeData(2000000, 40, 0);
                premiumprocessor.ChangeData(10000000, 65, 0);
                eliteprocessor.ChangeData(30000000, 100, 0);
                legendaryprocessor.ChangeData(50000000, 130, 0);

                firstLevel.ChangeData(1, 1000, 250, false);
                secondLevel.ChangeData(2, 10000, 2500, false);
                thirdLevel.ChangeData(3, 50000, 9000, false);
                fourLevel.ChangeData(4, 400000, 75000, false);
                fiveLevel.ChangeData(5, 2000000, 350000, false);
                sixLevel.ChangeData(6, 10000000, 1300000, false);
                sevenLevel.ChangeData(7, 50000000, 8000000, false);

                firstAchive.ChangeData(10000000, 1000000, false, VariationAchive.Money);
                secondAchive.ChangeData(100000000, 10000000, false, VariationAchive.Money);
                thirdAchive.ChangeData(1000000000, 100000000, false, VariationAchive.Money);
                fourAchive.ChangeData(1000, 100000, false, VariationAchive.SpeedClick);
                fiveAchive.ChangeData(10000, 1000000, false, VariationAchive.SpeedClick);
                sixAchive.ChangeData(100000, 10000000, false, VariationAchive.SpeedClick);
                sevenAchive.ChangeData(10000, 1000000, false, VariationAchive.SpeedAuto);
                eightAchive.ChangeData(100000, 10000000, false, VariationAchive.SpeedAuto);
                nineAchive.ChangeData(1000000, 100000000, false, VariationAchive.SpeedAuto);

                myBalance.changeData(1, 0, 0, 0, 1000, 1000, DateTime.Now);
                statisticsPlayer.ChangeData(1, 0, 0, 0, 0, 0, 0, 0, DateTime.Now);
                await baseData.CreateTable($@"CREATE TABLE StatsPlayer( idPlayer INT PRIMARY KEY NOT NULL, balancePlayer BIGINT NOT NULL, speedClick INT NOT NULL, 
                    speedVideoCard INT NOT NULL, speedProcessor INT NOT NULL, currentEnergy INT NOT NULL, maxEnergy INT NOT NULL, lastVisitDate DATETIME NOT NULL);");
                await baseData.CreateTable("CREATE TABLE Mouses(idMouse INT PRIMARY KEY NOT NULL,price INT NOT NULL,speed INT NOT NULL,quantity INT NOT NULL);");
                await baseData.CreateTable("CREATE TABLE Videocards(idVideocard INT PRIMARY KEY NOT NULL, price INT NOT NULL, speed INT NOT NULL, quantity INT NOT NULL);");
                await baseData.CreateTable("CREATE TABLE Processors(idProcessor INT PRIMARY KEY NOT NULL, price INT NOT NULL, speed INT NOT NULL, quantity INT NOT NULL);");
                await baseData.CreateTable("CREATE TABLE Levels(idLevel INT PRIMARY KEY NOT NULL, isDone INT NOT NULL);");
                await baseData.CreateTable("CREATE TABLE Achives(idAchives INT PRIMARY KEY NOT NULL, isDone INT NOT NULL);");
                await baseData.CreateTable($@"CREATE TABLE Statistics(idStats INT PRIMARY KEY NOT NULL, quantityClick INT NOT NULL, totalSumClickMoney INT NOT NULL,
                    totalSumAutoMoney INT NOT NULL, level INT NOT NULL, quantityAchives INT NOT NULL, quantityMouse INT NOT NULL, quantityVideocard INT NOT NULL,
                    quantityProcessor INT NOT NULL, dateBegin DATETIME NOT NULL);");
                await baseData.FieldTableStatsPlayerDef();
                await baseData.FieldTableStatisticsDef();
                await baseData.FieldTableMousesDef(dictionaryMouse, namesMouse);
                await baseData.FieldTableVideoCardDef(dictionaryVideoCard, namesVideoCard);
                await baseData.FieldTableProcessorDef(dictionaryProcessor, namesProcessor);
                await baseData.FieldTableLevelDef(dictionaryLevel, namesLevel);
                await baseData.FieldTableAchiveDef(dictionaryAchives, namesAchives);
                await writerLog.WriteLineAsync($"database create {DateTime.UtcNow}");
                
            }
            label2.Text = myBalance.BalansePlayer.ToString();
            label5.Text = myBalance.SpeedClick.ToString();
            label6.Text = myBalance.SpeedAutoString;
            label226.Text = myBalance.CurrentEnergy.ToString();
            label225.Text = myBalance.MaxEnergy.ToString();
            label2.DataBindings.Add(new Binding(nameof(Text), myBalance, nameof(myBalance.BalansePlayer), true, DataSourceUpdateMode.OnPropertyChanged));
            label226.DataBindings.Add(new Binding(nameof(Text), myBalance, nameof(myBalance.CurrentEnergy), true, DataSourceUpdateMode.OnPropertyChanged));
            label225.DataBindings.Add(new Binding(nameof(Text), myBalance, nameof(myBalance.MaxEnergy), true, DataSourceUpdateMode.OnPropertyChanged));
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

            //237, 240, 241
            label237.DataBindings.Add(new Binding(nameof(Text), firstLevel, nameof(firstLevel.NumberLevel), true, DataSourceUpdateMode.OnPropertyChanged));
            label240.DataBindings.Add(new Binding(nameof(Text), firstLevel, nameof(firstLevel.NeedCoin), true, DataSourceUpdateMode.OnPropertyChanged));
            label241.DataBindings.Add(new Binding(nameof(Text), firstLevel, nameof(firstLevel.Prize), true, DataSourceUpdateMode.OnPropertyChanged));
            //246, 243, 242
            label246.DataBindings.Add(new Binding(nameof(Text), secondLevel, nameof(firstLevel.NumberLevel), true, DataSourceUpdateMode.OnPropertyChanged));
            label243.DataBindings.Add(new Binding(nameof(Text), secondLevel, nameof(firstLevel.NeedCoin), true, DataSourceUpdateMode.OnPropertyChanged));
            label242.DataBindings.Add(new Binding(nameof(Text), secondLevel, nameof(firstLevel.Prize), true, DataSourceUpdateMode.OnPropertyChanged));
            //252, 249, 248
            label252.DataBindings.Add(new Binding(nameof(Text), thirdLevel, nameof(firstLevel.NumberLevel), true, DataSourceUpdateMode.OnPropertyChanged));
            label249.DataBindings.Add(new Binding(nameof(Text), thirdLevel, nameof(firstLevel.NeedCoin), true, DataSourceUpdateMode.OnPropertyChanged));
            label248.DataBindings.Add(new Binding(nameof(Text), thirdLevel, nameof(firstLevel.Prize), true, DataSourceUpdateMode.OnPropertyChanged));
            //258, 255, 254
            label258.DataBindings.Add(new Binding(nameof(Text), fourLevel, nameof(firstLevel.NumberLevel), true, DataSourceUpdateMode.OnPropertyChanged));
            label255.DataBindings.Add(new Binding(nameof(Text), fourLevel, nameof(firstLevel.NeedCoin), true, DataSourceUpdateMode.OnPropertyChanged));
            label254.DataBindings.Add(new Binding(nameof(Text), fourLevel, nameof(firstLevel.Prize), true, DataSourceUpdateMode.OnPropertyChanged));
            //264, 261, 260
            label264.DataBindings.Add(new Binding(nameof(Text), fiveLevel, nameof(firstLevel.NumberLevel), true, DataSourceUpdateMode.OnPropertyChanged));
            label261.DataBindings.Add(new Binding(nameof(Text), fiveLevel, nameof(firstLevel.NeedCoin), true, DataSourceUpdateMode.OnPropertyChanged));
            label260.DataBindings.Add(new Binding(nameof(Text), fiveLevel, nameof(firstLevel.Prize), true, DataSourceUpdateMode.OnPropertyChanged));
            //270, 267, 266
            label270.DataBindings.Add(new Binding(nameof(Text), sixLevel, nameof(firstLevel.NumberLevel), true, DataSourceUpdateMode.OnPropertyChanged));
            label267.DataBindings.Add(new Binding(nameof(Text), sixLevel, nameof(firstLevel.NeedCoin), true, DataSourceUpdateMode.OnPropertyChanged));
            label266.DataBindings.Add(new Binding(nameof(Text), sixLevel, nameof(firstLevel.Prize), true, DataSourceUpdateMode.OnPropertyChanged));
            //276, 273, 272
            label276.DataBindings.Add(new Binding(nameof(Text), sevenLevel, nameof(firstLevel.NumberLevel), true, DataSourceUpdateMode.OnPropertyChanged));
            label273.DataBindings.Add(new Binding(nameof(Text), sevenLevel, nameof(firstLevel.NeedCoin), true, DataSourceUpdateMode.OnPropertyChanged));
            label272.DataBindings.Add(new Binding(nameof(Text), sevenLevel, nameof(firstLevel.Prize), true, DataSourceUpdateMode.OnPropertyChanged));

            label279.DataBindings.Add(new Binding(nameof(Text), myBalance, nameof(myBalance.BalansePlayer), true, DataSourceUpdateMode.OnPropertyChanged));
            label282.DataBindings.Add(new Binding(nameof(Text), myBalance, nameof(myBalance.SpeedClick), true, DataSourceUpdateMode.OnPropertyChanged));
            label283.DataBindings.Add(new Binding(nameof(Text), myBalance, nameof(myBalance.SpeedAutoString), true, DataSourceUpdateMode.OnPropertyChanged));
            label294.DataBindings.Add(new Binding(nameof(Text), statisticsPlayer, nameof(statisticsPlayer.QuantityClick), true, DataSourceUpdateMode.OnPropertyChanged));
            label295.DataBindings.Add(new Binding(nameof(Text), statisticsPlayer, nameof(statisticsPlayer.TotalSumClickMoney), true, DataSourceUpdateMode.OnPropertyChanged));
            label296.DataBindings.Add(new Binding(nameof(Text), statisticsPlayer, nameof(statisticsPlayer.TotalSumAutoMoney), true, DataSourceUpdateMode.OnPropertyChanged));
            label297.DataBindings.Add(new Binding(nameof(Text), statisticsPlayer, nameof(statisticsPlayer.Level), true, DataSourceUpdateMode.OnPropertyChanged));
            label298.DataBindings.Add(new Binding(nameof(Text), statisticsPlayer, nameof(statisticsPlayer.QuantityAchives), true, DataSourceUpdateMode.OnPropertyChanged));
            label299.DataBindings.Add(new Binding(nameof(Text), statisticsPlayer, nameof(statisticsPlayer.QuantityMouse), true, DataSourceUpdateMode.OnPropertyChanged));
            label300.DataBindings.Add(new Binding(nameof(Text), statisticsPlayer, nameof(statisticsPlayer.QuantityVideocard), true, DataSourceUpdateMode.OnPropertyChanged));
            label301.DataBindings.Add(new Binding(nameof(Text), statisticsPlayer, nameof(statisticsPlayer.QuantityProcessor), true, DataSourceUpdateMode.OnPropertyChanged));
            label302.DataBindings.Add(new Binding(nameof(Text), statisticsPlayer, nameof(statisticsPlayer.QuantityDays), true, DataSourceUpdateMode.OnPropertyChanged));

            //304, 303
            label304.DataBindings.Add(new Binding(nameof(Text), firstAchive, nameof(firstAchive.NeedClaim), true, DataSourceUpdateMode.OnPropertyChanged));
            label303.DataBindings.Add(new Binding(nameof(Text), firstAchive, nameof(firstAchive.Prize), true, DataSourceUpdateMode.OnPropertyChanged));
            //309, 307
            label309.DataBindings.Add(new Binding(nameof(Text), secondAchive, nameof(secondAchive.NeedClaim), true, DataSourceUpdateMode.OnPropertyChanged));
            label307.DataBindings.Add(new Binding(nameof(Text), secondAchive, nameof(secondAchive.Prize), true, DataSourceUpdateMode.OnPropertyChanged));
            //314, 313
            label314.DataBindings.Add(new Binding(nameof(Text), thirdAchive, nameof(thirdAchive.NeedClaim), true, DataSourceUpdateMode.OnPropertyChanged));
            label313.DataBindings.Add(new Binding(nameof(Text), thirdAchive, nameof(thirdAchive.Prize), true, DataSourceUpdateMode.OnPropertyChanged));
            //319, 318
            label319.DataBindings.Add(new Binding(nameof(Text), fourAchive, nameof(fourAchive.NeedClaim), true, DataSourceUpdateMode.OnPropertyChanged));
            label318.DataBindings.Add(new Binding(nameof(Text), fourAchive, nameof(fourAchive.Prize), true, DataSourceUpdateMode.OnPropertyChanged));
            //324, 323
            label324.DataBindings.Add(new Binding(nameof(Text), fiveAchive, nameof(fiveAchive.NeedClaim), true, DataSourceUpdateMode.OnPropertyChanged));
            label323.DataBindings.Add(new Binding(nameof(Text), fiveAchive, nameof(fiveAchive.Prize), true, DataSourceUpdateMode.OnPropertyChanged));
            //329 ,328
            label329.DataBindings.Add(new Binding(nameof(Text), sixAchive, nameof(sixAchive.NeedClaim), true, DataSourceUpdateMode.OnPropertyChanged));
            label328.DataBindings.Add(new Binding(nameof(Text), sixAchive, nameof(sixAchive.Prize), true, DataSourceUpdateMode.OnPropertyChanged));
            //334, 333
            label334.DataBindings.Add(new Binding(nameof(Text), sevenAchive, nameof(sevenAchive.NeedClaim), true, DataSourceUpdateMode.OnPropertyChanged));
            label333.DataBindings.Add(new Binding(nameof(Text), sevenAchive, nameof(sevenAchive.Prize), true, DataSourceUpdateMode.OnPropertyChanged));
            //339, 338
            label339.DataBindings.Add(new Binding(nameof(Text), eightAchive, nameof(eightAchive.NeedClaim), true, DataSourceUpdateMode.OnPropertyChanged));
            label338.DataBindings.Add(new Binding(nameof(Text), eightAchive, nameof(eightAchive.Prize), true, DataSourceUpdateMode.OnPropertyChanged));
            //344, 343
            label344.DataBindings.Add(new Binding(nameof(Text), nineAchive, nameof(nineAchive.NeedClaim), true, DataSourceUpdateMode.OnPropertyChanged));
            label343.DataBindings.Add(new Binding(nameof(Text), nineAchive, nameof(nineAchive.Prize), true, DataSourceUpdateMode.OnPropertyChanged));

            RegLevels();
            RegAchives();

            threadUpBalanceInSecond.Start();
            threadUpEnergyInSeconds.Start();
            threadCheckLevel.Start();
            threadCheckAchive.Start();

            showAnimationNotify = true;
            sizeNotifyX = 0;
            sizeNotifyY = 0;
            frameCountNotify = 0;
            timer3.Interval = 10;
            timer3.Start();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            myBalance.LastVisitDate = DateTime.Now;
            isThreadingActive = false;
            if(isChangedDataMouses)
            {
                await updateBaseData.UpdateTableMouse(dictionaryMouse, namesMouse);
            }
            if(isChangedDataVideoCard)
            {
                await updateBaseData.UpdateTableVideoCard(dictionaryVideoCard, namesVideoCard);
            }
            if(isChangedDataProcessor)
            {
                await updateBaseData.UpdateTableProcessor(dictionaryProcessor, namesProcessor);
            }
            if(isChangedDataLevel)
            {
                await updateBaseData.UpdateTableLevel(dictionaryLevel, namesLevel);
            }
            if (isChangedDataAchive)
            {
                await updateBaseData.UpdateTableAchive(dictionaryAchives, namesAchives);
            }
            await updateBaseData.UpdateTableStatsPlayer(myBalance);
            await updateBaseData.UpdateTableStatistics(statisticsPlayer);
            await writerLog.WriteLineAsync($"exit the program {DateTime.UtcNow}");
            writerLog.Dispose();
            Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (showAnimationNotify) button7_Click(sender, e);
            if (myBalance.CurrentEnergy >= 3)
            {
                myBalance.upBalanse(myBalance.SpeedClick);
                myBalance.CurrentEnergy -= 3;
                statisticsPlayer.QuantityClick++;
                statisticsPlayer.TotalSumClickMoney += myBalance.SpeedClick;
            }
        }

        private void openPanel(object sender, EventArgs e)
        {
            if (showAnimationNotify) button7_Click(sender, e);
            PictureBox selectPictureBox = (PictureBox)sender;
            selectedPanel = selectPictureBox.Name[1] - 48;
            frameCount = 0;
            coordPointY = 805;
            sizeY = 0;
            showAnimationPanel = true;
            timer2.Interval = 7;
            timer2.Start();
        }

        private async void pictureBox3_Click(object sender, EventArgs e)
        {
            if (showAnimationNotify) button7_Click(sender, e);
            timer1.Interval = 7;
            frameCount = 0;
            coordPointY = 805;
            sizeY = 0;
            showAnimation = true;
            await writerLog.WriteLineAsync($"open panel shop {DateTime.UtcNow}");
            timer1.Start();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            openPanel(s2_pictureBox4, e);
        }

        private void label8_Click(object sender, EventArgs e)
        {
            openPanel(s0_pictureBox5, e);
        }

        private void label9_Click(object sender, EventArgs e)
        {
            openPanel(s1_pictureBox6, e);
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

        private void button23_Click(object sender, EventArgs e)
        {
            button3_Click(sender, e);
        }

        private void button34_Click(object sender, EventArgs e)
        {
            button3_Click(sender, e);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label5.Text = myBalance.SpeedClick.ToString();
            label6.Text = myBalance.SpeedAutoString;
            timer2.Interval = 7;
            selectedPanel = 0;
            frameCount = 0;
            coordPointY = 155;
            sizeY = 650;
            showAnimationPanel = false;
            timer2.Start();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label5.Text = myBalance.SpeedClick.ToString();
            label6.Text = myBalance.SpeedAutoString;
            timer2.Interval = 7;
            selectedPanel = 1;
            frameCount = 0;
            coordPointY = 155;
            sizeY = 650;
            showAnimationPanel = false;
            timer2.Start();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label5.Text = myBalance.SpeedClick.ToString();
            label6.Text = myBalance.SpeedAutoString;
            timer2.Interval = 7;
            selectedPanel = 2;
            frameCount = 0;
            coordPointY = 155;
            sizeY = 650;
            showAnimationPanel = false;
            timer2.Start();
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

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (showAnimationPanel)
            {
                if (frameCount <= 5)
                {
                    panels[selectedPanel].Location = new Point(12, coordPointY);
                    panels[selectedPanel].Size = new Size(620, sizeY);
                    coordPointY -= 130;
                    sizeY += 130;
                    frameCount++;
                }
                else
                {
                    timer2.Stop();
                }
            }
            else
            {
                if (frameCount <= 5)
                {
                    panels[selectedPanel].Location = new Point(12, coordPointY);
                    panels[selectedPanel].Size = new Size(620, sizeY);
                    coordPointY += 130;
                    sizeY -= 130;
                    frameCount++;
                }
                else
                {
                    timer2.Stop();
                }
            }
        }

        private async void buyComponentMouse(object sender, EventArgs e)
        {
            Button selectButton = (Button)sender;
            if (dictionaryMouse.ContainsKey(selectButton.Name))
            {
                Mouse newmouse = dictionaryMouse[selectButton.Name];
                if (myBalance.BalansePlayer < newmouse.Price)
                {
                    MessageBox.Show("������������ �������");
                }
                else
                {
                    isChangedDataMouses = true;
                    newmouse.Quantity += 1;
                    newmouse.Price += Convert.ToInt32(Convert.ToDouble(newmouse.Price) * 0.60);
                    newmouse.SpeedClick += Convert.ToInt32(Convert.ToDouble(newmouse.SpeedClick) * 0.25);
                    myBalance.SpeedClick += newmouse.SpeedClick;
                    myBalance.downBalanse(newmouse.Price);
                    label2.Text = myBalance.BalansePlayer.ToString();
                    statisticsPlayer.QuantityMouse++;
                    await writerLog.WriteLineAsync($"buy component mouse {DateTime.UtcNow}");
                }
            }
            else
            {
                MessageBox.Show("No found key");
            }
        }
        private async void buyComponentVideoCard(object sender, EventArgs e)
        {
            Button selectButton = (Button)sender;
            if (dictionaryVideoCard.ContainsKey(selectButton.Name))
            {
                VideoCard newvideocard = dictionaryVideoCard[selectButton.Name];
                if (myBalance.BalansePlayer < newvideocard.Price)
                {
                    MessageBox.Show("������������ �������");
                }
                else
                {
                    isChangedDataVideoCard = true;
                    newvideocard.Quantity += 1;
                    newvideocard.Price += Convert.ToInt32(Convert.ToDouble(newvideocard.Price) * 0.60);
                    newvideocard.Speed += Convert.ToInt32(Convert.ToDouble(newvideocard.Speed) * 0.25);
                    myBalance.SpeedVideoCard += newvideocard.Speed;
                    myBalance.downBalanse(newvideocard.Price);
                    label2.Text = myBalance.BalansePlayer.ToString();
                    statisticsPlayer.QuantityVideocard++;
                    await writerLog.WriteLineAsync($"buy component videocard {DateTime.UtcNow}");
                }
            }
            else
            {
                MessageBox.Show("No found key");
            }
        }
        private async void buyComponentProcessor(object sender, EventArgs e)
        {
            Button selectButton = (Button)sender;
            if (dictionaryProcessor.ContainsKey(selectButton.Name))
            {
                Processor newprocessor = dictionaryProcessor[selectButton.Name];
                if (myBalance.BalansePlayer < newprocessor.Price)
                {
                    MessageBox.Show("������������ �������");
                }
                else
                {
                    isChangedDataProcessor = true;
                    newprocessor.Quantity += 1;
                    newprocessor.Price += Convert.ToInt32(Convert.ToDouble(newprocessor.Price) * 0.60);
                    newprocessor.Speed += Convert.ToInt32(Convert.ToDouble(newprocessor.Speed) * 0.25);
                    myBalance.SpeedProcessor += newprocessor.Speed;
                    myBalance.downBalanse(newprocessor.Price);
                    label2.Text = myBalance.BalansePlayer.ToString();
                    statisticsPlayer.QuantityProcessor++;
                    await writerLog.WriteLineAsync($"buy component processor {DateTime.UtcNow}");
                }
            }
            else
            {
                MessageBox.Show("No found key");
            }
        }
        private void AutoUpBalance()
        {
            while (isThreadingActive)
            {
                myBalance.upBalanse(myBalance.SpeedVideoCard + myBalance.SpeedProcessor);
                statisticsPlayer.TotalSumAutoMoney += myBalance.SpeedProcessor + myBalance.SpeedVideoCard;
                Thread.Sleep(1000);
            }
        }
        private void AutoUpEnergy()
        {
            while (isThreadingActive)
            {
                if (myBalance.CurrentEnergy < myBalance.MaxEnergy)
                {
                    myBalance.CurrentEnergy += 1;
                }
                Thread.Sleep(3000);
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (showAnimationNotify)
            {
                if (frameCountNotify == 0) Thread.Sleep(200);
                if (frameCountNotify < 5)
                {
                    sizeNotifyX += 113;
                    if (frameCountNotify <= 2)
                    {
                        sizeNotifyY += 43;
                    }
                    panel7.Size = new Size(sizeNotifyX, sizeNotifyY);
                    frameCountNotify++;
                }
                else
                {
                    timer3.Stop();
                }
            }
            else
            {
                if (frameCountNotify < 5)
                {
                    sizeNotifyX -= 113;
                    if (frameCountNotify > 1)
                    {
                        sizeNotifyY -= 43;
                    }
                    panel7.Size = new Size(sizeNotifyX, sizeNotifyY);
                    frameCountNotify++;
                }
                else
                {
                    timer3.Stop();
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            showAnimationNotify = false;
            sizeNotifyX = 565;
            sizeNotifyY = 129;
            frameCountNotify = 0;
            timer3.Interval = 10;
            timer3.Start();
        }

        private async void getLevel(object sender, EventArgs e)
        {
            Button selectButton = (Button)sender;
            if (dictionaryLevel.ContainsKey(selectButton.Name))
            {
                Level newlevel = dictionaryLevel[selectButton.Name];
                if (selectButton.Text == "��������")
                {
                    newlevel.IsDone = true;
                    statisticsPlayer.Level++;
                    myBalance.upBalanse(newlevel.Prize);
                    selectButton.Text = "��������";
                    isChangedDataLevel = true;
                    await writerLog.WriteLineAsync($"getting level {DateTime.UtcNow}");
                }
            }
        }
        private void ChangeButton(object sender)
        {
            Button selectButton = (Button)sender;
            selectButton.Text = "��������";
            selectButton.BackColor = Color.FromArgb(0, 192, 0);
        }
        private void StartChangeButton(object sender)
        {
            Button selectButton = (Button)sender;
            selectButton.Text = "��������";
            selectButton.BackColor = Color.FromArgb(0, 192, 0);
        }
        private void CheckLevels()
        {
            while (isThreadingActive)
            {
                Thread.Sleep(10000);
                for (int i = 0; i < levelList.Count; i++)
                {
                    if (levelList[i].IsDone == false)
                    {
                        if (levelList[i].NeedCoin < myBalance.BalansePlayer)
                        {
                            ChangeButton(dictionaryButtonLevel[levelList[i]]);
                        }
                    }
                }
            }
        }
        private void RegLevels()
        {
            for (int i = 0; i < levelList.Count; i++)
            {
                if (levelList[i].IsDone)
                {
                    StartChangeButton(dictionaryButtonLevel[levelList[i]]);
                }
            }
        }
        private async void getAchive(object sender, EventArgs e)
        {
            Button selectButton = (Button)sender;
            if (dictionaryAchives.ContainsKey(selectButton.Name))
            {
                Achives newAchives = dictionaryAchives[selectButton.Name];
                if (selectButton.Text == "��������")
                {
                    newAchives.IsDone = true;
                    statisticsPlayer.QuantityAchives++;
                    myBalance.upBalanse(newAchives.Prize);
                    selectButton.Text = "��������";
                    isChangedDataAchive = true;
                    await writerLog.WriteLineAsync($"getting achive {DateTime.UtcNow}");
                }
            }
        }
        private void CheckAchives()
        {
            while (isThreadingActive)
            {
                Thread.Sleep(10000);
                for (int i = 0; i < achivesList.Count; i++)
                {
                    if (achivesList[i].IsDone == false)
                    {
                        switch (achivesList[i].TypeAchives)
                        {
                            case VariationAchive.SpeedClick:
                                if (achivesList[i].NeedClaim < myBalance.SpeedClick)
                                {
                                    ChangeButton(dictionaryButtonAchives[achivesList[i]]);
                                }
                                break;
                            case VariationAchive.SpeedAuto:
                                if (achivesList[i].NeedClaim < (myBalance.SpeedVideoCard + myBalance.SpeedProcessor))
                                {
                                    ChangeButton(dictionaryButtonAchives[achivesList[i]]);
                                }
                                break;
                            case VariationAchive.Money:
                                if (achivesList[i].NeedClaim < myBalance.BalansePlayer)
                                {
                                    ChangeButton(dictionaryButtonAchives[achivesList[i]]);
                                }
                                break;
                            default:
                                break;
                        }
                    }
                }
            }
        }
        private void RegAchives()
        {
            for (int i = 0; i < achivesList.Count; i++)
            {
                if (achivesList[i].IsDone)
                {
                    StartChangeButton(dictionaryButtonAchives[achivesList[i]]);
                }
            }
        }
    }
}
