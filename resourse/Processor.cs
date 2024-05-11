using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SergxloveCoin.resourse
{
    internal abstract class Processor
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
}
