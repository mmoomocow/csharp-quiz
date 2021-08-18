using System;

namespace console
{
	public class Question
	{
		public string questionText;
		public string[] possibleAnswers;
		public int correctIndex;

		public Question(string text, string[] answers, int correct)
		{
			questionText = text;
			possibleAnswers = answers;
			correctIndex = correct;
		}
	}
	class Program
	{
		static void Main(string[] args)
		{

		}
	}
}
