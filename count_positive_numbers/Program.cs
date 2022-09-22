void count_number_of_positive_numbers(int limit, int count, int num_of_positives) {
    Console.WriteLine("Введите число:");
    int number = int.Parse(Console.ReadLine());
    int number_of_positives = num_of_positives;
    if (number > 0) {
        number_of_positives++;
    }
    
    if (count >= limit) {
        Console.WriteLine("Количестве цифр больше нуля:"+number_of_positives);
        return;
    }

    int counter = count;
    count_number_of_positive_numbers(limit, counter+1, number_of_positives);
}

Console.WriteLine("Задайте количество чисел, которые желаете ввести:");
int limit = int.Parse(Console.ReadLine());
if (limit <=0) {
    Console.WriteLine("Значение должно быть больше нуля");
    return;
}
int count = 1;
count_number_of_positive_numbers(limit,count,0);