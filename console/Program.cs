using System;

namespace console
{
	public class MultiChoiceQuestion
	{
		string questionText;
		string[] possibleAnswers; // if multiChoice true
		int correctIndex; // if multiChoice true

		public MultiChoiceQuestion(string text, string[] answers, int correct)
		{
			questionText = text;
			possibleAnswers = answers;
			correctIndex = correct;
		}
	}
	public class Question
	{
		string questionText;
		string correctIndex; // if multiChoice true

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
