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