using System;
using System.Collections.Generic;
using System.Linq;
using QuizApp.Models;

namespace QuizApp.Services
{
    public static class QuizService

    {
            // En tjänst (service) för att hantera quiz-frågor

        public static void DisplayIntro(bool isEnglish)
        {
            Console.Clear();
            if (isEnglish)
            {             
                   // Skriver ut introduktion på engelska
                Console.WriteLine("==============================================");
                Console.WriteLine("       Welcome to Programming Quiz");
                Console.WriteLine("          for Programming language!");
                Console.WriteLine("==============================================");
                Console.WriteLine("There are 15 questions to answer.");
                Console.WriteLine("Press 'Enter' to start.");
            }
            else
            {
                                // Skriver ut introduktion på svenska

                Console.WriteLine("==============================================");
                Console.WriteLine(" Välkommen till Programmeringsquiz för");
                Console.WriteLine("         Programmeringspråk!");
                Console.WriteLine("==============================================");
                Console.WriteLine("Det finns totalt 15 frågor att besvara.");
                Console.WriteLine("Tryck 'Enter' för att starta.");
            }
            Console.ReadLine(); // Väntar på att användaren trycker på Enter
        }
        // Hämtar en lista med frågor för quizet, antingen på engelska eller svenska
        public static List<Question> GetQuestions(bool isEnglish)
        {
            if (isEnglish)
            {// Returnerar en lista med frågor på engelska
                return new List<Question>
                {
                    new Question("Which tag pair is used to create a heading in HTML?", new string[] { "<p>", "<h1>", "<div>", "<span>" }, "<h1>"),
                    new Question("Which keyword is used to define a function in Python?", new string[] { "func", "def", "define", "function" }, "def"),
                    new Question("What is the correct syntax to output 'Hello World' in C++?", new string[] { "print('Hello World')", "cout << 'Hello World';", "Console.WriteLine('Hello World');", "System.out.println('Hello World');" }, "cout << 'Hello World';"),
                    new Question("Which of the following is a valid way to declare a variable in JavaScript?", new string[] { "let x = 10;", "var x := 10;", "int x = 10;", "declare x = 10;" }, "let x = 10;"),
                    new Question("What is the main purpose of SQL?", new string[] { "Styling web pages", "Managing databases", "Creating animations", "Handling system processes" }, "Managing databases"),
                    new Question("Which symbol is used for single-line comments in Java?", new string[] { "#", "//", "--", "/* */" }, "//"),
                    new Question("What is the entry point method in a Java application?", new string[] { "start()", "run()", "main()", "execute()" }, "main()"),
                    new Question("Which of the following is not a programming language?", new string[] { "Python", "Java", "HTML", "C#" }, "HTML"),
                    new Question("What does CSS stand for?", new string[] { "Creative Style Sheets", "Cascading Style Sheets", "Computer Style System", "Colorful Style Sheets" }, "Cascading Style Sheets"),
                    new Question("Which operator is used to compare two values in JavaScript?", new string[] { "=", "==", "===", "!==" }, "==="),
                    new Question("In Python, which data structure is immutable?", new string[] { "List", "Tuple", "Dictionary", "Set" }, "Tuple"),
                    new Question("What is the correct way to declare a class in Java?", new string[] { "class MyClass {}", "MyClass = class {}", "def MyClass: {}", "new class MyClass {}" }, "class MyClass {}"),
                    new Question("Which method is used to read input from the user in C#?", new string[] { "Console.ReadLine()", "input()", "Scanner.read()", "System.in.read()" }, "Console.ReadLine()"),
                    new Question("Which programming language is mainly used for building iOS applications?", new string[] { "Swift", "Kotlin", "Objective-C", "C#" }, "Swift"),
                    new Question("What is the default value of an uninitialized boolean variable in Java?", new string[] { "true", "false", "null", "undefined" }, "false"),
                }
                .OrderBy(q => Guid.NewGuid()).ToList();
            }
            else
            {                // Returnerar en lista med frågor på svenska

                return new List<Question>
                {
                    new Question("Vilket taggpar används för att skapa en rubrik i HTML? / Which tag pair is used to create a heading in HTML?", new string[] { "<p>", "<h1>", "<div>", "<span>" }, "<h1>"),
                    new Question("Vilket nyckelord används för att definiera en funktion i Python? / Which keyword is used to define a function in Python?", new string[] { "func", "def", "define", "function" }, "def"),
                    new Question("Vad är den korrekta syntaxen för att skriva ut 'Hello World' i C++? / What is the correct syntax to output 'Hello World' in C++?", new string[] { "print('Hello World')", "cout << 'Hello World';", "Console.WriteLine('Hello World');", "System.out.println('Hello World');" }, "cout << 'Hello World';"),
                    new Question("Vilket av följande är ett giltigt sätt att deklarera en variabel i JavaScript? / Which of the following is a valid way to declare a variable in JavaScript?", new string[] { "let x = 10;", "var x := 10;", "int x = 10;", "declare x = 10;" }, "let x = 10;"),
                    new Question("Vad är huvudsyftet med SQL? / What is the main purpose of SQL?", new string[] { "Styling webbsidor / Styling web pages", "Hantera databaser / Managing databases", "Skapa animationer / Creating animations", "Hantera systemprocesser / Handling system processes" }, "Hantera databaser / Managing databases"),
                    new Question("Vilken symbol används för enkla kommentarer i Java? / Which symbol is used for single-line comments in Java?", new string[] { "#", "//", "--", "/* */" }, "//"),
                    new Question("Vilken metod används som startpunkt i en Java-applikation? / What is the entry point method in a Java application?", new string[] { "start()", "run()", "main()", "execute()" }, "main()"),
                    new Question("Vilket av följande är INTE ett programmeringsspråk? / Which of the following is NOT a programming language?", new string[] { "Python", "Java", "HTML", "C#" }, "HTML"),
                    new Question("Vad står CSS för? / What does CSS stand for?", new string[] { "Creative Style Sheets", "Cascading Style Sheets", "Computer Style System", "Colorful Style Sheets" }, "Cascading Style Sheets"),
                    new Question("Vilken operator används för att jämföra två värden i JavaScript? / Which operator is used to compare two values in JavaScript?", new string[] { "=", "==", "===", "!==" }, "==="),
                    new Question("Vilken datastruktur i Python är oföränderlig (immutable)? / In Python, which data structure is immutable?", new string[] { "Lista / List", "Tuple / Tuple", "Dictionary / Dictionary", "Set / Set" }, "Tuple"),
                    new Question("Hur deklarerar man en klass i Java? / What is the correct way to declare a class in Java?", new string[] { "class MyClass {}", "MyClass = class {}", "def MyClass: {}", "new class MyClass {}" }, "class MyClass {}"),
                    new Question("Vilken metod används för att läsa inmatning från användaren i C#? / Which method is used to read input from the user in C#?", new string[] { "Console.ReadLine()", "input()", "Scanner.read()", "System.in.read()" }, "Console.ReadLine()"),
                    new Question("Vilket programmeringsspråk används främst för att utveckla iOS-appar? / Which programming language is mainly used for building iOS applications?", new string[] { "Swift", "Kotlin", "Objective-C", "C#" }, "Swift"),
                    new Question("Vad är standardvärdet för en oinitierad boolean-variabel i Java? / What is the default value of an uninitialized boolean variable in Java?", new string[] { "true", "false", "null", "undefined" }, "false"),
                }
                .OrderBy(q => Guid.NewGuid()).ToList();
            }
        }
    }
}
