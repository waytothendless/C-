int ackerman(int first, int second) {
    if (first == 0) {
        return second +1;
    } else if (second == 0) {
        return ackerman(first-1, 1);
    } else {
        return ackerman(first - 1, ackerman(first, second -1));
    }
}

Console.WriteLine("Enter first value for ackermann function:");
int first = int.Parse(Console.ReadLine());
Console.WriteLine("Enter first value for ackermann function:");
int second = int.Parse(Console.ReadLine());
Console.WriteLine(ackerman(first, second));