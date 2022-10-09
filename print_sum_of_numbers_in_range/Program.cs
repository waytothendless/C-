Console.WriteLine("Enter the lower limit:");
int lower = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the upper limit:");
int upper = int.Parse(Console.ReadLine());
int sum = 0;
while(lower<=upper) {
    sum+=lower;
    lower++;
}

Console.WriteLine(sum);