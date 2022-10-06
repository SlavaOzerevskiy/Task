//Задача 4: Напишите программу, которая принимает на вход три числа 
//и выдаёт максимальное из этих чисел.

Console.Clear();
Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32( Console.ReadLine() );
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32( Console.ReadLine() );
Console.Write("Введите третье число: ");
int number3 = Convert.ToInt32( Console.ReadLine() );
int[] array1 = {number1, number2, number3};
int maxValue = array1[0];

for (int i = 1; i <= 2; i++) 
{
    if (maxValue < array1[i]) 
    {
        maxValue = array1[i];
    }
}

Console.WriteLine($"Наибольшее число: {maxValue}");
