# Statistics.cs

В данном документе описан класс Statistics, отвечающий за статистику игрока.

## Список полей: 

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

_quantityClick - отвечает за количество кликов.

_totalSumClickMoney - отвечает за общее количество заработааных монет за клики.

_totalSumAutoMoney - отвечает за общее количество заработанных монет в автоматическом режиме.

_level - отвечает за уровень игрока.

_quantityAchives - отвечает за количество достижений.

_quantityMouse - отвечает за количество компонетов "Мышь".

_quantityVideoCrad - отвечает за количество компонетов "Видеокарта".

_quantityProcessor - отвечает за количество компонетов "Процессор".

_dateBegin - отвечает за дату начала игры.

_quantityDaysPlayed - отвечает за количество дней в игре.

PropertyChanged - отвечает за обновление данных.

## Список свойств:

QuantityClick - получение/установка поля _quantityClick.

TotalSumClickMoney - получение/установка поля _totalSumClickMoney.

TotalSumAutoMoney - получение/установка поля _totalSumAutoMoney.

Level - получение/установка поля _level.

QuantityAchives - получение/установка поля _quantityAchives.

QuantityMouse - получение/установка поля _quantityMouse.

QuantityVideoCrad - получение/установка поля _quantityVideoCard.

QuantityProcessor - получение/установка поля _quantityProcessor.

DateBegin - получение/установка поля _dateBegin.

QuantityDaysPlayed - получение поля _quantityDaysPlayed.

## Конструкторы:

В классе реализованно 2 конструктора: конструктор по умолчанию и конструктор с параметрами.

#### Конструктор по умолчанию:

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

#### Второй конструктор с параметрами:

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

## Список методов:

public void ChangeData(int quantityClick, int totalSumClickMoney, int totalSumAutoMoney, int level, int quantityAchives, int quantityMouse, int quantityVideoCrad, int quantityProcessor, DateTime dateBegin) - обновление всех полей.

public void OnPropertyChanged([CallerMemberName] string prop = "") - обновление данных на форме.

