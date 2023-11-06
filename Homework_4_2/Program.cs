Console.WriteLine("Write the size of the array");
int N = int.Parse(Console.ReadLine());
Console.WriteLine("Fill the array");
int[] array = new int[N];

for (int i = 0; i < N; i++) array[i] = int.Parse(Console.ReadLine());
int max = array[0];
int min = array[0];
foreach (int j in array)
{
    max = j > max ? j : min = j < min ? j : min;
}
int sum = max + min;
Console.WriteLine($"sum = {sum}");
Console.ReadLine();
