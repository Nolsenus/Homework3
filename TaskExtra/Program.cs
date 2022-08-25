int SquareSumZero() {
    int sum = 0;
    int squareSum = 0;
    try {
        do {
            int nextNum = Convert.ToInt32(Console.ReadLine());
            sum += nextNum;
            squareSum += nextNum * nextNum;
        } while (sum != 0);
    } catch {
        Console.WriteLine("Вы ввели не целое число.");
    }
    return squareSum;
}

Console.WriteLine("Вводите целые числа, чтобы закончить введите такое число, чтобы сумма всех чисел была равна 0");
Console.WriteLine(SquareSumZero());