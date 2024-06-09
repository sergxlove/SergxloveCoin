using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SergxloveCoin.resourse
{
    internal abstract class Processor
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
    internal sealed class CommonProcessor : Processor, INotifyPropertyChanged
    {
        public CommonProcessor() 
        {
            _name = "Обычный процессор";
            _price = 300;
            _speed = 2;
            _quantity = 0; 
        }
        public CommonProcessor(string name, int price, int speed, int quantity)
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
    internal sealed class EconomyProcessor : Processor, INotifyPropertyChanged
    {
        public EconomyProcessor() 
        {
            _name = "Эконом процессор";
            _price = 1500;
            _speed = 3;
            _quantity = 0;
        }
        public EconomyProcessor(string name, int price, int speed, int quantity)
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
    internal sealed class BudgetProcessor : Processor , INotifyPropertyChanged
    {
        public BudgetProcessor()
        {
            _name = "Бюджетный процессор";
            _price = 6000;
            _speed = 5;
            _quantity = 0;
        }
        public BudgetProcessor(string name, int price, int speed, int quantity)
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
    internal sealed class StandartProcessor : Processor , INotifyPropertyChanged
    {
        public StandartProcessor()
        {
            _name = "Стандартный процессор";
            _price = 25000;
            _speed = 8;
            _quantity = 0;
        }
        public StandartProcessor(string name, int price, int speed, int quantity)
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
    internal sealed class UniversalProcessor : Processor, INotifyPropertyChanged
    {
        public UniversalProcessor() 
        {
            _name = "Универсальный процессор";
            _price = 100000;
            _speed = 13;
            _quantity = 0;
        }
        public UniversalProcessor(string name, int price, int speed, int quantity)
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
    internal sealed class ClassicalProcessor : Processor, INotifyPropertyChanged
    {
        public ClassicalProcessor()
        {
            _name = "Классический процессор";
            _price = 500000;
            _speed = 25;
            _quantity = 0;
        }
        public ClassicalProcessor(string name, int price, int speed, int quantity)
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
    internal sealed class ProfessionalProcessor : Processor , INotifyPropertyChanged
    {
        public ProfessionalProcessor()
        {
            _name = "Профессиональный процессор";
            _price = 2000000;
            _speed = 40;
            _quantity = 0;
        }
        public ProfessionalProcessor(string name, int price, int speed, int quantity)
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
    internal sealed class PremiumProcessor : Processor , INotifyPropertyChanged
    {
        public PremiumProcessor()
        {
            _name = "Премиум процессор";
            _price = 10000000;
            _speed = 65;
            _quantity = 0;
        }
        public PremiumProcessor(string name, int price, int speed, int quantity)
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
    internal sealed class EliteProcessor : Processor , INotifyPropertyChanged
    {
        public EliteProcessor()
        {
            _name = "Элитный процессор";
            _price = 3000000;
            _speed = 100;
            _quantity = 0;
        }
        public EliteProcessor(string name, int price, int speed, int quantity)
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
    internal sealed class LegendaryProcessor : Processor , INotifyPropertyChanged
    {
        public LegendaryProcessor()
        {
            _name = "Легендарный процессор";
            _price = 50000000;
            _speed = 130;
            _quantity = 0;
        }
        public LegendaryProcessor(string name, int price, int speed, int quantity)
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
