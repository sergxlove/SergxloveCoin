# Achives.cs

This document presents the class Achives, responsible for player achievement.


## List field:

```c#
private int _needClaim;
private int _prize;
private bool _isDone;
private VariationAchive _typeAchives;
public event PropertyChangedEventHandler? PropertyChanged;
```


_needClaim - is responsible for the amount of coins required to achieve an achievement.


_prize - The prize awarded to a player for achieving an achievement.


_isDone - Reports whether or not the achievement has been received.

_tyreAchives - is responsible for the type of achievement.

PropertyChanged is responsible for updating the data.


## Implementation of the enumerated type VariationAchive:

```c#
enum VariationAchive
{
	None = 0,
	Money = 1,
	SpeedAuto = 2,
	peedClick = 3
}
```

## List propertys:

NeedClaim - Get/set the _needClaim field.

Prize - receiving/setting of _prize field.

IsDone - Get/set _isDone field.

TypeAchives - Get/set _typeAchives field.

## Constructors:

In the class implemented 2 constructors: default constructor and parameterized constructor.

#### Default constructor:

```c#
public Achives()
{
	_needClaim = 0;
	_prize = 0;
	_isDone = false;
	_typeAchives = VariationAchive.None;
}
```


#### Constructor with parameters:


```c#
public Achives(int needClaim, int  prize, bool isDone, VariationAchive typeAchives)
{
	_needClaim = needClaim;
	_prize = prize;
	_isDone = isDone;
	_typeAchives = typeAchives;
}
```


## List of methods:

public void ChangeData(int needClaim, int prize, bool isDone, VariationAchive typeAchives) - update all field


public void OnPropertyChanged([CallerMemberName] string prop = "") - update data in form







