public class Car
{
    public Car(string model, string manufacturer, int year)
    {
        Model = model;
        Manufacturer = manufacturer;
        Year = year;
    }

    public string Model { get; set; }
    public string Manufacturer { get; set; }
    public int Year { get; set; }

    public override string ToString()
    {
        return $"{Manufacturer} {Model} - {Year}";
    }

    // Deconstruct
    public void Deconstruct(out string model, out string manufacturer, out int year)
    {
        model = Model; 
        manufacturer = Manufacturer; 
        year = Year;
    }
}
