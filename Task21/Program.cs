double FindDistance3D (int x1, int y1, int z1, int x2, int y2, int z2) {
    return Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2) + (z1 - z2) * (z1 - z2));
}

try{
    Console.Write("Введите координату X1: ");
    int x1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите координату Y1: ");
    int y1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите координату Z1: ");
    int z1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите координату X2: ");
    int x2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите координату Y2: ");
    int y2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите координату Z2: ");
    int z2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("A(" + x1 + "," + y1 + "," + z1 +"); B(" + x2 + "," + y2 +"," +z2 +") -> " 
                        + FindDistance3D(x1, y1, z1, x2, y2, z2).ToString("F"));
} catch {
    Console.WriteLine("Вы ввели не целое число.");
}