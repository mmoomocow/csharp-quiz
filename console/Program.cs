using System;

namespace console
{
	// === Component - Question class ===

	/// <summary>
	/// The question class is used to represent a question, it is used because creating multiple question objects and placing them
	/// inside an array is a better option than having multiple arrays, especially when there are multiple question types.
	/// Without the object 4 arrays would be needed per question type
	/// </summary>
	public class Question
	{
		/// <summary>The question text</summary>
		public string questionText;

		/// <summary>An array of the possible answers</summary>
		public string[] possibleAnswers;

		/// <summary>The **index** position of the correct answer</summary>
		public int correctIndex;

		/// <summary>An explanation for why the answer is correct</summary>
		public string explanation;

		/// <summary>
		/// Constructs a new question object
		/// </summary>
		/// <param name="question">The question text</param>
		/// <param name="answers">An array of the possible answers</param>
		/// <param name="correctAnswer">The **index** position of the correct answer</param>
		/// <param name="answerExplanation">An explanation for why the answer is correct</param>
		/// <returns>A question object with the given information</returns>
		public Question(string question, string[] answers, int correctAnswer, string answerExplanation)
		{
			questionText = question;
			possibleAnswers = answers;
			correctIndex = correctAnswer;
			explanation = answerExplanation;
		}
	}

	/// <summary>
	/// The main program class
	/// </summary>
	class Program
	{
		/// <summary>
		/// The main code to be run
		/// </summary>
		/// <param name="args">Any command line args given when running the program</param>
		static void Main(string[] args)
		{
			// Create the random generator
			Random rnd = new Random();

			// Create questions. 
			// Each array of questions is a different type
			// The questions are created from the Question constructor
			Question[] Questions_firstAid = {
				new Question("Question 1 A", (new string[] { "Answer 0", "Answer 1", "Answer 2", "Answer 3" }), 3, "Some kind of explanation for why number 1 is correct..."),
				new Question("Question 1 B", (new string[] { "Answer 0", "Answer 1", "Answer 2", "Answer 3" }), 2, "Some kind of explanation for why number 2 is correct..."),
				new Question("Question 1 C", (new string[] { "Answer 0", "Answer 1", "Answer 2", "Answer 3" }), 0, "Some kind of explanation for why number 3 is correct..."),
				new Question("Question 1 D", (new string[] { "Answer 0", "Answer 1", "Answer 2", "Answer 3" }), 1, "Some kind of explanation for why number 4 is correct..."),
			};
			Question[] Questions_caregivers = {
				new Question("Question 2 A", (new string[] { "Answer 0", "Answer 1", "Answer 2", "Answer 3" }), 1, "Some kind of explanation for why number 1 is correct..."),
				new Question("Question 2 B", (new string[] { "Answer 0", "Answer 1", "Answer 2", "Answer 3" }), 2, "Some kind of explanation for why number 2 is correct..."),
				new Question("Question 2 C", (new string[] { "Answer 0", "Answer 1", "Answer 2", "Answer 3" }), 3, "Some kind of explanation for why number 3 is correct..."),
				new Question("Question 2 D", (new string[] { "Answer 0", "Answer 1", "Answer 2", "Answer 3" }), 2, "Some kind of explanation for why number 4 is correct..."),
			};
			Question[] Questions_vitalSigns = {
				new Question("What is a normal Heart Rate?", (new string[] { "80 bpm", "120 bpm", " 100 bpm", "60 bpm" }), 0, "80 bpm is an average heart rate, however the context of a scenario can change what would be expected."),
				new Question("What's a normal palpated blood pressure?", (new string[] { "120/80", "120/P", "80/P", "130/70" }), 1, "As the blood pressure is palpated, there should be no bottom number, 120/p is normal."),
				new Question("What is a normal BGL?", (new string[] { "2 mmol/L", "15 mmol/L", "12 mmol/L", "5 mmol/L" }), 3, "Anything less than or equal to 3 is considered low and requires intervention and anything above 10 is higher than normal."),
				new Question("What is the lowest GCS score possible?", (new string[] { "0", "1", "2", "3" }), 3, "Each of the 3 areas of the GCS assessment is given a minimum score of 1, so less than 3 is not possible"),
			};

			Question[] Questions_writtenTest = {
				new Question("Question 4 A", (new string[] { "Answer 0", "Answer 1", "Answer 2", "Answer 3" }), 0, "Some kind of explanation for why number 1 is correct..."),
				new Question("Question 4 B", (new string[] { "Answer 0", "Answer 1", "Answer 2", "Answer 3" }), 2, "Some kind of explanation for why number 2 is correct..."),
				new Question("Question 4 C", (new string[] { "Answer 0", "Answer 1", "Answer 2", "Answer 3" }), 1, "Some kind of explanation for why number 3 is correct..."),
				new Question("Question 4 D", (new string[] { "Answer 0", "Answer 1", "Answer 2", "Answer 3" }), 3, "Some kind of explanation for why number 4 is correct..."),
			};

			// === Component - Deciding question type ===
			// Pre-define an int for the type outside of the scope of the while loop
			int questionType;
			// Ask the user what question type they want
			Console.WriteLine("What question type do you want? \n1. First Aid \n2. Caregivers \n3. Vital Signs \n4. Written Test");
			// Get the user's input
			// Using a while loop and TryParse reduces the amount of code required, and the loop will only run when
			// TryParse fails
			while (!Int32.TryParse(Console.ReadLine(), out questionType) && questionType >= 1 && questionType <= 4)
			{
				// Tell the user that their choice is not valid
				Console.WriteLine("Thats not a valid choice! please try again");
				// and ask again
				Console.WriteLine("What question type do you want? \n1. First Aid \n2. Caregivers \n3. Vital Signs \n4. Written Test");
			}


			// === Component - Selecting a random question ===
			// Define the randomQuestion variable outside of the scope of the switch
			Question randomQuestion;
			// Use a switch statement to get the correct question type
			// A switch statement is used here because it allows simple expantion of the program 
			switch (questionType)
			{
				// If the user gives question type 2 as their answer
				case 2:
					// Generate a random number, it will be >= 0 and <= the length of the array
					// Then get the item in that index position of the array
					randomQuestion = Questions_caregivers[rnd.Next(Questions_caregivers.Length)];
					break;
				// If the user gives question type 3 as their answer
				case 3:
					// Generate a random number, it will be >= 0 and <= the length of the array
					// Then get the item in that index position of the array
					randomQuestion = Questions_vitalSigns[rnd.Next(Questions_vitalSigns.Length)];
					break;
				// If the user gives question type 4 as their answer
				case 4:
					// Generate a random number, it will be >= 0 and <= the length of the array
					// Then get the item in that index position of the array
					randomQuestion = Questions_writtenTest[rnd.Next(Questions_writtenTest.Length)];
					break;
				// Having a default case is required, if the switch hasn't triggered yet it will run this
				default:
					// Generate a random number, it will be >= 0 and <= the length of the array
					// Then get the item in that index position of the array
					randomQuestion = Questions_firstAid[rnd.Next(Questions_firstAid.Length)];
					break;
			}


			// === Component - Asking the user the question ===

			// Write the question text of the randomly selected question
			Console.WriteLine(randomQuestion.questionText);
			// Use a for loop to iterate through all possible answers
			for (int i = 0; i < randomQuestion.possibleAnswers.Length; i++)
			{
				// Print the possible answer number and the possible answer
				// the i + 1 is used because normal people count from 1
				// and starting from 0 (as would happen due to it being the index position)
				// could confuse them
				Console.WriteLine($"{i + 1}) {randomQuestion.possibleAnswers[i]}");
			}

			// === Component - Handeling the user's response ===

			// Pre-define an int for the answer outside of the scope of the while loop
			int answerInt;
			// Another while loop used for input, for the same reasons as above
			while (!Int32.TryParse(Console.ReadLine(), out answerInt))
			{
				// Tell the user that their answer is not valid, and to try again
				Console.WriteLine("Thats not a valid answer, please try again!");
				// Loop!
			}

			// If the answer is not correct
			if (answerInt != randomQuestion.correctIndex)
			{
				// Tell the user the answer is incorrect, then give the correct answer and an explanation for why the answer is correct
				Console.WriteLine($"Sorry, thats not correct. The correct answer was: \n{randomQuestion.correctIndex + 1}) {randomQuestion.possibleAnswers[randomQuestion.correctIndex]}\n{randomQuestion.explanation}");
			}
			// Else it is correct
			else
			{
				// Congratulate the user
				Console.WriteLine("Thats correct!!");
			}

			// To prevent the program exiting instantly
			Console.ReadLine();
		}
	}
}
