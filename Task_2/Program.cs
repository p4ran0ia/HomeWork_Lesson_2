int GenerateRandomNumbers()
{
    int n = new Random().Next(1, 1000000);
    return n;
}

void ThirdNumber()
{
    int n = GenerateRandomNumbers();
    Console.WriteLine(n);
    if(n < 100)
    Console.WriteLine("no third number");
    else
    {
        while(n >= 1000)
        {
            int a = n / 10;
            n = a;
        }
        n = n % 10;  
    }
    Console.WriteLine(n); 
}

ThirdNumber();


