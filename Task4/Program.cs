int n;
int[] arr = new int [n];
for (int i = 0; i < n; i++)
{
   arr[i]=Convert.ToInt32(Console.ReadLine());
}
for (int i = 0; i < n; i++)
{
    if(arr[i]>0)
    {
        System.Console.WriteLine(0);
    }
    else {
        System.Console.WriteLine(arr[i]);
    }
}

