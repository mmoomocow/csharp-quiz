using System;
using System.Collections.Generic;

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
	/// Questions for the quiz. 
	/// Each use should have a separate object, as asked questions are removed from the list
	/// </summary>
	public class Questions
	{
		private List<Question> firstAid = new List<Question>
		{
			new Question("Status 1 is considered to be:", (new string[] { "Dead", "Potentially immediately life threatening", "Not medically urgent", "Immediately life threatening" }), 3, "Status one is used to describe someone who's condition is immediately life threatening"),
			new Question("A patient with stroke symptoms and < 3 hour onset would be what status?", (new string[] { "Status 1", "Status 2", "Status 3", "Status 4" }), 1, "Stroke patients with a symptom onset of < 3.5 hours are considered status 2"),
			new Question("A patient was in a RTC but has no apparent injuries, what status are they?", (new string[] { "Status 1", "Status 2", "Status 3", "Status 4" }), 3, "If the patient has no injuries they are status 4, MOI should not be considered when determining status codes"),
			new Question("A patient walks over to you complaining of a toothache, what status are they?", (new string[] { "Status 1", "Status 2", "Status 3", "Status 4" }), 3, "Toothaches are not medically urgent"),
			new Question("What operation code is used for 'Urgent but not Immediately Life Threatening'", (new string[] { "Purple", "Orange", "Yellow", "Green" }), 1, "Operation code orange is defined as Urgent but not Immediately Life Threatening"),
			new Question("What status code is the following patient: 13-year-old female with an open fracture of the wrist", (new string[] { "Status 4", "Status 3", "Status 2", "Status 1" }), 1, "As there is a broken long bone and bleeding they are status 3. It is unlikely to be life threatening."),
			new Question("Status code 0 is:", (new string[] { "Dead", "Potentially immediately life threatening", "Not medically urgent", "Immediately life threatening" }), 0, "Dead patients are given the status code 0"),
			new Question("Cardboard splints cannot be used on:", (new string[] { "Arms", "Wrists", "The Neck", "Legs" }), 2, "Splints can only be applied to the limbs, wrists and ankles. For the neck we have special equipment"),
			new Question("A ROSC would be experienced after a:", (new string[] { "Broken Leg", "Cardiac Arrest", "Spinal injury", "Brief loss of consciousness" }), 1, "A ROSC is a 'Return Of Spontaneous Circulation' after a cardiac arrest")
		};

		private List<Question> vitalSigns = new List<Question>
		{
			new Question("What is a normal Heart Rate?", (new string[] { "80 bpm", "120 bpm", "100 bpm", "60 bpm" }), 0, "80 bpm is an average heart rate, however the context of a scenario can change what would be expected."),
			new Question("What's a normal palpated blood pressure?", (new string[] { "120/80", "120/P", "80/P", "130/70" }), 1, "As the blood pressure is palpated, there should be no bottom number, 120/p is normal."),
			new Question("What is a normal BGL?", (new string[] { "2 mmol/L", "15 mmol/L", "12 mmol/L", "5 mmol/L" }), 3, "Anything less than or equal to 3 is considered low and requires intervention and anything above 10 is higher than normal."),
			new Question("What is the lowest GCS score possible?", (new string[] { "0", "1", "2", "3" }), 3, "Each of the 3 areas of the GCS assessment is given a minimum score of 1, so less than 3 is not possible"),
			new Question("What is a normal resperatory rate?", (new string[] {"10 bpm", "12 bpm", "15 bpm", "21 bpm"}), 1, "The average resp rate is 12 breaths per minute"),
			new Question("Where do you take the heart rate of a conscious person?", (new string[] { "Wrist", "Neck", "Leg", "Chest" }), 0, "The wrist is the least intrusive place to take a pulse, so for conscious patients we take it there."),
			new Question("What would a GCS of 15 be in AVPU?", (new string[] { "Alert", "Voice", "Pain", "Unresponsive" }), 0, "15 is the highest GCS score, and higher scores mean the patient is more awake and alert"),
			new Question("How is response to pain checked?", (new string[] { "By pricking them with a pin", "By tapping their head", "By tapping on their arms", "By knocking on their clavical" }), 3, "The clavical is used because it causes little pain, and is less harmful"),
			new Question("Which of these is not one of the 3 categories in the GCS scale", (new string[] { "Eye opening", "Pain response", "Motor response", "Verbal response" }), 1, "Pain response is measured as part of eye opening and motor response but is not one of the 3 catagories"),
		};

		private List<Question> writtenTest = new List<Question> {
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

		private Random rand;

		/// <summary>
		/// Pick a random question from the chosen list.
		/// Removes the question from the list to prevent asking the same question multiple times.
		/// </summary>
		/// <param name="questionType">The question type of the question: 0 = First Aid  -  1 = Vital Signs  -  2 = Written Test</param>
		/// <param name="rand">The random object to generate index values from</param>
		/// <returns></returns>
		public Question randomQuestion(int questionType)
		{
			if (questionType == 0)
			{
				int randomIndex = rand.Next(0, firstAid.Count - 1);
				Question randomQuestion = firstAid[randomIndex];
				firstAid.RemoveAt(randomIndex);
				return randomQuestion;
			}
			else if (questionType == 1)
			{
				int randomIndex = rand.Next(0, vitalSigns.Count - 1);
				Question randomQuestion = vitalSigns[randomIndex];
				vitalSigns.RemoveAt(randomIndex);
				return randomQuestion;
			}
			else
			{
				int randomIndex = rand.Next(0, writtenTest.Count - 1);
				Question randomQuestion = writtenTest[randomIndex];
				writtenTest.RemoveAt(randomIndex);
				return randomQuestion;
			}
		}

		/// <summary>
		/// Constructs a default Questions object
		/// </summary>
		public Questions(Random randomNumberGenerator) { rand = randomNumberGenerator; }
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

			// Construct the user's 'unique' set of questions
			Questions player1Questions = new Questions(rnd);

			// === Component - Deciding question type ===
			// Pre-define an int for the type outside of the scope of the while loop
			int questionType;
			// Ask the user what question type they want
			Console.WriteLine("What question type do you want? \n1. First aid and Triage \n2. Vital Signs \n3. Written Test");
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

			// Create the userScore variable
			int userScore = 0;
			// The number of questions to ask
			int numberOfQuestions = 5;


			// Ask 5 questions of the same type
			// set i as 0; While i < numberOfQuestions; Add 1 to i
			for (int i = 0; i < numberOfQuestions; i++)
			{
				// Get a random question based on the selected question type
				Question randomQuestion = player1Questions.randomQuestion(questionType - 1);


				// === Component - Asking the user a question ===

				// Write the question text of the randomly selected question
				Console.WriteLine(randomQuestion.questionText);
				// Use a for loop to iterate through all possible answers
				// Changed from i because i is defined by the main question loop
				for (int j = 0; j < randomQuestion.possibleAnswers.Length; j++)
				{
					// Print the possible answer number and the possible answer
					// the j + 1 is used because normal people count from 1
					// and starting from 0 (as would happen due to it being the index position)
					// could confuse them
					Console.WriteLine($"{j + 1}) {randomQuestion.possibleAnswers[j]}");
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
				if (answerInt != (randomQuestion.correctIndex + 1))
				{
					// Tell the user the answer is incorrect, then give the correct answer and an explanation for why the answer is correct
					Console.WriteLine($"Sorry, thats not correct. The correct answer was: \n{randomQuestion.correctIndex + 1}) {randomQuestion.possibleAnswers[randomQuestion.correctIndex]}\n{randomQuestion.explanation}");
				}
				// Else it is correct
				else
				{
					// Congratulate the user
					Console.WriteLine("Thats correct!!");
					userScore++;
				}

				// Space out questions
				Console.WriteLine("\n\n");
			}

			// Tell the user how well they did using an if statement

			// If all questions were answered correctly
			if (userScore == numberOfQuestions)
			{
				Console.WriteLine($"Perfect!!! You got all {userScore} of the {numberOfQuestions} questions correct! But can you do it again?");
			}
			// If they got none correct
			else if (userScore == 0)
			{
				Console.WriteLine("You got non correct, but you can only go up from here");
			}
			// If they got more than 75%
			else if (userScore <= (numberOfQuestions * 0.75))
			{
				Console.WriteLine($"Amazing! You got {userScore}/{numberOfQuestions} correct. Can you get them all next time?");
			}
			// If they got more than 50%
			else if (userScore <= (numberOfQuestions * 0.5))
			{
				Console.WriteLine($"Pretty good, you got {userScore}/{numberOfQuestions}. Can you do better?");
			}
			// If they got more than 25%
			else if (userScore <= (numberOfQuestions * 0.25))
			{
				Console.WriteLine($"Not bad, but only {userScore}/{numberOfQuestions} correct, ");
			}
			// If they got less than 25%
			else
			{
				Console.WriteLine($"You got {userScore}/{numberOfQuestions}. Learn from your mistakes!");
			}


			// To prevent the program exiting instantly
			Console.ReadLine();
		}
	}
}
