// Выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1


// Не используя рекурсию, выведите первые N чиснл Фибоначчи. Первые два числа  Фибоначчи : 0 и 1.



int a0 = 0, a1 = 1, a2, n = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    a2 = a1 + a0;
    a0 = a1;
    a1 = a2;
    Console.Write(a2);
    Console.Write(" ");
}


// Console.Write("Введите N: ");
// int n = Convert.ToInt32(Console.ReadLine());
// List<int> arr = new List<int>() {0};
// int i = 0;

// int fibonacci(int n, int i)
// {   
//     if (arr[i] != 0 && i >= 1)
//         arr[i] = n;
//     i++;
//     Console.Write(i);
//     Console.Write(" ");
//     if (n <= 2) 
//         return 1;
//     return fibonacci(n - 1, i) + fibonacci(n - 2, i);
// }
// fibonacci(n, i);
// //Console.Write(string.Join(" ", arr));
