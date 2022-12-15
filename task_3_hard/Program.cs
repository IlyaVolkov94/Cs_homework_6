/* На вход программы подаются три целых положительных числа.
Определить , является ли это сторонами треугольника.
Если да, то вывести всю информацию по нему - площадь, периметр, значения углов треугольника в градусах,
является ли он прямоугольным, равнобедренным, равносторонним.
*/

double[] InputArray()
{
    int inputSize = 3;
    double[] array = new double[inputSize];
    for (int i = 0; i < inputSize; i++)
    {
        Console.WriteLine($"Введите {i + 1} сторону");
        array[i] = Convert.ToDouble(Console.ReadLine());
    }
    return array;
}

double[] SortArray(double[] array)    //Сортировка выбором
{
    double[] sortArray = new double[array.Length];
    for (int i = 0; i < array.Length; i++)
        sortArray[i] = array[i];
    for (int i = 0; i < sortArray.Length; i++)
        for (int j = i; j < sortArray.Length; j++)
            if (sortArray[i] < sortArray[j])
                (sortArray[i], sortArray[j]) = (sortArray[j], sortArray[i]);
    return sortArray;
}

string InfoArray(double[] inputArray)
{
    string text = string.Empty;
    double perimeter = 0;
    foreach (double buf in inputArray)
        perimeter += buf;
    double area = perimeter / 2;
    foreach (double buf in inputArray)
        area *= (perimeter / 2 - buf);
    area = Math.Sqrt(area);
    double height = 2 * area / inputArray[0];
    int anglesSize = 3;
    double[] angles = new double[anglesSize];
    int j = anglesSize - 1;
    while (j > 0)
    {
        angles[j] = Math.Round((180 / Math.PI) * Math.Asin(height / inputArray[j]), 1);
        j--;
        if (j == 0)
            angles[j] = Math.Round(180 - angles[j + 1] - angles[j + 2], 1);
    }
    text = "Периметр равен: " + perimeter + "; Площадь равна: " + Math.Round(area, 2) + "; ";
    {
        for (int k = 0; k < anglesSize; k++)
            text += " Угол " + (k + 1) + ": " + angles[k] + ";";
        double temp = angles[2];
        int count = 0;
        foreach (double buf in angles)
            if (temp == buf) count++;
        switch (count)
        {
            case 2:
                text += " Равнобедренный";
                break;
            case 3:
                text += " Равносторонний";
                break;
            default:
                text += " Разносторонний";
                break;
        }
        int indexMaxAngle = 0;
        int rightAngle = 90;
        if (angles[indexMaxAngle] == rightAngle)
            text += " прямоугольный треугольник";
        else
            text += " треугольник";
    }
    return text;
}

bool CheckArray(double[] array)
{
    bool flag = false;

    for(int i=0; i<array.Length; i++)
    {
        
    }

    return flag;
}

double[] array = InputArray();
array = SortArray(array);
Console.WriteLine(InfoArray(array));