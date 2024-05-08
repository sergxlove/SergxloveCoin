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
            _speedMouse = 0.000f;
            _balanceCoinString = "";
        }
        private float _speedClick;
        private float _balanceCoin;
        private string _balanceCoinString;
        private float _speedVideoCard;
        private float _speedMouse;
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
        public float SpeedMouse
        {
            get
            {
                return _speedMouse;
            }
            set
            {
                _speedMouse = value;
                OnPropertyChanged();
            }
        }
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
        public void upBalanse(string value)
        {

        }
    }
}
