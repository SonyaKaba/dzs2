Console.WriteLine("enter number: ");
string Sa = Console.ReadLine();

int a = int.Parse(Sa);

if (a < 100)
{
    Console.WriteLine("not found");
}
else 
{
    int d = 10;
    while (true) 
{
    int s = a / d;
    if (s > 10 && s < 100)
    {
        break;
    }
    else
    {
        d *= 10;
    }

}
 Console.WriteLine($"The second number is { (a/d) % 10} ");
}
