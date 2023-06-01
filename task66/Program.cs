int ReadInt(string argument) 
{
    Console.Write(argument);
    int i;
    while (!int.TryParse(Console.ReadLine(), out i))
    {
        System.Console.WriteLine("Это не число!");
        Console.Write(argument);
    }
    return i;
}
int SumNumbers(int m, int n)
{
    if (n == m) return n;
    else return n + SumNumbers(m, n - 1);
}
int m = ReadInt("Введите M: ");
int n = ReadInt("Введите N: ");
if (n < m)
{
    int temp = n;
    n = m;
    m = temp;
}
System.Console.WriteLine(SumNumbers(m, n));
