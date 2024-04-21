//string[] fruit = { "apples", "bananas", "pears" };


string[] fruit = new string[3];

fruit[0] = "apples";
fruit[1] = "bananas";
fruit[2] = "pears";

//Console.WriteLine($"{fruit[0]}, {fruit[1]}, {fruit[2]}");

int fruitArrayLenght = fruit.Length;

Console.WriteLine($"There are {fruitArrayLenght} fruits in your array.");

for (int i = 0; i < fruitArrayLenght; i++)
{
    fruit[i] = fruit[i].Replace(fruit[i][0], char.ToUpper(fruit[i][0]));
}

foreach (string element in fruit)
{
    Console.WriteLine(element);
}