// See https://aka.ms/new-console-template for more information
double p = 11.0;
Console.WriteLine($"Hello, World! Part {p}");

for (int counter = 0; counter < 5; counter++)
{
    if (counter == 2)
    {
        Console.WriteLine("Counter is TWO");
    }
    else
    {
        Console.WriteLine($"Counter is {counter}");
    }
}

// nested loop
for (int row = 1; row < 11; row++)
{
    for (char column = 'a'; column < 'k'; column++)
    {
        Console.WriteLine($"The cell is ({row}, {column})");
    }
}