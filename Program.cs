// 1. Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
// void getDot (int x, int y){
// if (x == 0 || y == 0){
// Console.WriteLine("Замените нулевое значение для корректного определения четверти");
// }else{
// if(x > 0 && y > 0)
// Console.WriteLine("1 четверть");
// if(x > 0 && y < 0)
// Console.WriteLine("4 четверть");
// if(x < 0 && y > 0)
// Console.WriteLine("2 четверть");
// if(x < 0 && y < 0)
// Console.WriteLine("3 четверть");
// }
// }
// Console.WriteLine("Введите две точки: ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// int y1 = Convert.ToInt32(Console.ReadLine());

// getDot(x1, y1);

// 2. Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
// void getDot (int num)
// {
// if (num == 1)
// {
// Console.WriteLine("x>0 , y>0");
// }
// else if(num == 2){
// Console.WriteLine("x<0 , y>0");
// }
// else if(num == 3){
// Console.WriteLine("x<0 , y<0");
// }
// else if(num == 4){
// Console.WriteLine("x>0 , y<0");
// }
// else{
//    Console.WriteLine("Задайте другой номер"); 
// }
// } 
// Console.WriteLine("Введите точку: ");
// int num = Convert.ToInt32(Console.ReadLine());
// getDot(num);


// 3. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// Console.Clear();

// double distAB(int x1, int y1, int x2, int y2)
// {
// return Math.Sqrt(Math.Pow(Math.Abs((x2 - x1)), 2) + Math.Pow(Math.Abs((y2 - y1)), 2));
// }

// Console.WriteLine("Введите координту Х1: ");
// int xA = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координту Y1: ");
// int yA = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координту X2: ");
// int xB = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координту Y2: ");
// int yB = Convert.ToInt32(Console.ReadLine());

// double res = Math.Round(distAB(y2: yB, x1: xA, y1: yA, x2: xB), 2);

// Console.WriteLine("Длина отрезка: " + res);

// 4. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N
// Console.Clear();
// void listSqrt(int n)
// {
// int count = 1;

// Console.Write(n + "-> ");

// if (n > 0)
// {
// while (count <= n)
// {
// Console.Write(Math.Pow(count, 2) + ", ");
// count++;
// }
// }
// else
// {
// count = -1;
// while (count >= n)
// {
// Console.Write(Math.Pow(count, 2) + ", ");
// count--;
// }
// }
// }

// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// listSqrt(num);

// ДОМАШНЕЕ ЗАДАНИЕ

// 1. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// void Polindrom(int num)
// {
// int a1 = num%10;
// int a2 = num/10%10;
// int a3 = num/100%10;
// int a4 = num/1000%10;
// int a5 = num/10000;

// int b = a1 * 10000 + a2 * 1000 + a3 * 100 + a4 * 10 + a5;
// if (num == b){
//     Console.WriteLine("Введенное число является палиндромом");
// }
//  else
// {
//     Console.WriteLine("Введенное число не является палиндромом");
// }
// }
// Console.WriteLine("Введите пятизначное число: ");
// Polindrom(Convert.ToInt32(Console.ReadLine()));


// 2. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// double distAB(int x1, int y1, int x2, int y2, int z1, int z2)
// {
// return Math.Sqrt(Math.Pow(Math.Abs((x2 - x1)), 2) + Math.Pow(Math.Abs((y2 - y1)), 2) + Math.Pow(Math.Abs((z2 - z1)), 2));
// }

// Console.WriteLine("Введите координту Х1: ");
// int xA = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координту Y1: ");
// int yA = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координту X2: ");
// int xB = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координту Y2: ");
// int yB = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координту Z1: ");
// int zA = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координту Z2: ");
// int zB = Convert.ToInt32(Console.ReadLine());

// double res = Math.Round(distAB(y2: yB, x1: xA, y1: yA, x2: xB, z1: zA, z2: zB), 2);

// Console.WriteLine("Длина отрезка: " + res);


// 3. Напишите программу, которая принимает на вход число (N) и выдат таблицу кубов чисел от 1 до N.
// void listCube(int n)
// {
// int count = 1;
// Console.Write(n + " -> ");
// if (n > 0)
// {
// while (count <= n)
// {
// Console.Write(Math.Pow(count, 3) + ", ");
// count++;
// }
// }
// else
// {
// count = -1;
// while (count >= n)
// {
// Console.Write(Math.Pow(count, 3) + ", ");
// count--;
// }
// }
// }

// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// listCube(num);
