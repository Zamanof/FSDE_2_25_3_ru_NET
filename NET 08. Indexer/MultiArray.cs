// indexer
// https://learn.microsoft.com/ru-ru/dotnet/csharp/programming-guide/indexers/

class MultiArray
{
    int[,] ints;
    public int Rows { get; set; }
    public int Columns { get; set; }

    public MultiArray(int rows, int columns)
    {
        Rows = rows;
        Columns = columns;
        ints = new int[rows, columns];
    }
    // multidimensional indexer
    public int this[int row, int column]
    {
        get => ints[row, column];
        set => ints[row, column] = value;
    }
}
