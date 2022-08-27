// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] testArray = new int[4];
int sum = 0;
for (int i = 0; i < 4; i++) 
{
testArray[i] = new Random().Next(-99,100);
if (i %2 != 0) sum += testArray[i];
}
Console.WriteLine($"[{String.Join("; ", testArray)}]");
Console.WriteLine(sum); 