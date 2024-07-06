# Achives.cs

¬ данном документе представлен класс Achives, отвечающий за достижени€ игрока.


## —писок полей:

```c#
private int _needClaim;
private int _prize;
private bool _isDone;
private VariationAchive _typeAchives;
public event PropertyChangedEventHandler? PropertyChanged;
```


_needClaim - отвечает за необходимое количество монет дл€ получени€ достижени€.


_prize - отвечаает за приз, получаеммый игроком за выполнение достижени€.


_isDone - сообщает получено ли достижение или нет.

_tyreAchives - отвечает за тип достижени€.

_PropertyChanged - отвечает за обновление данных.


## –еализаци€ перечисл€емого типа VariationAchive:

```c#
enum VariationAchive
{
	None = 0,
	Money = 1,
	SpeedAuto = 2,
	peedClick = 3
}
```

## —писок свойст:

NeedClaim - получение/установка пол€ _needClaim.

Prize - получение/установка пол€ _prize.

IsDone - получение/установка пол€ _isDone.

TypeAchives - получение/установка пол€ _typeAchives.

##  онструкторы:

¬ классе реализованно 2 конструктора: конструктор по умолчанию и конструктор с параметрами.

####  онструктор по умолчанию:

```c#
public Achives()
{
	_needClaim = 0;
	_prize = 0;
	_isDone = false;
	_typeAchives = VariationAchive.None;
}
```


####  онструктор с параметрами:


```c#
public Achives(int needClaim, int  prize, bool isDone, VariationAchive typeAchives)
{
	_needClaim = needClaim;
	_prize = prize;
	_isDone = isDone;
	_typeAchives = typeAchives;
}
```


## —писок методов:

public void ChangeData(int needClaim, int prize, bool isDone, VariationAchive typeAchives) - обновление всех полей


public void OnPropertyChanged([CallerMemberName] string prop = "") - обновление данных на форме







