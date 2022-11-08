// See https://aka.ms/new-console-template for more information

int day = -5;

if (day>7 && day<1)
    {
        System.Console.WriteLine("Вы ввели не день недели");
    }
    else if (day>5)
    {
        System.Console.WriteLine("Этот день - выходной");
    }
    else 
    {
        System.Console.WriteLine("Этот день не является выходным днем");
    }

