// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

int ReadData(string line)
{
    Console.WriteLine(line);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}

void PrintData(string prefix, string value)
{
    Console.WriteLine(prefix + value);
}

int PositiveElements(int length)
{
    int[] array = new int[length];
    int cont = 0;
    Console.WriteLine("Введите числа");
    for (int i = 0; i < length; i++)
    {
        array[i] = int.Parse(Console.ReadLine() ?? "");
        if (array[i] > 0)
            cont++;
    }
    return cont;
}

int length = ReadData("Введите количество чисел ");
int contPositiveElements = 0;
contPositiveElements = PositiveElements(length);
PrintData("Количество чисел более 0 = ", contPositiveElements.ToString());