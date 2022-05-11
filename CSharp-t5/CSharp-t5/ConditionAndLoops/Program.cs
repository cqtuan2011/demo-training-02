Console.WriteLine("Hi, what would you like to drink?");
Console.WriteLine("Input option: 1/. Coffee      2/. Tea");
int option = int.Parse(Console.ReadLine());

switch (option)
{
    case 1:
        Console.WriteLine("Here is your coffe, have a great day!");
        break;
    case 2:
        Console.WriteLine("Here is your tea, enjoy!");
        break;
}

Console.ReadKey();

