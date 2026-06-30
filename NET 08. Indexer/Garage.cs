// indexer
// public return_type this[parameters...] { get; set; }
class Garage
{
    private Car[] cars;

    public Garage(int size)
    {
        cars = new Car[size];
    }
    public int Count
    {
        get => cars.Length;
    }

    // indexer with int parameter
    public Car this[int index]
    {
        get
        {
            if (index >= 0 || index < cars.Length)
            {
                return cars[index];
            }
            throw new IndexOutOfRangeException();
        }
        set
        {
            if (index >= 0 || index < cars.Length)
            {
                cars[index] = value;
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }
    }

    // indexer with string parameter
    public Car this[string number]
    {
        get
        {
            if(Enum.IsDefined(typeof(Numbers), number))
            {
                int index = (int)Enum.Parse(typeof(Numbers), number);
                return cars[index];
            }
            throw new IndexOutOfRangeException();
        }
        set
        {
            if (Enum.IsDefined(typeof(Numbers), number))
            {
                int index = (int)Enum.Parse(typeof(Numbers), number);
                cars[index] = value;
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }
    }

    // indexer with double parameter
    public Car this[double price]
    {
        get
        {
            foreach (var car in cars)
            {
                if (car.Price == price)
                {
                    return car;
                }
            }
            throw new IndexOutOfRangeException();
        }
        set
        {
            for (int i = 0; i < cars.Length; i++)
            {
                if (cars[i].Price == price)
                {
                    cars[i] = value;
                    return;
                }
            }
            throw new IndexOutOfRangeException();
        }
    }
}
