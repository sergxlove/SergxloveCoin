using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SergxloveCoin.resourse
{
    internal abstract class Mouse
    {
        public abstract string Name { get; set; }
        public abstract float Price { get; set; }
        public abstract float SpeedClick { get; set; }
        public abstract int Quantity { get; set; }
        protected string? _name;
        protected float _price;
        protected float _speedClick;
        protected int _quantity;
    }
    internal sealed class CommonMouse : Mouse, INotifyPropertyChanged
    {
        public CommonMouse()
        {
            _name = "Обычная мышь";
            _price = 0.500f;
            _speedClick = 0.003f;
            _quantity = 0;
        }
        public CommonMouse(string name, float price, float speedClick, int quantity)
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
        public override float Price
        {
            get => _price;
            set
            {
                _price = value;
                OnPropertyChanged();
            }
        }
        public override float SpeedClick
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
            _price = 2.000f;
            _speedClick = 0.009f;
            _quantity = 0;
        }
        public EconomyMouse(string name, float price, float speedClick, int quantity)
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
        public override float Price
        {
            get => _price;
            set
            {
                _price = value;
                OnPropertyChanged();
            }
        }
        public override float SpeedClick
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
            _price = 10.000f;
            _speedClick = 0.020f;
            _quantity = 0;
        }
        public BudgetMouse(string name, float price, float speedClick, int quantity)
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
        public override float Price
        {
            get => _price;
            set
            {
                _price = value;
                OnPropertyChanged();
            }
        }
        public override float SpeedClick
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
            _price = 50.000f;
            _speedClick = 0.045f;
            _quantity = 0;
        }
        public StandartMouse(string name, float price, float speedClick, int quantity)
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
        public override float Price
        {
            get => _price;
            set
            {
                _price = value;
                OnPropertyChanged();
            }
        }
        public override float SpeedClick
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
            _price = 250.000f;
            _speedClick = 0.110f;
            _quantity = 0;
        }
        public UniversalMouse(string name, float price, float speedClick, int quantity)
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
        public override float Price
        {
            get => _price;
            set
            {
                _price = value;
                OnPropertyChanged();
            }
        }
        public override float SpeedClick
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
            _price = 1000.000f;
            _speedClick = 0.250f;
            _quantity = 0;
        }
        public ClassicalMouse(string name, float price, float speedClick, int quantity)
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
        public override float Price
        {
            get => _price;
            set
            {
                _price = value;
                OnPropertyChanged();
            }
        }
        public override float SpeedClick
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
            _price = 4000.000f;
            _speedClick = 0.650f;
            _quantity = 0;
        }
        public ProfessionalMouse(string name, float price, float speedClick, int quantity)
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
        public override float Price
        {
            get => _price;
            set
            {
                _price = value;
                OnPropertyChanged();
            }
        }
        public override float SpeedClick
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
            _price = 20000.000f;
            _speedClick = 1.000f;
            _quantity = 0;
        }
        public PremiumMouse(string name, float price, float speedClick, int quantity)
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
        public override float Price
        {
            get => _price;
            set
            {
                _price = value;
                OnPropertyChanged();
            }
        }
        public override float SpeedClick
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
            _price = 100000.000f;
            _speedClick = 2.100f;
            _quantity = 0;
        }
        public EliteMouse(string name, float price, float speedClick, int quantity)
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
        public override float Price
        {
            get => _price;
            set
            {
                _price = value;
                OnPropertyChanged();
            }
        }
        public override float SpeedClick
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
            _price = 250000.000f;
            _speedClick = 4.000f;
            _quantity = 0;
        }
        public LegendaryMouse(string name, float price, float speedClick, int quantity)
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
        public override float Price
        {
            get => _price;
            set
            {
                _price = value;
                OnPropertyChanged();
            }
        }
        public override float SpeedClick
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
