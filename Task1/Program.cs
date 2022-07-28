//Программа задает массив заполненный случайными положительными трёхзначными числами. 

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

//Программа выводит массив в терминал
void ShowArray (int[] array) // Войд - потому что выводит на экран и ничего не возвращает
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();  
}

//Программа показывает количество чётных чисел в массиве.
int EvenDigit (int[] array)
{
    int sum = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]% 2 == 0)
        {
            sum++;
        }
    }
    return sum;
}

int[] myArray = FillRandomArray(8,100,999);
ShowArray(myArray);

Console.WriteLine("Number of even elements in the array" + EvenDigit(myArray)); 