int[] numbers = {1,2,3,4,5,6,7,8,9,10};

// Dizi içerisindeki elemanların toplamı

int total = 0;
for (int i = 0; i < numbers.Length; i++)
{
    total += numbers[i];
}
Console.WriteLine($"Dizideki elemanların toplamı: {total}");

// Dizi içerisindeki elemanların ortalaması

int total2 = 0;
for (int i = 0; i < numbers.Length; i++)
{
    total2 += numbers[i];
}
double average = total2 / numbers.Length;
Console.WriteLine($"Dizideki elemanların ortalaması: {average}");

// Dizi içerisindeki en büyük ve en küçük eleman

int maxNumber = 0;
int minNumber = 2147483647; // max 32bit int
for (int i = 0; i < numbers.Length; i++)
{
    if (maxNumber < numbers[i])
    {
        maxNumber = numbers[i];
    }
    if (minNumber > numbers[i])
    {
        minNumber = numbers[i];
    }
}
Console.WriteLine($"Dizi içerisindeki en büyük ve en küçük eleman: {maxNumber}, {minNumber}");

// Diziyi tersine çevirme

int leftIndex = 0;
int rightIndex = numbers.Length - 1;

while (leftIndex < rightIndex)
{
    int temp = numbers[leftIndex];
    numbers[leftIndex] = numbers[rightIndex];
    numbers[rightIndex] = temp;

    leftIndex++;
    rightIndex--;
}

Console.WriteLine($"Ters çevrilmiş dizi:");
for (int i = 0; i < numbers.Length; i++)
{
    Console.Write($"{numbers[i]},");
}




Console.WriteLine("\n\n---------------------------------------\n"); // Örneklerin karışmaması için

// leetcode.com Two Sum sorusu

//Two Sum

/*
Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

You may assume that each input would have exactly one solution, and you may not use the same element twice.

You can return the answer in any order.


Input: nums = [3,2,4], target = 6
Output: [1,2]
 */

int[] nums = { 3, 2, 4 };
int target = 6;

for (int i = 0; i < nums.Length; i++)
{
    for (int j = i + 1; j < nums.Length; j++)
    {
        if (nums[i] + nums[j] == target)
        {
            Console.WriteLine($"[{i}, {j}]");
        }
    }
}

Console.WriteLine(); // Örneklerin karışmaması için

// Döngü ile üçgen yapmak

int rows = 5;

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < rows - i; j++)
    {
        Console.Write(" ");
    }

    for (int k = 0; k <= i * 2; k++)
    {
        Console.Write("*");
    }

    Console.WriteLine();
}

Console.WriteLine(); // Örneklerin karışmaması için

// Döngü ile dik üçgen yapmak

int height = 5;

for (int i = 1; i <= height; i++)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}

Console.WriteLine(); // Örneklerin karışmaması için

// Fibonacci sayısını hesaplamak

// Fibonacci Dizisi, her sayının kendisinden bir önceki sayı ile toplanması ile elde edilen sayılar serisidir.

Console.Write("Kaçıncı Fibonacci sayısını hesaplamak istersiniz? ");
int n = int.Parse(Console.ReadLine());

int a = 0, b = 1, c = 0;

for (int i = 2; i <= n; i++)
{
    c = a + b;
    a = b;
    b = c;
}

Console.WriteLine("{0}. Fibonacci sayısı: {1}", n, b);

// Çarpım Tablosu

Console.Write("\nÇarpım tablosunun boyutu: ");
int size = int.Parse(Console.ReadLine());

for (int i = 1; i <= size; i++)
{
    for (int j = 1; j <= size; j++)
    {
        Console.Write("{0,4}", i * j);
    }
    Console.WriteLine();
}

// Bir sayının asal olup olmadığı

Console.Write("\nSayının asal olup olmadığını kontrol edin: ");
int number = int.Parse(Console.ReadLine());
bool prime = true;

for (int i = 2; i <= number / 2; i++)
{
    if (number % i == 0)
    {
        prime = false;
        break;
    }
}

if (prime)
{
    Console.WriteLine($"{number} sayısı asaldır.");
}
else
{
    Console.WriteLine($"{number} sayısı asal değildir.");
}

// Seçilen sayıya kadar toplama örneği

Console.WriteLine("\nSeçtiğiniz sayıya kadar toplam:");
number = Convert.ToInt32(Console.ReadLine());
total = 0;
int counter = 1;

while (counter <= number)
{
    total += counter;
    counter++;
}

Console.WriteLine("Toplam: " + total);