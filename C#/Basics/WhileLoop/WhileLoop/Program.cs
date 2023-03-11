Random randomNumberGenerator = new Random();
int puzzle = randomNumberGenerator.Next(0, 100);

bool isWin = false;

while (!isWin)
{
    Console.WriteLine("Tahmin: ");
    int suggest = Convert.ToInt32(Console.ReadLine());
    if (suggest < puzzle)
    {
        Console.WriteLine("Yukarı");
    }
    else if (suggest > puzzle)
    {
        Console.WriteLine("Aşağı");
    }
    else
    {
        Console.WriteLine("Bildiniz!");
        isWin = true;
    }
}

int[] numbers = { 13, 46, 0, 1, 18, -9 };

int index = 0;
while (index < numbers.Length)
{
    Console.WriteLine(numbers[index++]);
}