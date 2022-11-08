// See https://aka.ms/new-console-template for more information
int[] array = new int[6];
Random rand = new Random();
int i = 0;
int sum = 0;
while (i < array.Length)
{
    array[i] = rand.Next(-99,99); 
    System.Console.WriteLine(array[i]);
    if ((i+1)%2>0)
    {
        sum = sum+array[i];
    }
    i++;
}
    System.Console.WriteLine(sum);



