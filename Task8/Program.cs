void cip(int a, int b, int tem = 0)
{
    tem = a;
    a = b;
    b = tem;
    System.Console.WriteLine($"x = {a}");
    System.Console.WriteLine($"y = {b}");
}
int a, b;
a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());

cip(a, b);
