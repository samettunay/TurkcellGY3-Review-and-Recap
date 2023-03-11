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



// leetcode.com Two Sum sorusu

Console.WriteLine("\n\n---------------------------------------\n");

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