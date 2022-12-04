//Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом. Задание должно быть выполнено в методе.
// В методе не должно быть вывода в консоль. Не использовать String!
//14212 -> нет
//12821 -> да
//23432 -> да



int InputInt()
{
    Console.WriteLine("Введите число");
    bool uinput= int.TryParse(Console.ReadLine(),out int number);

    if(uinput)
    {
        return number;
    }
    else
    {
        Console.WriteLine("Введено некорректное значение");
    }
    return -1;
}

int number = InputInt();
    int newNumber = 0;

        for (int i = number; i > 0; i = (i / 10))
        {
            int remain = i % 10;
            
            newNumber = (newNumber * 10) + remain;
        }

        if (newNumber == number)
        {
            Console.Write("Число является палиндромом");
        }
        else
        {
            Console.WriteLine("Число не является палиндромом");
        }