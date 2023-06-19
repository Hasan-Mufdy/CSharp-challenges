using System;
using System.IO;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Please enter 3 numbers separated by space...");
        string input = Console.ReadLine();
        string[] nums = input.Split(" ");
        int[] numbers = Array.ConvertAll(nums, int.Parse);
        product(numbers);

        /////////////////////////////////////////////////////////////

        Console.WriteLine("Enter a number between 2 and 10...");
        string input2 = Console.ReadLine();
        int input2Int = Convert.ToInt32(input2);
        int[] arr = new int[input2Int];
        Console.WriteLine("");
        for (int i = 0; i < input2Int; i++)
        {
            Console.WriteLine("enter a number");
            arr[i] = int.Parse(Console.ReadLine());
        }
        Average(arr);

        ///////////////////////////////////////////////

        Pattern();

        ///////////////////////////////////////////////
        // this is a test array, it will be used with a couple of methods
        int[] nArray = {1, 2, 3, 4};
        
        checkRecurrence(nArray);

        ///////////////////////////////////////////////
        
        maxValue(nArray);

        ///////////////////////////////////////////////
        string userMessage = "";
        Console.WriteLine("type anything to add in the words.txt file...");
        userMessage = Console.ReadLine();

        string path = "../../../data.txt";
        ReadFileText(path);
        OverWriteTheFileContent(path, userMessage);

        ///////////////////////////////////////////////

        ReadAllLines(path);

        ////////////////////////////////////////////////
        
        changeWords(path);

        ///////////////////////////////////////////////

        string[] arrayOfWords = {"this", "is", "a", "sentance" };
        calculateWords(arrayOfWords);





    }

    public static int product(int[] nums)
    {
       
        if (nums == null)
        {
            Console.WriteLine("invalid input...");
            return 0;
        }
        else if(nums.Length != 3)
        {
            Console.WriteLine("invalid input...");
            return 0;
        }
        //else { }
        // int inputInt = Convert.ToInt32(userInput);
        int n1 = Convert.ToInt32(nums[0]);
        int n2 = Convert.ToInt32(nums[1]);
        int n3 = Convert.ToInt32(nums[2]);

        int product = n1 * n2 * n3;
        Console.WriteLine("product is: " + product);
        return product;
     }
    
    public static double Average(int[] nums)
    {
        int sum = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
        }
        double arrAvg = sum / nums.Length;

    return arrAvg;
    }

    public static void Pattern()
    {
        int n = 5; // Number of rows

        // Print upper half of the pattern
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                Console.Write(" ");
            }

            for (int j = 0; j < 2 * i + 1; j++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }

        // Print lower half of the pattern
        for (int i = n - 2; i >= 0; i--)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                Console.Write(" ");
            }

            for (int j = 0; j < 2 * i + 1; j++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }
    }

    public static int checkRecurrence(int[] nums)
    {
        int maxC = 0;
        int mostRec = 0;

        // I will use nested for loops

        for (int i = 0; i < nums.Length; i++)
        {
            int count = 0;
            for (int j = 0; j < nums.Length; j++)
            {
                if (nums[j] == nums[i]) { count++; }
            }
            if (count > maxC)
            {
                maxC = count;
                mostRec = nums[i];
            }
        }

        return mostRec;
    }

    public static int maxValue(int[] nums)
    {
        int max = 0;

        if (nums.Length == 0)
        {
            return 0;
        }

        max = nums[0];
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] > max){
                max = nums[i];
            }
        }

        return max;
    }

    static void ReadFileText(string path)
    {
        string dataFromFile = File.ReadAllText(path);


        Console.WriteLine(dataFromFile);
    }

    public static void ReadAllLines(string path)
    {
        string[] lines = File.ReadAllLines(path);
        int i = 0;
        foreach (string line in lines)
        {
            Console.WriteLine($"{line} in {i}");
            i++;
        }
        // Console.WriteLine(lines);
    }
    public static void OverWriteTheFileContent(string path, string s)
    {
        string newLine = s;

        File.WriteAllText(path, newLine);
    }

    public static void changeWords(string path)
    {
        string[] lines = File.ReadAllLines(path);
        int i = 0;
        foreach (string line in lines)
        {
            Console.WriteLine($"{line} in {i}");
            i++;
        }
        string beforeRemoving = lines[lines.Length - 1];
        lines[lines.Length - 1] = "";

        OverWriteTheFileContent(path, beforeRemoving);

    }


    public static string[] calculateWords(string[] arr)
    {
        if (arr.Length == 0)
        {
            return null;
        }

        string[] res = new string[arr.Length];

        for(int i = 0; i < arr.Length; i++)
        {
            string word = arr[i];
            int wLength = word.Length;
            res[i] = word + ": " + wLength;
        }
        return res;
    }


}