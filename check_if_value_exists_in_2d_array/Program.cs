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
Console.WriteLine("Задайте первый индекс искомого элемента:");
int first_index = int.Parse(Console.ReadLine());
Console.WriteLine("Задайте второй индекс искомого элемента:");
int second_index = int.Parse(Console.ReadLine());
int element = array_of_ints[first_index,second_index];
if (element == null) {
    Console.WriteLine("Элемент с координатами "+first_index+" и "+second_index+" не найдены");
    return;
}

Console.WriteLine(element);