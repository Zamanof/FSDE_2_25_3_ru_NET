namespace NET_12._Extension_Methods;

public static class StringExtensions
{
    public static int CountWords(this string text)
    {
        var words = text.Split(' ');
        return words.Length;
    }

    public static int CountSpaces(this string text)
    {

        return text.Count(char.IsWhiteSpace);
    }
    
    public static int CountVowels(this string text)
    {
        int count = 0;
        text = text.ToLower();
        foreach (char c in text)
        {
            if ("aeiou".IndexOf(c) >= 0) count++;
        }
        return count;
    }
    
    public static int ToInt(this string text)
    => int.TryParse(text, out int result) ? result : 0;
}