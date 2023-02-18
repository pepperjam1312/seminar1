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
//Задача 10. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

// int Prompt (string message)
// {

//     System.Console.Write(message);
//     string value = Console.ReadLine();
//     int result = Convert.ToInt32(value);
//     return result;

// }

// int number = Prompt("Enter a three-digit number > ");
// if (number < 100 || number >= 1000)
// {
//     Console.WriteLine("You have not entered a three-digit number, please re-enter");
//     return;
// }
// Console.WriteLine($"Entered number `{number}`");
// int SecondRank = number / 10 % 10;
// Console.WriteLine($" Second digit `{SecondRank}` ");

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

// int Prompt (string message)
//  {

//      Console.Write(message);
//      string value = Console.ReadLine();
//      int result = Convert.ToInt32(value);
//      return result;

//  }

//  int GetThirdRank (int number)
//  {
//     while (number > 999)
//     {
//         number /= 10;
//     }
//     return number % 10;

//  }
//  bool ValidateNumber (int number)
//  {

//     if (number < 100)
// {

//     Console.WriteLine(" No third digit");
//     return false;
// }
// return true ;
//  }
//  int number = Prompt("Enter the number > ");
//  if (ValidateNumber(number))
//  {
//     Console.WriteLine(GetThirdRank(number));
//  }

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

  int Prompt (string message)
  {

       Console.Write(message);
       string value = Console.ReadLine();
       int result = Convert.ToInt32(value);
       return result;

   }

bool IsWeekend(int weekDay)
{
     if (weekDay > 5)
    {
     return true;
    } 
    return false;
 }
bool ValidateWeekday (int number)
{
if (number > 0 && number <= 7)
 {
    return true;
 }
 Console.WriteLine("Это не день недели!");
 return false;
}
int weekDay = Prompt("Введите день недели >");
    if (ValidateWeekday(weekDay))
{
    Console.WriteLine("Наконец-то выходной");
}
else
{
    Console.WriteLine("Придется работать");
}



