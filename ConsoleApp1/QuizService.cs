using System;
using System.Collections.Generic;
using System.Linq;
using QuizApp.Models;

namespace QuizApp.Services
{
    public static class QuizService

    {
        public static void DisplayIntro(bool isEnglish)
        {
            Console.Clear();
            if (isEnglish)
            {
                Console.WriteLine("==============================================");
                Console.WriteLine("       Welcome to Programming Quiz");
                Console.WriteLine("          for Programming language!");
                Console.WriteLine("==============================================");
                Console.WriteLine("There are 15 questions to answer.");
                Console.WriteLine("Press 'Enter' to start.");
            }
            else
            {
                Console.WriteLine("==============================================");
                Console.WriteLine(" Välkommen till Programmeringsquiz för");
                Console.WriteLine("         Programmeringspråk!");
                Console.WriteLine("==============================================");
                Console.WriteLine("Det finns totalt 15 frågor att besvara.");
                Console.WriteLine("Tryck 'Enter' för att starta.");
            }
            Console.ReadLine();
        }
        public static List<Question> GetQuestions(bool isEnglish)
        {
            if (isEnglish)
            {
                return new List<Question>
                {
                    new Question("Which tag pair is used to create a heading in HTML?", new string[] { "<p>", "<h1>", "<div>", "<span>" }, "<h1>"),

                }
                .OrderBy(q => Guid.NewGuid()).ToList();
            }
            else
            {
                return new List<Question>
                {
                    new Question("Vilket taggpar används för att skapa en rubrik i HTML?", new string[] { "<p>", "<h1>", "<div>", "<span>" }, "<h1>"),

                }
                .OrderBy(q => Guid.NewGuid()).ToList();
            }
        }
    }
}
