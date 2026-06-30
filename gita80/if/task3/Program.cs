using System;
class Program
{
    static void Main(string[] args)
    {
        float x,y;
        Console.Write("x: ");
        x = int.Parse(Console.ReadLine());
        Console.Write("y: ");
        y = int.Parse(Console.ReadLine());
        if(x==y)
        {
            Console.WriteLine($"{x} : {y}");
            return;
        }

        float half = (x+y)/2;
        float doubled = x*y*2;
        
        if(x>y) (x,y)=(doubled,half);
        else (x,y)=(half,doubled);
        Console.WriteLine($"{x} : {y}");
    }
}