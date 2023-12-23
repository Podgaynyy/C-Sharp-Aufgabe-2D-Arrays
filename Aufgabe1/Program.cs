//Задача 1: Напишите программу, которая на вход принимает позиции элемента
//в двумерном массиве, и возвращает значение этого элемента или же указание,
//что такого элемента нет.


int[,] FillArray(int rows, int cols, int min, int max) //Программа, которая заполняет 2хмерный массив
{
    int[,] array =  new int[rows, cols];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            array[i,j] = new Random().Next(min, max);
        }
    }
    return array;
}
void PrintElement(int[,] array, int x, int y) //где х и y будут номерами строк и столбцов массива
{
    if (x < array.GetLength(0) || y < array.GetLength(1))
    {
        Console.WriteLine(array[x, y]); 
    }
    else { Console.WriteLine("индексы элемента находятся за пределами массива"); }
}

PrintElement((FillArray(5,5,0,100)),2,7);