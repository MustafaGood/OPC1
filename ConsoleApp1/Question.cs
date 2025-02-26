// Namnrymden (namespace) definierar var klassen hör hemma i projektet.

namespace QuizApp.Models;
// Klassen Question representerar en fråga i en quiz-app.

public class Question
{
    public string Text { get; }     // Egenskap för själva frågetexten. (t.ex. "Vad heter du?")
    public string[] Options { get; }     // Egenskap för svarsalternativen. (t.ex. ["Mustafa", "Adam", "Simon", "Amanda"])

    public string CorrectAnswer { get; }     // Egenskap för det korrekta svaret. (t.ex. "Mustafa")

        // Konstruktor: Skapar en ny fråga med text, alternativ och rätt svar.
    public Question(string text, string[] options, string correctAnswer)
    {
        Text = text; // Sätter frågetexten.
        Options = options; // Sätter svarsalternativen.
        CorrectAnswer = correctAnswer;// Sätter det rätta svaret.
    }
}
