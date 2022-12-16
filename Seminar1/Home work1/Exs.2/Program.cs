
//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7

//просим ввести длину массива чисел, в которых будем искать максимальное

Console.Write("Введите количество целых чисел для поиска максимального: ");

int amount = Convert.ToInt32(Console.ReadLine());

// создаем массив с длиной, введеной пользователем

int [] numbers = new int[amount] ;

// вводим данные числа последовательно в массив

for (int i = 0; i < amount; i++) {

Console.Write("Введите  целое число: ");


numbers[i] = Convert.ToInt32(Console.ReadLine());

}



// объявляем по умолчанию максимальным первый член массива

int maxNumber = numbers[0];

// ищем и выводим максимальный член массива

for (int i = 0; i < numbers.Length - 1; i++) {

        if (numbers[i] < numbers[i + 1]) {

            maxNumber = numbers[i + 1];

        }

}
Console.WriteLine($"максимальное число: {maxNumber}");

