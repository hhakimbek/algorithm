using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("KABISA YILI");
        Console.Write("Year: ");
        int year = int.Parse(Console.ReadLine());
        if(year%400==0)
        {
            Console.WriteLine(366);
        } else
        {
            if(year%100!=0 && year%4==0)
            {
                Console.WriteLine(366);
            } else
            {
                Console.WriteLine(365);
            }
        }
    }
}