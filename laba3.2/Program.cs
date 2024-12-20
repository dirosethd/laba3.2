        Console.Write("Введите натуральное число N (N >= 10): ");
        int N;

        while (!int.TryParse(Console.ReadLine(), out N) || N < 10)
        {
            Console.Write("Введите корректное натуральное число N (N >= 10): ");
        }

        for (int i = 10; i <= N; i++)
        {
            int firstDigit = GetFirstDigit(i);
            int sumOfDigits = GetSumOfDigits(i);

            Console.WriteLine($"Число: {i}, Первая цифра: {firstDigit}, Сумма цифр: {sumOfDigits}");
        }
    static int GetFirstDigit(int number)
    {
        while (number >= 10)
        {
            number /= 10;
        }
        return number;
    }

    static int GetSumOfDigits(int number)
    {
        int sum = 0;
        while (number > 0)
        {
            sum += number % 10;
            number /= 10;
        }
        return sum;
    }
