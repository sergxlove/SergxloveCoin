# StatsPlayer.cs

� ������ ��������� ������ ����� StatsPlayer, ���������� �� �������������� ������.

## ������ �����: 

```CSharp
private int _speedClick;
private long _balanceCoin;
private int _speedVideoCard;
private int _speedProcessor;
private int _currentEnergy;
private int _maxEnergy;
private DateTime _lastVisitDate;
public event PropertyChangedEventHandler? PropertyChanged;
```

_speedClick - �������� �� ���������� ����� �� ����.

_balanceCoin - �������� �� ������ ������.

_speedVideoCard - �������� �� ���������� �����, ������� ���������� �� �����������.

_speedProcessor - �������� �� ���������� �����, ������� ���������� �� �����������.

_currentEnergy - �������� �� ������� ���������� �������.

_maxEnergy - �������� �� ������������ ���������� �������.

_lastVisitDate - �������� �� �������� ���� � ����.

PropertyChanged - �������� �� ���������� ������.

## ������ �������:

BalancePlayer - ���������/��������� ���� _balanceCoin.

SpeedClick - ���������/��������� ���� _speedClick.

SpeedVideoCard - ���������/��������� ���� _speedVideoCard.

SpeedProcessor - ���������/��������� ���� _speedProcessor.

CurrentEnergy ���������/��������� ���� _currentEnergy.

MaxEnergy - ���������/��������� ���� _maxEnergy.

LastVisitDate - ���������/��������� ���� _lastVisitDate.

SpeedClickString - ��������� ���� _speedClick ���� string.

SpeedAutoString - ��������� �������� ��������������� ��������� �����.

## ������������:

� ������ ���������� 1 ����������� �� ���������:

#### ����������� �� ���������:

```CSharp
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
```


## ������ �������:

public void upBalanse(string value) - ��������� ������� �� ��������� ���� string.

public void upBalanse(int value) - ��������� ������� �� ��������� ���� int.

public void downBalanse(string value) - ���������� ������� �� ��������� ���� string.

public void downBalanse(int value) - ���������� ������� �� ��������� ���� int.

public void changeData(int speedClick, long balanceCoin, int speedVideoCrad, int speedProcessor, int currentEnergy, int maxEnergy, DateTime lastVisitDate) - ���������� ���� �����.

public void OnPropertyChanged([CallerMemberName] string prop = "") - ���������� ������ �� �����.