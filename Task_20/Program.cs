// Задача 20
// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.

//              A (3,6,8);   B (2,1,-7), -> 15.84
//              A (7,-5, 0); B (1,-1,9)  -> 11.53

        double cutLength;
        int []  a = new int [3];
        int []  b = new int [3];
        Console.WriteLine("Enter point coordinates (X, Y, Z) for two dots: A and B");
        Console.Write("Dot A coordnate X: ");
        a[0] = Convert.ToInt32(Console.ReadLine());
        Console.Write("Dot A coordnate Y: ");
        a[1] = Convert.ToInt32(Console.ReadLine());
        Console.Write("Dot A coordnate Z: ");
        a[2] = Convert.ToInt32(Console.ReadLine());

        Console.Write("Dot B coordnate X: ");
        b[0] = Convert.ToInt32(Console.ReadLine());
        Console.Write("Dot B coordnate Y: ");
        b[1] = Convert.ToInt32(Console.ReadLine());
        Console.Write("Dot B coordnate Z: ");
        b[2] = Convert.ToInt32(Console.ReadLine());

        cutLength = CutLength(a, b);
        Console.WriteLine($"The distance between points A and B is: {cutLength}");


        double CutLength(int []  dot1, int []  dot2){
            int i = 0;
            double cutLength = 0;
            int wholePartCutLength;
            int fractionalPartCutLength;
            int []  Delta = new int [3];            
            Delta[0] = dot2[0] - dot1[0];
            Delta[1] = dot2[1] - dot1[1];
            Delta[2] = dot2[2] - dot1[2];
            while(i <= 2){
               cutLength += Math.Pow(Delta[i++], 2); 
            }            
            cutLength = Math.Sqrt(cutLength);
            wholePartCutLength = (int)cutLength;
            cutLength = cutLength - (double)wholePartCutLength;
            fractionalPartCutLength = (int)(cutLength * 100);
            cutLength = (double)wholePartCutLength + ((double)fractionalPartCutLength / 100);
            return cutLength;
            // return Math.Round(cutLength, 2); - не даёт результат по условию как в примере
        }
