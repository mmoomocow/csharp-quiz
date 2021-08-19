using System;

namespace console
{
	public struct Question
	{
		public string questionText;
		public string[] possibleAnswers;
		public int correctIndex;
		public string explanation;

		public Question(string question, string[] answers, int correctAnswer, string answerExplanation)
		{
			questionText = question;
			possibleAnswers = answers;
			correctIndex = correctAnswer;
			explanation = answerExplanation;
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			Random rnd = new Random();
			Question[] questions =
			{
				new Question("Question 1", (new string[] {"Answer 0", "Answer 1", "Answer 2", "Answer 3"}), 2),
				new Question("Question 2", (new string[] {"Answer 0", "Answer 1", "Answer 2", "Answer 3"}), 3),
				new Question("Question 3", (new string[] {"Answer 0", "Answer 1", "Answer 2", "Answer 3"}), 0),
			};
			Question randomQuestion = questions[rnd.Next(questions.Length)];

			Console.WriteLine(randomQuestion.questionText);
			for (int i = 0; i < randomQuestion.possibleAnswers.Length; i++)
			{
				Console.WriteLine($"{i + 1}) {randomQuestion.possibleAnswers[i]}");
			}

			int answerInt;
			while (!Int32.TryParse(Console.ReadLine(), out answerInt))
			{
				Console.WriteLine("Thats not a valid answer, please try again!");
			}

			if (answerInt != randomQuestion.correctIndex)
			{
				Console.WriteLine($"Sorry, thats not correct. The correct answer was: \n{randomQuestion.correctIndex + 1}) {randomQuestion.possibleAnswers[randomQuestion.correctIndex]}");
			}
			else
			{
				Console.WriteLine("Thats correct!!");
			}

			Console.ReadLine();
		}
	}
}
