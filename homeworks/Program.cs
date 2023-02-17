//  Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Console.WriteLine("Please input First Number");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Please input second Number");
// int num2 = Convert.ToInt32(Console.ReadLine());
// if ( num1> num2 )
// {
//     Console.WriteLine($"Maximum number from {num1} and {num2} is {num1} ");
// }
// else
// {
//     Console.WriteLine($"Maximum number from {num1} and {num2} is {num2} ");
// }



// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// Console.WriteLine("Please input First Number");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Please input second Number");
// int num2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Please input second Number");
// int num3 = Convert.ToInt32(Console.ReadLine());
// int max = num1;
// if (num2 > max)
// {
//     max = num2;}
//     if (num3 > max)
//     {
//         max = num3;
//     };
//     Console.WriteLine($"Maximum number from {num1}, {num2}, {num3} is {max} ");

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

// Console.WriteLine("Please input Number");
// int num = Convert.ToInt32(Console.ReadLine());

// if (num % 2 == 0)
// {
//     Console.WriteLine($"{num} -> да");
// }
// else
// {
//     Console.WriteLine($"{num} -> нет");
// }



// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

// Console.WriteLine("Please input Number");
// int num = Convert.ToInt32(Console.ReadLine());
// int current = 2;
// if(num <- 2)
// {
//     Console.WriteLine($" Where no positive even numbers between 1 and {num} ");
// }
// else
// {
//     Console.Write($" positive even numbers between 1 and {num} are: ");
// while (current <= num)
// {
//     Console.Write($"{current}");
//     current = current + 2;
// };
// };