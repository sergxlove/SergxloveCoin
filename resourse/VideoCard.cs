using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SergxloveCoin.resourse
{
    internal abstract class VideoCard
    {
        public abstract string Name { get; set; }
        public abstract int Price { get; set; }
        public abstract int Speed { get; set; }
        public abstract int Quantity { get; set; }
        protected string? _name;
        protected int _price;
        protected int _speed;
        protected int _quantity;
    }
    internal sealed class CommonVideoCard : VideoCard , INotifyPropertyChanged
    {
        public CommonVideoCard() 
        {
            _name = "Обычная видеокарта";
            _price = 150 ;
            _speed = 5;
            _quantity = 0;
        }
        public CommonVideoCard(string name, int price, int speed, int quantity)
        {
            _name = name;
            _price = price;
            _speed = speed;
            _quantity = quantity;
        }
        public override string Name
        {
            get
            {
                if (_name == null)
                {
                    return "no";
                }
                else
                {
                    return _name;
                }
            }
            set
            {
                _name = value;
            }
        }
        public override int Price
        {
            get => _price;
            set
            {
                _price = value;
                OnPropertyChanged();
            }
        }
        public override int Speed
        {
            get => _speed;
            set
            {
                _speed = value;
                OnPropertyChanged();
            }
        }
        public override int Quantity
        {
            get => _quantity;
            set
            {
                _quantity = value;
                OnPropertyChanged();
            }
        }
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
        public event PropertyChangedEventHandler? PropertyChanged;
    }
    internal sealed class EconomyVideoCard : VideoCard, INotifyPropertyChanged 
    {
        public EconomyVideoCard()
        {
            _name = "Эконом видеокарта";
            _price = 500;
            _speed = 10;
            _quantity = 0;
        }
        public EconomyVideoCard(string name, int price, int speed, int quantity)
        {
            _name = name;
            _price = price;
            _speed = speed;
            _quantity = quantity;
        }
        public override string Name
        {
            get
            {
                if (_name == null)
                {
                    return "no";
                }
                else
                {
                    return _name;
                }
            }
            set
            {
                _name = value;
            }
        }
        public override int Price
        {
            get => _price;
            set
            {
                _price = value;
                OnPropertyChanged();
            }
        }
        public override int Speed
        {
            get => _speed;
            set
            {
                _speed = value;
                OnPropertyChanged();
            }
        }
        public override int Quantity
        {
            get => _quantity;
            set
            {
                _quantity = value;
                OnPropertyChanged();
            }
        }
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
        public event PropertyChangedEventHandler? PropertyChanged;
    }
    internal sealed class BudgetVideoCard : VideoCard , INotifyPropertyChanged
    {
        public BudgetVideoCard()
        {
            _name = "Бюджетная видеокарта";
            _price = 3000;
            _speed = 20;
            _quantity = 0;
        }
        public BudgetVideoCard(string name, int price, int speed, int quantity)
        {
            _name = name;
            _price = price;
            _speed = speed;
            _quantity = quantity;
        }
        public override string Name
        {
            get
            {
                if (_name == null)
                {
                    return "no";
                }
                else
                {
                    return _name;
                }
            }
            set
            {
                _name = value;
            }
        }
        public override int Price
        {
            get => _price;
            set
            {
                _price = value;
                OnPropertyChanged();
            }
        }
        public override int Speed
        {
            get => _speed;
            set
            {
                _speed = value;
                OnPropertyChanged();
            }
        }
        public override int Quantity
        {
            get => _quantity;
            set
            {
                _quantity = value;
                OnPropertyChanged();
            }
        }
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
        public event PropertyChangedEventHandler? PropertyChanged;
    }
    internal sealed class StandartVideoCard : VideoCard , INotifyPropertyChanged
    {
        public StandartVideoCard()
        {
            _name = "Стандартная видеокарта";
            _price = 10000;
            _speed = 35;
            _quantity = 0;
        }
        public StandartVideoCard(string name, int price, int speed, int quantity)
        {
            _name = name;
            _price = price;
            _speed = speed;
            _quantity = quantity;
        }
        public override string Name
        {
            get
            {
                if (_name == null)
                {
                    return "no";
                }
                else
                {
                    return _name;
                }
            }
            set
            {
                _name = value;
            }
        }
        public override int Price
        {
            get => _price;
            set
            {
                _price = value;
                OnPropertyChanged();
            }
        }
        public override int Speed
        {
            get => _speed;
            set
            {
                _speed = value;
                OnPropertyChanged();
            }
        }
        public override int Quantity
        {
            get => _quantity;
            set
            {
                _quantity = value;
                OnPropertyChanged();
            }
        }
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
        public event PropertyChangedEventHandler? PropertyChanged;
    }
    internal sealed class UniversalVideoCard : VideoCard, INotifyPropertyChanged
    {
        public UniversalVideoCard()
        {
            _name = "Универсальная видеокарта";
            _price = 50000;
            _speed = 60;
            _quantity = 0;
        }
        public UniversalVideoCard(string name, int price, int speed, int quantity)
        {
            _name = name;
            _price = price;
            _speed = speed;
            _quantity = quantity;
        }
        public override string Name
        {
            get
            {
                if (_name == null)
                {
                    return "no";
                }
                else
                {
                    return _name;
                }
            }
            set
            {
                _name = value;
            }
        }
        public override int Price
        {
            get => _price;
            set
            {
                _price = value;
                OnPropertyChanged();
            }
        }
        public override int Speed
        {
            get => _speed;
            set
            {
                _speed = value;
                OnPropertyChanged();
            }
        }
        public override int Quantity
        {
            get => _quantity;
            set
            {
                _quantity = value;
                OnPropertyChanged();
            }
        }
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
        public event PropertyChangedEventHandler? PropertyChanged;
    }
    internal sealed class ClassicalVideoCard : VideoCard , INotifyPropertyChanged
    {
        public ClassicalVideoCard()
        {
            _name = "Классическая видеокарта";
            _price = 300000;
            _speed = 100;
            _quantity = 0;
        }
        public ClassicalVideoCard(string name, int price, int speed, int quantity)
        {
            _name = name;
            _price = price;
            _speed = speed;
            _quantity = quantity;
        }
        public override string Name
        {
            get
            {
                if (_name == null)
                {
                    return "no";
                }
                else
                {
                    return _name;
                }
            }
            set
            {
                _name = value;
            }
        }
        public override int Price
        {
            get => _price;
            set
            {
                _price = value;
                OnPropertyChanged();
            }
        }
        public override int Speed
        {
            get => _speed;
            set
            {
                _speed = value;
                OnPropertyChanged();
            }
        }
        public override int Quantity
        {
            get => _quantity;
            set
            {
                _quantity = value;
                OnPropertyChanged();
            }
        }
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
        public event PropertyChangedEventHandler? PropertyChanged;
    }
    internal sealed class ProfessionalVideoCard : VideoCard, INotifyPropertyChanged
    {
        public ProfessionalVideoCard()
        {
            _name = "Профессиональная видеокарта";
            _price = 1000000;
            _speed = 250;
            _quantity = 0;
        }
        public ProfessionalVideoCard(string name, int price, int speed, int quantity)
        {
            _name = name;
            _price = price;
            _speed = speed;
            _quantity = quantity;
        }
        public override string Name
        {
            get
            {
                if (_name == null)
                {
                    return "no";
                }
                else
                {
                    return _name;
                }
            }
            set
            {
                _name = value;
            }
        }
        public override int Price
        {
            get => _price;
            set
            {
                _price = value;
                OnPropertyChanged();
            }
        }
        public override int Speed
        {
            get => _speed;
            set
            {
                _speed = value;
                OnPropertyChanged();
            }
        }
        public override int Quantity
        {
            get => _quantity;
            set
            {
                _quantity = value;
                OnPropertyChanged();
            }
        }
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
        public event PropertyChangedEventHandler? PropertyChanged;
    }
    internal sealed class PremiumVideoCard : VideoCard , INotifyPropertyChanged
    {
        public PremiumVideoCard()
        {
            _name = "Премиум видеокарта";
            _price = 2500000;
            _speed = 400;
            _quantity = 0;
        }
        public PremiumVideoCard(string name, int price, int speed, int quantity)
        {
            _name = name;
            _price = price;
            _speed = speed;
            _quantity = quantity;
        }
        public override string Name
        {
            get
            {
                if (_name == null)
                {
                    return "no";
                }
                else
                {
                    return _name;
                }
            }
            set
            {
                _name = value;
            }
        }
        public override int Price
        {
            get => _price;
            set
            {
                _price = value;
                OnPropertyChanged();
            }
        }
        public override int Speed
        {
            get => _speed;
            set
            {
                _speed = value;
                OnPropertyChanged();
            }
        }
        public override int Quantity
        {
            get => _quantity;
            set
            {
                _quantity = value;
                OnPropertyChanged();
            }
        }
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
        public event PropertyChangedEventHandler? PropertyChanged;
    }
    internal sealed class EliteVideoCard : VideoCard, INotifyPropertyChanged
    {
        public EliteVideoCard()
        {
            _name = "Элитная видеокарта";
            _price = 10000000;
            _speed = 700;
            _quantity = 0;
        }
        public EliteVideoCard(string name, int price, int speed, int quantity)
        {
            _name = name;
            _price = price;
            _speed = speed;
            _quantity = quantity;
        }
        public override string Name
        {
            get
            {
                if (_name == null)
                {
                    return "no";
                }
                else
                {
                    return _name;
                }
            }
            set
            {
                _name = value;
            }
        }
        public override int Price
        {
            get => _price;
            set
            {
                _price = value;
                OnPropertyChanged();
            }
        }
        public override int Speed
        {
            get => _speed;
            set
            {
                _speed = value;
                OnPropertyChanged();
            }
        }
        public override int Quantity
        {
            get => _quantity;
            set
            {
                _quantity = value;
                OnPropertyChanged();
            }
        }
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
        public event PropertyChangedEventHandler? PropertyChanged;
    }
    internal sealed class LegendaryVideoCard : VideoCard , INotifyPropertyChanged
    {
        public LegendaryVideoCard()
        {
            _name = "Легендарная видеокарта";
            _price = 45000000;
            _speed = 1000;
            _quantity = 0;
        }
        public LegendaryVideoCard(string name, int price, int speed, int quantity)
        {
            _name = name;
            _price = price;
            _speed = speed;
            _quantity = quantity;
        }
        public override string Name
        {
            get
            {
                if (_name == null)
                {
                    return "no";
                }
                else
                {
                    return _name;
                }
            }
            set
            {
                _name = value;
            }
        }
        public override int Price
        {
            get => _price;
            set
            {
                _price = value;
                OnPropertyChanged();
            }
        }
        public override int Speed
        {
            get => _speed;
            set
            {
                _speed = value;
                OnPropertyChanged();
            }
        }
        public override int Quantity
        {
            get => _quantity;
            set
            {
                _quantity = value;
                OnPropertyChanged();
            }
        }
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
