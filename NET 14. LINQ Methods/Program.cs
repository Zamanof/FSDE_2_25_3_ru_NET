// LINQ methods - Это методы расширения,
// которые позволяют работать с коллекциями данных
// в стиле функционального програмирования.
// Под копотом у этих методов LINQ запросы


List<Group> groups = new List<Group>
{
    new Group { Name = "FSDE_2_25_3_ru", Faculty="Development" },
    new Group { Name = "FSDA_2_23_3_az", Faculty="Cyber Cecurity" },
    new Group { Name = "FSDM_2_25_1_ru", Faculty="Development" },
    new Group { Name = "FSDE_2_25_1_ru", Faculty="Design" },
    new Group { Name = "FSDE_2_25_2_ru", Faculty="Development" },
    new Group { Name = "FSDE_2_25_4_ru", Faculty="Design" },
    new Group { Name = "FSDE_2_25_5_ru", Faculty="Cyber Security" }
};

List<Student> students = new List<Student>
{
    new Student { FirstName = "John", LastName = "Doe", Age = 20, GroupId = 1 },
    new Student { FirstName = "Jane", LastName = "Smith", Age = 22, GroupId = 2 },
    new Student { FirstName = "Michael", LastName = "Johnson", Age = 21, GroupId = 1 },
    new Student { FirstName = "Emily", LastName = "Davis", Age = 19, GroupId = 3 },
    new Student { FirstName = "David", LastName = "Wilson", Age = 23, GroupId = 2 },
    new Student { FirstName = "Sarah", LastName = "Miller", Age = 20, GroupId = 4 },
    new Student { FirstName = "Daniel", LastName = "Anderson", Age = 152, GroupId = 5 },
    new Student { FirstName = "Olivia", LastName = "Thomas", Age = 21, GroupId = 6 },
    new Student { FirstName = "James", LastName = "Jackson", Age = 19, GroupId = 7 },
    new Student { FirstName = "Sophia", LastName = "White", Age = 23, GroupId = 3 },
    new Student { FirstName = "William", LastName = "Harris", Age = 20, GroupId = 4 },
    new Student { FirstName = "Ava", LastName = "Martin", Age = 22, GroupId = 5 },
    new Student { FirstName = "Alexander", LastName = "Thompson", Age = 21, GroupId = 6 },
    new Student { FirstName = "Isabella", LastName = "Garcia", Age = 19, GroupId = 7 },
    new Student { FirstName = "Ethan", LastName = "Martinez", Age = 23, GroupId = 1 },
    new Student { FirstName = "Lionel", LastName = "Messi", Age = 20, GroupId = 2 },
    new Student { FirstName = "Cristiano", LastName = "Ronaldo", Age = 22, GroupId = 3 },
    new Student { FirstName = "Neymar", LastName = "Jr", Age = 21, GroupId = 4 },
    new Student { FirstName = "Kylian", LastName = "Mbappe", Age = 19, GroupId = 5 },
    new Student { FirstName = "Luka", LastName = "Modric", Age = 23, GroupId = 6 },
    new Student { FirstName = "Sergio", LastName = "Ramos", Age = 20, GroupId = 7 },
    new Student { FirstName = "Kevin", LastName = "De Bruyne", Age = 22, GroupId = 1 },
    new Student { FirstName = "Robert", LastName = "Lewandowski", Age = 35, GroupId = 2 },
    new Student { FirstName = "Mohamed", LastName = "Salah", Age = 19, GroupId = 3 },
    new Student { FirstName = "Virgil", LastName = "van Dijk", Age = 23, GroupId = 4 },
    new Student { FirstName = "Harry", LastName = "Kane", Age = 20, GroupId = 5 },
    new Student { FirstName = "Erling", LastName = "Haaland", Age = 22, GroupId = 6 },
    new Student { FirstName = "Ronaldo", LastName = "Nazario de Lima", Age = 21, GroupId = 7 },
    new Student { FirstName = "Zinedine", LastName = "Zidane", Age = 19, GroupId = 1 },
    new Student { FirstName = "Ronaldinho", LastName = "Fenomeno", Age = 23, GroupId = 2 },
    new Student { FirstName = "Andres", LastName = "Iniesta", Age = 20, GroupId = 3 },
    new Student { FirstName = "Xavi", LastName = "Hernandez", Age = 22, GroupId = 4 },

};

#region First, FirstOrDefault
//var student = students.First(s=> s.Age > 30);
//Console.WriteLine(student);

//var student = students.FirstOrDefault(s=> s.Age == 30);
//if (student != null) Console.WriteLine(student);
//else Console.WriteLine("Student not found");
#endregion

#region Single, SingleOrDefault
// .Single() - возвращает единственный элемент последовательности,
// который удовлетворяет условию.
// Если элементов больше одного или нет ни одного, то выбрасывается исключение.
//var stud = students.Single(s => s.Age == 158);
//Console.WriteLine(stud);

// .SingleOrDefault() - возвращает единственный элемент последовательности,
// Если элементов больше одного, то выбрасывается исключение.
// Если нет ни одного элемента,
// то возвращается значение по умолчанию (null для ссылочных типов).
//var stud1 = students.SingleOrDefault(s => s.Age == 152);
//Console.WriteLine(stud1);
#endregion

#region Where
//var result = students.Where(s => s.Age > 22).ToList();
/*
 var result = from s in students
              where s.Age > 22
              select s; 
 */
//foreach (var item in result)
//{
//    Console.WriteLine(item);
//}


#endregion

#region Contains
//var student = new Student
//{
//    FirstName = "Nadir",
//    LastName = "Zamanov",
//    Age = 45,
//    GroupId = 1
//};
//Console.WriteLine(students.Contains(student));
//students.Add(student);
//Console.WriteLine(students.Contains(student));

#endregion

#region Min, Max, Average, Sum
//var min = students.Min(s => s.Age);
//Console.WriteLine(min);
//var max = students.Max(s => s.Age);
//Console.WriteLine(max);
//Console.WriteLine(students.Min(s => s.FirstName));
//Console.WriteLine(students.Max(s => s.FirstName));

//var average = students.Average(s => s.Age);
//Console.WriteLine(average);

//var sum = students.Sum(s => s.Age);
//Console.WriteLine(sum);

#endregion

#region OrderBy, OrderByDescending, ThenBy, ThenByDescending
//var result = students.OrderBy(s => s.Age).ToList();
//result.ForEach(Console.WriteLine);

//var resultDesc = students.OrderByDescending(s => s.Age).ToList();
//resultDesc.ForEach(Console.WriteLine);


//var studentsOrdered = students.OrderBy(s=> s.Age).ThenByDescending(s=> s.FirstName).ToList();
//studentsOrdered.ForEach(Console.WriteLine);
#endregion

#region Count
//var count = students.Count(s => s.Age == 20);
//Console.WriteLine(count);
#endregion

#region Take, Skip, TakeLast, SkipLast, SkipWhile, TakeWhile
//var studs = students.Skip(3).Take(3).ToList();
//studs.ForEach(Console.WriteLine);

//var studs2 = students.TakeWhile(s => s.Age < 30).ToList();
//studs2.ForEach(Console.WriteLine);
#endregion

#region All, Any
//var all = students.All(s => s.Age < 200);
//Console.WriteLine(all);

//var any = students.Any(s => s.Age > 100);
//Console.WriteLine(any);
#endregion

#region Join, GroupJoin
/*
 var result = from g in groups
             join s in students on g.Id equals s.GroupId
             select new
             {
                 GroupName = g.Name,
                 StudentName = $"{s.FirstName} {s.LastName}",
                 StudentAge = s.Age,
                 FacultyName = g.Faculty
             };
*/
//var result = groups.Join(students,
//                            g => g.Id,
//                            s => s.GroupId,
//                            (g, s) => new
//                            {
//                                FirstName = s.FirstName,
//                                LastName = s.LastName,
//                                Age = s.Age,
//                                GroupName = g.Name,
//                                Faculty = g.Faculty
//                            });

//foreach (var item in result)
//{
//    Console.WriteLine($"""
//            FirstName: {item.FirstName}
//            LastName:  {item.LastName}
//            Age:       {item.Age}
//            GroupName: {item.GroupName}
//            Faculty:   {item.Faculty}

//        """);
//}

var result = groups.GroupJoin(students,
                    g => g.Id,
                    s => s.GroupId,
                    (g, s) => new
                    {
                        GroupName = g.Name,
                        Students = s
                    });

foreach (var item in result)
{
    Console.WriteLine($"GroupName: {item.GroupName}");
    foreach (var student in item.Students)
    {
        Console.WriteLine($"    FirstName: {student.FirstName}, LastName: {student.LastName}, Age: {student.Age}");
    }
}
#endregion
