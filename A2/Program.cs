﻿int N = new Random().Next(100, 1000);

Console.WriteLine("Компьютер выбрал число: " + N);

//int a1 = N/10;
//int a11 = a1/10;
int a11 = N/100;
int a3 = N%10;
int a2 = a1%10;
int N1 = 10*a11 + a3;

// Console.WriteLine("Вспомогательный расчет: " + a1);
// Console.WriteLine("Второе число: " + a2);
Console.WriteLine("Третье число: " + a3);
Console.WriteLine("В итоге двузначное число: " + N1);

