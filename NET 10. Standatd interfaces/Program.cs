// Standard interfaces
Auditory auditory = new Auditory();

foreach (var student in auditory)
{
    Console.WriteLine(student);
}

auditory.Sort(new AgeComparer());

Console.WriteLine();

Console.ForegroundColor = ConsoleColor.Red;
foreach (var student in auditory)
{
    Console.WriteLine(student);
}
Console.ForegroundColor = ConsoleColor.White;

