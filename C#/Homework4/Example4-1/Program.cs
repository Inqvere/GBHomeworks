// See https://aka.ms/new-console-template for more information

int[] num = new int[2];
int i = 0;
while (i<2)
{
    Console.Write("Введите ", i+1, " число: ");
    Console.Write(i+1);
    Console.Write(" число: ");    
    num [i] = Convert.ToInt32(Console.ReadLine());
    i++;
}

    Console.Write("Ответ: "); 
    Console.Write(Math.Pow(num[0],num[1]));

