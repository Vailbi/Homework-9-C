// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа 
// в промежутке от N до 1

InputSizeArray("Введите число: ");
int numN;

int InputSizeArray (string x)
{
    Console.Write(x);
    numN = Convert.ToInt32(Console.ReadLine());
    return numN;
}

void Recursion( int a)
{
    if (a>=1)
    {
        Console.Write(a+" ");
        Recursion(a-1);
    }
    else
    {
        Console.Write(a);
    }
}
Recursion(numN);