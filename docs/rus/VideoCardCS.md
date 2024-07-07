# VideoCard.cs


В данном документе описан класс Mouse, отвечающий за компонент процессор.

## Список полей: 

```CSharp
private string? _name;
private int _price;
private int _speed;
private int _quantity;
public event PropertyChangedEventHandler? PropertyChanged;
```


_name - отвечает за имя компонента.

_price - отвечает за стоимость компонента.

_speed - отвечает за скорость компонента.

_quantity - отвечает за количество компонента.

PropertyChanged - отвечает за обновление данных


## Список свойств

Name - получение/установка поля _name.

Price - получение/установка поля _price.

SpeedClick - получение/установка поля _speedClick. 

Quantity - получение/установка поля _quantity.


## Конструкторы:

В классе реализованно 3 конструктора: конструктор по умолчанию и 2 конструктора с различными параметрами.

#### Конструктор по умолчанию:

```CSharp
public VideoCard()
{
	_name = "no";
	_price = 0;
	_speed = 0;
	_quantity = 0;
}
```

#### Первый конструктор с параметрами:

```CSharp
public VideoCard(string? name)
{
	_name=name;
	_price = 0;
	_speed = 0;
	_quantity = 0;
}
```

#### Второй конструктор с параметрами:

```CSharp
public VideoCard(string? name, int price, int speed, int quantity)
{
	_name = name;
	_price = price;
	_speed = speed;
	_quantity = quantity;
}
```

## Список методов:

public void ChangeData(int price, int speed, int quantity) - обновление всех полей.

public void OnPropertyChanged([CallerMemberName] string prop = "") - обновление данных на форме.