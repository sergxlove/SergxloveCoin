using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SergxloveCoin.resourse
{
    internal sealed class Level : INotifyPropertyChanged
    {
        public Level() 
        {
            _numberLevel = 0;
            _needCoin = 0;
            _prize = 0;
            _isDone = false;
        }

        public Level(int numberLevel, int needCoin, int prize, bool isDone)
        {
            _numberLevel = numberLevel;
            _needCoin = needCoin;
            _prize = prize;
            _isDone = isDone;
        }

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }

        public int NumberLevel
        {
            get => _numberLevel;
            set
            {
                _numberLevel = value;
                OnPropertyChanged();
            }
        }

        public int NeedCoin
        {
            get => _needCoin;
            set
            {
                _needCoin = value;
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

        public void ChangeData(int numberLevel, int needCoin, int prize, bool isDone)
        {
            _numberLevel = numberLevel;
            _needCoin = needCoin;
            _prize = prize;
            _isDone = isDone;
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        private int _numberLevel;
        private int _needCoin;
        private int _prize;
        private bool _isDone;
    }
}
