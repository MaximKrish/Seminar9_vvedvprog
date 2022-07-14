// Напишите программу, которая перевернет одгномерный массив (последний элемент будет на первом месте, а первый на на последнем и т.д.)
int[] f(int[] array)
{
    for(int i = 0; i < array.Length/2; i++)
    {
        (array[i], array[array.Length-(i+1)]) = (array[array.Length-(i+1)], array[i]); 
    }
    return array;
}
int n;
Console.WriteLine("Задайте длину массива : ");
n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
var random = new Random();
for(int i = 0; i < array.Length; i++)
{
	array[i] = random.Next(100,999);
}
Console.WriteLine("Наш массив: ");
Console.WriteLine("[" + string.Join(",", array) + "]");
Console.WriteLine("[" + string.Join(",", f(array)) + "]");
