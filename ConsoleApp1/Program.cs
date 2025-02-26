using System;
using System.Collections.Generic;
using QuizApp.Models;
using QuizApp.Services;
// Frågar användaren om språkval

Console.WriteLine("Select language: 1. Swedish 2. English");
string langChoice = Console.ReadLine() ?? string.Empty;
bool isEnglish = langChoice == "2";
// Visar information om ett godkänt resultat beroende på valt språk

Console.WriteLine(isEnglish
    ? "Important: Passing is over 15 correct answers and failing is under 15."
    : "Viktigt: Godkänd är över 15 frågor och under 15 är underkänd.");
// Visar introduktionstext och hämtar frågor från QuizService

QuizService.DisplayIntro(isEnglish);
List<Question> questions = QuizService.GetQuestions(isEnglish);

int score = RunQuiz(questions, isEnglish);
// Startar quizet och räknar ut poängen


double percent = (double)score / questions.Count * 100;
string evaluation = isEnglish
    ? (score > 15 ? "Passed" : "Failed")
    : (score > 15 ? "Godkänd" : "Underkänd");
// Ändrar färg beroende på om spelaren klarade quizet eller inte

Console.ForegroundColor = score > 15 ? ConsoleColor.Green : ConsoleColor.Red;
// Visar slutresultatet för användaren

Console.WriteLine(isEnglish
    ? $"Thank you for playing! You got {score} out of {questions.Count} correct ({percent:0.##}%). {evaluation}."
    : $"Tack för att du spelade! Du fick {score} av {questions.Count} rätt ({percent:0.##}%). {evaluation}.");
Console.ResetColor();

static int RunQuiz(List<Question> questions, bool isEnglish)
{    // Sparar spelarens poäng

    int score  0;
    // Håller koll på frågenumret

    int questionNumber = 1;

    foreach (var question in questions)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine(isEnglish
            // Visar frågan i cyan färg

            ? $"Question {questionNumber}: {question.Text}"
            : $"Fråga {questionNumber}: {question.Text}");
        Console.ResetColor();

        for (int i = 0; i < question.Options.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {question.Options[i]}");
        }

        Console.Write(isEnglish ? "Choose a number: " : "Välj ett nummer: ");
        string userAnswer = Console.ReadLine() ?? string.Empty;
        if (!int.TryParse(userAnswer, out int userAnswerIndex) || userAnswerIndex < 1 || userAnswerIndex > question.Options.Length)
        {
            Console.WriteLine(isEnglish ? "Invalid answer. Try again." : "Ogiltigt svar. Försök igen.");
            continue;
        }

        int correctIndex = Array.IndexOf(question.Options, question.CorrectAnswer) + 1;

        if (userAnswerIndex == correctIndex)
        {
            score++;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(isEnglish ? "Correct ✅" : "Rätt ✅");
            Console.WriteLine(isEnglish ? $"Your current score: {score}\n" : $"Din nuvarande poäng: {score}\n");
            Console.ResetColor();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(isEnglish ? "Wrong ❌" : "Fel ❌");
            Console.WriteLine(isEnglish
                ? $"Correct answer: {correctIndex}. {question.CorrectAnswer}"
                : $"Rätt svar: {correctIndex}. {question.CorrectAnswer}");
            Console.WriteLine(isEnglish ? $"Your current score: {score}\n" : $"Din nuvarande poäng: {score}\n");
            Console.ResetColor();
        }

        questionNumber++;
    }

    return score;
}
