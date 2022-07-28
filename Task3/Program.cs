//Программа задает массив вещественных чисел
double [] FillRandomArray()
{
    double[] array = new double[new Random().Next(4,12)]; // генерируется случайный размер массива в указанном диапозоне
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 99) + new Random().NextDouble();
    }
    return array;
}

//Программа выводит заданный массив на экран
void ShowArray (double[] array) 
{
    for (int i = 0; i < array.Length; i++)
    Console.WriteLine("{0:0.##}", array[i]);

    Console.WriteLine();  
}

//Программа находит разницу между максимальным и минимальным элементми массива
double DiffMinMax (double[] array)
{
    double maxNumber = array[0];
    double minNumber = array[0];

    for (int i = 1; i < array.Length; i++)
    {
        if (maxNumber < array[i])
        {
            maxNumber = array[i];
        }
            if (minNumber > array[i])
        {
            minNumber = array[i];
        }
    }
    double decision = maxNumber - minNumber;
    return decision;
}

// Программа ограничивает количество знаков после запятой и выводит результат на экран
void CutDownNum (double num)
{
    Console.WriteLine("The difference between the largest and smallest array element is " + "{0:0.##}", num); // вот тут не до конца разобралась
    // стоит ли это делать как метод, или это нужно после метода записать, при его вызове
}

double[] myArray = FillRandomArray();
ShowArray(myArray);

double num = DiffMinMax(myArray);
CutDownNum(num);