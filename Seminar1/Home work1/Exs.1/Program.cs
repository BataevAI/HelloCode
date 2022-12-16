//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = -9 b = -3 -> max = -3



Console.WriteLine("Введите первое целое число");
int number1 = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Введите второе целое число");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2) {

Console.WriteLine($"первое число: {number1} больше второго числа: {number2}");

}

else Console.WriteLine($"первое число: {number2} больше второго числа: {number1}");

