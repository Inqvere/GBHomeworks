// See https://aka.ms/new-console-template for more information


double[] num = {3,7.3,22.2,2,78};

int i = 0;
double max = 0;
double min = num[0];
while (i< num.Length)
{
    Console.Write (i+1);
    Console.Write (" элемент массива: ");
    Console.WriteLine (num[i]);

    if (num[i]>max)
    {
        max = num[i];
    }
    else if (num[i]<min)
    {
        min = num[i];
    }

    i++;
}

Console.Write ("Максимальный элемент массива: ");
Console.WriteLine (max);
Console.Write ("Минимальный элемент массива: ");
Console.WriteLine (min);
Console.Write ("Их разница: ");
Console.WriteLine (max-min);
