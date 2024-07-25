using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SergxloveCoin.resourse
{
    internal sealed class StatsPlayer : INotifyPropertyChanged
    {
        public StatsPlayer()
        {
            _speedClick = 1;
            _balanceCoin = 0;
            _speedVideoCard = 0;
            _speedProcessor = 0;
            _currentEnergy = 1000;
            _maxEnergy = 1000;
            _lastVisitDate = DateTime.MinValue;
        }

        public long BalansePlayer
        {
            get { return _balanceCoin; }
            set 
            {
                _balanceCoin = value;
                OnPropertyChanged();
            }
        }

        public int SpeedClick
        {
            get { return _speedClick; }
            set { _speedClick = value; }
        }

        public int SpeedVideoCard
        {
            get { return _speedVideoCard; }
            set { _speedVideoCard = value; }
        }

        public int SpeedProcessor
        {
            get { return _speedProcessor; }
            set { _speedProcessor = value; }
        }

        public string SpeedClickString
        {
            get { return _speedClick.ToString(); }
        }

        public string SpeedAutoString
        {
            get { return (_speedProcessor + _speedVideoCard).ToString(); }
        }

        public int CurrentEnergy
        {
            get { return _currentEnergy; }
            set 
            {
                _currentEnergy = value;
                OnPropertyChanged();
            }
        }

        public int MaxEnergy
        {
            get { return _maxEnergy; }
            set 
            {
                _maxEnergy = value;
                OnPropertyChanged();
            }
        }

        public DateTime LastVisitDate
        {
            get { return _lastVisitDate; }
            set { _lastVisitDate = value; }
        }

        public void upBalanse(string value)
        {
            _balanceCoin += Convert.ToInt64(value);
            OnPropertyChanged();
        }

        public void upBalanse(int value)
        {
            BalansePlayer += value;
        }

        public void downBalanse(string value)
        {
            _balanceCoin -= Convert.ToInt64(value);
        }

        public void downBalanse(int value)
        {
            _balanceCoin -= value;
        }

        public void changeData(int speedClick, long balanceCoin, int speedVideoCrad, int speedProcessor, int currentEnergy, int maxEnergy, DateTime lastVisitDate)
        {
            _speedClick = speedClick;
            _balanceCoin = balanceCoin;
            _speedVideoCard = speedVideoCrad;
            _speedProcessor = speedProcessor;
            _currentEnergy = currentEnergy;
            _maxEnergy = maxEnergy;
            _lastVisitDate = lastVisitDate;
        }

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }

        private int _speedClick;
        private long _balanceCoin;
        private int _speedVideoCard;
        private int _speedProcessor;
        private int _currentEnergy;
        private int _maxEnergy;
        private DateTime _lastVisitDate;
        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
