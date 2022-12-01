//Считываем данные с консоли
string? Num1Line = Console.ReadLine();

//Проверяем, чтобы данные были не пустыми
if (Num1Line != null)
{
    //Парсим введенное число
    int num1 = int.Parse(Num1Line);

    //Вводим дополнительную переменную
    int c = num1 % 2;

    //Задаем условие
    if (c == 0)

        Console.WriteLine("Четное");

    else

        Console.WriteLine("Нечетное");


}