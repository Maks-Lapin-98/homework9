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
string NumbersRec1(int m, int n)
{
    if (m < n + 1) return $"{m} " + NumbersRec1(m + 1, n);
    else return String.Empty;
}
int m = ReadInt("Введите M: ");
int n = ReadInt("Введите N: ");
System.Console.WriteLine(NumbersRec1(m, n));