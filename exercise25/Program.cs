
int a = inputInt("A");
int b = inputInt("B");

Console.WriteLine("Результат равен: " + intPow(a, b));



int inputInt(string name)
{
    Console.WriteLine("Введите число " + name + ": ");
    bool isInt = int.TryParse(Console.ReadLine(), out int num);
    if (isInt)
    {
        return num;
    }
    else
    {
        Console.WriteLine("Вы ввели некорректное число!");
        return -1;
    }
}

int intPow(int a, int b)
{
    int res = a;
    if (b == 0 ) return 1;
    if (b == 1 ) return a;
    for (int i = 2; i <= b; i++)
    {
        res = res * a;


    }

    return res;
}