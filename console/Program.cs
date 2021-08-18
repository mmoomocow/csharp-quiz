using System;

namespace console
{
	public struct Question
	{
		public string questionText;
		public string[] possibleAnswers;
		public int correctIndex;

		public Question(string question, string[] answers, int correctAnswer)
		{
			questionText = question;
			possibleAnswers = answers;
			correctIndex = correctAnswer;
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			Question[] questions =
			{
				new Question("Question 1", (new string[] {"Answer 0", "Answer 1", " Answer 2", "Answer 3"}), 2),
				new Question("Question 2", (new string[] {"Answer 0", "Answer 1", " Answer 2", "Answer 3"}), 3),
				new Question("Question 3", (new string[] {"Answer 0", "Answer 1", " Answer 2", "Answer 3"}), 0),
			};
		}
	}
}
