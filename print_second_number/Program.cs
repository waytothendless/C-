int print_second_digit(int number) {
    return (number /10 ) % 10;
}

Console.WriteLine("Введите трёхзначное число:");
int number = int.Parse(Console.ReadLine());
if(number < 100) {
    Console.WriteLine("Число не трёхзначное");
    return;
}
Console.WriteLine("Вторая цифра:"+print_second_digit(number));
