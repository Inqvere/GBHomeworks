// See https://aka.ms/new-console-template for more information


double dim =  0;

double FindTheDim (int x1, int y1, int z1, int x2, int y2, int z2)
{
dim =  Math.Sqrt(Math.Pow(x2-x1,2) + Math.Pow(y2-y1,2)+ Math.Pow(z2-z1,2));
return dim;
}


void EnterTheCoordinates ()
{
Console.Write("Введите координату по оси X для первой точки: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату по оси Y для первой точки: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату по оси Z для первой точки: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату по оси X для первой точки: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату по оси Y для первой точки: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату по оси Z для первой точки: ");
int z2 = Convert.ToInt32(Console.ReadLine());

FindTheDim(x1,y1,z1,x2,y2,z2);


}

EnterTheCoordinates();
Console.Write("Расстояние между координатами: ");
Console.Write(dim);



