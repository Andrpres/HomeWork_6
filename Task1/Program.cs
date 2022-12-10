/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
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

//Проверяем сколько чисел больше 0
int FinishResult (int[]array){
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}

int[] resultArray = Numbers();
PrintArray(resultArray);
int finishResult = FinishResult(resultArray);
Console.WriteLine($"-> {finishResult}");