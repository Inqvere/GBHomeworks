// See https://aka.ms/new-console-template for more information

int number = 324;

int SearchDigit (int n)
{
   int secondDigit = (n - (n/100)*100)/10;
   return secondDigit;
}

System.Console.WriteLine(SearchDigit(number));

