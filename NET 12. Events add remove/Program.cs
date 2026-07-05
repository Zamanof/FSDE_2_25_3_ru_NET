List<Student> students = new()
{
    new Student { FirstName = "Ali",       LastName = "Mammadov",    Age = 19, MarkAverage = 10.5 },
    new Student { FirstName = "Leyla",     LastName = "Aliyeva",     Age = 20, MarkAverage = 11.2 },
    new Student { FirstName = "Kamran",    LastName = "Hasanov",     Age = 18, MarkAverage = 6.8 },
    new Student { FirstName = "Nigar",     LastName = "Quliyeva",    Age = 21, MarkAverage = 11.8 },
    new Student { FirstName = "Orxan",     LastName = "Rustamov",    Age = 22, MarkAverage = 8.7 },
    new Student { FirstName = "Aysel",     LastName = "Ismayilova",  Age = 19, MarkAverage = 10.9 },
    new Student { FirstName = "Murad",     LastName = "Kerimov",     Age = 20, MarkAverage = 6.5 },
    new Student { FirstName = "Gunel",     LastName = "Abbasova",    Age = 18, MarkAverage = 12.0 },
    new Student { FirstName = "Elvin",     LastName = "Huseynov",    Age = 23, MarkAverage = 5.4 },
    new Student { FirstName = "Sabina",    LastName = "Taghiyeva",   Age = 21, MarkAverage = 9.6 },
    new Student { FirstName = "Tural",     LastName = "Jafarov",     Age = 19, MarkAverage = 8.3 },
    new Student { FirstName = "Laman",     LastName = "Rzayeva",     Age = 20, MarkAverage = 11.5 },
    new Student { FirstName = "Rashad",    LastName = "Suleymanov",  Age = 22, MarkAverage = 10.0 },
    new Student { FirstName = "Aynur",     LastName = "Mahmudova",   Age = 18, MarkAverage = 10.8 },
    new Student { FirstName = "Farid",     LastName = "Veliyev",     Age = 24, MarkAverage = 6.9 },
    new Student { FirstName = "Sevda",     LastName = "Asgarova",    Age = 20, MarkAverage = 9.3 },
    new Student { FirstName = "Elnur",     LastName = "Bayramov",    Age = 21, MarkAverage = 7.7 },
    new Student { FirstName = "Narmin",    LastName = "Rahimova",    Age = 19, MarkAverage = 11.7 },
    new Student { FirstName = "Samir",     LastName = "Orujov",      Age = 22, MarkAverage = 8.1 },
    new Student { FirstName = "Amina",     LastName = "Mehdiyeva",   Age = 18, MarkAverage = 11.3 }
};
Teacher teacher = new();
foreach (var student in students)
{
    // event subscribe
    teacher.ExamEvent += student.Exam;
}

teacher.StartExam("Make Backend for site");

public delegate void ExamDelegate(string task);