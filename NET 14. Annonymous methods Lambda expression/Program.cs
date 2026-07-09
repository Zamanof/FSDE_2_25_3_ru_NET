// Annonymous methods


List<int> numbers = new();
FillList(numbers);
ShowList(numbers);

#region method and delegate
//Func<int, bool> predicate = IsEven;
////var evens = numbers.Where(IsEven).ToList();
//var  evens = numbers.Where(predicate).ToList();
//ShowList(evens);

//bool IsEven(int number)
//    => number % 2 == 0;
#endregion

#region Annonymous methods
/*
delegate(int x) { return x % 2 == 0;}
    equals
bool IsEven(int number)
    => number % 2 == 0;
*/
// [](int x){ return x % 2 != 0;}
//var evens = numbers.Where(delegate (int x) { return x % 2 != 0; }).ToList();
//ShowList(evens);
#endregion

#region Lambda expression
// (parameters_list) => expression_or_statement_block
/*
(int x)=> x % 2 == 0

equals

delegate(int x) { return x % 2 == 0;}
    
equals

bool IsEven(int number)
    => number % 2 == 0;
*/

//var evens = numbers.Where(x => x % 2 == 0).ToList();
//ShowList(evens);
#endregion

var fill = (List<int> numbers) =>
{
    Random random = new();
    for (int i = 0; i <= 25; i++)
    {
        numbers.Add(random.Next(-90, 90));
    }
};
// В некоторых случаях, когда метод очень большой
// то не рекомендуется это писать как лямбда выражение.
// Лучше вынести это в отдельный метод.

void ShowList(List<int> numbers)
{
    foreach (var item in numbers)
    {
        Console.Write($"{item} ");
    }
    Console.WriteLine();
}

void FillList(List<int> numbers)
{
    Random random = new();
    for (int i = 0; i <= 25; i++)
    {
        numbers.Add(random.Next(-90, 90));
    }
}

// python  lambda x: x % 2 == 0
// C++     [](int x){return x % 2 == 0;} <=> анонимные функции <=> Functor (класс который ведет себя как функция)
// C#      (int x) => x % 2 == 0 <=> анонимные методы <=> анонимные делегаты  delegate (int x) {return x % 2 == 0;}
