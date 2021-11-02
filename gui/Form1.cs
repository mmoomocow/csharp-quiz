using System;
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
}
