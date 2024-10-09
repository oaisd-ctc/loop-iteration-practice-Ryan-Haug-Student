public class Program
{
    public static void Main(string[] args)
    {
        Console.Clear();

        // Write1ThroughN_While(-1);
        // Write1ThroughN_While(5);
        // Write1ThroughN_While(0);

        // Write1ThroughN_For(-1);
        // Write1ThroughN_For(5);
        // Write1ThroughN_For(0);

        // WriteNThrough1_While(-1);
        // WriteNThrough1_While(5);
        // WriteNThrough1_While(0);

        // WriteNThrough1_For(-1);
        // WriteNThrough1_For(5);
        // WriteNThrough1_For(0);

        // WriteEvensThrough100();

        // FindSum(5);
        // FindSum(1);
        // FindSum(3);
        // FindSum(100);

        FindSumOfEvenNumbers(10);
        FindSumOfEvenNumbers(-5);
        FindSumOfEvenNumbers(2);
        FindSumOfEvenNumbers(0);
        FindSumOfEvenNumbers(1);
        FindSumOfEvenNumbers(25);
        FindSumOfEvenNumbers(-25);
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
            Console.WriteLine(n + " is out of range");
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
            Console.WriteLine(n + " is not in range.");
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
            Console.WriteLine(n + " is out of range");
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
            Console.WriteLine(n + " Is out of range.");
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
        int result = n;

        if (n > 0)
        {
            for (int i = n; i > 0; i--)
            {
                n--;
                result = result + n;
            }
            Console.WriteLine(result);
        }

        else if (n == 0)
        {
            Console.WriteLine("0");
        }

        else
        {
            for (int i = n; i < 0; i++)
            {
                result = result + (n + 1);
                n++;
            }
            Console.WriteLine(result);
        }
    }

    public static void FindSumOfEvenNumbers(int n)
    {
        
    }
}