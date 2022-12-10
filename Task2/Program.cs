/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
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

// Ищем точку пересечения двух прямых
void Dotes (double[]array){
    double x = (array[2] - array[0]) / (array[1] - array[3]);
    double y = array[1] * x + array[0];
    
    Console.Write($"({x}; {y})");
}

double[] kb = new double[4]; 
kb[0] = GetNumberFromConsole("Введите b1");
kb[1] = GetNumberFromConsole("Введите k1");
kb[2] = GetNumberFromConsole("Введите b2");
kb[3] = GetNumberFromConsole("Введите k2");

Dotes(kb);

