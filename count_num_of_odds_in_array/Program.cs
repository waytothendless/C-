int[] generate_array(int dimension) {
    int[] array_of_integers = new int[dimension];
    Random rnd = new Random();
    int i = 0;
    while(i < dimension) {
        array_of_integers[i] = rnd.Next(100, 999); 
        i++;
    }

    return array_of_integers;
}

int count_number_of_odds(int[] array_of_ints) {
    int total = array_of_ints.Count();
    if (total == 0) {
        return 0;
    }

    int i =0;
    int num_of_odds = 0;
    while(i < total) {
        if (array_of_ints[i] % 2 != 0) {
            num_of_odds++;
        }
        i++;
    }

    return num_of_odds;
}

Console.WriteLine("Укажите размерность массива:");
int dimension = int.Parse(Console.ReadLine());
int[] array_of_integers = generate_array(dimension);
Console.WriteLine("[{0}]", string.Join(", ", array_of_integers));
Console.WriteLine("Количество нечетных чисел в массиве:"+count_number_of_odds(array_of_integers));