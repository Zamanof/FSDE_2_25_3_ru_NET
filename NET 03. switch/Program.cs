// switch
//Console.WriteLine("Enter week day 1~7");
//int.TryParse(Console.ReadLine(), out int weekDay);

//switch (weekDay)
//{
//	case 1:
//        Console.WriteLine("Monday");
//		break;
//	case 2:
//        Console.WriteLine("Tuesday");
//        break;
//    case 3:
//        Console.WriteLine("Wednesday");
//        break;
//    case 4:
//        Console.WriteLine("Thursday");
//        break;
//    case 5:
//        Console.WriteLine("Friday");
//        break;
//    case 6:
//        Console.WriteLine("Saturday");
//        break;
//    case 7:
//        Console.WriteLine("Sunday");
//        break;

//    default:
//        Console.WriteLine("Incorrect data");
//		break;
//}

//switch ((WeekDay)weekDay)
//{
//    case WeekDay.MONDAY:
//        Console.WriteLine("Monday");
//        break;
//    case WeekDay.THUSDAY:
//        Console.WriteLine("Tuesday");
//        break;
//    case WeekDay.WEDNESDAY:
//        Console.WriteLine("WEDNESDAY");
//        break;
//    case WeekDay.THURSDAY:
//        Console.WriteLine("THURSDAY");
//        break;
//    case WeekDay.FRIDAY:
//        Console.WriteLine("FRIDAY");
//        break;
//    case WeekDay.SATURDAY:
//        Console.WriteLine("SATURDAY");
//        break;
//    case WeekDay.SUNDAY:
//        Console.WriteLine("SUNDAY");
//        break;

//}

//double.TryParse(Console.ReadLine(), out double numb);

//switch (numb)
//{
//    case 0.5:
//        Console.WriteLine("Foo");
//        break;
//    default:
//        break;
//}

//string name = "Nadir";

//switch (name)
//{
//    case "Nadir":
//        break;
//    case "Salam":
//        break;
//    default:
//        break;
//}

Console.WriteLine("Enter week day 1~7");
int.TryParse(Console.ReadLine(), out int month);

//switch ((Months)month)
//{
//    case Months.JANUARY:
//    case Months.MARCH:
//    case Months.MAY:
//    case Months.JULY:
//    case Months.AUGUST:
//    case Months.OCTOBER:
//    case Months.DECEMBER:
//        Console.WriteLine("31 days");
//        break;
//    case Months.FEBRUARY:
//        Console.WriteLine("29 or 28 days");
//        break;

//    case Months.APRIL:
//    case Months.JUNE:
//    case Months.SEPTEMBER:
//    case Months.NOVEMBER:
//        Console.WriteLine("30 days");
//        break;

//    default:
//        break;
//}

// goto

switch ((Months)month)
{
    case Months.JANUARY:
        goto case Months.DECEMBER;
    case Months.FEBRUARY:
        Console.WriteLine("28 or 29 days");
        break;
    case Months.MARCH:
        goto case Months.DECEMBER;
    case Months.APRIL:
        goto case Months.NOVEMBER;
    case Months.MAY:
        goto case Months.DECEMBER;    
    case Months.JUNE:
        goto case Months.NOVEMBER;
    case Months.JULY:
        goto case Months.DECEMBER;
    case Months.AUGUST:
        goto case Months.DECEMBER;        
    case Months.SEPTEMBER:
        goto case Months.NOVEMBER;
    case Months.OCTOBER:
        goto case Months.DECEMBER;
    case Months.NOVEMBER:
        Console.WriteLine("30 days");
        break;
    case Months.DECEMBER:
        Console.WriteLine("31 days");
        break;
    default:
        break;
}

enum WeekDay
{
    MONDAY = 1,
    THUSDAY,
    WEDNESDAY,
    THURSDAY,
    FRIDAY,
    SATURDAY,
    SUNDAY
}

enum Months
{
    JANUARY = 1,
    FEBRUARY,
    MARCH,
    APRIL,
    MAY,
    JUNE,
    JULY,
    AUGUST,
    SEPTEMBER,
    OCTOBER,
    NOVEMBER,
    DECEMBER
}
