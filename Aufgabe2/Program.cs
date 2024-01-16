//Setze ein zweidimensionales Array. Schreiben Sie ein Programm
//was die erste und letzte Zeile des Arrays vertauscht.


int[,] FillArray(int rows, int cols) //Array ausfüllen
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

int[,] ZamenaStrok(int[,] array) //Methode, die Strings in einem Array ersetzt
{
    int row1 = 0; 
//Die erste Zeile hat den Index 0
    int row2 = array.GetLength(1)-1; //und das ist der Index der letzten Zeile
    for (int i = 0; i < array.GetLength(1); i++) //Iteriere die Spalten
    {
        int temp = array[row1, i]; // temporäre Variable für Spaltenwert in Zeile
        array[row1, i] = array[row2, i]; //Ändern Sie die Spaltenwerte in der ersten und letzten Zeile
        array[row2, i] = temp;
    }
    return array;
}

void PrintArray(int[,] array) //zeige das Array auf dem Bildschirm an
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

int[,] array = FillArray(4, 4); //ein Array erstellt
PrintArray(array); //ein reguläres Array gedruckt
PrintArray(ZamenaStrok(array));
//ein Array mit ersetzten Strings gedruckt
