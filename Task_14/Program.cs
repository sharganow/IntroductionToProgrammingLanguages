// Напишите программу, которая принимает на вход число и проверяет,
// является ли оно кратным одновременно 7 и 23
//       14 -> нет
//       46 -> нет
//      161 -> да
Console.WriteLine("Hello, User!");
string quit, answerOut;
char quitRepite = 'n';
int first;
do{
    Console.WriteLine("Checking for multiplicity of 7 and 23");
    Console.Write("Enter number: ");
    answerOut = Console.ReadLine();
    first = Convert.ToInt32(answerOut);    
    vOutResult(bCheckMultiplicityTwoNumbers(first, 7, 23), answerOut);

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

 bool bCheckMultiplicityTwoNumbers(int chkNum, int numA, int numB){
    if(chkNum % numA != 0){
        return false;
    }
    else{
        if(chkNum % numB != 0){          
            return false;
        }
        else{
            return true;  
        }
    }
 }

 void vOutResult(bool b, string s){
    if(b){  s += " -> да" ;  }
    else{   s += " -> нет";  }
    Console.WriteLine(s);
 }
 // УРА!
