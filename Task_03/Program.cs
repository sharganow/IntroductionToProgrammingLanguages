// See https://aka.ms/new-console-template for more information
string quit;
char quitRepite = 'n';
int day;
int u8DaysKnown = 0;
Console.WriteLine("Hello, User!");
Console.Beep(); Console.Beep(); Console.Beep();
Console.WriteLine("Let's learn the days of the week and their order!");
do{
    Console.Write("Enter the serial number of the day of the week and you will find out what it is called: ");
    day = Convert.ToInt32(Console.ReadLine());
    switch(day){
        case 0:{
            Console.WriteLine("Zero day - the day of the apocalypse or the creation of the world, this is beyond us)))");
            u8DaysKnown |= 1;
        }break;
        case 1:{
            Console.WriteLine("In Russia, the first day of the week is Monday.");
            u8DaysKnown |= 2;
        }break;
        case 2:{
            Console.WriteLine("The second day of the week is Tuesday.");
            u8DaysKnown |= 4;
        }break;
        case 3:{
            Console.WriteLine("The third day of the week is Wednesday.");
            u8DaysKnown |= 8;
        }break;
        case 4:{
            Console.WriteLine("The fourth day of the week is Thursday.");
            u8DaysKnown |= 16;
        }break;
        case 5:{
            Console.WriteLine("The fifth day of the week is Friday");
            u8DaysKnown |= 32;
        }break;
        case 6:{
            Console.WriteLine("The sixth day of the week is Suturday");
            u8DaysKnown |= 64;
        }break;
        case 7:{
            Console.WriteLine("The last day in Russia and the first day in other countries of the week is Sunday");
            u8DaysKnown |= 128;
        }break;
        default:{
            Console.WriteLine("On planet earth in the solar system, a week is seven days - no more ... for now");
            u8DaysKnown = 0;
        }break;
    }
    Console.WriteLine();
        if(u8DaysKnown >= 254){
            Console.WriteLine("Would you like to secure information? If yes, then click 'Y'");
        quit = Console.ReadLine();
        quit = quit.ToLower();
        if('y' == Convert.ToChar(quit[0])){
            u8DaysKnown = 0;
            Console.WriteLine("What will we continue");
        }
        else{
            quitRepite = 'y';
        };
    }
}while(quitRepite == 'n');
 Console.WriteLine("We will be glad to see you again!");
 Console.Beep(); Console.Beep();    // УРА!
