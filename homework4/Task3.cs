﻿// Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.
Console.Write("Введите координаты X точки: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты Y точки: ");
int y = Convert.ToInt32(Console.ReadLine());
if (x == 0 || y == 0)
{
    Console.WriteLine("Точка находится на оси координат");
}
else
{
   if (x > 0 && y > 0)
   {
    Console.WriteLine("1");
   }
   else
   {
      if (x < 0 && y > 0)
      {
        Console.WriteLine("2");
      }
      else 
      {
         if (x < 0 && y < 0)
         {
            Console.WriteLine("3");
         }
         else
         { 
            Console.WriteLine("4");
         }            
       }
    }
}    




