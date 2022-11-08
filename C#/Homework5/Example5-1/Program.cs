// See https://aka.ms/new-console-template for more information
int[] array = new int[5];
Random rand = new Random();
int i = 0;
int qua = 0;
while (i < array.Length)
{
    array[i] = rand.Next(0,999); 
    System.Console.WriteLine(array[i]);
    IsEven(array[i]);
    i++;
}
    System.Console.WriteLine(qua);


void IsEven (int digit)
{
    if (array[i]%2==0)
    {
        qua++;
    }
}

