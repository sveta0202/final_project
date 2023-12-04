// Написать программу, которая из имеющегося массива строк формирует 
// новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string[] firstArray = new string[5] {"hello", "94", "12345", "world", "cat"};
string[] finalArray = new string[firstArray.Length];

//-------------------------------------------------------

void FillingTheFinalArray(string[] firstArray, string[] finalArray)
{
    int count = 0;
    for (int i = 0; i < firstArray.Length; i++)
    {
        if(firstArray[i].Length <= 3)
        {
            finalArray[count] = firstArray[i];
            count++;
        }
    }
}

void PrintFinalArray(string[] finalArray)
{
    for (int i = 0; i < finalArray.Length; i++)
    {
        Console.Write($"{finalArray[i]} ");
    }
    Console.WriteLine();
}

//------------------------------------------------------------
FillingTheFinalArray(firstArray, finalArray);
PrintFinalArray(finalArray);








