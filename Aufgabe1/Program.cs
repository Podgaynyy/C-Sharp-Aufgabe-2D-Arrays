//Aufgabe 1: Schreiben Sie ein Programm, das Elementpositionen als Eingabe verwendet
//in einem zweidimensionalen Array und gibt den Wert dieses Elements oder eine Angabe zurück,
//dass es kein solches Element gibt.

int[,] FillArray(int rows, int cols, int min, int max) //Programm, das ein zweidimensionales Array füllt
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
void PrintElement(int[,] array, int x, int y) //wobei x und y die Zeilen- und Spaltennummern des Arrays sind
{
    if (x < array.GetLength(0) || y < array.GetLength(1))
    {
        Console.WriteLine(array[x, y]); 
    }
    else { Console.WriteLine("Elementindizes liegen außerhalb des Arrays"); }
}

PrintElement((FillArray(5,5,0,100)),2,7);
