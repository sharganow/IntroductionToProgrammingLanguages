// Задача №25
// Напишите цикл, который принимает на вход два числа
// (А и В) и возводит число А в натуральную степень В.
Console.Write("Введите число для возведения в степень А: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите  натуральное  значение степени В: ");
int[] b = new int[1];
b[0] = int.Parse(Console.ReadLine());
int result;
result = Exponentiation(a, b);
Console.WriteLine($"{a} ^ {b[0]} = {result}");

int Exponentiation(int foundation, int[] digree){
    int res = 1;    
     for(int i = 1; i <= digree[0]; i++){
        try{
            checked
            {
            res *= foundation;  
            }
            
        }
        catch(Exception){
            Console.WriteLine("Предельно возможное значение для выражения!");
            digree[0] = i - 1;
            break;
        } 
    }
    return res;
}

