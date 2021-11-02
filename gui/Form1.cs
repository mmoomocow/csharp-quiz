using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gui
{
	public partial class quizApp : Form
	{
		#region Variables

		// Define player 1's questions
		Questions player1Questions = new Questions(new Random());
		// pre-define the current question
		Question currentQuestion;

		// Choose question type toggle
		bool choosingQuestionType = false;


		#endregion Variables

		#region Functions

		/// <summary>
		/// First part of getting the user to pick a question type
		/// Sets the text for all the buttons and enables/disables the relevant buttons
		/// </summary>
		void pickQuestionType()
		{
			answerExplanation.Text = "";
			questionText.Text = "Please choose the question type you want to be asked";
			AnswerBtn1.Text = "Triage and First aid";
			AnswerBtn2.Text = "Vital Signs";
			AnswerBtn3.Text = "Written Test";
			AnswerBtn4.Text = "";
			AnswerBtn1.Enabled = true;
			AnswerBtn2.Enabled = true;
			AnswerBtn3.Enabled = true;
			AnswerBtn4.Enabled = false;
			NextQuestion.Enabled = false;
			choosingQuestionType = true;
		}
		/// <summary>
		/// Handle a user's choice of question type.
		/// Then disable all the buttons
		/// <param name="chosen">The option number that was picked by the user, non-index values<param>
		/// </summary>
		void HandlePickQuestionType(int chosen)
		{
			answerExplanation.Text = "";
			player1Questions.setQuestionType(chosen);
			questionText.Text = "Question type chosen, hit next question to continue";
			AnswerBtn1.Text = "";
			AnswerBtn2.Text = "";
			AnswerBtn3.Text = "";
			AnswerBtn4.Text = "";
			AnswerBtn1.Enabled = false;
			AnswerBtn2.Enabled = false;
			AnswerBtn3.Enabled = false;
			AnswerBtn4.Enabled = false;
			NextQuestion.Enabled = true;
			choosingQuestionType = false;
		}
		/// <summary>
		/// Handle the user's answer to a question
		/// <param name="indexOfButton">The index value of the answer button<param>
		/// </summary>
		void AnsweredQuestion(int indexOfButton)
		{
			// If the user answered correctly 
			if (currentQuestion.correctIndex == indexOfButton)
			{
				// Remove the question
				player1Questions.removeQuestion(currentQuestion);
				// and tell the user the answer was correct
				questionText.Text = "You got it correct!!";
			}
			// Else the question was wrong
			else
			{
				// Tell the user it was not correct
				// Don't remove the question as it gives the user an opertunuty to learn
				questionText.Text = "Sorry, that's not correct!";
			}

			// Explain the correct answer to the user
			answerExplanation.Text = currentQuestion.explanation;

			// Clear the button text
			AnswerBtn1.Text = "";
			AnswerBtn2.Text = "";
			AnswerBtn3.Text = "";
			AnswerBtn4.Text = "";

			// Disable the answer buttons
			AnswerBtn1.Enabled = false;
			AnswerBtn2.Enabled = false;
			AnswerBtn3.Enabled = false;
			AnswerBtn4.Enabled = false;

			// Enable the next question button
			NextQuestion.Enabled = true;
		}

		#endregion Functions

		#region Quiz startup

		// When the app starts
		public quizApp()
		{
			// init the app
			InitializeComponent();
			// get the user to pick a question type
			pickQuestionType();
		}

		#endregion Quiz startup

		#region Button Clicks

		// Answer button, index 0, position 1
		// This function is called when the user presses answer button 1
		private void AnswerBtn1_Click(object sender, EventArgs e)
		{
			// If the user is choosing the question type
			if (choosingQuestionType)
			{
				// Run the function to handle the question type answer, with the non-index position of the button as the input variable
				HandlePickQuestionType(1);
			}
			// Else the user is answering the question
			else
			{
				// Run the function to handle the question answer, with the index postition of the button as the input variable
				AnsweredQuestion(0);
			}
		}

		// Answer button, index 1, position 2
		// This function is called when the user presses answer button 1
		private void AnswerBtn2_Click(object sender, EventArgs e)
		{
			// If the user is choosing the question type
			if (choosingQuestionType)
			{
				// Run the function to handle the question type answer, with the non-index position of the button as the input variable
				HandlePickQuestionType(2);
			}
			// Else the user is answering the question
			else
			{
				// Run the function to handle the question answer, with the index postition of the button as the input variable

				AnsweredQuestion(1);
			}
		}

		// Answer button, index 2, position 3
		// This function is called when the user presses answer button 1
		private void AnswerBtn3_Click(object sender, EventArgs e)
		{
			// If the user is choosing the question type
			if (choosingQuestionType)
			{
				// Run the function to handle the question type answer, with the non-index position of the button as the input variable
				HandlePickQuestionType(3);
			}
			// Else the user is answering the question
			else
			{
				// Run the function to handle the question answer, with the index postition of the button as the input variable
				AnsweredQuestion(2);
			}
		}

		// Answer button, index 3, position 4
		// This function is called when the user presses answer button 1
		private void AnswerBtn4_Click(object sender, EventArgs e)
		{
			// Run the function to handle the question answer, with the index postition of the button as the input variable
			// as the button is disabed when selecting the question type, we don't need to use the 'choosingQuestionType' check
			AnsweredQuestion(3);
		}

		// The next question button.
		private void NextQuestion_Click(object sender, EventArgs e)
		{
			// Try and get a new question
			try
			{
				// Using the class function
				currentQuestion = player1Questions.randomQuestion();
			}
			// Catch the no more questions exception
			catch
			{
				// Get the user to pick a new question type
				pickQuestionType();
				// Don't continue
				return;
			}

			// Clear the explanation text
			answerExplanation.Text = "";
			// Ask the question
			questionText.Text = currentQuestion.questionText;
			// Populate the answer buttons
			AnswerBtn1.Text = currentQuestion.possibleAnswers[0];
			AnswerBtn2.Text = currentQuestion.possibleAnswers[1];
			AnswerBtn3.Text = currentQuestion.possibleAnswers[2];
			AnswerBtn4.Text = currentQuestion.possibleAnswers[3];
			// Enable all the answer buttons
			AnswerBtn1.Enabled = true;
			AnswerBtn2.Enabled = true;
			AnswerBtn3.Enabled = true;
			AnswerBtn4.Enabled = true;
			// Disable the next question button
			NextQuestion.Enabled = false;

		}
		#endregion Button Clicks
	}

	#region classes
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
		private readonly List<Question> firstAid = new List<Question>
		{
			new Question("Status 1 is considered to be:", (new string[] { "deceased", "Potentially immediately life threatening", "Not medically urgent", "Immediately life threatening" }), 3, "Status one is used to describe someone who's condition is immediately life threatening"),
			new Question("A patient with stroke symptoms and < 3 hour onset would be what status?", (new string[] { "Status 1", "Status 2", "Status 3", "Status 4" }), 1, "Stroke patients with a symptom onset of < 3.5 hours are considered status 2"),
			new Question("A patient was in a RTC but has no apparent injuries, what status are they?", (new string[] { "Status 1", "Status 2", "Status 3", "Status 4" }), 3, "If the patient has no injuries they are status 4, MOI should not be considered when determining status codes"),
			new Question("A patient walks over to you complaining of a toothache, what status are they?", (new string[] { "Status 1", "Status 2", "Status 3", "Status 4" }), 3, "Toothaches are not medically urgent"),
			new Question("What operation code is used for 'Urgent but not Immediately Life Threatening'", (new string[] { "Purple", "Orange", "Yellow", "Green" }), 1, "Operation code orange is defined as Urgent but not Immediately Life Threatening"),
			new Question("What status code is the following patient: 13-year-old female with an open fracture of the wrist", (new string[] { "Status 4", "Status 3", "Status 2", "Status 1" }), 1, "As there is a broken long bone and bleeding they are status 3. It is unlikely to be life threatening."),
			new Question("Status code 0 is:", (new string[] { "deceased", "Potentially immediately life threatening", "Not medically urgent", "Immediately life threatening" }), 0, "deceased patients are given the status code 0"),
			new Question("Cardboard splints cannot be used on:", (new string[] { "Arms", "Wrists", "The Neck", "Legs" }), 2, "Splints can only be applied to the limbs, wrists and ankles. For the neck we have special equipment"),
			new Question("A ROSC would be experienced after a:", (new string[] { "Broken Leg", "Cardiac Arrest", "Spinal injury", "Brief loss of consciousness" }), 1, "A ROSC is a 'Return Of Spontaneous Circulation' after a cardiac arrest")
		};

		private readonly List<Question> vitalSigns = new List<Question>
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

		private readonly List<Question> writtenTest = new List<Question> {
			new Question("How many Districts are there in the south island?", (new string[] { "7", "9", "10", "11" }), 1, "There are 9 districts, Mid Canterbury, North Canterbury, Christchurch, Costal Otago, Central Otago, Southland, Aoraki, West Coast and Nelson Marlborough."),
			new Question("How many regions are there in New Zealand", (new string[] { "1", "2", "3", "4" }), 2, "There are 3 regions, Northern, Central and South Island"),
			new Question("How many areas are there in the Costal Otago district?", (new string[] { "5", "8", "6", "4" }), 0, "There are 5 areas, South, Costal otago, Ara te uru, Taieri, and Otepoti"),
			new Question("How many badges are there in the Grand Prior curriculum", (new string[] { "15", "23", "27", "31" }), 2, "There are 27 badges you can achieve under the grand prior system. This is because green, blue and gold levels are counted as one badge."),
			new Question("How many hours of comunity service are required to get a green shield?", (new string[] { "100 hours", "200 hours", "500 hours", "800 hours" }), 2, "100 hours is a grey shield, 200 hours is a red shield, 500 hours is a green shield, 800 hours is a blue shield and 1000 hours is a gold shield"),
			new Question("Which of these is not a St John program", (new string[] { "Operations", "Therapy Pets", "1737", "FEDs" }), 2, "St John's community programs include Operations, Therapy Pets, FEDs, Medical Alarms, St John in schools and more. 1737 is independent, but a good resource to use"),
			new Question("Which of these is not one of St John's cardinal values on the Amalfi Cross?", (new string[] { "Compassion", "Prudence", "Temperance", "Fortitude" }), 0, "The 4 cardinal values on the Amalfi Cross are Prudence, Justice, Temperance and Fortitude"),
			new Question("In what decade was the Order of the Hospital of St John of Jerusalem start?", (new string[] { "1110", "1060", "1150", "1070" }), 3, "The exact date of when the order formed is unknown, however it is believed to be in 1070."),
			new Question("When did the order become a royal order?", (new string[] { "1888", "1873", "1891", "1915" }), 0, "It was in 1888 when Queen Victoria granted the order of St John royal charter and the royal beasts were added to the Amalfi cross"),
		};

		private readonly Random rand;

		private int questionType;

		/// <summary>
		/// Pick a random question from the chosen list.
		/// Removes the question from the list to prevent asking the same question multiple times.
		/// </summary>
		/// <returns>A randomly selected question object</returns>
		public Question randomQuestion()
		{
			if (questionType == 0)
			{
				if (firstAid.Count == 0) { throw new Exception("no more questions"); }
				int randomIndex = rand.Next(0, firstAid.Count - 1);
				Question randomQuestion = firstAid[randomIndex];
				return randomQuestion;
			}
			else if (questionType == 1)
			{
				if (vitalSigns.Count == 0) { throw new Exception("no more questions"); }
				int randomIndex = rand.Next(0, vitalSigns.Count - 1);
				Question randomQuestion = vitalSigns[randomIndex];
				return randomQuestion;
			}
			else
			{
				if (writtenTest.Count == 0) { throw new Exception("no more questions"); }
				int randomIndex = rand.Next(0, writtenTest.Count - 1);
				Question randomQuestion = writtenTest[randomIndex];
				return randomQuestion;
			}
		}

		/// <summary>
		/// Remove a question from the currently selected question list
		/// </summary>
		/// <param name="question">The question to remove</param>
		public void removeQuestion(Question question)
		{
			if (questionType == 0) { firstAid.Remove(question); }
			else if (questionType == 1) { vitalSigns.Remove(question); }
			else { writtenTest.Remove(question); }
		}

		/// <summary>
		/// Get the user to choose the type of question they want
		/// </summary>
		public void setQuestionType(int chosen)
		{
			questionType = chosen - 1;
		}

		/// <summary>
		/// Constructs a default Questions object
		/// </summary>
		public Questions(Random randomNumberGenerator) { rand = randomNumberGenerator; }
	}

	#endregion classes
}
