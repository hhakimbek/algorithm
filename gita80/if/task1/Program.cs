using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("a = ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("b = ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("c = ");
        int c = int.Parse(Console.ReadLine());

        int minimumV1 = a;
        if(minimumV1>b)minimumV1 = b;
        if(minimumV1>c)minimumV1 = c;

        int minimumV2 = Math.Min(a,Math.Min(b,c));

        Console.WriteLine($"Minimum V1: {minimumV1}");
        Console.WriteLine($"Minimum V2: {minimumV2}");

    }
}