int[,] generateTwoDimensionalArray(int width, int height) {
    int[,] array_of_integers = new int[width, height];
    Random rnd = new Random();
    int i = 0;
    int j = 0;
    while(i < width) {
        while(j < height) {
            array_of_integers[i,j] = rnd.Next(1, 100);
            j++;
        }
        j = 0;
        i++;
    }

    return array_of_integers;
}

Console.WriteLine("Задайте ширину массива:");
int width = int.Parse(Console.ReadLine());
Console.WriteLine("Задайте высоту массива:");
int height = int.Parse(Console.ReadLine());
int[,] array_of_ints = generateTwoDimensionalArray(width, height);
int i = 0;
int j = 0;
int sum = 0;
float avg = 0;
while (i < width) {
    while(j < height) {
        Console.Write(array_of_ints[i,j]+" ");
        sum+=array_of_ints[i,j];
        j++;
    }
    
    Console.WriteLine();
    avg = (float)sum/(float)j;
    Console.WriteLine("Среднее арифметическое:"+avg);
    sum = 0;
    i++;
    j = 0;
}