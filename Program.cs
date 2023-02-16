string[] NewStringArrayInput(int size) //задаем длину массива
{
    string[] newStringArray = new string[size];

    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите {i}-й элемент массива: ");
        newStringArray[i] = Console.ReadLine()!;
        
    }

    return newStringArray;
}

