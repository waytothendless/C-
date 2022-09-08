int print_third_digit(string rawInput) {
    int number = (int)Char.GetNumericValue(rawInput[2]);
    
    return number % 10;
}

Console.WriteLine("Введите число:");
string rawInput = Console.ReadLine();
if(rawInput.Length < 3) {
    Console.WriteLine("Третья цифра отсутствует");
    return;
}

Console.WriteLine("Третья цифра:"+print_third_digit(rawInput));