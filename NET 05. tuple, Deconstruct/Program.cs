// tuple c# 7
//(int, double) myTuple = (64, 78.5);

//Console.WriteLine(myTuple.Item1);
//Console.WriteLine(myTuple.Item2);

//(int summ, double price, string name) myTuple2 = (35, 47.2, "Nadir");

//Console.WriteLine(myTuple2.summ);
//Console.WriteLine(myTuple2.price);
//Console.WriteLine(myTuple2.name);


//Tuple<int, int> tuple = new Tuple<int, int>(1, 2);


//var result = CalculateSumAndAverage(25, 6);
//Console.WriteLine(result.Item1);
//int some;
//(int summ, float average, some) = result;
//Console.WriteLine($"{summ}, {average}, {some}");

//(_, float av, _) = CalculateSumAndAverage(97, 6);
//Console.WriteLine(av);


Car car = new("BMW", "Tesla", 2227);
//Console.WriteLine(car);

//string model = car.Model;
//int year = car.Year;
//Console.WriteLine(model);

(string mod, _, _) = car;

Console.WriteLine(mod);

(int, float, int) CalculateSumAndAverage(int numb1, int numb2)
{
    int sum = numb1 + numb2;
    float average = sum / 2.0f;
    return (sum, average, 658);
}