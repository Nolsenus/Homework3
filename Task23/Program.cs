string GetCubesString (int x) {
    string result = "";
    for (int i = 1; i < x; ++i) {
        result += i * i * i + ", ";
    }
    if (x > 0) result += x * x * x;
    return result;
}

try {
    Console.Write("Введите целое число: ");
    int x = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(x + " -> " + GetCubesString(x));
} catch {
    Console.WriteLine("Вы ввели не целое число.");
}