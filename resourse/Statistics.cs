using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SergxloveCoin.resourse
{
    internal sealed class Statistics : INotifyPropertyChanged
    {
        public Statistics() 
        {
            _quantityClick = 0;
            _totalSumClickMoney = 0;
            _totalSumAutoMoney = 0;
            _level = 0;
            _quantityAchives = 0;
            _quantityMouse = 0;
            _quantityVideoCrad = 0;
            _quantityProcessor = 0;
            _dateBegin = DateTime.Now;
            _quantityDaysPlayed = 0;
        }

        public Statistics(int quantityClick, int totalSumClickMoney, int totalSumAutoMoney, int level, int quantityAchives, int quantityMouse, int quantityVideoCrad, int quantityProcessor, DateTime dateBegin, int quantityDaysPlayed)
        {
            _quantityClick = quantityClick;
            _totalSumClickMoney = totalSumClickMoney;
            _totalSumAutoMoney = totalSumAutoMoney;
            _level = level;
            _quantityAchives = quantityAchives;
            _quantityMouse = quantityMouse;
            _quantityVideoCrad = quantityVideoCrad;
            _quantityProcessor = quantityProcessor;
            _dateBegin = dateBegin;
            _quantityDaysPlayed = quantityDaysPlayed;
        }

        public int QuantityClick
        {
            get => _quantityClick;
            set
            {
                _quantityClick = value;
                OnPropertyChanged(); 
            }
        }

        public int TotalSumClickMoney
        {
            get => _totalSumClickMoney;
            set
            {
                _totalSumClickMoney = value;
                OnPropertyChanged();
            }
        }

        public int TotalSumAutoMoney
        {
            get => _totalSumAutoMoney;
            set
            {
                _totalSumAutoMoney = value;
                OnPropertyChanged();
            }
        }

        public int Level
        {
            get => _level;
            set
            {
                _level = value;
                OnPropertyChanged();
            }
        }

        public int QuantityAchives
        {
            get => _quantityAchives;
            set
            {
                _quantityAchives = value;
                OnPropertyChanged();
            }
        }

        public int QuantityMouse
        {
            get => _quantityMouse;
            set
            {
                _quantityMouse = value;
                OnPropertyChanged();
            }
        }

        public int QuantityVideocard
        {
            get => _quantityVideoCrad;
            set
            {
                _quantityVideoCrad = value;
                OnPropertyChanged();
            }
        }

        public int QuantityProcessor
        {
            get => _quantityProcessor;
            set
            {
                _quantityProcessor = value;
                OnPropertyChanged();
            }
        }

        public DateTime DateBegin
        {
            get => _dateBegin;
            set
            {
                _dateBegin = value;
                OnPropertyChanged();
            }

        }

        public int QuantityDays
        {
            get
            {
                TimeSpan diff = DateTime.Now - _dateBegin;
                return diff.Days;
            }
        }

        public void ChangeData(int quantityClick, int totalSumClickMoney, int totalSumAutoMoney, int level, int quantityAchives, int quantityMouse, int quantityVideoCrad, int quantityProcessor, DateTime dateBegin)
        {
            _quantityClick = quantityClick;
            _totalSumClickMoney = totalSumClickMoney;
            _totalSumAutoMoney = totalSumAutoMoney;
            _level = level;
            _quantityAchives = quantityAchives;
            _quantityMouse = quantityMouse;
            _quantityVideoCrad = quantityVideoCrad;
            _quantityProcessor = quantityProcessor;
            _dateBegin = dateBegin;
        }

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }

        private int _quantityClick;
        private int _totalSumClickMoney;
        private int _totalSumAutoMoney;
        private int _level;
        private int _quantityAchives;
        private int _quantityMouse;
        private int _quantityVideoCrad;
        private int _quantityProcessor;
        private DateTime _dateBegin;
        private int _quantityDaysPlayed;
        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
