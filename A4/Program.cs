// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

// 14 -> нет 
// 46 -> нет 
// 161 -> да



Console.Write ("Enter the first number: "); 
int N1 = int.Parse(Console.ReadLine()!);


if (N1%7 == 0 && N1%23 == 0)
{
    Console.WriteLine ("-----> да");

    // Console.Write ("Число" + N1 +  "кратно числу" + N2 "); это то же самое, что и выше, но длиннее
}

else 
{
    Console.WriteLine ("----> нет ");
}




