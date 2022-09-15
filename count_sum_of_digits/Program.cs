// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите число:");
int number = int.Parse(Console.ReadLine());
int number_of_digits = (int)Math.Floor(Math.Log10(number) + 1);
int sum = 0;
int current = number;
int current_digit = 0;
while(number_of_digits > 0) {
    current_digit = current % 10;
    sum = sum + current_digit;
    current = current / 10;
    number_of_digits--;
}

Console.WriteLine(sum);