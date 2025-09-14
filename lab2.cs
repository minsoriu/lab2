Console.WriteLine("Введите первое число:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число:");
int c = Convert.ToInt32(Console.ReadLine());
int negativeNumbers = 0;
if ((a >= 0) && (b >= 0) && (c >= 0)) {
    Console.WriteLine("Нет отрицательных чисел");
} else {
    if (a < 0) {
        negativeNumbers += 1;
    }
    if (b < 0) {
        negativeNumbers += 1;
    }
    if (c < 0) {
        negativeNumbers += 1;
    }
    Console.WriteLine($"Количество отрицательных чисел равно {negativeNumbers}");
}