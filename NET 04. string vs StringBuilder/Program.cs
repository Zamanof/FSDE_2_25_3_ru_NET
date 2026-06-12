// string vs StringBuilder

using System.Text;

string word = "Hi";

for (int i = 0; i < 1000; i++)
{
    word += 'a';
}

StringBuilder sb = new StringBuilder("Hi");
Console.WriteLine(sb.Capacity);
var capa = sb.Capacity;
for (int i = 0; i < 1000; i++)
{
    sb.Append('a');
    if (capa < sb.Capacity)
    {
        capa = sb.Capacity;
        Console.WriteLine(capa);
    }
}
var word2 = sb.ToString();