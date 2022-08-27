// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] testArray = new int[4];
int count = 0;
for (int i = 0; i < 4; i++)
{
testArray[i] = new Random().Next(100,1000);
if (testArray[i] %2 == 0) count++;
}
Console.WriteLine($"[{String.Join("; ", testArray)}]");
Console.WriteLine(count); 

