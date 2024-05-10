using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SergxloveCoin.resourse
{
    internal abstract class VideoCard
    {
        public abstract string Name { get; set; }
        public abstract float Price { get; set; }
        public abstract float Speed { get; set; }
        public abstract int Quantity { get; set; }
        protected string? _name;
        protected float _price;
        protected float _speed;
        protected int _quantity;
    }
    internal sealed class CommonVideoCard : VideoCard , INotifyPropertyChanged
    {
        public CommonVideoCard() 
        {
            _name = "Обычная видеокарта";
            _price = 1.500f;
            _speed = 0.005f;
            _quantity = 0;
        }
        public CommonVideoCard(string name, float price, float speed, int quantity)
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
        public override float Price
        {
            get => _price;
            set
            {
                _price = value;
                OnPropertyChanged();
            }
        }
        public override float Speed
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
            _price = 5.000f;
            _speed = 0.010f;
            _quantity = 0;
        }
        public EconomyVideoCard(string name, float price, float speed, int quantity)
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
        public override float Price
        {
            get => _price;
            set
            {
                _price = value;
                OnPropertyChanged();
            }
        }
        public override float Speed
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
            _price = 30.000f;
            _speed = 0.020f;
            _quantity = 0;
        }
        public BudgetVideoCard(string name, float price, float speed, int quantity)
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
        public override float Price
        {
            get => _price;
            set
            {
                _price = value;
                OnPropertyChanged();
            }
        }
        public override float Speed
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
            _price = 100.000f;
            _speed = 0.035f;
            _quantity = 0;
        }
        public StandartVideoCard(string name, float price, float speed, int quantity)
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
        public override float Price
        {
            get => _price;
            set
            {
                _price = value;
                OnPropertyChanged();
            }
        }
        public override float Speed
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
            _price = 500.000f;
            _speed = 0.060f;
            _quantity = 0;
        }
        public UniversalVideoCard(string name, float price, float speed, int quantity)
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
        public override float Price
        {
            get => _price;
            set
            {
                _price = value;
                OnPropertyChanged();
            }
        }
        public override float Speed
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
            _price = 3000.000f;
            _speed = 0.100f;
            _quantity = 0;
        }
        public ClassicalVideoCard(string name, float price, float speed, int quantity)
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
        public override float Price
        {
            get => _price;
            set
            {
                _price = value;
                OnPropertyChanged();
            }
        }
        public override float Speed
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
            _price = 10000.000f;
            _speed = 0.250f;
            _quantity = 0;
        }
        public ProfessionalVideoCard(string name, float price, float speed, int quantity)
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
        public override float Price
        {
            get => _price;
            set
            {
                _price = value;
                OnPropertyChanged();
            }
        }
        public override float Speed
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
            _price = 25000.000f;
            _speed = 0.400f;
            _quantity = 0;
        }
        public PremiumVideoCard(string name, float price, float speed, int quantity)
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
        public override float Price
        {
            get => _price;
            set
            {
                _price = value;
                OnPropertyChanged();
            }
        }
        public override float Speed
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
            _price = 100000.000f;
            _speed = 0.700f;
            _quantity = 0;
        }
        public EliteVideoCard(string name, float price, float speed, int quantity)
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
        public override float Price
        {
            get => _price;
            set
            {
                _price = value;
                OnPropertyChanged();
            }
        }
        public override float Speed
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
            _price = 450000.000f;
            _speed = 1.000f;
            _quantity = 0;
        }
        public LegendaryVideoCard(string name, float price, float speed, int quantity)
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
        public override float Price
        {
            get => _price;
            set
            {
                _price = value;
                OnPropertyChanged();
            }
        }
        public override float Speed
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
