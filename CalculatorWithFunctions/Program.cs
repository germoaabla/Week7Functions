int a = 5;
int b = 6;

Add(a, b);
Add(10, 100);

static void Add(int x, int y)
{
    Console.WriteLine($"{x} + {y} = {x + y}");
}

Multiply(a, b);

static void Multiply(int x, int y)
{
    Console.WriteLine($"{x} * {y} = {x * y}");

}

Subtract(a, b);

static void Subtract(int x, int y)
{
    Console.WriteLine($"{x} - {y} = {x - y}");
}
