# Mouse.cs

¬ данном документе описан класс Mouse, отвечающий за компонент мышь.

## —писок полей

```CSharp
private string? _name;
private int _price;
private int _speedClick;
private int _quantity;
public event PropertyChangedEventHandler? PropertyChanged;
```

_name - отвечает за им€ компонента.

_price - отвечает за стоимость компонента.

_speedClick - отвечает за скорость компонента.

_quantity - отвечает за количество компонента.

PropertyChanged - отвечает за обновление данных

## —писок свойств

Name - получение/установка пол€ _name.

Price - получение/установка пол€ _price.

SpeedClick - получение/установка пол€ _speedClick. 

Quantity - получение/установка пол€ _quantity.

##  онструкторы:

¬ классе реализованно 3 конструктора: конструктор по умолчанию и 2 конструктора с различными параметрами.

####  онструктор по умолчанию:

```CSharp
public Mouse()
{
	_name = "no";
	_price = 0;
	_speedClick = 0;
	_quantity = 0;
}
```

#### ѕервый конструктор с параметрами:
```CSharp
public Mouse(string? name)
{
	_name = name;
	_price = 0;
	_speedClick = 0;
	_quantity = 0;
}
```

#### ¬торой конструктор с параметрами:

```CSharp
public Mouse(string? name, int price, int speedClick, int quantity)
{
	_name = name;
	_price = price;
	_speedClick = speedClick;
	_quantity = quantity;
}
```

## —писок методов:

public void ChangeData(int price, int speed, int quantity) - обновление всех полей.

public void OnPropertyChanged([CallerMemberName] string prop = "") - обновление данных на форме.