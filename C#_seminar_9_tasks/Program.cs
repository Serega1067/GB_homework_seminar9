/*
Задача 2.
Показать треугольник Паскаля. Сделать вывод в виде равнобедренного 
треугольника.
*/

int[,] CreateTriangle(int size)
{
    int[,] triangle = new int[size, size];
    for (int i = 0; i < size; i++)
    {
        triangle[i, 0] = 1;
        triangle[i, i] = 1;
    }
    for (int i = 2; i < size; i++)
    {
        for (int j = 1; j < i; j++)
        {
            triangle[i, j] = triangle[i - 1, j - 1] + 
                             triangle[i - 1, j];
        }
    }
    return triangle;
}

void PrintTriangle(int[,] argTriangle)
{
    for (int i = 0; i < argTriangle.GetLength(0); i++)
    {
        for (int j = argTriangle.GetLength(1) - 1; j >= 0; j--)
        {
            if (argTriangle[i, j] > 0)
            {
                Console.Write(argTriangle[i, j] + 
                              WhiteSpace(argTriangle[i, j]));
            }
            else
            {
                Console.Write("   ");
            }
        }
        Console.WriteLine();
    }
}

string WhiteSpace(int argNum)
{
    string s = "";
    int count = Convert.ToString(argNum).Length;
    for (int i = 0; i < 6 - count; i++)
    {
        s = s + " ";
    }
    return s;
}

Console.WriteLine("Нарисуем числами равнобедренный треугольник");
Console.WriteLine("Введите высоту треугольника: ");
int heightTriangle = Convert.ToInt32(Console.ReadLine());

PrintTriangle(CreateTriangle(heightTriangle));
