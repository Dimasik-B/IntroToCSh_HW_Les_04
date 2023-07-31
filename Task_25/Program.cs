Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
Console.Write("В какую степень возвести: ");
int exp = int.Parse(Console.ReadLine()!);

Console.WriteLine($"{num} в степени {exp} = {GetExp(num, exp)}");

int GetExp(int a, int b){
    int result= a;
    for (int i = 1; i < b; i++){
        result *= a;
    }
    return result;
}
