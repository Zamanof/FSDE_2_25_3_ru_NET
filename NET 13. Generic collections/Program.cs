/*
non generic                  generic                             C++

ArrayList                    List<T>                            vector<T>

Stack                        Stack<T>                           stack<T>       

Queue                        Queue<T>                           queue<T>

Hashtable                   Dictionary<TKey, TValue>            map<TKey, TValue>

SortedList                  SortedList<TKey, TValue>            -

 -                          LinkedList<T>                       list<T>
 
*/

// Проблемы non generic collections (boxing/unboxing)
// boxing/unboxing - это дорогой процесс и проблема с безопасностю типов
// Поэтому начиная с C# 2.0 были введены generic collections, которые решают эти проблемы
Random random = new Random();

List<int> ints = new();
for (int i = 0; i< 25; i++)
{
    ints.Add(random.Next(10, 99));
}

foreach (int i in ints)
{
    Console.Write($"{i} ");
}
Console.WriteLine();
Console.WriteLine(ints[0] + 26);