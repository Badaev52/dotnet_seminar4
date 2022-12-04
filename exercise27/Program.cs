int num = inputInt();

int dig = numberOfDigits(num);

Console.WriteLine("Сумма цифр в числе равна: " + sumDigitsNumber(num, dig));


int inputInt()
{
    Console.WriteLine("Введите число: ");
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

int numberOfDigits(int number)
{
    int digits = 0;
    if (number == 0) return 1;
    while (number > 0)
    {
        number = number / 10;
        digits++;
    }
    return digits;
}

int sumDigitsNumber(int num, int digits)
{
    int res = 0;

    for (int i = 0; i < digits; i++)
    {
        res = res + num % 10;
        num = num / 10;
    }

    return res;
}
