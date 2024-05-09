using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SergxloveCoin.resourse
{
    internal abstract class Mouse
    {
        public abstract string Name { get; set; }
        public abstract float Price { get; set; }
        public abstract float SpeedClick { get; set; }
        public abstract int Qantity { get; set; }
        protected string _name;
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
            get => _name;
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
        public override int Qantity
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
