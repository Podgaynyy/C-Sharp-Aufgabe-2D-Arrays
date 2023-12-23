//Задайте двумерный массив. Напишите программу,
//которая поменяет местами первую и последнюю строку массива.


int[,] FillArray(int rows, int cols) //Заполняем массив
{
    int[,] array = new int[rows, cols];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            array[i, j] = new Random().Next(10, 100);
        }
    }
    return array;
}

int[,] ZamenaStrok(int[,] array) //Метод, который заменяет строки в массиве
{
    int row1 = 0; //Первая строка будет иметь индекс 0
    int row2 = array.GetLength(1)-1; //а это индекс последней строки
    for (int i = 0; i < array.GetLength(1); i++) //Итерируем столбцы
    {
        int temp = array[row1, i]; // временная переменная для значения столбца в строке
        array[row1, i] = array[row2, i]; //меняем значения столбца в первой и последней строке
        array[row2, i] = temp;
    }
    return array;
}

void PrintArray(int[,] array) //выводим массив на экран
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for(int j= 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] array = FillArray(4, 4); //создали массив
PrintArray(array); //распечатали обычный массив
PrintArray(ZamenaStrok(array));//распечатали массив с заменёнными строками