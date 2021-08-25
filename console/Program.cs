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
			Question[] questionsType1 = {
				new Question("Question 1 A", (new string[] { "Answer 0", "Answer 1", "Answer 2", "Answer 3" }), 3, "Some kind of explanation for why number 1 is correct..."),
				new Question("Question 1 B", (new string[] { "Answer 0", "Answer 1", "Answer 2", "Answer 3" }), 2, "Some kind of explanation for why number 1 is correct..."),
				new Question("Question 1 C", (new string[] { "Answer 0", "Answer 1", "Answer 2", "Answer 3" }), 0, "Some kind of explanation for why number 1 is correct..."),
				new Question("Question 1 D", (new string[] { "Answer 0", "Answer 1", "Answer 2", "Answer 3" }), 1, "Some kind of explanation for why number 1 is correct..."),
			};
			Question[] questionsType2 = {
				new Question("Question 2 A", (new string[] { "Answer 0", "Answer 1", "Answer 2", "Answer 3" }), 1, "Some kind of explanation for why number 1 is correct..."),
				new Question("Question 2 B", (new string[] { "Answer 0", "Answer 1", "Answer 2", "Answer 3" }), 2, "Some kind of explanation for why number 1 is correct..."),
				new Question("Question 2 C", (new string[] { "Answer 0", "Answer 1", "Answer 2", "Answer 3" }), 3, "Some kind of explanation for why number 1 is correct..."),
				new Question("Question 2 D", (new string[] { "Answer 0", "Answer 1", "Answer 2", "Answer 3" }), 2, "Some kind of explanation for why number 1 is correct..."),
			};
			Question[] questionsType3 = {
				new Question("Question 3 A", (new string[] { "Answer 0", "Answer 1", "Answer 2", "Answer 3" }), 3, "Some kind of explanation for why number 1 is correct..."),
				new Question("Question 3 B", (new string[] { "Answer 0", "Answer 1", "Answer 2", "Answer 3" }), 3, "Some kind of explanation for why number 1 is correct..."),
				new Question("Question 3 C", (new string[] { "Answer 0", "Answer 1", "Answer 2", "Answer 3" }), 0, "Some kind of explanation for why number 1 is correct..."),
				new Question("Question 3 D", (new string[] { "Answer 0", "Answer 1", "Answer 2", "Answer 3" }), 2, "Some kind of explanation for why number 1 is correct..."),
			};

			Question[] questionsType4 = {
				new Question("Question 4 A", (new string[] { "Answer 0", "Answer 1", "Answer 2", "Answer 3" }), 0, "Some kind of explanation for why number 1 is correct..."),
				new Question("Question 4 B", (new string[] { "Answer 0", "Answer 1", "Answer 2", "Answer 3" }), 2, "Some kind of explanation for why number 1 is correct..."),
				new Question("Question 4 C", (new string[] { "Answer 0", "Answer 1", "Answer 2", "Answer 3" }), 1, "Some kind of explanation for why number 1 is correct..."),
				new Question("Question 4 D", (new string[] { "Answer 0", "Answer 1", "Answer 2", "Answer 3" }), 3, "Some kind of explanation for why number 1 is correct..."),
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
				Console.WriteLine($"Sorry, thats not correct. The correct answer was: \n{randomQuestion.correctIndex + 1}) {randomQuestion.possibleAnswers[randomQuestion.correctIndex]}\n{randomQuestion.explanation}");
			}
			else
			{
				Console.WriteLine("Thats correct!!");
			// }

			Console.ReadLine();
		}
	}
}
