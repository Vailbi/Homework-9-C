// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n. 

Console.WriteLine("Введите число M:");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N:");
int N = Convert.ToInt32(Console.ReadLine());

int RecAkkerman(int a, int b)
{
    if (a==0)
    return b+1;
    else if ((a != 0) && (b==0))
    return RecAkkerman(a-1,1);
    else
    return RecAkkerman(a-1,RecAkkerman(a,b-1));
}

Console.WriteLine(RecAkkerman(M,N));