
//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите трехзначное число");

//программа принимает число от пользователя

int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));

//высчитываем вторую цифру трехзначного числа


int digit_2 = ( number % 100 - (number % 10))/10;

// проверяем является ли число трехзначным

 if ((number > 999) || (number < 100) ) {
Console.WriteLine("Необходимо было ввести число от -999 до -100 или от 100 до 999");

}

else {

    Console.WriteLine($"Вторая цифра числа : {digit_2}");
}


