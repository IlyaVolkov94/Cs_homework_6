/*  Сгенерировать массив случайных целых чисел размерностью m*n (размерность вводим с клавиатуры).
Вывести на экран красивенько таблицей. Найти минимальное число и его индекс, найти максимальное число и его индекс.
Вывести эту информацию на экран.
*/

int[] FillTwoDimensionalArray(int row, int col)
{
    int[] oneDimentionalArray = new int[row * col];
    for (int i = 0; i < oneDimentionalArray.Length; i++)
        oneDimentionalArray[i] = new Random().Next(0, row * col);
    return oneDimentionalArray;
}

void PrintOneDimensionalAsTwoDimensional(int[] array, int rows, int cols)
{
    Console.WriteLine();
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i == j * rows + cols)
        {
            Console.WriteLine();
            j++;
        }
        Console.Write($"{array[i],3}\t");
    }
}

void MaxAndMinFromArray(int[] array, int rows, int cols)
{
    int resArraySize = 2;
    int[] resArray = new int[resArraySize];
    int indexMax = 0;
    int indexMin = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > array[indexMax])
        {
            array[indexMax] = array[i];
            indexMax = i;
        }
        if (array[i] < array[indexMin])
        {
            array[indexMin] = array[i];
            indexMin = i;
        }
    }
    int rowMax = 0;
    int tempIndexMax = indexMax;
    while (tempIndexMax > 0)
    {
        rowMax++;
        tempIndexMax /= cols;
    }
    int colMax = indexMax - rows * rowMax;
    int rowMin = 0;
    int tempIndexMin = indexMin;
    while (tempIndexMin > 0)
    {
        rowMin++;
        tempIndexMin /= cols;
    }
    int colMin = indexMin - rows*rowMin;

    Console.WriteLine($"Минимальное значение {array[indexMin]}; в {rowMin + 1} строке и {colMin + 1} столбце");
    Console.WriteLine($"Минимальное значение {array[indexMax]}; в {rowMax + 1} строке и {colMax + 1} столбце");
}

Console.WriteLine("Введите количество строк:");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов:");
int col = Convert.ToInt32(Console.ReadLine());
int[] array = FillTwoDimensionalArray(row, col);
MaxAndMinFromArray(array, row, col);
PrintOneDimensionalAsTwoDimensional(array, row, col);