using QuestionnaireLibrary;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Question question = new Question("What is the name of the current president of the USA?");
            Answer answerCorrect = new Answer("Joe biden", true);
            Answer answer2 = new Answer("Barack Obama", false);
            Answer answer3 = new Answer("Donald Trump", false);
            Answer answer4 = new Answer("Sam", false);
            question.Add(answerCorrect);
            question.Add(answer2);
            question.Add(answer3);
            question.Add(answer4);
            

            Console.WriteLine(question.ToString());
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"{i+1} "+ question.GetAnswer(i));
            }
            Console.WriteLine("What is the right answer: ");
            Answer answer = question.GetAnswer(Convert.ToInt32(Console.ReadLine())-1);
            if (answer.IsCorrect == true)
            {
                Console.WriteLine("Your answer is correct");
            }
            else
            {
                Console.WriteLine($"Your answer is wrong, the correct answer is {question.GetAnswer(0)}");
            }

        }
    }
}