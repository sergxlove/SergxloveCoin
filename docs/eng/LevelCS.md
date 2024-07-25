# Level.cs

This document describes the Level class, which is responsible for the player’s level.

## Field list


```csharp
public event PropertyChangedEventHandler? PropertyChanged;
private int _numberLevel;
private int _needCoin;
private int _prize;
private bool _isDone;
```


_numberLevel - is responsible for the sequence number of the level.


_needClaim - Responsible for the number of coins required to obtain a level.


_prize - The prize awarded to a player for completing a level.


_isDone - Reports whether or not the level is received.


PropertyChanged is responsible for updating the data.


## Property list

NumberLevel - Get/set field _numberLevel

NeedClaim - Get/set the _needClaim field.

Prize - receiving/setting of _prize field.

IsDone - Get/set _isDone field.


## Designers:

In the class implemented 2 constructors: default constructor and parameterized constructor.


#### Default constructor:

```CSharp
public Level() 
{
	_numberLevel = 0;
	_needCoin = 0;
	_prize = 0;
	_isDone = false;
}
```


#### Constructor with parameters:

```CSharp
public Level(int numberLevel, int needCoin, int prize, bool isDone)
{
	_numberLevel = numberLevel;
	_needCoin = needCoin;
	_prize = prize;
	_isDone = isDone;
}
```


## List of methods:

public void ChangeData(int numberLevel, int needCoin, int prize, bool isDone) - update all field.

public void OnPropertyChanged([CallerMemberName] string prop = "") - update data in form.
