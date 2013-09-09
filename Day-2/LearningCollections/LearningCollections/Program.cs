using System;
using System.Collections.Generic;
using System.Text;

namespace LearningCollections
{
    public class NumberCollector
    {
        public int[] CollectNumbers(int count)
        {
            int[] numbers = new int[count];
            Console.WriteLine("Enter {0} numbers",count);
            for (int i = 0; i < count; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            return numbers;
        }
    }

    public class NumberProcessor
    {
        private int[] _numbers;
        public NumberProcessor(int[] numbers)
        {
            _numbers = numbers;
        }

        public int[] GetAllEvenNumbers()
        {
            int[] evenNumbers = new int[0];
            int counter = 0;
            for (int i = 0; i < _numbers.Length; i++)
            {
                int number = _numbers[i];
                if (number%2 == 0)
                {
                    int[] newArray = new int[counter + 1];
                    evenNumbers.CopyTo(newArray, 0);
                    evenNumbers = newArray;

                    evenNumbers[counter] = number;
                    counter = counter + 1;
                }
            }
            return evenNumbers;
        }

        /*public int[] GetAllOddNumbers()
        {
            
        }*/
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];
            NumberCollector collector = new NumberCollector();
            numbers = collector.CollectNumbers(10);

            NumberProcessor processor = new NumberProcessor(numbers);
            int[] evenNumbers = processor.GetAllEvenNumbers();
            Console.WriteLine();
            Console.WriteLine("All even numbers");
            
            for (var i = 0; i < evenNumbers.Length; i++)
            {
                Console.WriteLine(evenNumbers[i]);
            }
            Console.WriteLine();
            /*Console.WriteLine("All odd numbers");
            for (var i = 0; i < 10; i++)
            {
                int number = numbers[i];
                if (number % 2 != 0)
                {
                    Console.WriteLine(number);
                }
            }*/
            Console.ReadLine();

        }
    }
}
