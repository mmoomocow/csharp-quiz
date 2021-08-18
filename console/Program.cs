using System;

namespace console
{
	public class MultiChoiceQuestion
	{
		public string questionText;
		public string[] possibleAnswers;
		public int correctIndex;

		public MultiChoiceQuestion(string text, string[] answers, int correct)
		{
			questionText = text;
			possibleAnswers = answers;
			correctIndex = correct;
		}
	}
	public class Question
	{
		public string questionText;
		public string correctIndex;

		public Question(string text, string correct)
		{
			questionText = text;
			correctIndex = correct;
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
		}
	}
}
