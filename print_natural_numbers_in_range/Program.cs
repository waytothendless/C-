void print_narural_numbers_in_range(int upper_limit) {
    Console.WriteLine(upper_limit);
    if (upper_limit==1) {
        return;
    }

    print_narural_numbers_in_range(upper_limit - 1);
}
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter the upper limit");
int upper_limit = int.Parse(Console.ReadLine());
print_narural_numbers_in_range(upper_limit);
