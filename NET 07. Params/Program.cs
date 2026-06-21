// params - Отправка в метод "бесконечное"  число параметров
int[] arr = [29, 78, 97, 44, 152];

Console.WriteLine(Sum(arr));
Console.WriteLine(Sum(new int[] {15, 78, 7}));
Console.WriteLine(Sum([15, 78, 71]));

Console.WriteLine(ParamsSum(25, 748, 774));
Console.WriteLine(ParamsSum(arr));
int Sum(int[] ints)
{
    int result = default;

    foreach (int i in ints)
        result += i;
    return result;
}

int ParamsSum(params int[] ints)
{
    int result = default;

    foreach (int i in ints)
        result += i;
    return result;
}
