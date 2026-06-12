// structs
/*
1. struct обьекты создаются в stack
2. Когда создаем конструктор с параметрами, конструктор по умолчанию не удаляеться
3. В структурах копирование всегда глубокое копирование (deep copy) (копируется значения)
4. От стркутур невозможно наследоватся
*/

Point point = new Point();
point.x = 26;
point.y = 69;
Point point1 = point;

Console.WriteLine($"point.x = {point.x}, point.y = { point.y}");
Console.WriteLine($"point1.x = {point1.x}, point1.y = { point1.y}");
Console.WriteLine($"point.arr[0] = {point.arr[0]}");
Console.WriteLine($"point1.arr[0] = {point1.arr[0]}");

point.x = 946;
point.arr[0] = 364;

Console.WriteLine($"point.x = {point.x}, point.y = {point.y}");
Console.WriteLine($"point1.x = {point1.x}, point1.y = {point1.y}");
Console.WriteLine($"point.arr[0] = {point.arr[0]}");
Console.WriteLine($"point1.arr[0] = {point1.arr[0]}");
