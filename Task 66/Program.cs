// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.WriteLine("Введите число M:");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N:");
int N = Convert.ToInt32(Console.ReadLine());

int SumRec(int num1, int num2)
{
    if (num1==num2) return num1;
    else return num1 + SumRec(num1+1,num2);
}
Console.WriteLine(SumRec(M,N));


