using System;
using System.Collections.Generic;
using QuizApp.Models;
using QuizApp.Services;

Console.WriteLine("Select language: 1. Swedish 2. English");
string langChoice = Console.ReadLine() ?? string.Empty;
bool isEnglish = langChoice == "2";
Console.WriteLine(isEnglish
    ? "Important: Passing is over 15 correct answers and failing is under 15."
    : "Viktigt: Godkänd är över 15 frågor och under 15 är underkänd.");
QuizService.DisplayIntro(isEnglish);
List<Question> questions = QuizService.GetQuestions(isEnglish);

int score = RunQuiz(questions, isEnglish);

double percent = (double)score / questions.Count * 100;
string evaluation = isEnglish
    ? (score > 15 ? "Passed" : "Failed")
    : (score > 15 ? "Godkänd" : "Underkänd");
Console.ForegroundColor = score > 15 ? ConsoleColor.Green : ConsoleColor.Red;
Console.WriteLine(isEnglish
    ? $"Thank you for playing! You got {score} out of {questions.Count} correct ({percent:0.##}%). {evaluation}."
    : $"Tack för att du spelade! Du fick {score} av {questions.Count} rätt ({percent:0.##}%). {evaluation}.");
Console.ResetColor();

static int RunQuiz(List<Question> questions, bool isEnglish)
{
    int score  0;
    int questionNumber = 1;

    foreach (var question in questions)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine(isEnglish
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
