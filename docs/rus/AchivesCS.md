# Achives.cs

� ������ ��������� ����������� ����� Achives, ���������� �� ���������� ������.


## ������ �����:

```c#
private int _needClaim;
private int _prize;
private bool _isDone;
private VariationAchive _typeAchives;
public event PropertyChangedEventHandler? PropertyChanged;
```


_needClaim - �������� �� ����������� ���������� ����� ��� ��������� ����������.


_prize - ��������� �� ����, ����������� ������� �� ���������� ����������.


_isDone - �������� �������� �� ���������� ��� ���.

_tyreAchives - �������� �� ��� ����������.

_PropertyChanged - �������� �� ���������� ������.


## ���������� �������������� ���� VariationAchive:

```c#
enum VariationAchive
{
	None = 0,
	Money = 1,
	SpeedAuto = 2,
	peedClick = 3
}
```

## ������ ������:

NeedClaim - ���������/��������� ���� _needClaim.

Prize - ���������/��������� ���� _prize.

IsDone - ���������/��������� ���� _isDone.

TypeAchives - ���������/��������� ���� _typeAchives.

## ������������:

� ������ ������������ 2 ������������: ����������� �� ��������� � ����������� � �����������.

#### ����������� �� ���������:

```c#
public Achives()
{
	_needClaim = 0;
	_prize = 0;
	_isDone = false;
	_typeAchives = VariationAchive.None;
}
```


#### ����������� � �����������:


```c#
public Achives(int needClaim, int  prize, bool isDone, VariationAchive typeAchives)
{
	_needClaim = needClaim;
	_prize = prize;
	_isDone = isDone;
	_typeAchives = typeAchives;
}
```


## ������ �������:

public void ChangeData(int needClaim, int prize, bool isDone, VariationAchive typeAchives) - ���������� ���� �����


public void OnPropertyChanged([CallerMemberName] string prop = "") - ���������� ������ �� �����







