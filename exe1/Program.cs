Console.Write("enter number: ");
string aText = Console.ReadLine();

switch (aText.Length)
{
    case > 2:
        Console.WriteLine("number thee " + aText[2]);
        break;
    default:
        Console.WriteLine("not found");
        break;
}
