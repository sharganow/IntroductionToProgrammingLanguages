/**************************************************************
 * Напишите программу, которая выводит случайное число из отрезка 
 * [10, 99] и показывает наибольшую цифру числа.
 **************************************************************/
Console.WriteLine("Hello, World!");

int rndNum = new Random().Next(10, 100);        /* данная функция особенна тем, 
что верхнее значение диапазона она не сгенерирует никогда 
(поэтому мы задали значение 100, а не 99 как по услозию задачи),
к тому же функция псевдослучайная - привязана к системному времени процессора,
если использовать ее несколько раз подряд в единый момент времени (три строчки подряд) -
то все полученые от неё значения окажутся равными (15мс - один такт системного времени) */
var rndVar = new Random();
Console.WriteLine ($"Сллучайное число из отрезка 10 - 99 => {rndNum}");

int firstDigit  = rndNum / 10;
int secomdDigit = rndNum % 10;
int maxDigit    = firstDigit > secomdDigit ? firstDigit : secomdDigit;
Console.WriteLine($"Наибольшая цифра числа {rndNum} => {maxDigit}");

rndNum = rndVar.Next(10, 100);
Console.WriteLine ($"Сллучайное число из отрезка 10 - 99 => {rndNum}"); 

int vMaxDigit(int num){
    int firstDigit  = num / 10;
    int secomdDigit = num % 10;
    if( firstDigit  == secomdDigit ) return 0;
    return firstDigit > secomdDigit ? firstDigit : secomdDigit;
}

maxDigit = vMaxDigit(rndNum);

String result = maxDigit > 0 ? maxDigit.ToString() : "Цивры одинаковые";
Console.WriteLine($"Наибольшая цифра числа {rndNum} => {result}");
