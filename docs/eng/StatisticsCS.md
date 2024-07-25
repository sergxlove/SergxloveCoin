# Statistics.cs

This document describes the Statistics class, which is responsible for player statistics.

## Field list: 

```CSharp
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
```

_quantityClick - is responsible for the number of clicks.

_totalSumClickMoney - is responsible for the total number of coins earned per click.

_totalSumAutoMoney - is responsible for the total number of coins earned in automatic mode.

_level - is responsible for the player’s level.

_quantityAchives - is responsible for the number of achievements.

_quantityMouse - is responsible for the number of "Mouse" components.

_quantityVideoCrad - is responsible for the number of "Video Card" components.

_quantityProcessor - is responsible for the number of "Processor" components.

_dateBegin is responsible for the start date of the game.

_quantityDaysPlayed - is responsible for the number of days in the game.

PropertyChanged is responsible for updating the data.

## Property list:

QuantityClick - Get/set the _quantityClick field.

TotalSumClickMoney - Get/set the _totalSumClickMoney field.

TotalSumAutoMoney - Get/set the _totalSumAutoMoney field.

Level - Get/set _level field.

QuantityAchives - Get/set the _quantityAchives field.

QuantityMouse - Get/set _quantityMouse field.

QuantityVideoCrad - Get/set the _quantityVideoCard field.

QuantityProcessor - Get/set _quantityProcessor field.

DateBegin - Get/set the _dateBegin field.

QuantityDaysPlayed - Get the field _quantityDaysPlayed.

## Designers:

In the class implemented 2 constructors: default constructor and parameterized constructor.

#### Default constructor:

```CSharp
public Statistics() 
{
	_quantityClick = 1;
	_totalSumClickMoney = 1;
	_totalSumAutoMoney = 1;
	_level = 1;
	_quantityAchives = 1;
	_quantityMouse = 1;
	_quantityVideoCrad = 1;
	_quantityProcessor = 1;
	_dateBegin = DateTime.Now;
	_quantityDaysPlayed = 1;
}
```

#### Second constructor with parameters:

```CHarp
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
```

## List of methods:

public void ChangeData(int quantityClick, int totalSumClickMoney, int totalSumAutoMoney, int level, int quantityAchives, int quantityMouse, int quantityVideoCrad, int quantityProcessor, DateTime dateBegin) - update all field.

public void OnPropertyChanged([CallerMemberName] string prop = "") - update data in form.

