# Level.cs

� ������ ��������� ������ ����� Level, ���������� �� ������� ������.

## ������ �����


```csharp
public event PropertyChangedEventHandler? PropertyChanged;
private int _numberLevel;
private int _needCoin;
private int _prize;
private bool _isDone;
```


_numberLevel - �������� �� ���������� ����� ������.


_needClaim - �������� �� ����������� ���������� ����� ��� ��������� ������.


_prize - ��������� �� ����, ����������� ������� �� ���������� ������.


_isDone - �������� ������� �� ������� ��� ���.


PropertyChanged - �������� �� ���������� ������.


## ������ �������

NumberLevel - ���������/��������� ���� _numberLevel

NeedClaim - ���������/��������� ���� _needClaim.

Prize - ���������/��������� ���� _prize.

IsDone - ���������/��������� ���� _isDone.


## ������������:

� ������ ������������ 2 ������������: ����������� �� ��������� � ����������� � �����������.


#### ����������� �� ���������:

```CSharp
public Level() 
{
	_numberLevel = 0;
	_needCoin = 0;
	_prize = 0;
	_isDone = false;
}
```


#### ����������� � �����������:

```CSharp
public Level(int numberLevel, int needCoin, int prize, bool isDone)
{
	_numberLevel = numberLevel;
	_needCoin = needCoin;
	_prize = prize;
	_isDone = isDone;
}
```


## ������ �������:

public void ChangeData(int numberLevel, int needCoin, int prize, bool isDone) - ���������� ���� �����.

public void OnPropertyChanged([CallerMemberName] string prop = "") - ���������� ������ �� �����.
