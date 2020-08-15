using System;

class Test
{
    static void Main()
    {

        int number = int.Parse(Console.ReadLine());
        int toBase = int.Parse(Console.ReadLine());

        string result = string.Empty;

        result = IntegerToBase(ref number, toBase, ref result);
        Console.WriteLine(result);

    }

    private static string IntegerToBase(ref int number, int toBase, ref string result)
    {
        while (number > 0)
        {
            int firstDigit = number / toBase;
            int lasstDigit = number % toBase;
            number = number / toBase;

            result = lasstDigit + result;

        }
        return result;
    }

}