// See https://aka.ms/new-console-template for more information
Random rnd = new Random();
int number = rnd.Next(100,999);


int SearchDigit (int n)
{
   int firstDigit = n/100;
   int thirdDigit = n%10;
   int newDigit = firstDigit*10+thirdDigit;
   return newDigit;
}
System.Console.WriteLine("Сгенерированное трехзначное число:");
System.Console.WriteLine(number);
System.Console.WriteLine("Все что от него осталось:");
System.Console.WriteLine(SearchDigit(number));

