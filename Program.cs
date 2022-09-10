/* Написать программу, которая из имеющегося массива строк формирует массив из строк, 
длина которых меньше либо равна 3-м символам. Первоначальный массив можно ввести с клавиатуры,
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться 
коллекциями, лучше обойтись исключительно массивами.
*/

string[] CreateArray(int count)
{
    
string[] newArray = new string[count];
count = newArray.Length;
for (int i = 0; i < count; i++)
{
    Console.Write($"Input airport {i+1}: ");
    newArray[i] = Console.ReadLine();
    Console.WriteLine();
}
return newArray;
}

void ShowStringArray (string[] array)
{    
for (int i = 0; i < array.Length; i++)
{
        Console.Write(array[i] + " ");
}
   Console.WriteLine();
}

string[] SecondStringArray(string[] array)
{
string[] newArray = new string[array.Length];
for (int i = 0; i < newArray.Length; i++)
    {
    if (array[i].Length <= 3) 
    newArray[i] = array[i];    
    }        
return newArray;
}

Console.Write("Input the number of airports: ");
int str = Convert.ToInt32(Console.ReadLine()); 
string[] firstArray = CreateArray(str);
Console.Write("The initial array is: ");
ShowStringArray(firstArray);
Console.WriteLine();
Console.Write("The result array is: ");
string[] secondArray = SecondStringArray(firstArray);
ShowStringArray(secondArray);
Console.WriteLine();
