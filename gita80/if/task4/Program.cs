using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Day: ");
        int day = int.Parse(Console.ReadLine()??"");
        Console.Write("Month: ");
        int month = int.Parse(Console.ReadLine()??"");
        int[] arr = {31,28,31,30,31,30,31,31,30,31,30,31};
        if (month > 12)
        {
            Console.WriteLine("Bunday oy yo'q");
            return;
        }
        if(arr[month-1]<day)
        {
            Console.WriteLine("Bunday sana yo'q");
            return;
        }
        day++;
        if(arr[month-1]<day)
        {
            day=1;
            month++;
            if(month>12) month=1;
        }
        Console.WriteLine($"{day.ToString().PadLeft(2,'0')}.{month.ToString().PadLeft(2,'0')}");
        
    }
}