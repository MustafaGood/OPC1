using Xunit;
using QuizApp.Models;

public class QuestionTests
{
    [Fact]
    public void TestCorrectAnswer()
    {
        // Skapar en ny fråga med två alternativ, där "Rätt" är det korrekta svaret.
        var question = new Question("Testfråga", new[] { "Fel", "Rätt" }, "Rätt");
        // Kontrollerar att det korrekta svaret finns på rätt plats i listan.
        Assert.Equal(2, Array.IndexOf(question.Options, question.CorrectAnswer) + 1);
    }
}
