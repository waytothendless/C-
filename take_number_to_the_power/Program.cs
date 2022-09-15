Console.WriteLine("Введите целое число:");
int number = int.Parse(Console.ReadLine());
Console.WriteLine("Введите показатель степени:");
int degree = int.Parse(Console.ReadLine());
int i =1;
int result=1;
while(i<=degree) {
    result = result*number;
    i++;
}

Console.WriteLine(result);