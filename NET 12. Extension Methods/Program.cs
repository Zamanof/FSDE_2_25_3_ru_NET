// Extension methods

using NET_12._Extension_Methods;

string text = "Lorem ipsum dolor sit amet. Salam. Hello world.";
// Console.WriteLine(CountWords(text));
// Console.WriteLine(text.CountWords());
// Console.WriteLine(text.CountSpaces());
// Console.WriteLine(text.CountVowels());

// Console.WriteLine("1564".ToInt() + 12);


int CountWords(string text)
{
    var words = text.Split(' ');
    return words.Length;
}

