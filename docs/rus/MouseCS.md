# Mouse.cs

� ������ ��������� ������ ����� Mouse, ���������� �� ��������� ����.

## ������ �����

```CSharp
private string? _name;
private int _price;
private int _speedClick;
private int _quantity;
public event PropertyChangedEventHandler? PropertyChanged;
```

_name - �������� �� ��� ����������.

_price - �������� �� ��������� ����������.

_speedClick - �������� �� �������� ����������.

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
public Mouse()
{
	_name = "no";
	_price = 0;
	_speedClick = 0;
	_quantity = 0;
}
```

#### ������ ����������� � �����������:
```CSharp
public Mouse(string? name)
{
	_name = name;
	_price = 0;
	_speedClick = 0;
	_quantity = 0;
}
```

#### ������ ����������� � �����������:

```CSharp
public Mouse(string? name, int price, int speedClick, int quantity)
{
	_name = name;
	_price = price;
	_speedClick = speedClick;
	_quantity = quantity;
}
```

## ������ �������:

public void ChangeData(int price, int speed, int quantity) - ���������� ���� �����.

public void OnPropertyChanged([CallerMemberName] string prop = "") - ���������� ������ �� �����.