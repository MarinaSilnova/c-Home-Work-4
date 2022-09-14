//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.Write(" Введите значение числа A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write(" Введите значение числа B: ");
int B = Convert.ToInt32(Console.ReadLine());
int Sq = 1;
for(int i = 1; i <= B; i++)
    Sq = Sq * A;
Console.WriteLine(Sq);