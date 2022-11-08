// See https://aka.ms/new-console-template for more information

int number = 798;


int SearchDigit (int n)
{
    int thirdDigit = n%10;
    return thirdDigit;
}

if (number/100>0)
    {
        System.Console.WriteLine(SearchDigit(number));
    }
    else
    {
        System.Console.WriteLine("Данное число - двузначное");
    }

