Console.Write("Введите размер массива: ");
int arraySize = int.Parse(Console.ReadLine());
Console.Write("Введите минимальное значение элемента массива: ");
int arrayMin = int.Parse(Console.ReadLine());
Console.Write("Введите максимальное значение элемента массива: ");
int arrayMax = int.Parse(Console.ReadLine());
int[] array = GetRandomArray(arraySize, arrayMin, arrayMax);
Console.WriteLine($"[{String.Join(", ", array)}]");

int[] GetRandomArray(int size, int min, int max){
    int[] arrayTemp = new int[size];
    for (int i = 0; i < arrayTemp.Length; i++){
        arrayTemp [i] = new Random().Next(min, max);
    }
    return arrayTemp;
}