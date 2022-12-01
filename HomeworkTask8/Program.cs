//Считываем данные с консоли
string? Num1Line = Console.ReadLine();

//Проверяем, чтобы данные были не пустыми
if (Num1Line != null)
{
    //Парсим введенное число
    int num1 = int.Parse(Num1Line);

    //Вводим дополнительные переменные
    int c = 2;
    string outResult = string.Empty;

    //Задаем условие для входа в цикл
    while (c <= num1)
{
        outResult = outResult + c + ",";
    c = c + 2;
}
    //Выводим данные в консоль
    Console.WriteLine(outResult);

}
