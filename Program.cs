public class Program
{
    public static void Main(string[] args)
    {
        Console.Clear();
        // Im using console.writeline inbetween all of the funcitions to seperate results and make it easier to read

        Write1ThroughN_While(-1);
        Write1ThroughN_While(5);
        Write1ThroughN_While(0);

        Console.WriteLine("");

        Write1ThroughN_For(-1);
        Write1ThroughN_For(5);
        Write1ThroughN_For(0);

        Console.WriteLine("");

        WriteNThrough1_While(-1);
        WriteNThrough1_While(5);
        WriteNThrough1_While(0);

        Console.WriteLine("");

        WriteNThrough1_For(-1);
        WriteNThrough1_For(5);
        WriteNThrough1_For(0);

        Console.WriteLine("");

        WriteEvensThrough100();

        Console.WriteLine("");

        FindSum(5);
        FindSum(1);
        FindSum(-3);
        FindSum(100);

        Console.WriteLine("");

        FindSumOfEvenNumbers(10);
        FindSumOfEvenNumbers(-5);
        FindSumOfEvenNumbers(2);
        FindSumOfEvenNumbers(0);
        FindSumOfEvenNumbers(1);
        FindSumOfEvenNumbers(25);
        FindSumOfEvenNumbers(-25);

        Console.WriteLine("");

        FindSumOfOddNumbers(10);
        FindSumOfOddNumbers(-5);
        FindSumOfOddNumbers(1);
        FindSumOfOddNumbers(2);
        FindSumOfOddNumbers(25);
        FindSumOfOddNumbers(-25);

        OutputRightTriangle(4);
        OutputRightTriangle(6);
        Console.WriteLine("");
        OutputRightTriangle(-4);
        OutputRightTriangle(-6);
        OutputRightTriangle(0);
    }
    public static void OutOfRangeMessage(int n)
    {
        Console.WriteLine(n + " Is out of range.");
    }
    public static void Write1ThroughN_While(int n)
    {
        int i = 0;

        if (n > 0)
        {
            while (i <= n)
            {
                Console.WriteLine(i);
                i++;
            }
        }
        else
        {
            OutOfRangeMessage(n);
        }
    }

    public static void Write1ThroughN_For(int n)
    {
        if (n > 0)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }
        }
        else
        {
            OutOfRangeMessage(n);
        }
    }

    public static void WriteNThrough1_While(int n)
    {
        if (n > 0)
        {
            while (0 < n)
            {
                Console.WriteLine(n);
                n--;
            }
        }
        else
        {
            OutOfRangeMessage(n);
        }
    }

    public static void WriteNThrough1_For(int n)
    {
        if (n > 0)
        {
            for (int i = n; i > 0; i--)
            {
                Console.WriteLine(i);
            }
        }

        else
        {
            OutOfRangeMessage(n);
        }
    }

    public static void WriteEvensThrough100()
    {
        int i = 0;
        while (i < 101)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
                i++;
            }

            else
            {
                i++;
            }
        }
    }

    public static void FindSum(int n)
    {
        int result = 0;

        if (n > 0)
        {
            for (int i = 0; i <= n; i++)
            {
                result = result + i;
            }
            Console.WriteLine(result);
        }

        else if (n == 0)
        {
            Console.WriteLine(0);
        }

        else
        {
            for (int i = n; i <= 1; i++)
            {
                result = result + i;
            }
            Console.WriteLine(result);
        }
    }

    public static void FindSumOfEvenNumbers(int n)
    {
        int result = 0;

        if (n > 0)
        {
            for (int i = 0; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    result += i;
                }
            }
            Console.WriteLine(result);
        }

        else if (n == 0)
        {
            Console.WriteLine(0);
        }

        else
        {
            for (int i = n; i <= 1; i++)
            {
                if (i % 2 == 0)
                {
                    result += i;
                }
            }
            Console.WriteLine(result);
        }
    }

    public static void FindSumOfOddNumbers(int n)
    {
        int result = 0;

        if (n > 0)
        {
            for (int i = 0; i <= n; i++)
            {
                if (i % 2 == 1)
                {
                    result += i;
                }
            }
            Console.WriteLine(result);
        }

        else if (n == 0)
        {
            Console.WriteLine(0);
        }

        else
        {
            for (int i = n; i <= 1; i++)
            {
                if (i % 2 == -1 || i % 2 == 1)
                {
                    result += i;
                }
            }
            Console.WriteLine(result);
        }
    }

    public static void OutputRightTriangle(int n)
    {
        if (n > 0)
        {
            for (int i = 0; i <= n; i++)
            {
                for (int i2 = 0; i2 < i; i2++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }

        else if (n == 0)
        {
            OutOfRangeMessage(n);
        }

        else
        {
            for (int i = n; i <= 0; i++)
            {
                for (int i2 = i; i2 < 0; i2++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }
    }
}