using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SergxloveCoin.resourse
{
    internal abstract class Mouse
    {
        public abstract string Name { get; set; }
        public abstract int Price { get; set; }
        public abstract int SpeedClick { get; set; }
        public abstract int Quantity { get; set; }
        protected string? _name;
        protected int _price;
        protected int _speedClick;
        protected int _quantity;
    }
    internal sealed class CommonMouse : Mouse, INotifyPropertyChanged
    {
        public CommonMouse()
        {
            _name = "Обычная мышь";
            _price = 500;
            _speedClick = 3;
            _quantity = 0;
        }
        public CommonMouse(string name, int price, int speedClick, int quantity)
        {
            _name = name;
            _price = price;
            _speedClick = speedClick;
            _quantity = quantity;
        }
        public override string Name
        {
            get
            {
                if(_name == null)
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
        public override int SpeedClick
        {
            get => _speedClick;
            set
            {
                _speedClick = value;
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
    internal sealed class EconomyMouse : Mouse ,INotifyPropertyChanged
    {
        public EconomyMouse() 
        {
            _name = "Эконом мышь";
            _price = 2000;
            _speedClick = 9;
            _quantity = 0;
        }
        public EconomyMouse(string name, int price, int speedClick, int quantity)
        {
            _name = name;
            _price = price;
            _speedClick = speedClick;
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
        public override int SpeedClick
        {
            get => _speedClick;
            set
            {
                _speedClick = value;
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
    internal sealed class BudgetMouse : Mouse, INotifyPropertyChanged
    {
        public BudgetMouse()
        {
            _name = "Бюджетная мышь";
            _price = 10000;
            _speedClick = 20;
            _quantity = 0;
        }
        public BudgetMouse(string name, int price, int speedClick, int quantity)
        {
            _name = name;
            _price = price;
            _speedClick = speedClick;
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
        public override int SpeedClick
        {
            get => _speedClick;
            set
            {
                _speedClick = value;
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
    internal sealed class StandartMouse : Mouse , INotifyPropertyChanged
    {
        public StandartMouse()
        {
            _name = "Стандартная мышь";
            _price = 50000;
            _speedClick = 45;
            _quantity = 0;
        }
        public StandartMouse(string name, int price, int speedClick, int quantity)
        {
            _name = name;
            _price = price;
            _speedClick = speedClick;
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
        public override int SpeedClick
        {
            get => _speedClick;
            set
            {
                _speedClick = value;
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
    internal sealed class UniversalMouse : Mouse, INotifyPropertyChanged
    {
        public UniversalMouse()
        {
            _name = "Универсальная мышь";
            _price = 250000;
            _speedClick = 110;
            _quantity = 0;
        }
        public UniversalMouse(string name, int price, int speedClick, int quantity)
        {
            _name = name;
            _price = price;
            _speedClick = speedClick;
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
        public override int SpeedClick
        {
            get => _speedClick;
            set
            {
                _speedClick = value;
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
    internal sealed class ClassicalMouse : Mouse, INotifyPropertyChanged
    {
        public ClassicalMouse()
        {
            _name = "Классическая мышь";
            _price = 1000000;
            _speedClick = 250;
            _quantity = 0;
        }
        public ClassicalMouse(string name, int price, int speedClick, int quantity)
        {
            _name = name;
            _price = price;
            _speedClick = speedClick;
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
        public override int SpeedClick
        {
            get => _speedClick;
            set
            {
                _speedClick = value;
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
    internal sealed class ProfessionalMouse : Mouse, INotifyPropertyChanged
    {
        public ProfessionalMouse() 
        {
            _name = "Профессиональная мышь";
            _price = 4000000;
            _speedClick = 650;
            _quantity = 0;
        }
        public ProfessionalMouse(string name, int price, int speedClick, int quantity)
        {
            _name = name;
            _price = price;
            _speedClick = speedClick;
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
        public override int SpeedClick
        {
            get => _speedClick;
            set
            {
                _speedClick = value;
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
    internal sealed class  PremiumMouse : Mouse, INotifyPropertyChanged
    {
        public PremiumMouse() 
        {
            _name = "Премиум мышь";
            _price = 20000000;
            _speedClick = 1000;
            _quantity = 0;
        }
        public PremiumMouse(string name, int price, int speedClick, int quantity)
        {
            _name = name;
            _price = price;
            _speedClick = speedClick;
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
        public override int SpeedClick
        {
            get => _speedClick;
            set
            {
                _speedClick = value;
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
    internal sealed class EliteMouse : Mouse , INotifyPropertyChanged
    {
        public EliteMouse() 
        {
            _name = "Элитная мышь";
            _price = 100000000;
            _speedClick = 2100;
            _quantity = 0;
        }
        public EliteMouse(string name, int price, int speedClick, int quantity)
        {
            _name = name;
            _price = price;
            _speedClick = speedClick;
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
        public override int SpeedClick
        {
            get => _speedClick;
            set
            {
                _speedClick = value;
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
    internal sealed class LegendaryMouse : Mouse , INotifyPropertyChanged
    {
        public LegendaryMouse() 
        {
            _name = "Легендарная мышь";
            _price = 250000000;
            _speedClick = 4000;
            _quantity = 0;
        }
        public LegendaryMouse(string name, int price, int speedClick, int quantity)
        {
            _name = name;
            _price = price;
            _speedClick = speedClick;
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
        public override int SpeedClick
        {
            get => _speedClick;
            set
            {
                _speedClick = value;
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
