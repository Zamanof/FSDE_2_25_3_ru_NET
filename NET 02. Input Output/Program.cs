// Console
// output
//Console.WriteLine("Hello");
//Console.Write("Hello ");
//Console.Write("Write");
//Console.BackgroundColor = ConsoleColor.Cyan;
//Console.ForegroundColor = ConsoleColor.Red;
//Console.WriteLine("Hi");
//Console.Clear();
//Console.WriteLine("Why");

// .Beep()
//Console.Beep(2500, 500);
//Thread.Sleep(500);
//Console.Beep(2500, 500);
//Thread.Sleep(100);
//Console.Beep(25800, 100);
//Thread.Sleep(100);
//Console.Beep(3000, 100);
//Thread.Sleep(100);

// input
//var data = Console.Read();
//Console.WriteLine(data);

//var data1 = Console.ReadLine();
//Console.WriteLine(data1);

//var key = Console.ReadKey();
//Console.WriteLine();
//Console.WriteLine(key.KeyChar);
//Console.WriteLine();
//Console.WriteLine(key.Key);

//ConsoleKeyInfo key1;
//while (true)
//{
//    key1 = Console.ReadKey();
//	if (key1.Key == ConsoleKey.Enter) break;
//    Console.WriteLine();
//    Console.WriteLine(key1.Key);
//}

//var number = int.Parse(Console.ReadLine());
//Console.WriteLine(number);

//int number2;
//int.TryParse(Console.ReadLine(), out number2);
//Console.WriteLine(number2);

// Convert

//int number3 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine(number3);


//
string name = "Nadir";
int age = 46;
//Console.Write("My name is ");
//Console.Write(name);
//Console.Write(". I am ");
//Console.Write(age);
//Console.Write(" years old.");
//Console.WriteLine();
// interpolation
Console.WriteLine($"My name is {name}. \nI am {age} years old.");

// @ - verbatim
Console.WriteLine(@$"My name is {name}. \n
I am {age} years old.");