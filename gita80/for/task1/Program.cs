using System;
Console.Write("n = ");
int n = int.Parse(Console.ReadLine()??""); 

for(int i=1;i<=n;i++)
{
    int result = ToPerfect(i);
    if(result>n) return;
    if(result!=0) Console.WriteLine(result);
}


int ToPerfect(int p)
{
    if(!IsPrime((int)p)) return 0;
    int right = (1<<p)-1;
    if(!IsPrime(right)) return 0;
    int result = (1<<p-1)*right;
    return result;
}

bool IsPrime(int n)
{
    if(n==2) return true;
    if(n%2==0 || n<2) return false;
    for(int i=3;i*i<=n;i+=2)
    {
        if(n%i==0) return false;
    }
    return true;
}