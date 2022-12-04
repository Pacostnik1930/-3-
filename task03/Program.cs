//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// Задание должно быть выполнено в методе и метод должен вернуть массив чисел.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

int num = InputInt();
int[] cubeTable = GetCubeTable(num);

int InputInt()
{
    Console.WriteLine("Введите целое число");
    bool isNum = int.TryParse(Console.ReadLine(), out int num);
    if (isNum)
    {
        return num;
    }
    else
    {
        Console.WriteLine("Введено неправильное значение");
        return -1;
    }

}

int[] GetCubeTable(int num)
{
    int[] array = new int[num];
    for (int i = 0; i < num; i++)
    {
        array[i] = (int)((Math.Pow(i + 1, 3)));
    }
    return array;

}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}");
        
    }
    Console.WriteLine();
    
}


PrintArray(cubeTable);
