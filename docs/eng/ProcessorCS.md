# Processor.cs

This document describes the mouse class, which is responsible for the processor component.

## Field list: 

```CSharp
private string? _name;
private int _price;
private int _speed;
private int _quantity;
public event PropertyChangedEventHandler? PropertyChanged;
```


_name - Is responsible for the component name.

_price - is responsible for the cost of the component.

_speed - is responsible for the component’s speed.

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
public Processor()
{
	_name = "no name";
	_price = 0;
	_speed = 0;
	_quantity = 0;
}
```

#### First constructor with parameters:

```CSharp
public Processor(string? name)
{
	_name = name;
	_price = 0;
	_speed = 0;
	_quantity = 0;
}
```

#### Second constructor with parameters:

```CSharp
public Processor(string? name, int price, int speed, int quantity)
{
	_name = name;
	_price = price;
	_speed = speed;
	_quantity = quantity;
}
```


## List of methods:

public void ChangeData(int price, int speed, int quantity) - update all field.

public void OnPropertyChanged([CallerMemberName] string prop = "") - update data in form.