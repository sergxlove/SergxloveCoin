using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SergxloveCoin.resourse
{
    internal sealed class StatsPlayer : INotifyPropertyChanged
    {
        public StatsPlayer() 
        {
            _speedClick = 0.001f;
            _balanceCoin = 0.000f;
            _speedVideoCard = 0.000f;
            _speedProcessor = 0.000f;
            _balanceCoinString = "1110,000";
        }
        private float _speedClick;
        private float _balanceCoin;
        private string _balanceCoinString;
        private float _speedVideoCard;
        private float _speedProcessor;
        public event PropertyChangedEventHandler? PropertyChanged;
        public float BalansePlayer
        {
            get
            {
                return _balanceCoin;
            }
            set
            {
                _balanceCoin = value;
                OnPropertyChanged();
            }
        }
        public string BalanceCoinString
        {
            get
            {
                return _balanceCoinString;
            }
            set
            {
                _balanceCoinString = value;
                OnPropertyChanged();
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
                OnPropertyChanged();
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
                OnPropertyChanged();
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
                OnPropertyChanged();
            }
        }
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
        public void upBalanse(string value)
        {
            BalanceCoinString = (Convert.ToSingle(_balanceCoinString) + Convert.ToSingle(value)).ToString("0.000");
        }
    }
}
