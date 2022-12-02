// Хотим найти сумму чисел от 1 до 10 включительно

int a=1;
int sum =1;

while (a <=10) // работаем до тех пор пока  а не вышли за 10
{
    a++;

    Console.WriteLine (" a = " + a);
    sum = sum + a;
    Console.WriteLine ("Текущая Сумма = " + sum);

}

Console.WriteLine ("Итогова Сумма = " + sum);
