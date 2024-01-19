using System.Xml.XPath;

internal class Program
{
    //operators
    //arithmetic operators
    //assignment operators
    //logical operators
    private static void Main(string[] args)
    {
        //assignment operators =,+=,-=,*=,/=,%=,&=
        int y = 45;
        y += 56;
        y -= 10;
        y *= 10;
        y /= 10;

        Console.WriteLine(y);
        ConditionalStatement();
    }

    static void ConditionalStatement()
    {
        int o = 528; int a = 43;
        int p = 378; int i = 50;

        if (o != p)
        {
            Console.WriteLine("the result is correct");

        }
        else
        {
            Console.WriteLine("the result is not correct");
        }
        if (i <= a)
        {
            Console.WriteLine("i is greater");

        }
        else
        {
            Console.WriteLine("the value is greater");
        }
    }
    static void CombinedMethod()
    {
        Console.WriteLine("Hello what would you like to order");
        Console.WriteLine("select 1. for coffee, 2 for croissant,3 for bubble tea");
        int result = int.Parse(Console.ReadLine());

        int d = 1;
        int e = 2;
        int f = 3;

        if (result == d || result == e || result ==f)
        {
            Console.WriteLine("Thank you for your patronage");

        }
        else
        {
            Console.WriteLine("please input the right value");
        }

    }
}