# Level.cs

В данном документе описан класс Level, отвечающий за уровень игрока.

## Список полей


```csharp
public event PropertyChangedEventHandler? PropertyChanged;
private int _numberLevel;
private int _needCoin;
private int _prize;
private bool _isDone;
```


_numberLevel - отвечает за порядковый номер уровня.


_needClaim - отвечает за необходимое количество монет для получения уровня.


_prize - отвечаает за приз, получаеммый игроком за выполнение уровня.


_isDone - сообщает получен ли уровент или нет.


PropertyChanged - отвечает за обновление данных.


## Список свойств

NumberLevel - получение/установка поля _numberLevel

NeedClaim - получение/установка поля _needClaim.

Prize - получение/установка поля _prize.

IsDone - получение/установка поля _isDone.


## Конструкторы:

В классе реализованно 2 конструктора: конструктор по умолчанию и конструктор с параметрами.


#### Конструктор по умолчанию:

```CSharp
public Level() 
{
	_numberLevel = 0;
	_needCoin = 0;
	_prize = 0;
	_isDone = false;
}
```


#### Конструктор с параметрами:

```CSharp
public Level(int numberLevel, int needCoin, int prize, bool isDone)
{
	_numberLevel = numberLevel;
	_needCoin = needCoin;
	_prize = prize;
	_isDone = isDone;
}
```


## Список методов:

public void ChangeData(int numberLevel, int needCoin, int prize, bool isDone) - обновление всех полей.

public void OnPropertyChanged([CallerMemberName] string prop = "") - обновление данных на форме.
