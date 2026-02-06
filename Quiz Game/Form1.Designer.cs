namespace Quiz_Game
{
    partial class Form1
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
            AnswerBtn = new Button();
            NewQuestionBtn = new Button();
            AnswerBox = new TextBox();
            label1 = new Label();
            QuestionTxt = new Label();
            scoreNum = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // AnswerBtn
            // 
            AnswerBtn.Location = new Point(517, 229);
            AnswerBtn.Name = "AnswerBtn";
            AnswerBtn.Size = new Size(263, 73);
            AnswerBtn.TabIndex = 0;
            AnswerBtn.Text = "Answer";
            AnswerBtn.UseVisualStyleBackColor = true;
            AnswerBtn.Click += AnswerBtn_Click;
            // 
            // NewQuestionBtn
            // 
            NewQuestionBtn.Location = new Point(76, 229);
            NewQuestionBtn.Name = "NewQuestionBtn";
            NewQuestionBtn.Size = new Size(263, 73);
            NewQuestionBtn.TabIndex = 1;
            NewQuestionBtn.Text = "New question";
            NewQuestionBtn.UseVisualStyleBackColor = true;
            NewQuestionBtn.Click += NewQuestionBtn_Click;
            // 
            // AnswerBox
            // 
            AnswerBox.Location = new Point(284, 173);
            AnswerBox.Name = "AnswerBox";
            AnswerBox.Size = new Size(284, 50);
            AnswerBox.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 19);
            label1.Name = "label1";
            label1.Size = new Size(115, 45);
            label1.TabIndex = 4;
            label1.Text = "Score :";
            // 
            // QuestionTxt
            // 
            QuestionTxt.AutoSize = true;
            QuestionTxt.Location = new Point(243, 80);
            QuestionTxt.Name = "QuestionTxt";
            QuestionTxt.Size = new Size(96, 45);
            QuestionTxt.TabIndex = 5;
            QuestionTxt.Text = "Blank";
            // 
            // scoreNum
            // 
            scoreNum.AutoSize = true;
            scoreNum.Location = new Point(141, 19);
            scoreNum.Name = "scoreNum";
            scoreNum.Size = new Size(37, 45);
            scoreNum.TabIndex = 6;
            scoreNum.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(182, 19);
            label4.Name = "label4";
            label4.Size = new Size(75, 45);
            label4.TabIndex = 7;
            label4.Text = "/ 10";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(18F, 45F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(907, 366);
            Controls.Add(label4);
            Controls.Add(scoreNum);
            Controls.Add(QuestionTxt);
            Controls.Add(label1);
            Controls.Add(AnswerBox);
            Controls.Add(NewQuestionBtn);
            Controls.Add(AnswerBtn);
            Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AnswerBtn;
        private Button NewQuestionBtn;
        private TextBox AnswerBox;
        private Label label1;
        private Label QuestionTxt;
        private Label scoreNum;
        private Label label4;
    }
}
