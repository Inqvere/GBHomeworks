// See https://aka.ms/new-console-template for more information

void IsThisPalindrom (int n)
{
int digit1 = n/10000;
int digit2 = (n%10000)/1000;
int digit4 = (n%100)/10;
int digit5 = n%10;

if (digit1==digit5 && digit2==digit4)
{
    System.Console.WriteLine("Данное число является палиндромом");
}
else 
{
    System.Console.WriteLine("Данное число НЕ является палиндромом");
}
}


void EnterTheText ()
{
Console.Write("Введите пятнизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number>9999 && number<100000)
{
    IsThisPalindrom(number);
}
else 
{
    System.Console.WriteLine("Вы ввели не пятизначное число");
}
}

EnterTheText();

