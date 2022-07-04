// Задача №28
// Напишите программу, которая принимает на вход число N и 
// выдаёт  произведение чисел от 1 до N
// 4 -> 24
// 5 -> 120
Console.Write("Введите любое число: ");
int enteredNumber = int.Parse(Console.ReadLine());
int result = Fractal(enteredNumber);
Console.WriteLine($"Вычисленное значение от введенного числа {enteredNumber} по условию равно {result}");

int Fractal(int number){
    int answer = 1;
    for(int i = 1; i <= number; i++){
        try{
            checked
            {
              answer *= i;  
            }
            
        }
        catch(Exception){
            Console.WriteLine("Переполнение типа!");
            enteredNumber = i - 1;
            break;
        }
        
    }
    return answer;
}

