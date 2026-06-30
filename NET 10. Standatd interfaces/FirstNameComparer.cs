// Standard interfaces
using System.Collections;

class FirstNameComparer : IComparer
{
    public int Compare(object? x, object? y)
    {
        if (x is Student left && y is Student right)
        {
            return left.FirstName.CompareTo(right.FirstName);
        }
        throw new Exception("Can not compare objects");
    }
}
