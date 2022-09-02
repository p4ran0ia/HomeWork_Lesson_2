void Num()
{
    Console.WriteLine("Input number: ");
    int n = Convert.ToInt32(Console.ReadLine());

    if(n > 99 && n < 1000)
    Console.WriteLine(n / 10 % 10);
    else
    Console.WriteLine("error");

}
Num();