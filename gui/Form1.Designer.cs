﻿
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
            this.answerBtn4 = new System.Windows.Forms.Button();
            this.answerBtn3 = new System.Windows.Forms.Button();
            this.answerBtn2 = new System.Windows.Forms.Button();
            this.answerBtn1 = new System.Windows.Forms.Button();
            this.questionText = new System.Windows.Forms.Label();
            this.answerExplanation = new System.Windows.Forms.Label();
            this.playerTurn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // answerBtn4
            // 
            this.answerBtn4.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.answerBtn4.Location = new System.Drawing.Point(422, 330);
            this.answerBtn4.Name = "answerBtn4";
            this.answerBtn4.Size = new System.Drawing.Size(350, 100);
            this.answerBtn4.TabIndex = 7;
            this.answerBtn4.Text = "Answer button 4";
            this.answerBtn4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.answerBtn4.UseVisualStyleBackColor = true;
            // 
            // answerBtn3
            // 
            this.answerBtn3.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.answerBtn3.Location = new System.Drawing.Point(422, 224);
            this.answerBtn3.Name = "answerBtn3";
            this.answerBtn3.Size = new System.Drawing.Size(350, 100);
            this.answerBtn3.TabIndex = 6;
            this.answerBtn3.Text = "Answer button 3";
            this.answerBtn3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.answerBtn3.UseVisualStyleBackColor = true;
            // 
            // answerBtn2
            // 
            this.answerBtn2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.answerBtn2.Location = new System.Drawing.Point(422, 118);
            this.answerBtn2.Name = "answerBtn2";
            this.answerBtn2.Size = new System.Drawing.Size(350, 100);
            this.answerBtn2.TabIndex = 5;
            this.answerBtn2.Text = "Answer button 2";
            this.answerBtn2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.answerBtn2.UseVisualStyleBackColor = true;
            // 
            // answerBtn1
            // 
            this.answerBtn1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.answerBtn1.Location = new System.Drawing.Point(422, 12);
            this.answerBtn1.Name = "answerBtn1";
            this.answerBtn1.Size = new System.Drawing.Size(350, 100);
            this.answerBtn1.TabIndex = 4;
            this.answerBtn1.Text = "Answer button 1";
            this.answerBtn1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.answerBtn1.UseVisualStyleBackColor = true;
            // 
            // questionText
            // 
            this.questionText.AutoSize = true;
            this.questionText.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.questionText.Location = new System.Drawing.Point(12, 51);
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
            this.answerExplanation.Location = new System.Drawing.Point(12, 199);
            this.answerExplanation.MaximumSize = new System.Drawing.Size(400, 75);
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
            this.playerTurn.Size = new System.Drawing.Size(155, 25);
            this.playerTurn.TabIndex = 10;
            this.playerTurn.Text = "It is player x\'s turn";
            // 
            // quizApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 441);
            this.Controls.Add(this.playerTurn);
            this.Controls.Add(this.answerExplanation);
            this.Controls.Add(this.questionText);
            this.Controls.Add(this.answerBtn4);
            this.Controls.Add(this.answerBtn3);
            this.Controls.Add(this.answerBtn2);
            this.Controls.Add(this.answerBtn1);
            this.Name = "quizApp";
            this.Text = "Quiz App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button answerBtn4;
        private System.Windows.Forms.Button answerBtn3;
        private System.Windows.Forms.Button answerBtn2;
        private System.Windows.Forms.Button answerBtn1;
        private System.Windows.Forms.Label questionText;
        private System.Windows.Forms.Label answerExplanation;
        private System.Windows.Forms.Label playerTurn;
    }
}

