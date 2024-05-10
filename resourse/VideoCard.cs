using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

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
