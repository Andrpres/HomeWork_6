/*
Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.
*/

// Получение числа с консоли
int GetNumberFromConsole(string message){
    bool isCorrect = false;
    int result = 0;

    while (!isCorrect)
    {
        Console.WriteLine(message);

        if (int.TryParse(Console.ReadLine(), out result))
        {
            isCorrect = true;
        }
        else
        {
            Console.WriteLine("Ввели не число. Введите число");
        }
    }
    return result;
}

//Добавляем все введенные числа в массив
int[] Numbers(){
    int[] numbers = new int[5];
    for (int i = 0; i < 5; i++)
    {
        numbers[i] = GetNumberFromConsole("Введите число");
    }
    return numbers;
}

//метод, который будет печатать массив
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

//Копируем массив поэлементно
int[] Copy(int[]array){
    int[] copy = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        copy[i] = array[i];
    }
    return copy;
}

int[] resultArray = Numbers();
Console.WriteLine($"Ваш массив: ");
PrintArray(resultArray);
Console.WriteLine();

int[] resultCopy = Copy(resultArray);
Console.WriteLine($"Копия вашего массива: ");
PrintArray(resultCopy);