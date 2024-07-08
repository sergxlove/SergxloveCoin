# Statistics.cs

� ������ ��������� ������ ����� Statistics, ���������� �� ���������� ������.

## ������ �����: 

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

_quantityClick - �������� �� ���������� ������.

_totalSumClickMoney - �������� �� ����� ���������� ������������ ����� �� �����.

_totalSumAutoMoney - �������� �� ����� ���������� ������������ ����� � �������������� ������.

_level - �������� �� ������� ������.

_quantityAchives - �������� �� ���������� ����������.

_quantityMouse - �������� �� ���������� ���������� "����".

_quantityVideoCrad - �������� �� ���������� ���������� "����������".

_quantityProcessor - �������� �� ���������� ���������� "���������".

_dateBegin - �������� �� ���� ������ ����.

_quantityDaysPlayed - �������� �� ���������� ���� � ����.

PropertyChanged - �������� �� ���������� ������.

## ������ �������:

QuantityClick - ���������/��������� ���� _quantityClick.

TotalSumClickMoney - ���������/��������� ���� _totalSumClickMoney.

TotalSumAutoMoney - ���������/��������� ���� _totalSumAutoMoney.

Level - ���������/��������� ���� _level.

QuantityAchives - ���������/��������� ���� _quantityAchives.

QuantityMouse - ���������/��������� ���� _quantityMouse.

QuantityVideoCrad - ���������/��������� ���� _quantityVideoCard.

QuantityProcessor - ���������/��������� ���� _quantityProcessor.

DateBegin - ���������/��������� ���� _dateBegin.

QuantityDaysPlayed - ��������� ���� _quantityDaysPlayed.

## ������������:

� ������ ������������ 2 ������������: ����������� �� ��������� � ����������� � �����������.

#### ����������� �� ���������:

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

#### ������ ����������� � �����������:

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

## ������ �������:

public void ChangeData(int quantityClick, int totalSumClickMoney, int totalSumAutoMoney, int level, int quantityAchives, int quantityMouse, int quantityVideoCrad, int quantityProcessor, DateTime dateBegin) - ���������� ���� �����.

public void OnPropertyChanged([CallerMemberName] string prop = "") - ���������� ������ �� �����.

