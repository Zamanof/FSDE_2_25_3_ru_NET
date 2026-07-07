// LINQ Join

class Group
{
    public uint Id { get; set; }
    public string Name { get; set; }
    public string Faculty { get; set; }
    static uint _idCounter = 1;
    public Group()
    {
        Id = _idCounter++;
    }
    override public string ToString()
    {
        return $"""
            Id:         {Id}, 
            Name:       {Name}
            Faculty:    {Faculty}
            """;
    }
}