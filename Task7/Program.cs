int cip(int n)
{
    if (n/10%10 == 1)
        return n;
    else
    {
        return n + cip(n - 1);
    }
}
cip(5);

