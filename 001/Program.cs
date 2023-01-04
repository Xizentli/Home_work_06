/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

//1. метод получения числа с консоли //размерность массива задается пользователем
int GetSizeArray(string message)
{
    int result;
    while (true)
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число.");
        }
    }
    return result;
}

//2. метод инициализации массива //элементы массива вводит пользователь
int[] InitArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = GetSizeArray($"Введите {i+1}е число из {size} чисел: ");
    }
    return array;
}

//3. метод печати массива
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

//4. метод подсчета чисел, больше нуля
int CountNumber(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
        count++;
    }
    return count;
}

int size = GetSizeArray("Укажите сколько чисел вы хотите ввести: ");
int[] array = InitArray(size);
Console.WriteLine("Введенные числа: ");
PrintArray(array);
int number = CountNumber(array);
Console.WriteLine($"Вы ввели {number} чисел больше 0.");