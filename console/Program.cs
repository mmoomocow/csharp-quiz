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

		}
	}
}
