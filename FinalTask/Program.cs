// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
//При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
//Примеры:
//[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
//[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
//[“Russia”, “Denmark”, “Kazan”] → []

string[] inArray = new string[4] {"Hello", "2", "world", ":-)"};

string[] FillResultArray(string[] inArray)
{
    int count = 0;
    for (int i = 0; i < inArray.Length; i++)
    {
        if(inArray[i].Length <= 3)
        {
            count++;
        }
    }
    
    string[] outArray = new string[count];
    int j = 0;
    for (int i = 0; i < inArray.Length; i++)
    {
        if(inArray[i].Length <= 3)
        {
            outArray[j] = inArray[i];
            j++;
        }
    }

    return outArray;
}

void WriteArray(string[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

string[] resultArray = FillResultArray(inArray);
WriteArray(resultArray);