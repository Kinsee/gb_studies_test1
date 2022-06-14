// Задача 2: Напишите программу, которая на вход
// принимает два числа и выдаёт, какое число большее, а
// какое меньшее.


Console.WriteLine("Task 2. Write first number");

int num1=int.Parse(Console.ReadLine());


Console.WriteLine("Write second number");
int num2=int.Parse(Console.ReadLine());

//Console.Write(num1+" "+ num2);

if ( num1>num2)
    {
Console.WriteLine("max="+num1);
    }
else
    {
        Console.WriteLine("max="+num2);
    }

//     Задача 4: Напишите программу, которая принимает на
// вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Task 4. Write first number");
int num1=int.Parse(Console.ReadLine());
Console.WriteLine("Write second number");
int num2=int.Parse(Console.ReadLine());
Console.WriteLine("Write third number");
int num3=int.Parse(Console.ReadLine());

int max=num1;

if (max<num2)
    {
        max=num2;
    }
if (max<num3)
    {
        max=num3;
    }

// Console.Write("maximum = "+max);

// Задача 6: Напишите программу, которая на вход
// принимает число и выдаёт, является ли число чётным
// (делится ли оно на два без остатка).

Console.WriteLine("Task 6. Write а number");
int num=int.Parse(Console.ReadLine());

if (num%2==0)
    {
        Console.Write("четное");
    }
if (num%2!=0)
    {
        Console.Write("нечетное");
    }

// Задача 8: Напишите программу, которая на вход
// принимает число (N), а на выходе показывает все чётные
// числа от 1 до N.

Console.WriteLine("Task 8. Write а number");
int num=int.Parse(Console.ReadLine());
int i=1;
while (i<=num)

    {if (i%2==0)
{
   Console.Write(i+" "); 
   i++;
}
else i++;
    }
