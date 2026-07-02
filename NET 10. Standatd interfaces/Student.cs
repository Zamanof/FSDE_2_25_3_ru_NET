// Standard interfaces
class Student: IComparable, ICloneable
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public DateTime BirthDate { get; set; }
    public StudentCard StudentCard { get; set; }

    public int CompareTo(object? obj)
    {
        if (obj is Student student)
        {
            return LastName.CompareTo(student.LastName);
        }
        throw new Exception("Can not compare objects");
    }

    public override string ToString()
    {
        return $"""
                Name:           {FirstName}
                Surname:        {LastName}
                Email:          {Email}
                BirthDay:       {BirthDate.ToShortDateString()}
                StudentCard:    {StudentCard}

            """;
    }

    public object Clone()
    {
        // deep copy
        Student tmp = this.MemberwiseClone() as Student;
        tmp.StudentCard = new StudentCard
        {
            Id = this.StudentCard.Id,
            Series = this.StudentCard.Series,
        };
        return tmp;
    }
}
