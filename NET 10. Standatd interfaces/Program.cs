// Standard interfaces
// Auditory auditory = new Auditory();
//
// foreach (var student in auditory)
// {
//     Console.WriteLine(student);
// }
//
// auditory.Sort(new AgeComparer());
//
// Console.WriteLine();
//
// Console.ForegroundColor = ConsoleColor.Red;
// foreach (var student in auditory)
// {
//     Console.WriteLine(student);
// }
// Console.ForegroundColor = ConsoleColor.White;


Student student = new Student
{
    FirstName = "Bob",
    LastName = "Boboff",
    Email = "bob@gmail.com",
    BirthDate = new DateTime(2001, 5, 25),
    StudentCard = new StudentCard
    {
        Series = "BB",
        Id = 265498
    }
};

#region Shallow Copy

// Student student1 = student;
// student1.FirstName = "Salam";
// Console.WriteLine(student);
// Console.WriteLine(student1);

#endregion

Student student2 = student.Clone() as Student;
student2.FirstName = "Salam";
student2.StudentCard.Series = "AA";
Console.WriteLine(student);
Console.WriteLine(student2);


