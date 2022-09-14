// 2-ой вариант решения задачи:  Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.Write(" Введите значение числа A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write(" Введите значение числа B: ");
int B = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Math.Pow(A, B));
