// indexer
// https://learn.microsoft.com/ru-ru/dotnet/csharp/programming-guide/indexers/

//Garage garage = new Garage(5);
//garage[0] = new Car() { Model = "BMW", Price = 200000.56 };
//garage[1] = new Car() { Model = "Audi", Price = 2.2 };
//garage[2] = new Car() { Model = "Mercedes", Price = 30.25 };
//garage[3] = new Car() { Model = "Toyota", Price = 15000 };
//garage[4] = new Car() { Model = "Honda", Price = 18000 };

//Console.WriteLine(garage.Count);

//for (int i = 0; i < garage.Count; i++)
//{
//    Console.WriteLine(garage[i]);
//}
//Console.WriteLine(garage["Second"]);
//Console.WriteLine(garage[30.25]);

MultiArray multiArray = new MultiArray(3, 3);

Random random = new Random();

for (int i = 0; i < multiArray.Rows; i++)
{
    for (int j = 0; j < multiArray.Columns; j++)
    {
        multiArray[i, j] = random.Next(10, 99);
    }
}

for (int i = 0; i < multiArray.Rows; i++)
{
    for (int j = 0; j < multiArray.Columns; j++)
    {
        Console.Write($"{multiArray[i, j]} ");
    }
    Console.WriteLine();
}