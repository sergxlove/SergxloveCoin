# StatsPlayer.cs

This document describes the StatsPlayer class that is responsible for the player’s characteristics.

## Field list: 

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

_speedClick - is responsible for the number of coins per click.

_balanceCoin - is responsible for the player’s balance.

_speedVideoCard - is responsible for the number of coins that are obtained from video cards.

_speedProcessor - is responsible for the number of coins that are mined on processors.

_currentEnergy - is responsible for the current amount of energy.

_maxEnergy - is responsible for the maximum amount of energy.

_lastVisitDate - is responsible for the entry of the Grey into the game.

PropertyChanged is responsible for updating the data.

## Property list:

BalancePlayer - Get/set _balanceCoin field.

SpeedClick - fetch/set the _speedClick field.

SpeedVideoCard - Receive/set the _speedVideoCard field.

SpeedProcessor - Get/set _speedProcessor field.

CurrentEnergy Receiving/setting the _currentEnergy field.

MaxEnergy - Get/set the _maxEnergy field.

LastVisitDate - Get/set the _lastVisitDate field.

SpeedClickString - Get a string type _speedClick field.

SpeedAutoString - Automatic recovery of coins.

## Designers:

The class has 1 default constructor:

#### Default constructor:

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


## Method list:

public void upBalanse(string value) - The parameter of the balance is raised by type string.

public void upBalanse(int value) - Balance enhancement by parameter type int.

public void downBalanse(string value) - reduction of balance by string parameter.

public void downBalanse(int value) - reduction of balance by parameter type int.

public void changeData(int speedClick, long balanceCoin, int speedVideoCrad, int speedProcessor, int currentEnergy, int maxEnergy, DateTime lastVisitDate) - update all fields.

public void OnPropertyChanged([CallerMemberName] string prop = "") - update the data on the form.