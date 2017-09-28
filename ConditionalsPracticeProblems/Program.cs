using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalsPracticeProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            //Check whether a letter is a vowel or a consonant
            //Console.WriteLine("Please enter a letter.");
            //string userLetter = Console.ReadLine().ToLower();
            //char yourLetter = char.Parse(userLetter);

            //if(yourLetter == 'a' || yourLetter == 'e' || yourLetter == 'i' || yourLetter == 'o' || yourLetter == 'u')
            //{
            //    Console.WriteLine("Your letter is a vowel");
            //}
            //else
            //{
            //    Console.WriteLine("Your letter is a consonant");
            //}

            //switch (yourLetter)
            //{
            //    case 'a':
            //        Console.WriteLine("This is a vowel");
            //        break;
            //    case 'e':
            //        Console.WriteLine("This is a vowel");
            //        break;
            //    case 'i':
            //        Console.WriteLine("This is a vowel");
            //        break;
            //    case 'o':
            //        Console.WriteLine("This is a vowel");
            //        break;
            //    case 'u':
            //        Console.WriteLine("This is a vowel");
            //        break;
            //    default:
            //        Console.WriteLine("This is a consonant.");
            //        break;
            //}

            //Console.WriteLine("Enter a whole number.");
            //int firstValue = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter a second whole number.");
            //int secondValue = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter a third whole number.");
            //int thirdValue = int.Parse(Console.ReadLine());

            //if (firstValue > secondValue)
            //{
            //    if (firstValue > thirdValue)
            //    {
            //        Console.WriteLine(firstValue + " is the larger value.");
            //    }
            //    else
            //    {
            //        Console.WriteLine(thirdValue + " is the largest value.");
            //    }
            //}
            //else if (secondValue > firstValue)
            //{
            //    Console.WriteLine(secondValue + " is the larger value.");
            //}
            //else
            //{
            //    Console.WriteLine("Go back to start.");
            //}


            Console.WriteLine("Please enter four whole numbers, one at a time.");
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());
            int fourthNum = int.Parse(Console.ReadLine());

            // double sum = firstNum + secondNum + thirdNum + fourthNum;
            // Console.WriteLine("The average is " + (sum / 4));

            int sum = firstNum + secondNum + thirdNum + fourthNum;
            double mean = sum / 4d;

           










        }
    }
}
