int a = inputInt("размер массива");

int[] array = new int[a];
newArray(array);
printArray(array);

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

void newArray(int[] array)
{

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = inputInt("массива " + i);
    }

}


void printArray(int[] array)
{

    for (int i = 0; i < array.Length; i++)
    {

        if (i == 0) Console.Write("[ ");
        Console.Write(array[i]);
        if (i < array.Length - 1) Console.Write(", ");
        if (i == array.Length - 1) Console.Write(" ]");
    }

}