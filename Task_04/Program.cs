/**************************************************************
*   Задача: Нужно написать программу, которая принимает через
*   консольный терминал три числа и выявляет максимальное из
*   чисел, а результат сравнения выводит обратно в консольный
*   терминал
***************************************************************/

bool maxFound;
string quit;
char quitRepite = 'n';
char[] namesOfNumbers = new char[] { 'A', 'B', 'C' };
int[] numbers = new int[3];
int index; int max; int maxIndex;

Console.WriteLine("Hello, User!");
Console.Beep(); Console.Beep(); Console.Beep();
do{
    Console.WriteLine("Let's compare three numbers and find the larger one.");

    for(index = 0; index < 3; index++){
        Console.Write($"Enter number {namesOfNumbers[index]}: ");
        numbers[index] = Convert.ToInt32(Console.ReadLine());
    }

    for(index = 0, maxFound = false, max = numbers[index], maxIndex = 0; index < 3; index++){
        if(max < numbers[index]){
            max = numbers[index];
            maxIndex = index;
            maxFound = true;
        }
        else{
            if(max > numbers[index]){
                if(!maxFound){
                    maxFound = true;
                }
            }
        }
    }

    if(maxFound){
        Console.WriteLine($"The number {namesOfNumbers[maxIndex]} is greater than the others, the maximum value is {numbers[maxIndex]}");
    }
    else{
        Console.WriteLine("All entered numbers are equal");
    }
    
    Console.WriteLine("Would you like to continue? If yes, then click 'Y'");
    quit = Console.ReadLine();
    quit = quit.ToLower();
    if('y' == Convert.ToChar(quit[0])){
        Console.WriteLine("What will we continue");
        
    }
    else{
        quitRepite = 'y';
    };

}while(quitRepite == 'n');
 Console.WriteLine("We will be glad to see you again!");
 Console.Beep(); Console.Beep();    // УРА!
