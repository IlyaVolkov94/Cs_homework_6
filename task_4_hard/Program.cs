/*  Сгенерировать массив случайных целых чисел размерностью m*n (размерность вводим с клавиатуры).
Вывести на экран красивенько таблицей. Найти минимальное число и его индекс, найти максимальное число и его индекс.
Вывести эту информацию на экран.
*/

int[] FillRandomArray(int value)
{
    int[] array = new int[value];
    int temp = new Random().Next(0, value);
    int j = 0;
    for (int i = 0; i < value; i++)
    {
        while (j < i)   //Проверяем рандомное число на наличие его в массиве
        {
            if (array[j] == temp)
            {
                temp = new Random().Next(0, value);
                j = 0;
            }
            else j++;
        }
        array[i] = temp;
    }
    return array;
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
    int indexMax = 0;
    int indexMin = 0;
    int Max = array[0];
    int Min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > Max)
        {
            Max = array[i];
            indexMax = i;
        }
        if (array[i] < Min)
        {
            Min = array[i];
            indexMin = i;
        }
    }
    int rowMax = indexMax / cols;
    int colMax = indexMax % cols;
    int rowMin = indexMin / cols;
    int colMin = indexMin % cols;
    Console.WriteLine(String.Empty);
    Console.WriteLine($"Минимальное значение {Min}; в {rowMin + 1} строке и {colMin + 1} столбце");
    Console.WriteLine($"Максимальное значение {Max}; в {rowMax + 1} строке и {colMax + 1} столбце");
}

Console.WriteLine("Введите количество строк:");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов:");
int col = Convert.ToInt32(Console.ReadLine());
int size = row * col;
int[] array = FillRandomArray(size);
MaxAndMinFromArray(array, row, col);
PrintOneDimensionalAsTwoDimensional(array, row, col);