
namespace gui
{
	partial class quizApp
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.AnswerBtn4 = new System.Windows.Forms.Button();
            this.AnswerBtn3 = new System.Windows.Forms.Button();
            this.AnswerBtn2 = new System.Windows.Forms.Button();
            this.AnswerBtn1 = new System.Windows.Forms.Button();
            this.questionText = new System.Windows.Forms.Label();
            this.answerExplanation = new System.Windows.Forms.Label();
            this.playerTurn = new System.Windows.Forms.Label();
            this.NextQuestion = new System.Windows.Forms.Button();
            this.score = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AnswerBtn4
            // 
            this.AnswerBtn4.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AnswerBtn4.Location = new System.Drawing.Point(422, 330);
            this.AnswerBtn4.Name = "AnswerBtn4";
            this.AnswerBtn4.Size = new System.Drawing.Size(350, 100);
            this.AnswerBtn4.TabIndex = 7;
            this.AnswerBtn4.Text = "Answer button 4";
            this.AnswerBtn4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AnswerBtn4.UseVisualStyleBackColor = true;
            this.AnswerBtn4.Click += new System.EventHandler(this.AnswerBtn4_Click);
            // 
            // AnswerBtn3
            // 
            this.AnswerBtn3.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AnswerBtn3.Location = new System.Drawing.Point(422, 224);
            this.AnswerBtn3.Name = "AnswerBtn3";
            this.AnswerBtn3.Size = new System.Drawing.Size(350, 100);
            this.AnswerBtn3.TabIndex = 6;
            this.AnswerBtn3.Text = "Answer button 3";
            this.AnswerBtn3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AnswerBtn3.UseVisualStyleBackColor = true;
            this.AnswerBtn3.Click += new System.EventHandler(this.AnswerBtn3_Click);
            // 
            // AnswerBtn2
            // 
            this.AnswerBtn2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AnswerBtn2.Location = new System.Drawing.Point(422, 118);
            this.AnswerBtn2.Name = "AnswerBtn2";
            this.AnswerBtn2.Size = new System.Drawing.Size(350, 100);
            this.AnswerBtn2.TabIndex = 5;
            this.AnswerBtn2.Text = "Answer button 2";
            this.AnswerBtn2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AnswerBtn2.UseVisualStyleBackColor = true;
            this.AnswerBtn2.Click += new System.EventHandler(this.AnswerBtn2_Click);
            // 
            // AnswerBtn1
            // 
            this.AnswerBtn1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AnswerBtn1.Location = new System.Drawing.Point(422, 12);
            this.AnswerBtn1.Name = "AnswerBtn1";
            this.AnswerBtn1.Size = new System.Drawing.Size(350, 100);
            this.AnswerBtn1.TabIndex = 4;
            this.AnswerBtn1.Text = "Answer button 1";
            this.AnswerBtn1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AnswerBtn1.UseVisualStyleBackColor = true;
            this.AnswerBtn1.Click += new System.EventHandler(this.AnswerBtn1_Click);
            // 
            // questionText
            // 
            this.questionText.AutoSize = true;
            this.questionText.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.questionText.Location = new System.Drawing.Point(13, 51);
            this.questionText.MaximumSize = new System.Drawing.Size(400, 75);
            this.questionText.Name = "questionText";
            this.questionText.Size = new System.Drawing.Size(119, 25);
            this.questionText.TabIndex = 8;
            this.questionText.Text = "Question Text";
            // 
            // answerExplanation
            // 
            this.answerExplanation.AutoSize = true;
            this.answerExplanation.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.answerExplanation.Location = new System.Drawing.Point(13, 224);
            this.answerExplanation.MaximumSize = new System.Drawing.Size(400, 200);
            this.answerExplanation.Name = "answerExplanation";
            this.answerExplanation.Size = new System.Drawing.Size(166, 25);
            this.answerExplanation.TabIndex = 9;
            this.answerExplanation.Text = "Answer explanation";
            // 
            // playerTurn
            // 
            this.playerTurn.AutoSize = true;
            this.playerTurn.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.playerTurn.Location = new System.Drawing.Point(13, 13);
            this.playerTurn.Name = "playerTurn";
            this.playerTurn.Size = new System.Drawing.Size(157, 25);
            this.playerTurn.TabIndex = 10;
            this.playerTurn.Text = "It is player 1\'s turn";
            // 
            // NextQuestion
            // 
            this.NextQuestion.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NextQuestion.Location = new System.Drawing.Point(74, 345);
            this.NextQuestion.Name = "NextQuestion";
            this.NextQuestion.Size = new System.Drawing.Size(232, 44);
            this.NextQuestion.TabIndex = 11;
            this.NextQuestion.Text = "Next Question";
            this.NextQuestion.UseVisualStyleBackColor = true;
            this.NextQuestion.Click += new System.EventHandler(this.NextQuestion_Click);
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.score.Location = new System.Drawing.Point(13, 96);
            this.score.MaximumSize = new System.Drawing.Size(400, 300);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(86, 19);
            this.score.TabIndex = 12;
            this.score.Text = "Your score is";
            // 
            // quizApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 441);
            this.Controls.Add(this.score);
            this.Controls.Add(this.NextQuestion);
            this.Controls.Add(this.playerTurn);
            this.Controls.Add(this.answerExplanation);
            this.Controls.Add(this.questionText);
            this.Controls.Add(this.AnswerBtn4);
            this.Controls.Add(this.AnswerBtn3);
            this.Controls.Add(this.AnswerBtn2);
            this.Controls.Add(this.AnswerBtn1);
            this.Name = "quizApp";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		public System.Windows.Forms.Button AnswerBtn4;
		public System.Windows.Forms.Button AnswerBtn3;
		public System.Windows.Forms.Button AnswerBtn2;
		public System.Windows.Forms.Button AnswerBtn1;
		public System.Windows.Forms.Label questionText;
		public System.Windows.Forms.Label answerExplanation;
		public System.Windows.Forms.Label playerTurn;
		public System.Windows.Forms.Button NextQuestion;
		public System.Windows.Forms.Label score;
	}
}

