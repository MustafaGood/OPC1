using Xunit;
using QuizApp.Models;

public class QuestionTests
{
    [Fact]
    public void TestCorrectAnswer()
    {
        var question = new Question("Testfråga", new[] { "Fel", "Rätt" }, "Rätt");
        Assert.Equal(2, Array.IndexOf(question.Options, question.CorrectAnswer) + 1);
    }
}
