double distance(int x1,int y1,int z1,int x2,int y2,int z2) {
    return Math.Round(Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1)+(z2-z1)*(z2-z1)),2);
}

Console.WriteLine("Введите координату x1:");
int x1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату y1:");
int y1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату z1:");
int z1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату x2:");
int x2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату y2:");
int y2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату z2:");
int z2 = int.Parse(Console.ReadLine());
Console.WriteLine("Расстояние:"+distance(x1,y1,z1,x2,y2,z2));