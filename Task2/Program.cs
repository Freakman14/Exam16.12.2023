int k;
k = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[k];
for (int i = 0; i < k; i++)
{
    arr[i] = Convert.ToInt32(Console.ReadLine());
}
int n;
n = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < k; i++)
{
    if (i == n)
    {
        continue;
    }
    System.Console.Write(arr[i] + " ");
}
