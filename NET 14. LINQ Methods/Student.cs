// LINQ Join

class Student
{
    public uint Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public uint Age { get; set; }
    public uint GroupId { get; set; }
    static uint _idCounter = 1;
    public Student()
    {
        Id = _idCounter++;
    }
    override public string ToString()
    {
        return $"""
            Id:         {Id}, 
            FirstName:  {FirstName}, 
            LastName:   {LastName}, 
            Age:        {Age}, 
            GroupId:    {GroupId}

            """;
    }
}
