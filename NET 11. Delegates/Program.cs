// Delegates
// delegate return_type delegate_name([parameter list])

#region delegate
// double numb1 = default, numb2 = default;
// Console.WriteLine("Enter first number");
// double.TryParse(Console.ReadLine(), out numb1);
// Console.WriteLine("Enter second number");
// double.TryParse(Console.ReadLine(), out numb2);
//
// Console.WriteLine("Enter operator: +, -, *, /");
// char operation = char.Parse(Console.ReadLine()!);
// CalculatorDelegate calculatorDelegate = null;
//
//
// switch ((Arithmetics)operation)
// {
//     case Arithmetics.ADD:
//         calculatorDelegate = Add;
//         break;
//     case Arithmetics.SUBTRACT:
//         calculatorDelegate = Subtract;
//         break;
//     case Arithmetics.MULTIPLY:
//         calculatorDelegate = Multiply;
//         break;
//     case Arithmetics.DIVIDE:
//         calculatorDelegate = Divide;
//         break;
// }
// if (calculatorDelegate != null)
//     Console.WriteLine($"{calculatorDelegate(numb1, numb2)}");
#endregion

#region Multicast Delegates
// CalculatorDelegate operations = Add;
// operations += Subtract;
// operations += Multiply;
// operations += Divide;
//
//
// double numb1 = 45, numb2 = 60;
// Console.WriteLine(operations(numb1, numb2));
// var delegateList = operations.GetInvocationList();
// Console.WriteLine(delegateList[2].DynamicInvoke(numb1, numb2));
// foreach (CalculatorDelegate item in delegateList)
// {
//     // Console.WriteLine(item(numb1, numb2));
//     Console.WriteLine(item.Invoke(numb1, numb2));
// }

// Console.WriteLine(delegateList[0].Method);
// Console.WriteLine(delegateList[1].Method);
// Console.WriteLine(delegateList[2].Method);
// Console.WriteLine(delegateList[3].Method);

#endregion


List<int> ints = [25, 78, -8, 0, -45, -4, 45];

#region Delegates examples
// Console.WriteLine(Calculator(25, 78, Subtract));
// var lst = Filter(ints, IsPositive);
// Anonymous delegate
// delegate (int x) { return x % 2 == 0; } <=> bool some(int x) => x % 2 == 0;
// var lst = Filter(ints, delegate (int x) { return x % 2 == 0; });
// foreach (var item in lst)
// {
//     Console.Write($"{item} ");
// }
//
// Console.WriteLine();

#endregion

#region Generic Delegates
// GenericCalculatorDelegate<int> calc = DivideInt;
// GenericCalculatorDelegate<double> calc1 = Divide;
// GenericCalculatorDelegate<string> calc2 = Concat;
// Console.WriteLine(calc2("Salam", "Saqol"));
#endregion

#region Sdandard Generic Delegates
#region Action<T>
// Action<T> - шаблонный делегат котрый может хранит ссылку на методы
// которые ничего не возвращают (void) и могут принимать до 16-и параметров
// Action<int> some <=> delegate void some(int a)
// Action<int> myAction = Show;
// myAction(15);

// Action<int, double, string> action <=> delegate void some(int a, double b, string c)
// Action<int, double, string> action1 = Some;
// action1(25, 78, "Salam");

// void Show(int a)
// {
//     Console.WriteLine(a);
// }
//
// void Some(int a, double b, string c)
// {
//     Console.WriteLine($"{c}: {a + b}");
// }
#endregion

#region Func<T>
// Func<T> - шаблонный делегат который может хранить ссылку на методы
// принимающие до 16-и параметров и возвращают значения

// Func<double, double, double> func = Add;
// Func<int, int, int> func1 = DivideInt;
// Func<double, double, double> func <=> delegate double delegate_name(double left, double right);

// Console.WriteLine(CalculatorWithFunc(25, 87, Multiply));
#endregion

#region Preicate<T>
// Predicate<T> - шаблонный делегат который может хранить ссылку на методы
// принимающий один параметр и возвращают bool значение
// Predicate<int> predicate = IsNegative;
// Predicate<int> predicate <=> delegate bool FilterDelegate(int value);
// var lst = Filter(ints, IsNegative);
// foreach (var item in lst)
//     Console.Write($"{item} ");
// Console.WriteLine();
#endregion

#region Comparison<T>
// Comparison<T> шаблонный делегат который может хранить ссылку на методы
// принимающие два одинаковых параметра и возвращают int значение
// Comparison<Human> comparison <=> delegate int comparison(Human left, Human right); 
// List<Human> humans =
// [
//     new(){Name = "Ali", Age = 25},
//     new(){Name = "Alekper", Age=15},
//     new(){Name = "Salim", Age=45},
//     new(){Name = "Vahid", Age=35},
//     new(){Name = "Zahid", Age=115}
// ];
// foreach (Human human in humans)
// {
//     Console.WriteLine(human);
// }
//
// // humans.Sort(NameComparison);
// humans.Sort(delegate(Human h1, Human h2)
// {
//     return h1.Age.CompareTo(h2.Age);
// });
//
// Console.WriteLine();
// foreach (Human human in humans)
// {
//     Console.WriteLine(human);
// }
#endregion
#endregion

double Add(double a, double b) => a + b;
double Subtract(double a, double b) => a - b;
double Multiply(double a, double b) => a * b;
double Divide(double a, double b) => b != 0 ? a / b : throw new DivideByZeroException();

string Concat(string a, string b) => a + b;

int DivideInt(int a, int b) => b != 0 ? a / b : throw new DivideByZeroException();

double Calculator(double a, double b, CalculatorDelegate calc)
{
    return calc(a, b);
}

double CalculatorWithFunc(double a, double b, Func<double, double, double> calc)
{
    return calc(a, b);
}

bool IsNegative(int value) => value < 0;
bool IsPositive(int value) => value > 0;

// List<int> Filter(List<int> ints, FilterDelegate filter)
// {
//     List<int> tmp = [];
//     foreach (var item in ints)
//     {
//       if (filter(item)) tmp.Add(item);
//           
//     }
//     return tmp;
// }
List<int> Filter(List<int> ints, Predicate<int> filter)
{
    List<int> tmp = [];
    foreach (var item in ints)
    {
      if (filter(item)) tmp.Add(item);
          
    }
    return tmp;
}

int AgeComparison(Human left, Human right)
{
    if (left.Age > right.Age) return 1;
    else if (left.Age < right.Age) return -1;
    else return 0;
}

int NameComparison(Human left, Human right)
{
    return left.Name.CompareTo(right.Name);
}

delegate double CalculatorDelegate(double left, double right); // double methodName(double a, double b)
delegate bool FilterDelegate(int value); // bool methodName(int value)

// Generic(template) delegate
delegate T GenericCalculatorDelegate<T>(T left, T right);

enum Arithmetics
{
    ADD = '+',
    SUBTRACT = '-',
    MULTIPLY = '*',
    DIVIDE  = '/'
}

class Human
{
    public string? Name { get; set; }
    public int Age { get; set; }
    
    public override string ToString()
        => $"{Name} -  {Age}";
}