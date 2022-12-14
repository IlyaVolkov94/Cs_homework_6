// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.

int[] InputArray(int value)  //Функция ввода координат
{
    int[] array = new int[value];
    string text = string.Empty;
    for (int i = 0; i < value; i++)
    {
        if (i == 0 || i == 1) text = "k" + (i + 1);
        if (i == 2 || i == 3) text = "b" + (i - 1);
        Console.WriteLine($"Введите коэффициент {text}");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

double[] FunctionsCross(int[] array)
{
    int coordinatesSize = 2;
    double[] coordinates = new double[coordinatesSize];
    int coodinateX=0;
    int coodinateY=1;
    int indexK1=0;
    int indexK2=1;
    int indexB1=2;
    int indexB2=3;
    coordinates[coodinateX] = (double)(array[indexB2] - array[indexB1]) / (array[indexK1] - array[indexK2]);
    coordinates[coodinateX] = Math.Round(coordinates[coodinateX], 2);
    coordinates[coodinateY] = (double)(array[0] * coordinates[coodinateX] + array[2]);
    coordinates[coodinateY] = Math.Round(coordinates[coodinateY], 2);
    return coordinates;
}

void PrintInfo(double[] array)
{
    string text = string.Empty;
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) text = "Координата X: ";
        if (i == 1) text = "Координата Y: ";
        Console.WriteLine(text + array[i]);
    }
}

int inputSize = 4;
int[] array = InputArray(inputSize);
PrintInfo(
    FunctionsCross(
        array
    )
);