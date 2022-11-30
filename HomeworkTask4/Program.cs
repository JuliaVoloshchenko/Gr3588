string? Num1Line = Console.ReadLine();
string? Num2Line = Console.ReadLine();
string? Num3Line = Console.ReadLine();



if (Num1Line != null && Num2Line != null && Num3Line != null)
{
    int num1 = int.Parse(Num1Line);
    int num2 = int.Parse(Num2Line);
    int num3 = int.Parse(Num3Line);
   
    if (num1 > num2)
    {
       if (num1 > num3)
        Console.WriteLine("max"+num1);
       else
       Console.WriteLine("max"+num3);

    }
    else
    {
        if (num2 > num3)
        Console.WriteLine("max"+num2);
        else
         Console.WriteLine("max"+num3);
    }
    
}
