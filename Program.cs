using System;
using System.Collections.Generic;
using magic8ball;

namespace magic8ball
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("                 Hello, ");
            Console.WriteLine("I'm the 8 ball and I have the answers for your doubts: ");
            Console.WriteLine();
        Start:
            Console.WriteLine("           What is your question? ");
            string qst = "question";
            qst = Console.ReadLine();

            Console.WriteLine("   The answer for  " + qst + " is :  ");

            List<string> listOfPossibleAnswers = new List<string>();

            listOfPossibleAnswers.Add("  It is certain!");
            listOfPossibleAnswers.Add("  It is decidedly so.");
            listOfPossibleAnswers.Add("  Whithout a doubt");
            listOfPossibleAnswers.Add("  Yes, definitely");
            listOfPossibleAnswers.Add("  You may rely on it");
            listOfPossibleAnswers.Add("  As I see it, yes!");
            listOfPossibleAnswers.Add("  Most likely");
            listOfPossibleAnswers.Add("  Outlook good");
            listOfPossibleAnswers.Add("  YES");
            listOfPossibleAnswers.Add("  Signs point to yes.");
            listOfPossibleAnswers.Add("  Reply hazy, try again!");
            listOfPossibleAnswers.Add("  Ask again later, I`m not sure yet");
            listOfPossibleAnswers.Add("  Better not tell you now!");
            listOfPossibleAnswers.Add("  Cannot predict now!");
            listOfPossibleAnswers.Add("  Concentrate and ask again what you really desire");
            listOfPossibleAnswers.Add("  Don't count on it.");
            listOfPossibleAnswers.Add("  My reply is NO!");
            listOfPossibleAnswers.Add("  My  sources say no");
            listOfPossibleAnswers.Add("  Outlook not so good");
            listOfPossibleAnswers.Add("  very doubtful");
            listOfPossibleAnswers.Add("  No way!");
            listOfPossibleAnswers.Add("  You will get everything you need!");
            listOfPossibleAnswers.Add("  You rock, don't worry");
            listOfPossibleAnswers.Add("  You already have the answer, trust in your gut!");
            listOfPossibleAnswers.Add("  All you need is patience");
            listOfPossibleAnswers.Add("  Maybe next month you will know better");
            listOfPossibleAnswers.Add("  I hope so, but you not puting effort enought on it");
            listOfPossibleAnswers.Add("  If it's meant to be, it will be");
            listOfPossibleAnswers.Add("  What's meant to be will always find its way");
            listOfPossibleAnswers.Add("  Give it your best shot, if it's meant to be, it will be!");
            listOfPossibleAnswers.Add("  Let it go! You better without");

            Random rdm = new Random();

            int answers = rdm.Next(0, 30);
            Console.WriteLine(listOfPossibleAnswers[answers]);

            // ask again

            Console.WriteLine("  Do you got another doubt?  ");
            Console.WriteLine("  Type ( 1 ) for affirmative   or  ( 2 ) for negative:  ");

            int numberChosen = int.Parse(Console.ReadLine());

            if (numberChosen == 1)
                goto Start;

            //if i only want the program asking twice:
            /* { 
                 Console.WriteLine("  What is your question? ");

                 string qst2 = "question";
                 qst2 = Console.ReadLine();

                 Console.WriteLine("   The answer for  " + qst2 + " is :    ");

                 Random rdm1 = new Random();

                 int answers2 = rdm.Next(0, 30);
                 Console.WriteLine(listOfPossibleAnswers[answers2]);
             }*/

            else
            {
                Console.WriteLine("  Thanks, this is all for today!");
            }
          
        }
    }
}
