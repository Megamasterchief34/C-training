// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
System.Console.Write("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
if (number % 7 == 0 && number % 23 == 0)
{
   System.Console.WriteLine("Данное число одновременно кратно 7 и 23!");
}
else
{
   System.Console.WriteLine("Данное число не кратно 7 и 23!"); 
}