using System;

namespace Deliverable_5
{
    class Program
    {
        static void Continue()
        {
            bool programContinue = true;
            string userContinue = "";
            
            Console.Write("Would you like to continue (y/n)? ");
            userContinue = Console.ReadLine().ToLower();

            if (userContinue == "y")
            {
                programContinue = true;
            }
            else if (userContinue == "n")
            {
                Console.WriteLine("Goodbye!");
                programContinue = false;
                System.Environment.Exit(1);
            }
        }

        static void Main(string[] args)
        {

            int vowelCount = 0;
            bool programContinue = true;
            string userContinue = "";

            while (programContinue == true)
            {
                Console.Write("Enter some text: ");

                string userInput = Console.ReadLine().ToLower();
                char[] userLetters = userInput.ToCharArray();

                for (int i = 0; i < userInput.Length; i++)
                {
                    if (userLetters[i] == 'a' || userLetters[i] == 'e' || userLetters[i] == 'i' || userLetters[i] == 'o' || userLetters[i] == 'u')
                    {
                        vowelCount++;
                    }
                }

                Console.WriteLine("There were " + vowelCount + " vowels.");
                vowelCount = 0;

                Continue();
            }
            // END OF EXERCISE 26
            //
            //int letterCount = 0;
            //bool programContinue = true;
            //string userContinue = "";

            //while (programContinue == true)
            //{
            //    Console.Write("Enter some text: ");

            //    string userInput = Console.ReadLine().ToLower();
            //    char[] userLetters = userInput.ToCharArray();
            //    letterCount = userInput.Length;

            //    for (int i = 0; i < userInput.Length; i++)
            //    {
            //        if (userLetters[i] == 'a' || userLetters[i] == 'e' || userLetters[i] == 'i' || userLetters[i] == 'o' || userLetters[i] == 'u' || userLetters[i] == ' ' || userLetters[i] == '.' || userLetters[i] == '?' || userLetters[i] == '!')
            //        {
            //            letterCount--;
            //        }
            //    }

            //    Console.WriteLine("There were " + letterCount + " consonants.");
            //    letterCount = 0;

            //    Continue();
            //}
            // END OF EXERCISE 27
            //
            //bool programContinue = true;
            //string userContinue = "";

            //while (programContinue == true)
            //{
            //    Console.Write("Enter some text: ");

            //    string userInput = Console.ReadLine().ToLower();
            //    string[] vowels = { "a", "e", "i", "o", "u" };

            //    foreach (var c in vowels)
            //    {
            //        userInput = userInput.Replace(c, string.Empty);
            //    }

            //    Console.WriteLine(userInput);

            //    Continue();
            //}
            // END OF EXERCISE 28
        }
    }
}
