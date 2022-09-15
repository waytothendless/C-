// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите размерность массива:");
int size = int.Parse(Console.ReadLine());
int[] nums = new int[size];
int i=0;
while(i < size) {
    Console.WriteLine("Задайте элемент массива:");
    int element = int.Parse(Console.ReadLine());
    nums[i] = element;
    i++;
}

 Console.WriteLine("[{0}]", string.Join(", ", nums));
