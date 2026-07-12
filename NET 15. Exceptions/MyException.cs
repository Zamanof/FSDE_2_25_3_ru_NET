// Exceptions
/*
   Правила которые не важные для соблюдения:
    Все исключения которые создаются пользовотелем
    должны нследоватся от ApplicationException

   Важные правила:
    1. Для исключения должны применить атрибут [Serializable]
    2. У исключения должна быть default constructor
    3. Должен быть constructor где назначаем значение для property Message
    4. Должен быть перегруженный constructor где обрабатываем Inner Exception
    5. Должен быть перегруженный constructor для того чтобы сериализовать тип

*/

using System.Runtime.Serialization;

[Serializable]
class MyException : ApplicationException
{
    public MyException()
    {
    }

    public MyException(string? message) 
        : base(message)
    {
    }

    public MyException(string? message, Exception? innerException) 
        : base(message, innerException)
    {
    }

    protected MyException(SerializationInfo info, StreamingContext context) 
        : base(info, context)
    {
    }
}