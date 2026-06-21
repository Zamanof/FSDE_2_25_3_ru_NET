// Operator overloading
class Point
{
    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }
    public Point()
        : this(default, default)
    { }

    public int X { get; set; }
    public int Y { get; set; }

    public override string ToString()
    {
        return $"Point ({X}, {Y})";
    }

    // Operator overloading

    // Unary operators overloading

    // Unary -
    public static Point operator -(Point point)
        => new(-point.X, -point.Y);

    public static Point operator ++(Point point)
    {
        ++point.X;
        ++point.Y;
        return point;
    }

    public static Point operator --(Point point)
    {
        --point.X;
        --point.Y;
        return point;
    }

    // Binary operators overloading

    public static Point operator +(Point left, Point right)
        => new Point(left.X + right.X, left.Y + right.Y);

    public static double operator -(Point left, Point right)
        => Math.Sqrt(Math.Pow(left.X - right.X, 2) + Math.Pow(left.Y - right.Y, 2));


    //point* 5
    public static Point operator *(Point point, int value)
        => new Point(point.X * value, point.Y * value);

    public static Point operator *(int value, Point point)
        => new Point(point.X * value, point.Y * value);

    // comparison operators
    // ==

    public override bool Equals(object? obj)
        => obj?.ToString() == this.ToString();

    public override int GetHashCode()
    {
        return this.ToString().GetHashCode();
    }
    public static bool operator ==(Point left, Point right)
        => left.Equals(right);

    public static bool operator !=(Point left, Point right)
        => !(left == right);
}
