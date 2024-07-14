# StatsPlayer.cs

В данном документе описан класс StatsPlayer, отвечающий за характеристики игрока.

## Список полей: 

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

_speedClick - отвечает за количество монет за клик.

_balanceCoin - отвечает за баланс игрока.

_speedVideoCard - отвечает за количество монет, которые добываются на видеокартах.

_speedProcessor - отвечает за количество монет, которые добываются на процессорах.

_currentEnergy - отвечает за текущее количество энергии.

_maxEnergy - отвечает за максимальное количество энергии.

_lastVisitDate - отвечает за поседний вход в игру.

PropertyChanged - отвечает за обновление данных.

## Список свойств:

BalancePlayer - получение/установка поля _balanceCoin.

SpeedClick - получение/установка поля _speedClick.

SpeedVideoCard - получение/установка поля _speedVideoCard.

SpeedProcessor - получение/установка поля _speedProcessor.

CurrentEnergy получение/установка поля _currentEnergy.

MaxEnergy - получение/установка поля _maxEnergy.

LastVisitDate - получение/установка поля _lastVisitDate.

SpeedClickString - получение поля _speedClick типа string.

SpeedAutoString - получение значения автоматического добывания монет.

## Конструкторы:

В классе реализован 1 конструктор по умолчанию:

#### Конструктор по умолчанию:

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


## Список методов:

public void upBalanse(string value) - повышение баланса по параметру типа string.

public void upBalanse(int value) - повышение баланса по параметру типа int.

public void downBalanse(string value) - уменьшение баланса по параметру типа string.

public void downBalanse(int value) - уменьшение баланса по параметру типа int.

public void changeData(int speedClick, long balanceCoin, int speedVideoCrad, int speedProcessor, int currentEnergy, int maxEnergy, DateTime lastVisitDate) - обновление всех полей.

public void OnPropertyChanged([CallerMemberName] string prop = "") - обновление данных на форме.