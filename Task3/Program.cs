int n;
n = Convert.ToInt32(Console.ReadLine());
int min = 99999999;
int max = -111111111;
int[] arr = new int[n];
for (int i = 0; i < n; i++)
{
    arr[i] = Convert.ToInt32(Console.ReadLine());
}
for (int i = 0; i < n; i++)
{
    if (min > arr[i])
    {
        min = arr[i];
    }
}
for (int i = 0; i < n; i++)
{
    if (max < arr[i])
    {
        max = arr[i];
    }
}
for (int i = min; i < max; i++)
{
    System.Console.Write(arr[i]+" ");
}
