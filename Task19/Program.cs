bool IsFiveDigitPalindrome(int x) {
    bool result = x % 10 == x / 10000;
    result = result && (x / 10 % 10 == x / 1000 % 10);
    return result;
}

try {
    Console.Write("Введите положительное пятизначное число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    if (number < 10000 || number > 99999) {
        Console.WriteLine("Вы ввели не положительное пятизначное число.");
    } else {
        Console.WriteLine(number + " -> " + (IsFiveDigitPalindrome(number) ? "Да" : "Нет"));
    }
} catch {
    Console.WriteLine("Вы ввели не целое число.");
}