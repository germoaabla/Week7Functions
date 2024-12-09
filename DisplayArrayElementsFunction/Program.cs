string[] fruitBasket = { "apples", "bananas", "oranges" };
string[] pets = { "cats", "dogs", "fish" };
string[] characters = { "Harry", "Ron" };
int[] numbers = { 1, 2, 3, 4, 5, 6 };

PrintArrayElements(fruitBasket);
PrintArrayElements(pets);
PrintArrayElements(characters);
//PrintArrayElements(numbers); - problem with data type!

static void PrintArrayElements(string[] SomeArray)
{
    for (int i = 0; i < SomeArray.Length; i++)
    {
        Console.WriteLine($"{i+1}. {SomeArray[i]}");
    }
}