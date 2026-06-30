// Standard interfaces
using System.Collections;

class Auditory: IEnumerable
{
    Student[] students = [
       new Student
{
    FirstName = "Nikola",
    LastName = "Tesla",
    Email = "nikola.tesla@acmotor.org",
    BirthDate = new DateTime(1856, 7, 10),
    StudentCard = new StudentCard { Series = "NT", Id = 100001 }
},

new Student
{
    FirstName = "Albert",
    LastName = "Einstein",
    Email = "a.einstein@relativity.net",
    BirthDate = new DateTime(1879, 3, 14),
    StudentCard = new StudentCard { Series = "AE", Id = 100002 }
},

new Student
{
    FirstName = "Isaac",
    LastName = "Newton",
    Email = "newton@gravity.uk",
    BirthDate = new DateTime(1643, 1, 4),
    StudentCard = new StudentCard { Series = "IN", Id = 100003 }
},

new Student
{
    FirstName = "Galileo",
    LastName = "Galilei",
    Email = "g.galilei@telescope.it",
    BirthDate = new DateTime(1564, 2, 15),
    StudentCard = new StudentCard { Series = "GG", Id = 100004 }
},

new Student
{
    FirstName = "Johannes",
    LastName = "Kepler",
    Email = "kepler@planetary.de",
    BirthDate = new DateTime(1571, 12, 27),
    StudentCard = new StudentCard { Series = "JK", Id = 100005 }
},

new Student
{
    FirstName = "Michael",
    LastName = "Faraday",
    Email = "m.faraday@electro.co",
    BirthDate = new DateTime(1791, 9, 22),
    StudentCard = new StudentCard { Series = "MF", Id = 100006 }
},

new Student
{
    FirstName = "James",
    LastName = "Maxwell",
    Email = "jmaxwell@fields.scot",
    BirthDate = new DateTime(1831, 6, 13),
    StudentCard = new StudentCard { Series = "JM", Id = 100007 }
},

new Student
{
    FirstName = "Marie",
    LastName = "Curie",
    Email = "marie.curie@radium.fr",
    BirthDate = new DateTime(1867, 11, 7),
    StudentCard = new StudentCard { Series = "MC", Id = 100008 }
},

new Student
{
    FirstName = "Louis",
    LastName = "Pasteur",
    Email = "pasteur@microbe.fr",
    BirthDate = new DateTime(1822, 12, 27),
    StudentCard = new StudentCard { Series = "LP", Id = 100009 }
},

new Student
{
    FirstName = "Charles",
    LastName = "Darwin",
    Email = "darwin@evolution.org",
    BirthDate = new DateTime(1809, 2, 12),
    StudentCard = new StudentCard { Series = "CD", Id = 100010 }
},

new Student
{
    FirstName = "Gregor",
    LastName = "Mendel",
    Email = "g.mendel@genetics.net",
    BirthDate = new DateTime(1822, 7, 20),
    StudentCard = new StudentCard { Series = "GM", Id = 100011 }
},

new Student
{
    FirstName = "Dmitri",
    LastName = "Mendeleev",
    Email = "mendeleev@periodic.ru",
    BirthDate = new DateTime(1834, 2, 8),
    StudentCard = new StudentCard { Series = "DM", Id = 100012 }
},

new Student
{
    FirstName = "Niels",
    LastName = "Bohr",
    Email = "bohr@atom.dk",
    BirthDate = new DateTime(1885, 10, 7),
    StudentCard = new StudentCard { Series = "NB", Id = 100013 }
},

new Student
{
    FirstName = "Erwin",
    LastName = "Schrodinger",
    Email = "cat@quantum.at",
    BirthDate = new DateTime(1887, 8, 12),
    StudentCard = new StudentCard { Series = "ES", Id = 100014 }
},

new Student
{
    FirstName = "Max",
    LastName = "Planck",
    Email = "planck@quantum.de",
    BirthDate = new DateTime(1858, 4, 23),
    StudentCard = new StudentCard { Series = "MP", Id = 100015 }
},

new Student
{
    FirstName = "Richard",
    LastName = "Feynman",
    Email = "feynman@physics.edu",
    BirthDate = new DateTime(1918, 5, 11),
    StudentCard = new StudentCard { Series = "RF", Id = 100016 }
},

new Student
{
    FirstName = "Stephen",
    LastName = "Hawking",
    Email = "hawking@blackholes.org",
    BirthDate = new DateTime(1942, 1, 8),
    StudentCard = new StudentCard { Series = "SH", Id = 100017 }
},

new Student
{
    FirstName = "Alan",
    LastName = "Turing",
    Email = "alan@computing.uk",
    BirthDate = new DateTime(1912, 6, 23),
    StudentCard = new StudentCard { Series = "AT", Id = 100018 }
},

new Student
{
    FirstName = "Blaise",
    LastName = "Pascal",
    Email = "pascal@math.fr",
    BirthDate = new DateTime(1623, 6, 19),
    StudentCard = new StudentCard { Series = "BP", Id = 100019 }
},

new Student
{
    FirstName = "Carl",
    LastName = "Gauss",
    Email = "gauss@numbers.de",
    BirthDate = new DateTime(1777, 4, 30),
    StudentCard = new StudentCard { Series = "CG", Id = 100020 }
},
        ];

    public IEnumerator GetEnumerator()
    {
        return students.GetEnumerator();
    }

    public void Sort()
    {
        Array.Sort(students);
    }

    public void Sort(IComparer comparer)
    {
        Array.Sort(students, comparer);
    }
}