// See https://aka.ms/new-console-template for more information


int[] num = {1,2,5,7,19,6,1,33};

int i = 0;
int max = 0;
int maxN = 0;
while (i< num.Length)
{
    Console.Write (i+1);
    Console.Write (" элемент массива: ");
    Console.WriteLine (num[i]);

    if (num[i]>max)
    {
        maxN = max;
        max = num[i];
    }
    else if (num[i]>maxN)
    {
        maxN = num[i];
    }

    i++;
}

Console.Write ("Максимальный элемент массива: ");
Console.WriteLine (max);
Console.Write ("Второй максимальный элемент массива: ");
Console.WriteLine (maxN);
