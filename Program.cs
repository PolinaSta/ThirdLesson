// 1. Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
void getDot (int x, int y){
if (x == 0 || y == 0){
Console.WriteLine("Нет возможности определить четверть");
}else{
if(x > 0 && y > 0)
Console.WriteLine("1 четверть");
if(x > 0 && y < 0)
Console.WriteLine("4 четверть");
if(x < 0 && y > 0)
Console.WriteLine("2 четверть");
if(x < 0 && y < 0)
Console.WriteLine("3 четверть");
}
}
Console.WriteLine("Введите две точки: ");
int x1 = Convert.ToInt32(Console.ReadLine());
int y1 = Convert.ToInt32(Console.ReadLine());

getDot(x1, y1);