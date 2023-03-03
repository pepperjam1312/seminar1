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

//   int Prompt (string message)
//   {

//        Console.Write(message);
//        string value = Console.ReadLine();
//        int result = Convert.ToInt32(value);
//        return result;

//    }

// bool IsWeekend(int weekDay)
// {
//      if (weekDay > 5)
//     {
//      return true;
//     } 
//     return false;
//  }
// bool ValidateWeekday (int number)
// {
// if (number > 0 && number <= 7)
//  {
//     return true;
//  }
//  Console.WriteLine("Это не день недели!");
//  return false;
// }
// int weekDay = Prompt("Введите день недели >");
//     if (ValidateWeekday(weekDay))
// {
//     Console.WriteLine("Наконец-то выходной");
// }
// else
// {
//     Console.WriteLine("Придется работать");
// }


// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да
// Console.Write("Введите число: ");
// string number = Console.ReadLine();

// void ProverkaChisla (string number)
// {
//     if (number[0]==number[4] && number[1]==number[3])
//     {
//         Console.WriteLine($"Ваше число: {number} - палиндром. ");
//     }
//     else Console.WriteLine($"Ваше число: {number} - не палиндром. ");
// }

// if (number!.Length == 5)
// {
//     ProverkaChisla(number);
// }
// else Console.WriteLine($"Введите правильное число");

// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

// static void Main(string[] args)
//  {
//         char selection;
//         Double x1, x2, y1, y2, z1, z2, distance;

//         Console.WriteLine("1. Расстояние между двумя точками на плоскости.");
//         Console.WriteLine("2. Расстояние между двумя точками в пространстве.");
//         Console.WriteLine("Выберите нужный пункт (1 или 2):");

//         selection = Convert.ToChar(Console.ReadLine());

//         switch (selection)
//         {
//             case '1':
//                 Console.Write("Введите координаты x1: ");
//                 x1 = Convert.ToDouble(Console.ReadLine());

//                 Console.Write("Введите координаты x2: ");
//                 x2 = Convert.ToDouble(Console.ReadLine());

//                 Console.Write("Введите координаты y1: ");
//                 y1 = Convert.ToDouble(Console.ReadLine());

//                 Console.Write("Введите координаты y2: ");
//                 y2 = Convert.ToDouble(Console.ReadLine());

//                 distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
//                 Console.WriteLine($"Расстояние между двумя точками на плоскости равно {distance}");
//                 Console.ReadKey();
//                 break;
//             case '2':
//                 Console.Write("Введите координаты x1: ");
//                 x1 = Convert.ToDouble(Console.ReadLine());

//                 Console.Write("Введите координаты x2: ");
//                 x2 = Convert.ToDouble(Console.ReadLine());

//                 Console.Write("Введите координаты y1: ");
//                 y1 = Convert.ToDouble(Console.ReadLine());

//                 Console.Write("Введите координаты y2: ");
//                 y2 = Convert.ToDouble(Console.ReadLine());

//                 Console.Write("Введите координаты z1: ");
//                 z1 = Convert.ToDouble(Console.ReadLine());

//                 Console.Write("Введите координаты z2: ");
//                 z2 = Convert.ToDouble(Console.ReadLine());

//                 distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
//                 Console.WriteLine($"Расстояние между двумя точками в пространстве равно {distance}");
//                 Console.ReadKey();
//                 break;
//             default:
//                 Console.WriteLine("Вы ввели неверный символ");
//                 Console.ReadKey();
//                 break;
//         }

//     }
// }

// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// Console.Write("Введите число: ");
// int cube = Convert.ToInt32(Console.ReadLine());

// void Cube(int[] cube){
//   int counter = 0;
//   int length = cube.Length;
//   while (counter <  length){
//     cube[counter] = Convert.ToInt32(Math.Pow(counter, 3));
//     counter++;
//   }
// }

// void PrintArry(int[] coll){
//   int count = coll.Length;
//   int index = 1;
//   while(index < count){
//     Console.Write(coll[index]+ " ");
//     index++;
//   }
// } 

// int[] array = new int[cube+1];
// Cube(array);
// PrintArry(array);

// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

// int Prompt (string message)
// {
//     System.Console.Write(message);
//     string readInput = System.Console.ReadLine ();
//     int result = int.Parse (readInput);
//     return result;
// }

// int Power (int powerBase, int exponent)
// {
//     int power =1;
//     for (int i = 0; i < exponent; i++)
//     {
//         power *= powerBase;
//     }
//     return power;
// }

// bool ValidateExponent (int exponent)
// {
//     if (exponent < 0)
//     {
//         System.Console.WriteLine("Показатель не должен быть меньше нуля");
//         return false;
//     }
//     return true;
// }

// int powerBase = Prompt ("Введите основание:");
// int exponent = Prompt ("Введите показатель:");
// if (ValidateExponent(exponent))
// {
//     System.Console.WriteLine($"Число {powerBase} в степени {exponent} равно {Power (powerBase, exponent)}");
// }

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

// int Prompt (string message)
// {
//     System.Console.Write(message);
//     string readInput = System.Console.ReadLine ();
//     int result = int.Parse (readInput);
//     return result;
// }

// int SumAllDigit (int number)
// {
//     int result =0 ;
//     while (number > 0)
//     {
//         result += number %10;
//         number = number /10;
//     }
//     return result;
// }
// int number = Prompt ("Введите число:");
// System.Console.WriteLine($"Сумма всех чисел в цифре{number} ={SumAllDigit(number)}");

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

// int Prompt (string message)
// {
//     System.Console.Write(message);
//     string readInput = System.Console.ReadLine ();
//     int result = int.Parse (readInput);
//     return result;
// }
// int [] GenerateArray (int Length, int minValue, int maxValue)
// {
//     int[] array = new int [Length];
//     Random random = new Random ();
//     for(int i = 0; i< Length; i++) 
//     {
//         arrayv[i] =random.Next (minValue, maxValue + 1);
//     }
//     return array;
// }

// void PrintArray(int [] array)
// {
//     System.Console.Write($"{array[array.Length -1]}");
//     System.Console.WriteLine("]");
// }

// int length = Prompt ("Длина массива:");
// int min = Prompt ("Начальное значение, для диапазона случайного числа:");
// int max = Prompt ("Конечное значение, для диапазона случайного числа;");
// int [] array = GenerateArray (Length, min, max);
// PrintArray(array);

