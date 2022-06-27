// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int rndNum = new Random().Next(10, 100);
Console.WriteLine ($"Сллучайное число из отрезка 10 - 99 => {rndNum}");

int firstDigit = rndNum / 10;
int secomdDigit = rndNum % 10;
int maxDigit = firstDigit > secomdDigit ? firstDigit : secomdDigit;
Console.WriteLine($"Наибольшая цифра числа {rndNum} => {maxDigit}");

rndNum = new Random().Next(10, 100);
Console.WriteLine ($"Сллучайное число из отрезка 10 - 99 => {rndNum}"); 

int MaxDigit(int num){
    int firstDigit = num / 10;
    int secomdDigit = rndNum % 10;
    if(firstDigit == secomdDigit) return 0;
    return firstDigit > secomdDigit ? firstDigit : secomdDigit;
}

maxDigit = MaxDigit(rndNum);

String result = maxDigit > 0 ? maxDigit.ToString() : "Цивры одинаковые";
Console.WriteLine($"Наибольшая цифра числа {rndNum} => {result}");