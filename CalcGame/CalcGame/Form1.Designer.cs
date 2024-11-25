
namespace CalcGame
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Num1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.PlayButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Reset = new System.Windows.Forms.Button();
            this.MultiplicationButton = new System.Windows.Forms.RadioButton();
            this.DivisionButton = new System.Windows.Forms.RadioButton();
            this.SquareRootButton = new System.Windows.Forms.RadioButton();
            this.MinusButton = new System.Windows.Forms.RadioButton();
            this.PlusButton = new System.Windows.Forms.RadioButton();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.labelTimer = new System.Windows.Forms.Label();
            this.labelAvgTime = new System.Windows.Forms.Label();
            this.labelTotalRightAnswers = new System.Windows.Forms.Label();
            this.RealRightAnswerLabel = new System.Windows.Forms.Label();
            this.AnswerButton = new System.Windows.Forms.Button();
            this.AnswerTextBox = new System.Windows.Forms.TextBox();
            this.PlayerAnswerLabel = new System.Windows.Forms.Label();
            this.TensRadioButton = new System.Windows.Forms.RadioButton();
            this.ThousandsRadioButton = new System.Windows.Forms.RadioButton();
            this.HundredThousandsRadioButton = new System.Windows.Forms.RadioButton();
            this.HundredsRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.AmountOfQuestionsAnsweredLabel = new System.Windows.Forms.Label();
            this.AmountOfQuestionsLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Num1
            // 
            this.Num1.AutoSize = true;
            this.Num1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num1.Location = new System.Drawing.Point(56, 38);
            this.Num1.Name = "Num1";
            this.Num1.Size = new System.Drawing.Size(126, 46);
            this.Num1.TabIndex = 0;
            this.Num1.Text = "Num1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(64, 87);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(202, 60);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 46);
            this.label2.TabIndex = 2;
            this.label2.Text = "Num2";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(68, 232);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(198, 65);
            this.textBox2.TabIndex = 3;
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLabel.Location = new System.Drawing.Point(548, 47);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(97, 37);
            this.TimeLabel.TabIndex = 9;
            this.TimeLabel.Text = "Time:";
            // 
            // PlayButton
            // 
            this.PlayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayButton.Location = new System.Drawing.Point(679, 668);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(139, 49);
            this.PlayButton.TabIndex = 10;
            this.PlayButton.Text = "Play";
            this.PlayButton.UseVisualStyleBackColor = true;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(548, 310);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 37);
            this.label3.TabIndex = 11;
            this.label3.Text = "Right answer:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(548, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(298, 37);
            this.label4.TabIndex = 12;
            this.label4.Text = "Total right answers:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(548, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 37);
            this.label1.TabIndex = 13;
            this.label1.Text = "Avg.Time:";
            // 
            // Reset
            // 
            this.Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reset.Location = new System.Drawing.Point(890, 668);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(146, 49);
            this.Reset.TabIndex = 15;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // MultiplicationButton
            // 
            this.MultiplicationButton.AutoSize = true;
            this.MultiplicationButton.Location = new System.Drawing.Point(30, 41);
            this.MultiplicationButton.Name = "MultiplicationButton";
            this.MultiplicationButton.Size = new System.Drawing.Size(125, 24);
            this.MultiplicationButton.TabIndex = 20;
            this.MultiplicationButton.TabStop = true;
            this.MultiplicationButton.Text = "Multiplication";
            this.MultiplicationButton.UseVisualStyleBackColor = true;
            this.MultiplicationButton.CheckedChanged += new System.EventHandler(this.MultiplicationButton_CheckedChanged);
            // 
            // DivisionButton
            // 
            this.DivisionButton.AutoSize = true;
            this.DivisionButton.Location = new System.Drawing.Point(193, 41);
            this.DivisionButton.Name = "DivisionButton";
            this.DivisionButton.Size = new System.Drawing.Size(88, 24);
            this.DivisionButton.TabIndex = 21;
            this.DivisionButton.TabStop = true;
            this.DivisionButton.Text = "Division";
            this.DivisionButton.UseVisualStyleBackColor = true;
            this.DivisionButton.CheckedChanged += new System.EventHandler(this.DivisionButton_CheckedChanged);
            // 
            // SquareRootButton
            // 
            this.SquareRootButton.AutoSize = true;
            this.SquareRootButton.Location = new System.Drawing.Point(323, 126);
            this.SquareRootButton.Name = "SquareRootButton";
            this.SquareRootButton.Size = new System.Drawing.Size(118, 24);
            this.SquareRootButton.TabIndex = 22;
            this.SquareRootButton.TabStop = true;
            this.SquareRootButton.Text = "Square root";
            this.SquareRootButton.UseVisualStyleBackColor = true;
            this.SquareRootButton.CheckedChanged += new System.EventHandler(this.SquareRootButton_CheckedChanged);
            // 
            // MinusButton
            // 
            this.MinusButton.AutoSize = true;
            this.MinusButton.Location = new System.Drawing.Point(30, 126);
            this.MinusButton.Name = "MinusButton";
            this.MinusButton.Size = new System.Drawing.Size(76, 24);
            this.MinusButton.TabIndex = 23;
            this.MinusButton.TabStop = true;
            this.MinusButton.Text = "Minus";
            this.MinusButton.UseVisualStyleBackColor = true;
            this.MinusButton.CheckedChanged += new System.EventHandler(this.MinusButton_CheckedChanged);
            // 
            // PlusButton
            // 
            this.PlusButton.AutoSize = true;
            this.PlusButton.Location = new System.Drawing.Point(193, 126);
            this.PlusButton.Name = "PlusButton";
            this.PlusButton.Size = new System.Drawing.Size(64, 24);
            this.PlusButton.TabIndex = 24;
            this.PlusButton.TabStop = true;
            this.PlusButton.Text = "Plus";
            this.PlusButton.UseVisualStyleBackColor = true;
            this.PlusButton.CheckedChanged += new System.EventHandler(this.PlusButton_CheckedChanged);
            // 
            // labelTimer
            // 
            this.labelTimer.AutoSize = true;
            this.labelTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimer.Location = new System.Drawing.Point(651, 47);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(77, 37);
            this.labelTimer.TabIndex = 25;
            this.labelTimer.Text = "time";
            // 
            // labelAvgTime
            // 
            this.labelAvgTime.AutoSize = true;
            this.labelAvgTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAvgTime.Location = new System.Drawing.Point(715, 110);
            this.labelAvgTime.Name = "labelAvgTime";
            this.labelAvgTime.Size = new System.Drawing.Size(141, 37);
            this.labelAvgTime.TabIndex = 26;
            this.labelAvgTime.Text = "Avg.time";
            // 
            // labelTotalRightAnswers
            // 
            this.labelTotalRightAnswers.AutoSize = true;
            this.labelTotalRightAnswers.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalRightAnswers.Location = new System.Drawing.Point(852, 244);
            this.labelTotalRightAnswers.Name = "labelTotalRightAnswers";
            this.labelTotalRightAnswers.Size = new System.Drawing.Size(286, 37);
            this.labelTotalRightAnswers.TabIndex = 27;
            this.labelTotalRightAnswers.Text = "TotalRightAnswers";
            // 
            // RealRightAnswerLabel
            // 
            this.RealRightAnswerLabel.AutoSize = true;
            this.RealRightAnswerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RealRightAnswerLabel.Location = new System.Drawing.Point(777, 310);
            this.RealRightAnswerLabel.Name = "RealRightAnswerLabel";
            this.RealRightAnswerLabel.Size = new System.Drawing.Size(188, 37);
            this.RealRightAnswerLabel.TabIndex = 28;
            this.RealRightAnswerLabel.Text = "RealAnswer";
            // 
            // AnswerButton
            // 
            this.AnswerButton.Location = new System.Drawing.Point(66, 488);
            this.AnswerButton.Name = "AnswerButton";
            this.AnswerButton.Size = new System.Drawing.Size(96, 36);
            this.AnswerButton.TabIndex = 29;
            this.AnswerButton.Text = "Submit";
            this.AnswerButton.UseVisualStyleBackColor = true;
            this.AnswerButton.Click += new System.EventHandler(this.AnswerButton_Click);
            // 
            // AnswerTextBox
            // 
            this.AnswerTextBox.Location = new System.Drawing.Point(68, 393);
            this.AnswerTextBox.Multiline = true;
            this.AnswerTextBox.Name = "AnswerTextBox";
            this.AnswerTextBox.Size = new System.Drawing.Size(198, 65);
            this.AnswerTextBox.TabIndex = 30;
            // 
            // PlayerAnswerLabel
            // 
            this.PlayerAnswerLabel.AutoSize = true;
            this.PlayerAnswerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerAnswerLabel.Location = new System.Drawing.Point(62, 342);
            this.PlayerAnswerLabel.Name = "PlayerAnswerLabel";
            this.PlayerAnswerLabel.Size = new System.Drawing.Size(191, 36);
            this.PlayerAnswerLabel.TabIndex = 32;
            this.PlayerAnswerLabel.Text = "Your answer:";
            // 
            // TensRadioButton
            // 
            this.TensRadioButton.AutoSize = true;
            this.TensRadioButton.Location = new System.Drawing.Point(48, 66);
            this.TensRadioButton.Name = "TensRadioButton";
            this.TensRadioButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TensRadioButton.Size = new System.Drawing.Size(63, 24);
            this.TensRadioButton.TabIndex = 34;
            this.TensRadioButton.TabStop = true;
            this.TensRadioButton.Text = "10\'s";
            this.TensRadioButton.UseVisualStyleBackColor = true;
            this.TensRadioButton.CheckedChanged += new System.EventHandler(this.TensRadioButton_CheckedChanged);
            // 
            // ThousandsRadioButton
            // 
            this.ThousandsRadioButton.AutoSize = true;
            this.ThousandsRadioButton.Location = new System.Drawing.Point(48, 227);
            this.ThousandsRadioButton.Name = "ThousandsRadioButton";
            this.ThousandsRadioButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ThousandsRadioButton.Size = new System.Drawing.Size(81, 24);
            this.ThousandsRadioButton.TabIndex = 35;
            this.ThousandsRadioButton.TabStop = true;
            this.ThousandsRadioButton.Text = "1000\'s";
            this.ThousandsRadioButton.UseVisualStyleBackColor = true;
            this.ThousandsRadioButton.CheckedChanged += new System.EventHandler(this.ThousandsRadioButton_CheckedChanged);
            // 
            // HundredThousandsRadioButton
            // 
            this.HundredThousandsRadioButton.AutoSize = true;
            this.HundredThousandsRadioButton.Location = new System.Drawing.Point(48, 317);
            this.HundredThousandsRadioButton.Name = "HundredThousandsRadioButton";
            this.HundredThousandsRadioButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.HundredThousandsRadioButton.Size = new System.Drawing.Size(103, 24);
            this.HundredThousandsRadioButton.TabIndex = 36;
            this.HundredThousandsRadioButton.TabStop = true;
            this.HundredThousandsRadioButton.Text = "100 000\'s";
            this.HundredThousandsRadioButton.UseVisualStyleBackColor = true;
            this.HundredThousandsRadioButton.CheckedChanged += new System.EventHandler(this.HundredThousandsRadioButton_CheckedChanged);
            // 
            // HundredsRadioButton
            // 
            this.HundredsRadioButton.AutoSize = true;
            this.HundredsRadioButton.Location = new System.Drawing.Point(48, 142);
            this.HundredsRadioButton.Name = "HundredsRadioButton";
            this.HundredsRadioButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.HundredsRadioButton.Size = new System.Drawing.Size(72, 24);
            this.HundredsRadioButton.TabIndex = 37;
            this.HundredsRadioButton.TabStop = true;
            this.HundredsRadioButton.Text = "100\'s";
            this.HundredsRadioButton.UseVisualStyleBackColor = true;
            this.HundredsRadioButton.CheckedChanged += new System.EventHandler(this.HundredsRadioButton_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.HundredsRadioButton);
            this.groupBox1.Controls.Add(this.TensRadioButton);
            this.groupBox1.Controls.Add(this.HundredThousandsRadioButton);
            this.groupBox1.Controls.Add(this.ThousandsRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(1214, 287);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 466);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Difficulty";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DivisionButton);
            this.groupBox2.Controls.Add(this.MultiplicationButton);
            this.groupBox2.Controls.Add(this.SquareRootButton);
            this.groupBox2.Controls.Add(this.MinusButton);
            this.groupBox2.Controls.Add(this.PlusButton);
            this.groupBox2.Location = new System.Drawing.Point(64, 565);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(496, 169);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Operation";
            // 
            // AmountOfQuestionsAnsweredLabel
            // 
            this.AmountOfQuestionsAnsweredLabel.AutoSize = true;
            this.AmountOfQuestionsAnsweredLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountOfQuestionsAnsweredLabel.Location = new System.Drawing.Point(883, 174);
            this.AmountOfQuestionsAnsweredLabel.Name = "AmountOfQuestionsAnsweredLabel";
            this.AmountOfQuestionsAnsweredLabel.Size = new System.Drawing.Size(41, 37);
            this.AmountOfQuestionsAnsweredLabel.TabIndex = 41;
            this.AmountOfQuestionsAnsweredLabel.Text = "N";
            // 
            // AmountOfQuestionsLabel
            // 
            this.AmountOfQuestionsLabel.AutoSize = true;
            this.AmountOfQuestionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountOfQuestionsLabel.Location = new System.Drawing.Point(548, 175);
            this.AmountOfQuestionsLabel.Name = "AmountOfQuestionsLabel";
            this.AmountOfQuestionsLabel.Size = new System.Drawing.Size(320, 37);
            this.AmountOfQuestionsLabel.TabIndex = 40;
            this.AmountOfQuestionsLabel.Text = "Amount of questions:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1557, 765);
            this.Controls.Add(this.AmountOfQuestionsAnsweredLabel);
            this.Controls.Add(this.AmountOfQuestionsLabel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PlayerAnswerLabel);
            this.Controls.Add(this.AnswerTextBox);
            this.Controls.Add(this.AnswerButton);
            this.Controls.Add(this.RealRightAnswerLabel);
            this.Controls.Add(this.labelTotalRightAnswers);
            this.Controls.Add(this.labelAvgTime);
            this.Controls.Add(this.labelTimer);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PlayButton);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Num1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "CalcGame";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Num1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.RadioButton MultiplicationButton;
        private System.Windows.Forms.RadioButton DivisionButton;
        private System.Windows.Forms.RadioButton SquareRootButton;
        private System.Windows.Forms.RadioButton MinusButton;
        private System.Windows.Forms.RadioButton PlusButton;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label labelTimer;
        private System.Windows.Forms.Label labelAvgTime;
        private System.Windows.Forms.Label labelTotalRightAnswers;
        private System.Windows.Forms.Label RealRightAnswerLabel;
        private System.Windows.Forms.Button AnswerButton;
        private System.Windows.Forms.TextBox AnswerTextBox;
        private System.Windows.Forms.Label PlayerAnswerLabel;
        private System.Windows.Forms.RadioButton TensRadioButton;
        private System.Windows.Forms.RadioButton ThousandsRadioButton;
        private System.Windows.Forms.RadioButton HundredThousandsRadioButton;
        private System.Windows.Forms.RadioButton HundredsRadioButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label AmountOfQuestionsAnsweredLabel;
        private System.Windows.Forms.Label AmountOfQuestionsLabel;
    }
}

