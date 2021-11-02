namespace gui
{
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

	#endregion classes
}
