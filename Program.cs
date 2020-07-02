using System;

namespace FizzBuzzPro2
{

    //Requirements: Hard - Print 1-100, replace the numbers on the output with a word input by the user. 
    //If the number is divisible by boh 5 and 3, print the whole word, if just 5, print the first half, 
    //if just 3, print the second half, if nothing, print the number. Alternate case per each output.

    class MainClass
    {
        public static void Main(string[] args)
        {
            Intro();
            string userInput = Console.ReadLine();     //Gets the Word
            double total = GetWordCount(userInput);    //Counts Word Length
            double firstTotal = GetEvenHalf(total);    //Splits the word, takes the first half
            double secondTotal = GetOddHalf(total);    //Remainder of the word
            int i1 = ConvertNumber(firstTotal);        //Converts to Int
            int i2 = ConvertNumber(secondTotal);       //Converts to Int
            string one = GetFirstHalf(userInput, i1);  //First Half insert
            string two = GetSecondHalf(userInput, i2); //Second Half insert
            Console.Clear();                           //Clears Choice from display
            FizzBuzz(one, two);                        //Chaos Ensues
        }


        public static void Intro()
        {
            Console.WriteLine("Please choose a word or sentence for FizzBuzz!");
        }
        public static double GetWordCount(string s1)
        {
            double count = 0;
            foreach (char number in s1)
            {
                count++;
            }
            return count;
        }

        public static double GetEvenHalf(double num1)
        {
            num1 = Math.Ceiling(num1 / 2);
            return num1;
        }

        public static double GetOddHalf(double num1)
        {
            num1 = Math.Floor(num1 / 2);
            return num1;
        }

        public static int ConvertNumber(double num1)
        {
            int num2 = Convert.ToInt32(num1);
            return num2;
        }

        public static string GetFirstHalf(string word, int num1)
        {
            string result = word.Substring(0, num1);
            return result;
        }

        public static string GetSecondHalf(string word, int num1)
        {
            string result = word.Substring(word.Length - num1, num1);
            return result;
        }

        public static void FizzBuzz(string w1, string w2)
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 5 == 0 && i % 3 == 0)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine(w1.ToUpper() + w2.ToUpper());
                    }
                    else
                    {
                        Console.WriteLine(w1.ToLower() + w2.ToLower());
                    }
                }

                else if (i % 5 == 0)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine(w2.ToUpper());
                    }
                    else
                    {
                        Console.WriteLine(w2.ToLower());
                    }
                }

                else if (i % 3 == 0)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine(w1.ToUpper());
                    }
                    else
                    {
                        Console.WriteLine(w1.ToLower());
                    }
                }

                else
                {
                    Console.WriteLine(i);
                }
            }
        }

    }
}
