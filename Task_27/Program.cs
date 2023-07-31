Console.Write("Введите число: ");
string num = Console.ReadLine();

Console.WriteLine($"Сумма цифр чила {num} = {GetSumOfDigits(num)}");

int GetSumOfDigits (string number){
    int sum = 0;
    for(int i = 0; i < number.Length; i++){
        sum += int.Parse(number[i].ToString());
    }
    return sum;
}
