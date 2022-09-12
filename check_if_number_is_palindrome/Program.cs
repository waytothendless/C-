bool check_if_number_is_palindrome(int x) {
    int firstDigit = x / 10000;
    int secondDigit = x /1000 %10;
    int thirdDigit = x / 100 % 10;
    int fourthDigit = x / 10 % 10;
    int fifthDigit = x % 10;

    int revertedNumber = fifthDigit*10000+fourthDigit*1000+thirdDigit*100+secondDigit*10+firstDigit;
    return x == revertedNumber;
}

Console.WriteLine("Введите пятизначное число:");
int number = int.Parse(Console.ReadLine());
if (number < 10000) {
    Console.WriteLine("Число не пятизначное:");
    return;
}

if (check_if_number_is_palindrome(number) == true)
{
    Console.WriteLine("Число палиндром:");
    return;
}

Console.WriteLine("Число  не палиндром:");

