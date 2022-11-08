// See https://aka.ms/new-console-template for more information


void FindCubes (int n)
{
int i = 1;
while (i<=n)
{
    Console.Write(Math.Pow(i,3));
    Console.Write(", ");
    i++;
}
}


Console.Write("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
FindCubes(num);

