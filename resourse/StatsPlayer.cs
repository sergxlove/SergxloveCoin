namespace SergxloveCoin.resourse
{
    internal sealed class StatsPlayer 
    {
        public StatsPlayer() 
        {
            _speedClick = 1;
            _balanceCoin = 10000000000;
            _speedVideoCard = 0;
            _speedProcessor = 0;
        }
        private int _speedClick;
        private long _balanceCoin;
        private int _speedVideoCard;
        private int _speedProcessor;
        public long BalansePlayer
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
        public int SpeedClick
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
        public int SpeedVideoCard
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
        public int SpeedProcessor
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
                return _speedClick.ToString();
            }
        }
        public string SpeedAutoString
        {
            get
            {
                return (_speedProcessor + _speedVideoCard).ToString();
            }
        }
        public void upBalanse(string value)
        {
            _balanceCoin += Convert.ToInt64(value);
        }
        public void upBalanse(int value)
        {
            _balanceCoin += value;
        }
        public void downBalanse(string value) 
        {
            _balanceCoin -= Convert.ToInt64(value);
        }
        public void downBalanse(int value) 
        {
            _balanceCoin -= value;
        }
        public void changeData(int speedClick, long balanceCoin, int speedVideoCrad, int speedProcessor)
        {
            _speedClick = speedClick;
            _balanceCoin = balanceCoin;
            _speedVideoCard = speedVideoCrad;  
            _speedProcessor = speedProcessor;
        }
    }
}
