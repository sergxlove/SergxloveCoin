using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SergxloveCoin.resourse
{
    internal sealed class Processor : INotifyPropertyChanged
    {
        public Processor()
        {
            _name = "no name";
            _price = 0;
            _speed = 0;
            _quantity = 0;
        }

        public Processor(string? name)
        {
            _name = name;
            _price = 0;
            _speed = 0;
            _quantity = 0;
        }

        public Processor(string? name, int price, int speed, int quantity)
        {
            _name = name;
            _price = price;
            _speed = speed;
            _quantity = quantity;
        }

        public string Name
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

        public int Price
        {
            get => _price;
            set
            {
                _price = value;
                OnPropertyChanged();
            }
        }

        public int Speed
        {
            get => _speed;
            set
            {
                _speed = value;
                OnPropertyChanged();
            }
        }

        public int Quantity
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

        public void ChangeData(int price, int speed, int quantity)
        {
            _price = price;
            _speed = speed;
            _quantity = quantity;
        }

        private string? _name;
        private int _price;
        private int _speed;
        private int _quantity;
        public event PropertyChangedEventHandler? PropertyChanged;
    }
}