//Name:- KGCS Gamage
//Index No:- 22828
//CS203.3

using System;

class RandomNumberGenerator
{
    static void Main()
    {
        // Prompt the user to enter the desired number of random integers
        Console.Write("Enter the number of random integers to generate: ");
        int numIntegers = int.Parse(Console.ReadLine());

        // Generate and print the random integers
        Random rand = new Random();
        for (int i = 0; i < numIntegers; i++)
        {
            int randomNumber = rand.Next(0, 101);
            Console.WriteLine(randomNumber);
        }
    }
}



//psuedo code
// Prompt the user for the desired number of random integers
Console.Write("Enter the number of random integers to generate: ");
int numIntegers = int.Parse(Console.ReadLine());

// Create a new random number generator
Random rand = new Random();

// Initialize an array to store the random integers
int[] randomIntegers = new int[numIntegers];

// Generate the random integers and store them in the array
for (int i = 0; i < numIntegers; i++)
{
    randomIntegers[i] = rand.Next(0, 101);
}

// Output the list of random integers
for (int i = 0; i < numIntegers; i++)
{
    Console.WriteLine(randomIntegers[i]);
}
