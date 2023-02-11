

int number;
{
    bool number_is_correct;

    do
    {
        Console.Write("Введите число ");
        string text = Console.ReadLine();        

        number_is_correct = int.TryParse(text, out number);

        if (!number_is_correct)
        {
            Console.ForegroundColor= ConsoleColor.Red;
            Console.WriteLine("Введено не число");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
    while(!number_is_correct);

    Console.Write($"{number}^2 = {number * number}");

}

/*int number, number_2;

Console.Write("Введите 1 число");
int.TryParse(Console.ReadLine(), out number);

Console.Write("Введите 1 число");
int.TryParse(Console.ReadLine(), out number);

Console.Write($"{number}^2 = {number * number}");*/