// See https://aka.ms/new-console-template for more information

using System.Security.Cryptography;

internal class Program
{
    public class random
    {
        private static void Main(string[] args)
        {
            int number = 0;
            String yes = "yes";
            String no = "no";
            String heads = "heads"; 
            String tails = "tails";
            String answer = "answer";
            string name;

            int counter;
            String wrong = "Wrong!";
            String correct = "Correct!";
            int score = 0;
            Random rnd = new();

            Console.WriteLine("Welcome to the Coin Flip Challenge! ");
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
            Console.WriteLine("Hello " + name + " ! Would you like to play the Coin Flip Challenge?");
            answer = Console.ReadLine();

            if (answer.Contains("no")) 
            {
                Console.WriteLine("Coward!");
                Environment.Exit(0);

            }
            for (counter = 1; counter <= 5; counter++)
            {
                Console.WriteLine("Heads of Tails? ");
                answer = Console.ReadLine();
                


                if (answer.Contains(heads) && number == 0)
                {
                    Console.WriteLine("Correct!");
                    score++;
                }
                if (answer.Contains(tails) && number == 1)
                {
                    Console.WriteLine("Correct!");
                    score++;
                }
                if (answer.Contains(heads) && number == 1)
                {
                    Console.WriteLine("Wrong.");
                }
                if (answer.Contains (tails) && number == 0) 
                {
                    Console.WriteLine("Wrong");
                }
            }
            Console.WriteLine("Thank you "  + name + ". You got a score of " + score + "!");
            Environment.Exit(0);
        }


    }
}
