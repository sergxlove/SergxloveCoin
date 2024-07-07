# VideoCard.cs


� ������ ��������� ������ ����� Mouse, ���������� �� ��������� ���������.

## ������ �����: 

```CSharp
private string? _name;
private int _price;
private int _speed;
private int _quantity;
public event PropertyChangedEventHandler? PropertyChanged;
```


_name - �������� �� ��� ����������.

_price - �������� �� ��������� ����������.

_speed - �������� �� �������� ����������.

_quantity - �������� �� ���������� ����������.

PropertyChanged - �������� �� ���������� ������


## ������ �������

Name - ���������/��������� ���� _name.

Price - ���������/��������� ���� _price.

SpeedClick - ���������/��������� ���� _speedClick. 

Quantity - ���������/��������� ���� _quantity.


## ������������:

� ������ ������������ 3 ������������: ����������� �� ��������� � 2 ������������ � ���������� �����������.

#### ����������� �� ���������:

```CSharp
public VideoCard()
{
	_name = "no";
	_price = 0;
	_speed = 0;
	_quantity = 0;
}
```

#### ������ ����������� � �����������:

```CSharp
public VideoCard(string? name)
{
	_name=name;
	_price = 0;
	_speed = 0;
	_quantity = 0;
}
```

#### ������ ����������� � �����������:

```CSharp
public VideoCard(string? name, int price, int speed, int quantity)
{
	_name = name;
	_price = price;
	_speed = speed;
	_quantity = quantity;
}
```

## ������ �������:

public void ChangeData(int price, int speed, int quantity) - ���������� ���� �����.

public void OnPropertyChanged([CallerMemberName] string prop = "") - ���������� ������ �� �����.