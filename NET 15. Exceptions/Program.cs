// Exceptions
/*
    Exception
        - SystemException
        - ApplicationException
*/

int numb1 = 15;
int numb2 = 2;
int result = default;

try
{
    //result = numb1 / numb2;
    //Console.WriteLine(result);
    //throw new Exception("Some exception");
    //Foo(25, 0);
    //Bar();
    //Some();
    throw new MyException("My Super Exception");
}
catch (DivideByZeroException ex)
{
    Console.WriteLine("Catch in Main - DivideByZeroException");
    Console.WriteLine();
    Console.WriteLine(ex.Message);
    Console.WriteLine();
    Console.WriteLine(ex.StackTrace);
    Console.WriteLine();
    Console.WriteLine(ex.TargetSite);
}
catch (NullReferenceException ex)
{
    Console.WriteLine("Catch in Main - NullReferenceException");
    Console.WriteLine();
    Console.WriteLine(ex.Message);
    Console.WriteLine();
    Console.WriteLine(ex.StackTrace);
    Console.WriteLine();
    Console.WriteLine(ex.TargetSite);
}
catch(MyException ex)
{
    Console.WriteLine("Catch in Main - MyException");
    Console.WriteLine();
    Console.WriteLine(ex.Message);
    Console.WriteLine();
    Console.WriteLine(ex.StackTrace);
    Console.WriteLine();
    Console.WriteLine(ex.TargetSite);
}
catch (Exception ex)
{
    Console.WriteLine("Catch in Main - any Exception");
    Console.WriteLine();
    Console.WriteLine(ex.Message);
    Console.WriteLine();
    Console.WriteLine(ex.StackTrace);
    Console.WriteLine();
    Console.WriteLine(ex.TargetSite);
}
//catch
//{
//    Console.WriteLine("Catch in Main - any Exception");

//}
finally
{
    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("Finally block");
    Console.ForegroundColor = ConsoleColor.White;
}


int Foo(int numb1, int numb2)
{
    int result = default;
    int[] arr = new int[5];
    try
    {
        result = numb1 / numb2;
        Console.WriteLine(arr[8]);
    }
    catch (DivideByZeroException ex)
    {
        Console.WriteLine("Catch in Foo - DivideByZeroException");
        Console.WriteLine();
        //Console.WriteLine(ex.Message);
        //Console.WriteLine();
        //Console.WriteLine(ex.StackTrace);
        //Console.WriteLine();
        //Console.WriteLine(ex.TargetSite);
        throw;
    }
    return result;
}

void Bar()
{
    Foo(1, 0);
}

void Some()
{
    Bar();
}
