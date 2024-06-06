using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SergxloveCoin.resourse
{
    internal sealed class StatsPlayer 
    {
        public StatsPlayer() 
        {
            _speedClick = 0.001f;
            _balanceCoin = 100.000f;
            _speedVideoCard = 0.000f;
            _speedProcessor = 0.000f;
            _balanceCoinString = "0,000";
        }
        private float _speedClick;
        private float _balanceCoin;
        private float _speedVideoCard;
        private float _speedProcessor;
        private string _balanceCoinString;
        public float BalansePlayer
        {
            get
            {
                return _balanceCoin;
            }
            set
            {
                _balanceCoin = value;
            }
        }
        public string BalanceCoinString
        {
            get
            {
                return _balanceCoin.ToString("0.000");
            }
            set
            {
                _balanceCoinString = value;
            }
        }
        public float SpeedClick
        {
            get
            {
                return _speedClick;
            }
            set
            {
                _speedClick = value;
            }
        }
        public float SpeedVideoCard
        {
            get
            {
                return _speedVideoCard;
            }
            set
            {
                _speedVideoCard = value;
            }
        }
        public float SpeedProcessor
        {
            get
            {
                return _speedProcessor;
            }
            set
            {
                _speedProcessor = value;
            }
        }
        public string SpeedClickString
        {
            get 
            {
                return _speedClick.ToString("0.000");
            }
        }
        public string SpeedAutoString
        {
            get
            {
                return (_speedProcessor + _speedVideoCard).ToString("0.000");
            }
        }
        public void upBalanse(string value)
        {
            _balanceCoin += Convert.ToSingle(value);
            _balanceCoinString = _balanceCoin.ToString("0.000");
        }
        public void upBalanse(float value)
        {
            _balanceCoin += value;
            _balanceCoinString = _balanceCoin.ToString("0.000");
        }
    }
}
