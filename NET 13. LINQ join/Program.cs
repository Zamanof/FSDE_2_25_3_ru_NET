// LINQ Join

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
    new Student { FirstName = "Daniel", LastName = "Anderson", Age = 22, GroupId = 5 },
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
    new Student { FirstName = "Robert", LastName = "Lewandowski", Age = 21, GroupId = 2 },
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
var result = from g in groups
             join s in students on g.Id equals s.GroupId
             select new
             {
                 GroupName = g.Name,
                 StudentName = $"{s.FirstName} {s.LastName}",
                 StudentAge = s.Age,
                 FacultyName = g.Faculty
             };

//foreach (var item in result)
//{
//    Console.WriteLine($"""
//            Student:    {item.StudentName}, 
//            Age:        {item.StudentAge}, 
//            Group:      {item.GroupName}, 
//            Faculty:    {item.FacultyName}

//        """);
//}

//var groupedByGroupName = from i in result
//                         group i by i.GroupName;

//foreach (var group in groupedByGroupName)
//{
//    Console.WriteLine($"Group: {group.Key}");
//    Console.WriteLine();
//    foreach (var item in group)
//    {
//        Console.WriteLine($"""
//            Student:    {item.StudentName}, 
//            Age:        {item.StudentAge}, 
//            Faculty:    {item.FacultyName}
//            Group:      {item.GroupName}

//        """);
//    }
//    Console.WriteLine();
//}

var groupedByFacultyName = from i in result
                           group i by i.FacultyName into x
                           orderby x.Key
                           select x;

foreach (var group in groupedByFacultyName)
{
    Console.WriteLine($"Faculty: {group.Key}");
    Console.WriteLine();
    foreach (var item in group)
    {
        Console.WriteLine($"""
            Student:    {item.StudentName}, 
            Age:        {item.StudentAge}, 
            Faculty:    {item.FacultyName}
            Group:      {item.GroupName}

        """);
    }
    Console.WriteLine();
}

