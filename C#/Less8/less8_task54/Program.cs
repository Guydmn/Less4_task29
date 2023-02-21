
Console.Write("Введите высоту массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите длинну массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int [,] doubleArray = new int [m, n];

Random rnd = new Random();

for (int i = 0; i < doubleArray.GetLength(0); i++)
{
    for (int j = 0; j < doubleArray.GetLength(1); j++)
    {
        doubleArray[i, j] = rnd.Next(0, 10);
        Console.Write($"{doubleArray[i, j]} ");
    }
    Console.WriteLine();
}
Console.WriteLine($"Массив после сортировки каждого ряда: ");

for (int i = 0; i < doubleArray.GetLength(0); i++)
{
    for (int j = 0; j < doubleArray.GetLength(1) - 1; j++)
    {
        for (int k = 0; k < doubleArray.GetLength(1) - j - 1; k++)
        {
            if (doubleArray[i, k] < doubleArray[i, k + 1])
            {
                int temp = doubleArray[i, k];
                doubleArray[i, k] = doubleArray[i, k + 1];
                doubleArray[i, k + 1] = temp;
            }
        }
    }
}

for (int i = 0; i < doubleArray.GetLength(0); i++)
{
    for (int j = 0; j < doubleArray.GetLength(1); j++)
    {
        Console.Write($"{doubleArray[i, j]} ");
    }
    Console.WriteLine();
}




// doubleArray[i, j-1] > max ||

//  max = doubleArray[i, j];
// doubleArray[i, j] = doubleArray[i, j-1];
// doubleArray[i, j-1] = max;

// doubleArray[i, j] > doubleArray[i, j-1]

// temp[i, j] = doubleArray[i, j];
// doubleArray[i, j] = doubleArray[i, j-1];
// doubleArray[i, j-1] = temp[i, j];

// temp = doubleArray[i,j];
// doubleArray[i, j] = doubleArray[i, j-1]; 
// doubleArray[i, j-1] = temp;

//  while (doubleArray[i, j] > max)
//                 {
//                     max = doubleArray[i, j];
//                     doubleArray[i, j] = doubleArray[i, j-1];
//                     doubleArray[i, j-1] = max;
//                 }