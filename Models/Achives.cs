using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SergxloveCoin.resourse
{
    enum VariationAchive
    {
        None = 0,
        Money = 1,
        SpeedAuto = 2,
        SpeedClick = 3
    }
    internal sealed class Achives : INotifyPropertyChanged
    {
        public Achives()
        {
            _needClaim = 0;
            _prize = 0;
            _isDone = false;
            _typeAchives = VariationAchive.None;
        }

        public Achives(int needClaim, int  prize, bool isDone, VariationAchive typeAchives)
        {
            _needClaim = needClaim;
            _prize = prize;
            _isDone = isDone;
            _typeAchives = typeAchives;
        }

        public int NeedClaim
        {
            get => _needClaim;
            set
            {
                _needClaim = value;
                OnPropertyChanged();
            }
        }

        public int Prize
        {
            get => _prize;
            set 
            {
                _prize = value;
                OnPropertyChanged();
            }
        }

        public bool IsDone
        {
            get => _isDone;
            set
            {
                _isDone = value;
                OnPropertyChanged();
            }
        }

        public VariationAchive TypeAchives
        {
            get => _typeAchives;
            set
            {
                _typeAchives = value;
                OnPropertyChanged();
            }
        }

        public void ChangeData(int needClaim, int prize, bool isDone, VariationAchive typeAchives)
        {
            _needClaim = needClaim;
            _prize = prize;
            _isDone = isDone;
            _typeAchives = typeAchives; 
        }

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }

        private int _needClaim;
        private int _prize;
        private bool _isDone;
        private VariationAchive _typeAchives;
        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
