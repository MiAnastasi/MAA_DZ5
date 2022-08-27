// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] testArray = new double[5];
double max = -1000;
double min = 1000;
for (int i = 0; i < 5; i++) 
{
testArray[i] = new Random().Next(-99,100);
if (testArray[i] < min) min = testArray[i];
if (testArray[i] > max) max = testArray[i];
}
Console.WriteLine($"[{String.Join("; ", testArray)}]");
Console.WriteLine(max-min); 