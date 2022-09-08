string check_if_day_is_weekend(int day) {
    if (day == 6 || day == 7) {
        return "Да";
    }

    return "Нет";
}

Console.WriteLine("Введите номер дня:");
int day = int.Parse(Console.ReadLine());
if(day < 1 || day > 7) {
    Console.WriteLine("Я не знаю такого дня недели");
    return;
}

Console.WriteLine(check_if_day_is_weekend(day));