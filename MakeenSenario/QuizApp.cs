using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.MakeenSenario
{
    internal class QuizApp
    {
        
            public static void Run()
            {
                //Assignment 2: Simple Quiz App
                // Concepts Used: Arrays, loops, conditions, switch
                // Description:
                //Create a quiz game that asks the user 5 multiple - choice questions.After each
                //question, show if the answer is correct and keep track of the score.


                //-Use arrays for questions, options, and correct answers.
                string[] questions = new string[]
                {
                "What is the main goal of the Makeen program?",
                "Which ministries are involved in the Makeen program?",
                "What kind of training does Makeen offe?",
                "Who is the target audience for Makeen training programs'?",
                "In which digital area was a recent Makeen training offered (per announcements)?"
                };
                string[,] options = new string[,]
                {
                {"A. To train Omanis in digital skills", "B. To sell digital certificates", "C. To run an e-commerce platform", "D. To manage government payrolls"},
                {"A. Ministry of Health and Ministry of Education", "B. Ministry of Labor and Ministry of Transport & ICT", "C. Ministry of Finance and Ministry of Culture", "D. Ministry of Tourism and Ministry of Environment"},
                {"A. Sports coaching", "B. Technical and digital certification courses", "C. Farming techniques", "D. Language translation only"},
                {"A. Charles Dickens", "B. Mark Twain", "C. William Shakespeare", "D. Jane Austen"},
                {"A. Foreign tourists", "B. Government officials only", "C. Job seekers and Omani youth", "D. CKindergarten students"}
                };
                char[] correctAnswers = new char[] { 'A', 'B', 'B', 'C', 'B' };//-Show the question and four options(A, B, C, D).
                int score = 0;
                //- Present each question one at a time using a loop.
                //-For each question:
                for (int i = 0; i < questions.Length; i++)
                {
                    Console.WriteLine(questions[i]);
                    for (int j = 0; j < 4; j++)
                    {
                        Console.WriteLine(options[i, j]);
                    }
                    Console.Write("Your answer (A, B, C, D): ");
                    char userAnswer = Char.ToUpper(Console.ReadKey().KeyChar);//- Read user input and compare it to the correct answer.
                    Console.WriteLine();
                    if (userAnswer == correctAnswers[i])
                    {
                        Console.WriteLine("Correct!");
                        score++;
                    }
                    else
                    {
                        Console.WriteLine($"Wrong! The correct answer is {correctAnswers[i]}.");
                    }
                    Console.WriteLine();
                }

                Console.WriteLine($"Your final score is {score} out of {questions.Length}.");
                //- At the end, show the final score out of 5.
                //- Use a switch to display feedback messages for the final score:
                //-Excellent
                //- Good
                //- Try Again
                switch (score)
                {
                    case 5:
                        Console.WriteLine("Excellent!");
                        break;
                    case 3:
                    case 4:
                        Console.WriteLine("Good!");
                        break;
                    default:
                        Console.WriteLine("Try Again!");
                        break;
                }
            }
        }
    }


