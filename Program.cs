// Задача 1 ------------------------------------------------------------------------------------------------------------
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
//----------------------------------------------------------------------------------------------------------------------

// bool Palindrom(int num)
// {
//     int n = num;
//     int revers = 0;

//     while (n != 0)
//     {
//         int r = n % 10;
//         revers = revers * 10 + r;
//         n = n / 10;
//     }

//     if (num == revers)
//         return true;
//     else return false;
// }

// Console.Write("Введите число число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// if (Palindrom(num))
//     Console.WriteLine("Yes");
// else
//     Console.WriteLine("No");

// Задача 2 ------------------------------------------------------------------------------------------------------------
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
//----------------------------------------------------------------------------------------------------------------------

// double Gipot(double x1, double y1, double z1, double x2, double y2, double z2)
// {
//     double distX = x2 - x1;
//     double distY = y2 - y1;
//     double distZ = z2 - z1;
//     double result = Math.Sqrt(distX * distX + distY * distY + distZ * distZ);
//     return result;
// }
// Console.Write("Введите значение x1 - ");
// int x1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите значение y1 - ");
// int y1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите значение z1 - ");
// int z1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите значение x2 - ");
// int x2 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите значение y2 - ");
// int y2 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите значение z2 - ");
// int z2 = Convert.ToInt32(Console.ReadLine());

// double distance = Math.Round(Gipot(x1, y1, z1, x2, y2, z2), 2);
// Console.Write($"Расстояние между точками 1 и 2 составляет - {distance}");


// Задача 3 ------------------------------------------------------------------------------------------------------------
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
//----------------------------------------------------------------------------------------------------------------------

// void Cube(double number)
// {
//     int index = 1;
//     while (index <= number)
//     {
//         double numberCube = Math.Pow(index, 3);
//         Console.Write(numberCube + " ");
//         index++;
//     }
// }

// bool Validate(int num)
// {
//     if (num > 0)
//         return true;
//     else
//         return false;
// }

// Console.Write("Введите число N: ");
// int num = Convert.ToInt32(Console.ReadLine());

// if (Validate(num))
//     Cube(num);
// else Console.WriteLine("Неверное значение");