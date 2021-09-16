﻿using System;

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
			Question[] Questions_triage = {
				new Question("Status 1 is considered to be:", (new string[] { "Dead", "Potentially immediately life threatening", "Not medically urgent", "Immediately life threatening" }), 3, "Status one is used to describe someone who's condition is immediately life threatening"),
				new Question("A patient with stroke symptoms and < 3 hour onset would be what status?", (new string[] { "Status 1", "Status 2", "Status 3", "Status 4" }), 1, "Stroke patients with a symptom onset of < 3.5 hours are considered status 2"),
				new Question("A patient was in a RTC but has no apparent injuries, what status are they?", (new string[] { "Status 1", "Status 2", "Status 3", "Status 4" }), 3, "If the patient has no injuries they are status 4, MOI should not be considered when determining status codes"),
				new Question("A patient walks over to you complaining of a toothache, what status are they?", (new string[] { "Status 1", "Status 2", "Status 3", "Status 4" }), 3, "Toothaches are not medically urgent"),
				new Question("What operation code is used for 'Urgent but not Immediately Life Threatening'", (new string[] { "Purple", "Orange", "Yellow", "Green" }), 1, "Operation code orange is defined as Urgent but not Immediately Life Threatening"),
				new Question("What status code is the following patient: 13-year-old female with an open fracture of the wrist", (new string[] { "Status 4", "Status 3", "Status 2", "Status 1" }), 1, "As there is a broken long bone and bleeding they are status 3. It is unlikely to be life threatening."),
				new Question("Status code 0 is:", (new string[] { "Dead", "Potentially immediately life threatening", "Not medically urgent", "Immediately life threatening" }), 0, "Dead patients are given the status code 0"),
			};

			Question[] Questions_vitalSigns = {
				new Question("What is a normal Heart Rate?", (new string[] { "80 bpm", "120 bpm", " 100 bpm", "60 bpm" }), 0, "80 bpm is an average heart rate, however the context of a scenario can change what would be expected."),
				new Question("What's a normal palpated blood pressure?", (new string[] { "120/80", "120/P", "80/P", "130/70" }), 1, "As the blood pressure is palpated, there should be no bottom number, 120/p is normal."),
				new Question("What is a normal BGL?", (new string[] { "2 mmol/L", "15 mmol/L", "12 mmol/L", "5 mmol/L" }), 3, "Anything less than or equal to 3 is considered low and requires intervention and anything above 10 is higher than normal."),
				new Question("What is the lowest GCS score possible?", (new string[] { "0", "1", "2", "3" }), 3, "Each of the 3 areas of the GCS assessment is given a minimum score of 1, so less than 3 is not possible"),
				new Question("What is a normal resperatory rate?", (new string[] {"10 bpm", "12 bpm", "15 bpm", "21 bpm"}), 1, "The average resp rate is 12 breaths per minute"),
			};

			Question[] Questions_writtenTest = {
				new Question("How many Districts are there in the south island?", (new string[] { "7", "9", "10", "11" }), 1, "There are 9 districts, Mid Canterbury, North Canterbury, Christchurch, Costal Otago, Central Otago, Southland, Aoraki, West Coast and Nelson Marlborough."),
				new Question("How many regions are there in New Zealand", (new string[] { "1", "2", "3", "4" }), 2, "There are 3 regions, Northern, Central and South Island"),
				new Question("How many areas are there in the Costal Otago district?", (new string[] { "5", "8", "6", "4" }), 1, "There are 5 areas, South, Costal otago, Ara te uru, Taieri, and Otepoti"),
				new Question("How many badges are there in the Grand Prior curriculum", (new string[] { "15", "23", "27", "31" }), 2, "There are 27 badges you can achieve under the grand prior system. This is because green, blue and gold levels are counted as one badge."),
				new Question("How many hours of comunity service are required to get a green shield?", (new string[] { "100 hours", "200 hours", "500 hours", "800 hours" }), 1, "200 hours gives you a blue shield."),
				new Question("Which of these is not a St John program", (new string[] { "Operations", "Therapy Pets", "1737", "FEDs" }), 2, "St John's community programs include Operations, Therapy Pets, FEDs, Medical Alarms, St John in schools and more. 1737 is independent, but a good resource to use"),
				new Question("Which of these is not one of St John's cardinal values on the Amalfi Cross?", (new string[] { "Compassion", "Prudence", "Temperance", "Fortitude" }), 0, "The 4 cardinal values on the Amalfi Cross are Prudence, Justice, Temperance and Fortitude"),
				new Question("In what decade was the Order of the Hospital of St John of Jerusalem start?", (new string[] { "1110", "1060", "1150", "1070" }), 3, "The exact date of when the order formed is unknown, however it is believed to be in 1070."),
				new Question("When was the order become a royal order?", (new string[] { "1888", "1873", "1891", "1915" }), 0, "It was in 1888 when Queen Victoria granted the order of St John royal charter and the royal beasts were added to the Amalfi cross"),
			};

			// === Component - Deciding question type ===
			// Pre-define an int for the type outside of the scope of the while loop
			int questionType;
			// Ask the user what question type they want
			Console.WriteLine("What question type do you want? \n1. Triage \n2. Vital Signs \n3. Written Test");
			// Get the user's input
			// Using a while loop and TryParse reduces the amount of code required, and the loop will only run when
			// TryParse fails
			while (!Int32.TryParse(Console.ReadLine(), out questionType) && questionType >= 1 && questionType <= 4)
			{
				// Tell the user that their choice is not valid
				Console.WriteLine("Thats not a valid choice! please try again");
				// and ask again
				Console.WriteLine("What question type do you want? \n1. Triage \n2. Vital Signs \n3. Written Test");
			}


			// === Component - Selecting a random question ===
			// Define the randomQuestion variable outside of the scope of the switch
			Question randomQuestion;
			// Use a switch statement to get the correct question type
			// A switch statement is used here because it allows simple expantion of the program 
			switch (questionType)
			{
				// If the user gives question type 2 as their answer
				case 1:
					// Generate a random number, it will be >= 0 and <= the length of the array
					// Then get the item in that index position of the array
					randomQuestion = Questions_vitalSigns[rnd.Next(Questions_vitalSigns.Length)];
					break;
				// If the user gives question type 3 as their answer
				case 2:
					// Generate a random number, it will be >= 0 and <= the length of the array
					// Then get the item in that index position of the array
					randomQuestion = Questions_writtenTest[rnd.Next(Questions_writtenTest.Length)];
					break;
				// Having a default case is required, if the switch hasn't triggered yet it will run this
				default:
					// Generate a random number, it will be >= 0 and <= the length of the array
					// Then get the item in that index position of the array
					randomQuestion = Questions_triage[rnd.Next(Questions_triage.Length)];
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
