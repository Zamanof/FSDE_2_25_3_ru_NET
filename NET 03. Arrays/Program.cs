// arrays
// Одномерные массивы
/*
C++ style arrays
// static array
int arr[5] = {25, 98, 88, 5, 78};

// dynamic arrays
int* arr = new int[5]{25, 98, 88, 5, 78};
*/

//int[] arr = new int[5] { 25, 98, 88, 5, 78 };
//int[] arr1 = { 25, 98, 88, 5, 78 };
//int[] arr2 = [25, 98, 88, 5, 78];
//Console.WriteLine(arr.Length);
//Console.WriteLine(arr.Rank);


// Многомерные массивы
/*
C++ style arrays
// static array
int arr[2][2] = {25, 98, 88, 5};
cout<< arr[0][0]<<endl;
// dynamic arrays
int** arr = new int*[2];
arr[0] = new int[2];
arr[1] = new int[2];
*/

//int[,] mdArr = new int[2, 2] { { 3, 56}, { 25, 89} };
//Console.WriteLine(mdArr[0, 0]);
//Console.WriteLine(mdArr[1, 1]);
//Console.WriteLine(mdArr.Length);
//Console.WriteLine(mdArr.Rank);

// Работа с массивами в циклах
//int[] arr = { 25, 98, 88, 5, 78 };
//int i = 0;
//while (i < arr.Length)
//{
//    Console.Write($"{arr[i]} ");
//    i++;
//}
//Console.WriteLine();

//for (int i = 0; i < arr.Length; i++)
//{
//    Console.Write($"{arr[i]} ");
//}
//Console.WriteLine();

// c++ for(int item: arr)
// for i in range(len(lst)):
// for i in lst:

//foreach (int i in arr)
//{
//    Console.Write($"{i} ");
//    //i += 1;
//}
//Console.WriteLine();

// Зубчатый массив (Jagged array)
int[][] jArr = new int[2][];
jArr[0] = new int[2] { 25, 65};
jArr[1] = [25, 68, 98, 12, 78];
Console.WriteLine(jArr[0][0]);
Console.WriteLine(jArr[1][4]);