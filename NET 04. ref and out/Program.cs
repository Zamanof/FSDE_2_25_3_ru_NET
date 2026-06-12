/*
ref -   Отправить значимый тип в метод как ссылка.
        Когда отправляеться в метод его заранее надо инициализировать
        https://learn.microsoft.com/ru-ru/dotnet/csharp/language-reference/keywords/ref
        
out -   Отправить значимый тип в метод как ссылка.
        Когда отправляеться в метод его можно и не инициализировать, 
        но необходимо инициализировать внутри метода
        https://learn.microsoft.com/ru-ru/dotnet/csharp/language-reference/keywords/out

in  -   Отправить значимый тип в метод как ссылка.
        Параметр внутри метода только для чтения (readonly)
        https://learn.microsoft.com/ru-ru/dotnet/csharp/language-reference/keywords/in
 
*/

int numb1 = 25;
int[] arr = [25, 36];
int numb2 = 25;
int numb3;
int numb4 = 256;
Console.WriteLine($"numb1 = {numb1}, numb2 = {numb2}, arr[0] = {arr[0]}");

ChangeValue(numb1, arr, ref numb2, out numb3, in numb4);

Console.WriteLine($"numb1 = {numb1}, numb2 = {numb2}, arr[0] = {arr[0]}, numb3 = {numb3}");

//IntTryParse(Console.ReadLine(), out int number);
//Console.WriteLine(number);
void ChangeValue(int numb1, int[] arr, ref int numb2, out int numb3, in int numb4)
{
    numb1 += 10;
    arr[0] = 15;
    numb2 += 10;
    numb3 = 36;
    //numb4 = 65;
}

void IntTryParse(string value, out int parsed)
{
    try
    {
        parsed = int.Parse(value);
    }
    catch (Exception)
    {

        parsed = default;
    }
}