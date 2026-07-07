// LINQ - Language Integrated Query 
// Это декларативный способ работы с данными в C#.
// LINQ позволяет писать запросы к коллекциям данных
// (например, массивам, спискам, базам данных) в стиле SQL,
// но используя синтаксис C#.
/*
LINQ to Objects - позволяет выполнять запросы к коллекциям объектов в памяти. 
LINQ to SQL - позволяет выполнять запросы к базам данных SQL Server.
LINQ to XML - позволяет выполнять запросы к XML-документам.
LINQ to Entities - позволяет выполнять запросы к объектам Entity Framework.
LINQ to DataSet - позволяет выполнять запросы к объектам DataSet.
PLINQ - Parallel LINQ - позволяет выполнять параллельные запросы к коллекциям данных, используя многопоточность.
*/
List<int> numbers = [98, 87, 1, -45, -25, 15, 0, 155, -452, 9, -455, 147, 58];
ShowNumbers(numbers);

#region from select
// from - источник данных
// select - выборка данных
//IEnumerable<int> query = from num in numbers
//                         select num;
// LINQ-запросы не выполняются до тех пор,
// пока не будет произведена итерация по результату запроса.
// это называется "отложенное выполнение" (deferred execution).
//ShowNumbers(query);
//numbers[0] = 679;
//ShowNumbers(numbers);
//ShowNumbers(query);
#endregion

#region where
// where - это условие для выборки
//IEnumerable<int> query = from num in numbers
//                         where num > 0 && num % 2 == 0
//                         select num;
//ShowNumbers(query);
#endregion

#region orderby ascending (by default)/descending
// orderby - сортировка данных
//IEnumerable<int> query = from num in numbers
//                         where num > 0
//                         orderby num descending
//                         select num;
//ShowNumbers(query);
#endregion

#region group by
// group by - группировка данных
//IEnumerable<IGrouping<int, int>> query = from num in numbers
//                                         where num > 0
//                                         group num by num % 3;

//foreach (var group in query)
//{
//    Console.WriteLine($"Group: {group.Key}");
//    ShowNumbers(group);
//}
#endregion

#region into
// into - хранит результат предыдущего запроса (промежуточный результат)
// и позволяет продолжить работу с ним
//var query_into = from num in numbers
//                 where num > 0
//                 group num by num % 3 into g
//                 orderby g.Key
//                 select g;

//foreach (var group in query_into)
//{
//    Console.WriteLine($"Group: {group.Key}");
//    ShowNumbers(group);
//}
#endregion
void ShowNumbers(IEnumerable<int> nums)
{
    foreach (var num in nums)
    {
        Console.Write($"{num} ");
    }
    Console.WriteLine();
}