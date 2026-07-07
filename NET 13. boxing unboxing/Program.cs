// boxing - unboxing

// boxing - это процесс упаковки значимого типа в объект.
// Когда значение типа (например, int, double и т.д.) присваивается переменной типа object,
// происходит упаковка.
// Это позволяет использовать
// значение типа как объект, но при этом создается копия значения в куче.


object boxedInt = 42; // boxing
Console.WriteLine(boxedInt.GetType());
//Console.WriteLine(boxedInt + 25);

// unboxing - это процесс извлечения значения из объекта обратно в знчимый тип.
var number = (double)boxedInt; // unboxing
Console.WriteLine(number + 25);
// Это дорогой процесс, так как происходит проверка типа
// и копирование значения обратно в стек.
// Еще проблема с безопасностью типов,
// так как можно попытаться извлечь значение из объекта в неправильный тип,
// что приведет к исключению во время выполнения.
// System.InvalidCastException: Unable to cast object of type 'System.Int32' to type 'System.Double'.