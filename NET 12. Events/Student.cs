namespace NET_12._Events;

public class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public double MarkAverage { get; set; }

    public void Exam(string task)
    {
        if(MarkAverage >= 7) 
            Console.WriteLine($"Student {FirstName} {LastName} solved {task}.");
        else
            Console.WriteLine($"Student {FirstName} {LastName} ne dopuskayetsya do ekzamena");
    }
}