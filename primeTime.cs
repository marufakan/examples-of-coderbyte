using System;
// Prime Time
// Have the function PrimeTime(num) take the num parameter being passed and return the string true if the parameter is a prime number, otherwise return the string false. The range will be between 1 and 2^16.
//  Examples
//  Input: 19
// Output: true
//  Input: 110
//  Output: false

class MainClass
{

    public static bool PrimeTime(int num)
    {
        if (num > 1)
        {
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
        }
        return true;

    }

    static void Main()
    {
        // keep this function call here
        Console.WriteLine(PrimeTime(Console.ReadLine()));
    }

}