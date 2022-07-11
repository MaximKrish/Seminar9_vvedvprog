//  Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int n, count = 0;
Console.WriteLine("Напишите кол-во чисел: ");
n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
Console.WriteLine("Напишите числа: ");
for (int i = 0; i < array.Length; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine());
    if(array[i] > 0)
    {
        count++;
    };
    
}
    
  
Console.WriteLine("Чисел больше 0 :");
Console.WriteLine(count);