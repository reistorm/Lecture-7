// итеративный метод

decimal fRec = 0;
decimal fIte = 0;
decimal FibonacchiRecursion(int n)
{
    fRec++;
    return n == 0 || n == 1 ? 1 : FibonacchiRecursion(n - 1) + FibonacchiRecursion(n - 2);

}

decimal FibonacchiIteration(int n)
{
    fIte++;
    decimal result = 1;
    decimal f0 = 1;
    decimal f1 = 1;
    for (int i = 2; i <= n; i++)
    {
        result = f0 + f1;
        f1 = result;
        fIte++;
    }
    return result;
}

Console.ReadLine();
DateTime dt = DateTime.Now;
for (int n = 10; n < 40; n++)
{
    Console.WriteLine($"FibonacchiIteration({n}) = {FibonacchiIteration(n)} fIte = {fIte.ToString("### ### ###"), -15}");
    fIte = 0;
}
System.Console.WriteLine((DateTime.Now - dt).TotalMilliseconds);

Console.WriteLine();
Console.ReadLine();
dt = DateTime.Now;
for (int n = 10; n < 40; n++)
{
    Console.WriteLine($"FibonacchiRecursion({n}) = {FibonacchiRecursion(n)} fRec = {fRec.ToString("### ### ###"), -15}");

}
System.Console.WriteLine((DateTime.Now - dt).TotalMilliseconds);
Console.ReadLine();

