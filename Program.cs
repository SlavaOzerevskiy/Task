//Задача 2: Напишите программу, которая на вход принимает два числа 
//и выдаёт, какое число большее, а какое меньшее.

Console.Clear();
Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32( Console.ReadLine() );
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32( Console.ReadLine() );

if (number1 > number2) 

{
    Console.WriteLine($"Число {number1} больше, чем число {number2}");
}
else 
{
    Console.WriteLine($"Число {number2} больше, чем число {number1}");
}


//Задача 4: Напишите программу, которая принимает на вход три числа 
//и выдаёт максимальное из этих чисел.

// Console.Clear();
// Console.Write("Введите первое число: ");
// int number1 = Convert.ToInt32( Console.ReadLine() );
// Console.Write("Введите второе число: ");
// int number2 = Convert.ToInt32( Console.ReadLine() );
// Console.Write("Введите третье число: ");
// int number3 = Convert.ToInt32( Console.ReadLine() );
// int[] array1 = {number1, number2, number3};
// int maxValue = array1[0];

// for (int i = 1; i <= 2; i++) 
// {
//     if (maxValue < array1[i]) 
//     {
//         maxValue = array1[i];
//     }
// }

// Console.WriteLine($"Наибольшее число: {maxValue}");

// //Задача 6: Напишите программу, которая на вход принимает число 
// //и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// Console.Clear();
// Console.Write("Введите число: ");
// int numberValue = Convert.ToInt32( Console.ReadLine() );

// if (numberValue % 2 == 0) 
// {
//     Console.Write("Число является четным");
// }
// else
// {
//     Console.Write("Число является нечетным");
// }


// //Задача 8: Напишите программу, которая на вход принимает число (N), 
// //а на выходе показывает все чётные числа от 1 до N.


// Console.Clear();
// Console.Write("Введите число: ");
// int numberValue = Convert.ToInt32( Console.ReadLine() );
// string StringValue = "";

// for (int i = 1; i <= numberValue; i++) 
// {
//     if (i % 2 == 0) 
//     {
//         StringValue = StringValue + " " + i;
//     }
// }

// Console.WriteLine(StringValue);
