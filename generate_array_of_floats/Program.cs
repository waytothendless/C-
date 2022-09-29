double[,] generateTwoDimensionalArray(int width, int height) {
    double[,] array_of_integers = new double[width, height];
    Random rnd = new Random();
    int i = 0;
    int j = 0;
    double min = 1;
    double max = 100;
    double range = max - min;
    while(i < width) {
        while(j < height) {
            array_of_integers[i,j] = (rnd.NextDouble()*range)+min;
            j++;
        }
        j = 0;
        i++;
    }

    return array_of_integers;
}

Console.WriteLine("Задайте длину массива:");
int length = int.Parse(Console.ReadLine());
Console.WriteLine("Задайте ширину массива:");
int height = int.Parse(Console.ReadLine());
double[,] array_of_doubles = generateTwoDimensionalArray(length, height);
int i=0;
int j=0;
while(i<length){
    while(j<height){
        Console.Write(array_of_doubles[i,j]+" ");
        j++;
    }
    j=0;
    Console.WriteLine();
    i++;
}