// Задача №21
// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 2D пространстве.
//          A(3,  6); B(2,  1) -> 5,09
//          A(7, -5); B(1, -1) -> 7,21
        double cutLength;
        int []  a = new int [2];
        int []  b = new int [2];
        Console.WriteLine("Enter point coordinates (X, Y) for two dots: A and B");
        Console.Write("Dot A coordnate X: ");
        a[0] = Convert.ToInt32(Console.ReadLine());
        Console.Write("Dot A coordnate Y: ");
        a[1] = Convert.ToInt32(Console.ReadLine());

        Console.Write("Dot B coordnate X: ");
        b[0] = Convert.ToInt32(Console.ReadLine());
        Console.Write("Dot B coordnate Y: ");
        b[1] = Convert.ToInt32(Console.ReadLine());

        cutLength = CutLength(a, b);
        Console.WriteLine($"The distance between points A and B is: {cutLength}");




        double CutLength(int []  dot1, int []  dot2){
            double cutLength;
            int wholePartCutLength;
            int fractionalPartCutLength;
            int []  Delta = new int [2];            
            Delta[0] = dot2[0] - dot1[0];
            Delta[1] = dot2[1] - dot1[1];
            cutLength = (Delta[0]*Delta[0]) + (Delta[1]*Delta[1]);
            cutLength = Math.Sqrt(cutLength);
            // wholePartCutLength = (int)cutLength;
            // cutLength = cutLength - (double)wholePartCutLength;
            // fractionalPartCutLength = (int)(cutLength * 100);
            // cutLength = (double)wholePartCutLength + ((double)fractionalPartCutLength / 100);
            // return cutLength;
            return Math.Round(cutLength, 2);
        }
