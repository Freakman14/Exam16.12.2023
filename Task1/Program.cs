int n;
int sum = 1;
n = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[n];
for (int i = 0; i < n; i++)
{
    arr[i] = Convert.ToInt32(Console.ReadLine());
}
for (int i = 0; i < n; i++)
{
    if (i == arr[i])
    {
        sum++;
    }
}
System.Console.WriteLine(sum);