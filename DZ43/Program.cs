// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.


double b1, k1, b2, k2, x, y;
Console.Write("Напишите число b1 = ");
b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Напишите число k1 = ");
k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Напишите число b2 = ");
b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Напишите число k2 = ");
k2 = Convert.ToDouble(Console.ReadLine());
x = (b1 - b2) / (k2 - k1);
y = k1 * x + b1;
Console.WriteLine("Точка пересечения двух прямых :");
Console.WriteLine(Convert.ToString(x));
Console.WriteLine(Convert.ToString(y));

// // Console.WriteLine("Напишите кол-во чисел: ");
// // n = Convert.ToInt32(Console.ReadLine());
// // int[] array = new int[n];
// Console.WriteLine("Напишите числа: ");
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = Convert.ToInt32(Console.ReadLine());
//     if(array[i] > 0)
//     {
//         count++;
//     };

// }


// Console.WriteLine("Чисел больше 0 :");
// Console.WriteLine(count);