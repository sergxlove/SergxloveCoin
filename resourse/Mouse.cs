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
    internal sealed class CommonMouse : Mouse , INotifyPropertyChanged
    {
        public CommonMouse() { }
        public override string Name
        {
            get => _name;
            
        }
        public override void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
