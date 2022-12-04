Task64();

Console.ReadKey();
Task66();

Console.ReadKey();
Task68();


void Task64()
{
    Console.WriteLine("\nЗадача 64: Задайте значение N. Напишите программу, которая выведет все " +
                        "натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии." +
                        "\nN = 5 -> [5, 4, 3, 2, 1]\nN = 8 -> [8, 7, 6, 5, 4, 3, 2, 1]");


    int number = ReadIntFromConsole("Введите число N: ");
    Console.WriteLine("[" + PrintNumber(number) + "]");
}

void Task66()
{
    Console.WriteLine("\nЗадача 66: Задайте значения M и N. Напишите программу, которая найдёт " +
                         "сумму натуральных элементов в промежутке от M до N." +
                         "\nM = 1, N = 15 -> 120\nM = 4, N = 8 -> 30");


    int numberM = ReadIntFromConsole("Введите число M: ");
    int numberN = ReadIntFromConsole("Введите число N: ");

    if (numberM > numberN) (numberM, numberN) = (numberN, numberM);

    Console.WriteLine($"Сумма элементов в промежуте от {numberM} до {numberN} -> {SumNumber(numberM, numberN)}");
}

void Task68()
{
    Console.WriteLine("\nЗадача 68: Напишите программу вычисления функции Аккермана с помощью " +
                        "рекурсии. Даны два неотрицательных числа m и n." +
                        "\nm = 2, n = 3 -> A(m,n) = 9\nm = 3, n = 2 -> A(m,n) = 29");

    int numberM = ReadIntFromConsole("Введите число m: ");
    int numberN = ReadIntFromConsole("Введите число n: ");

    int result = AckermanFunction(numberM, numberN);

    Console.WriteLine($"Результат вычисления функции Аккермана -> {result}");
}


int ReadIntFromConsole(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

string PrintNumber(int num)
{
    if (num == 1) return num.ToString();
    return (num + ", " + PrintNumber(num - 1));
}

int SumNumber(int num1, int num2)
{
    if (num1 == num2) return num1;
    return num2 + SumNumber(num1, num2 - 1);
}

int AckermanFunction(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return AckermanFunction(m - 1, 1);
    else return AckermanFunction(m - 1, AckermanFunction(m, n - 1));
}
