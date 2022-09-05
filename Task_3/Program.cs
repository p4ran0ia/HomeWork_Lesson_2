Console.WriteLine("Input number of the day of the week");
int n = Convert.ToInt32(Console.ReadLine());
if(n > 0 && n < 6)
Console.WriteLine("no");
else if(n > 5 && n < 8)
Console.WriteLine("yes");
else
Console.WriteLine("error");