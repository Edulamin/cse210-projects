using System;

class Program
{
    static void Main(string[] args)
    {
        
        int number = -1;
        List<int> numbers = new List<int>();
        int sum = 0;
        float average = 0;
        int largest = 0;
        long smallestPositive = 999999999999;
        
        Console.WriteLine("Enter a list of Numbers, type 0 when finished.");

        do
        {
            Console.Write("Enter a number: ");
            number = int.Parse(Console.ReadLine());                        
            
            if (number != 0)
            {
                numbers.Add(number);
            }           

        } while (number != 0);

        foreach (int numberItem in numbers)
        {
            sum = numberItem + sum;
        }
        Console.WriteLine($"The total sum is: {sum}");
                    
        foreach (int numberItem in numbers)
        {
            average = ((float)sum) / numbers.Count;
        }
        Console.WriteLine($"The average of the numbers is {average}");

        foreach (int numberItem in numbers)
        {
            largest = numbers.Max();
        } 
        Console.WriteLine($"The largest number is {largest}");

        foreach (int numberItem in numbers)
        {
            if (numberItem > 0 && numberItem < smallestPositive) 
            {
                smallestPositive = numberItem;
            }        
        }
        Console.WriteLine($"The smallest positive number is {smallestPositive}");

        numbers.Sort();
        foreach (int numberItem in numbers)
        {
            Console.WriteLine(numberItem);
        }
    }   
}