//Программа задает массив и заполняет его случайными числами

int[] FillRandomArray(int size, int min, int max)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max+1);
    }
    Console.WriteLine();
    return array;
}

//Программа выводит заданный массив в терминал
void ShowArray (int[] array) 
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();  
}

//Программа находит сумму элементов, стоящих на нечётных позициях.

int SumEvenDigit (int[] array)
{
    int sum = 0;

    for (int i = 0; i < array.Length; i+=2)
    {
        sum = sum+array[i];
    }
    return sum;
}

int[] myArray = FillRandomArray(8, 1, 9);
ShowArray(myArray);

Console.WriteLine("Number of even elements in the array is " + SumEvenDigit(myArray)); 

