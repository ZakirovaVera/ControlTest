// Задача: Написать программу, которая из имеющегося массива строк формирует 
// массив из строк, длины которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте 
// выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.
// Примеры:
// ["hello", "2", "world", ":-)"] ->["2", ":-)"]
// ["1234", "1567", "2", "computer science"] ->["2"]
// ["Russia", "Denmark", "Kazan"] ->[]

string[] arrayFirst = { "hello", "2", "world", ":-)" };
Console.WriteLine($"[{String.Join(", ", arrayFirst)}]");

string[] arraySecond = FillTheSecondArray(arrayFirst);
Console.WriteLine($"[{String.Join(", ", arraySecond)}]");

string[] FillTheSecondArray(string[] arrFirst)
{
    int count = 0;
    string[] arrSecond = new string[count];
    
    foreach(var item in arrFirst)
    {
        if (item.Length <= 3)
        {            
            Array.Resize(ref arrSecond, arrSecond.Length + 1);
            arrSecond[count] = item;
            count++;
        }
    }
    return arrSecond;
}
