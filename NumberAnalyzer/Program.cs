while (true)
{ 

Console.WriteLine("Hello, would you like to enter your name?");
string name = Console.ReadLine();
Console.WriteLine("Hey: " + name);

Console.WriteLine(name + ", can you please enter an integer between 1 and 100?");
double integer = double.Parse(Console.ReadLine());

if (integer < 0 || integer > 100)
{
    Console.WriteLine("Please enter a number between 1 and 100");
    return;
}
else
{
    Console.WriteLine("Cool, you picked: " + integer);
}
if (integer %2 == 1 && integer < 60)
{
    Console.WriteLine("Odd and less than 60");
}

if (integer %2 == 0 && integer >= 2 && integer < 25)
{
    Console.WriteLine("Even and less than 25");
}
if (integer % 2 == 0 && integer >= 26 && integer <= 60)
{
    Console.WriteLine("Even and between 26 and 60 inclusive");
}
if (integer % 2 == 0 && integer > 60 )
{
    Console.WriteLine("Even and greater than 60");
}
if (integer % 2 == 1 && integer > 60 )
{
    Console.WriteLine("Odd and greater than 60");
}

    while (true)
    {
        Console.WriteLine("Would you like to restart? Enter yes or y to continue, or enter any other key to exit.");
        string input = Console.ReadLine();
        if (input == "yes")
            break;
        else if (input == "y")
            break;
        else
            Console.WriteLine("Goodbye");
        return;
    }
}