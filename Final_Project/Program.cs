using System;
using static System.Console;

Clear();
Write("Введите количество элементов массива: ");
int size = int.Parse(ReadLine()!);
string[] Array = new string[size];

WriteLine($"Введите {size} непустых элементов строкового массива, разделяя их клавишей Enter:");
FillStringArray(Array);
WriteLine();
PrintStringArray(Array);
Write(" -> ");
string[] SecondArray = GetSecondArray(Array); 

PrintStringArray(SecondArray);


string[] GetSecondArray(string[] Array)
{
    // расчет длины нового массива
    int SecondArraySize = 0;
    for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i].Length <= 3) SecondArraySize++;
    }
    
    
    string[] result = new string[SecondArraySize];

    int SecondIndex = 0;

    for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i].Length <= 3)
        {
            result[SecondIndex] = Array[i];
            SecondIndex++;
        }
    }

    return result;
}


// заполнение массива строк
void FillStringArray(string[] Array)
{
    int length = Array.Length;
    int index = 0;
    string CurrentStr;                  // текущая строка, вводимая с клавиатуры
    while (index < length)
    {
        CurrentStr = ReadLine()!;
        if (CurrentStr != "" )          // проверка, что строка не пустая
        {
            Array[index] = CurrentStr; 
            index++;
        }
    }
}


// вывод массива строк
void PrintStringArray(string[] Array)
{
    Console.Write("[ ");
    for (int i = 0; i < Array.Length; i++)
    {
        Write($"{Array[i]} ");
    }
    Console.Write("]");
}
