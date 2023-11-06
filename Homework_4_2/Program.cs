Console.WriteLine("Write the size of the array");
int N = int.Parse(Console.ReadLine());
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Fill the array");
int[,] array = new int[N,A];
for (int i = 0; i < N; i++)
{
    for (int j = 0; j < A; j++) 
    { 
        array[i,j] = int.Parse(Console.ReadLine());
    }
}
int max = array[0,0];
int min = array[0,0];
foreach (int s in array)
{
    max = s > max ? s : max;
    min = s < min ? s : min;
}
int sum = max + min;
Console.WriteLine($"sum = {sum}");
Console.ReadLine();
