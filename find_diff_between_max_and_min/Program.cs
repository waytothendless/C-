double[] generate_array(int dimension) {
    double[] array_of_doubles = new double[dimension];
    Random rnd = new Random();
    int i = 0;
    while(i < dimension) {
        array_of_doubles[i] = rnd.NextDouble(); 
        i++;
    }

    return array_of_doubles;
}

double find_max(double[] array_of_nums) {
    int i = 0;
    double max = array_of_nums[i];
    while(i < array_of_nums.Count()) {
        if(array_of_nums[i] > max) {
            max = array_of_nums[i];
        }

        i++;
    } 

    return max;
}

double find_min(double[] array_of_doubles) {
    int i = 0;
    double min = array_of_doubles[i];
    while(i < array_of_doubles.Count()) {
        if(array_of_doubles[i] < min) {
            min = array_of_doubles[i];
        }

        i++;
    } 

    return min;
}

Console.WriteLine("Укажите размерность массива:");
int dimension = int.Parse(Console.ReadLine());
double[] array_of_doubles = generate_array(dimension);
Console.WriteLine("[{0}]", string.Join(", ", array_of_doubles));
double max_val = find_max(array_of_doubles);
double min_val = find_min(array_of_doubles);
Console.WriteLine("Максимум:"+max_val);
Console.WriteLine("Минимум:"+min_val);
Console.WriteLine("Разница между максимумом и минимумом:"+(max_val-min_val));