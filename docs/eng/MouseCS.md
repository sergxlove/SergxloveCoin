# Mouse.cs

This document describes the mouse class, which is responsible for the mouse component.

## Field list

```CSharp
private string? _name;
private int _price;
private int _speedClick;
private int _quantity;
public event PropertyChangedEventHandler? PropertyChanged;
```

_name - Is responsible for the component name.

_price - is responsible for the cost of the component.

_speedClick - is responsible for the component speed.

_quantity - is responsible for the amount of component.

PropertyChanged - responsible for updating data

## Property list

Name - fetch/set _name field.

Price - to receive/set the _price field.

SpeedClick - fetch/set the _speedClick field. 

Quantity - Get/set the _quantity field.

## Designers:

In the class implemented 3 constructors: default constructor and 2 constructors with different parameters.

#### Default constructor:

```CSharp
public Mouse()
{
	_name = "no";
	_price = 0;
	_speedClick = 0;
	_quantity = 0;
}
```

#### First constructor with parameters:

```CSharp
public Mouse(string? name)
{
	_name = name;
	_price = 0;
	_speedClick = 0;
	_quantity = 0;
}
```

#### Second constructor with parameters:

```CSharp
public Mouse(string? name, int price, int speedClick, int quantity)
{
	_name = name;
	_price = price;
	_speedClick = speedClick;
	_quantity = quantity;
}
```

## List of methods:

public void ChangeData(int price, int speed, int quantity) - update all field.

public void OnPropertyChanged([CallerMemberName] string prop = "") - update data in form.