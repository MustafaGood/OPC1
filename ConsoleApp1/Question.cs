namespace QuizApp.Models;
public class Question
{
    public string Text { get; } 
    public string[] Options { get; } 
    public string CorrectAnswer { get; } 

    public Question(string text, string[] options, string correctAnswer)
    {
        Text = text;
        Options = options;
        CorrectAnswer = correctAnswer;
    }
}
