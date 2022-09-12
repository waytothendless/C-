int cube(int x) {
    return x*x*x;
}

Console.WriteLine("Введите число:");
int num = int.Parse(Console.ReadLine());
int i = 1;
while (i <= num) {
    Console.WriteLine(cube(i)+" ");
    i++;
}