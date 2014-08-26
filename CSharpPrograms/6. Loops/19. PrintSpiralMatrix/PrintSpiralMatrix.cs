using System;

class PrintSpiralMatrix
{
    static void Main()
    {   // Print Spiral matrix.
        int matrixDimension, row = 0, column = 0, count = 1;
        int arrayLenght, maxCount = 0;
        Console.WriteLine("Enter dimension N of square matrix(N < 20).");
        Console.Write("N=");
        matrixDimension = int.Parse(Console.ReadLine());
        if (matrixDimension < 2 || matrixDimension > 20)
        {
            Console.WriteLine("Incorrect data.");
            return;
        }
        int[,] spiralArray = new int[matrixDimension, matrixDimension];
        int[] segments = new int[matrixDimension];
        string[] directions = new string[matrixDimension];
        segments = ArraySegments(matrixDimension);
        directions = Path(matrixDimension);
        maxCount = matrixDimension * matrixDimension;
        arrayLenght = matrixDimension + (matrixDimension - 1);
        spiralArray[0, 0] = 1;
        for (int i = 0; i < arrayLenght; i++)
        {
            for (int j = 0; j < segments[i] - 1; j++)
            {
                if (directions[i] == "R")
                {
                    column++;
                    count++;
                }
                if (directions[i] == "D")
                {
                    row++;
                    count++;
                }
                if (directions[i] == "L")
                {
                    column--;
                    count++;
                }
                if (directions[i] == "U")
                {
                    row--;
                    count++;
                }
                spiralArray[row, column] = count;
            }
        }
        for (int k = 0; k < matrixDimension; k++)
        {
            for (int m = 0; m < matrixDimension; m++)
            {
                if (maxCount < 10)
                {
                    Console.Write("{0,2} ", spiralArray[k, m]);
                }

                if (maxCount < 100)
                {
                    Console.Write("{0,3}", spiralArray[k, m]);
                }

                if (maxCount >= 100)
                {
                    Console.Write("{0,4}", spiralArray[k, m]);
                }
            }
            Console.WriteLine();
        }
        Console.ReadKey();
    }

    static int[] ArraySegments(int n)
    {
        int max;
        max = n + (n - 1);
        int[] segment = new int[max];
        segment[0] = n;
        for (int i = 0; i < max - 1; i++)
        {
            if (i % 2 == 0)
            {
                segment[i + 1] = n;
            }

            else
            {
                segment[i + 1] = n;
                n--;
            }
        }
        return segment;
    }

    static string[] Path(int n)
    {
        string[] direction = { "R", "D", "L", "U" };
        int max, count = 0;
        max = n + (n - 1);
        string[] route = new string[max];
        for (int i = 0; i < route.Length; i++)
        {
            if (i % 4 == 0)
            {
                count = 0;
            }
            route[i] = direction[count];
            count++;
        }
        return route;
    }
}

