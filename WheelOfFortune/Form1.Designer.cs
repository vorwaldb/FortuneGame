namespace WheelOfFortune
{
    partial class WheelOfFortuneForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.playerMoneyLabel = new System.Windows.Forms.Label();
            this.puzzleText = new System.Windows.Forms.Label();
            this.wheelTextBox = new System.Windows.Forms.TextBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.answerEntryTextBox = new System.Windows.Forms.TextBox();
            this.enterButton = new System.Windows.Forms.Button();
            this.spinRadio = new System.Windows.Forms.RadioButton();
            this.buyVowelRadio = new System.Windows.Forms.RadioButton();
            this.solvePuzzleRadio = new System.Windows.Forms.RadioButton();
            this.lettersLabel = new System.Windows.Forms.Label();
            this.categoryLabel = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "My Money";
            // 
            // playerMoneyLabel
            // 
            this.playerMoneyLabel.AutoSize = true;
            this.playerMoneyLabel.BackColor = System.Drawing.Color.Red;
            this.playerMoneyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerMoneyLabel.ForeColor = System.Drawing.Color.White;
            this.playerMoneyLabel.Location = new System.Drawing.Point(13, 39);
            this.playerMoneyLabel.Name = "playerMoneyLabel";
            this.playerMoneyLabel.Size = new System.Drawing.Size(90, 24);
            this.playerMoneyLabel.TabIndex = 1;
            this.playerMoneyLabel.Text = "$0000000";
            // 
            // puzzleText
            // 
            this.puzzleText.AutoSize = true;
            this.puzzleText.BackColor = System.Drawing.Color.YellowGreen;
            this.puzzleText.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.puzzleText.ForeColor = System.Drawing.Color.Black;
            this.puzzleText.Location = new System.Drawing.Point(79, 216);
            this.puzzleText.Name = "puzzleText";
            this.puzzleText.Size = new System.Drawing.Size(267, 29);
            this.puzzleText.TabIndex = 2;
            this.puzzleText.Text = "Sample text for a puzzle";
            // 
            // wheelTextBox
            // 
            this.wheelTextBox.Enabled = false;
            this.wheelTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wheelTextBox.ForeColor = System.Drawing.Color.Black;
            this.wheelTextBox.Location = new System.Drawing.Point(3, 328);
            this.wheelTextBox.Name = "wheelTextBox";
            this.wheelTextBox.Size = new System.Drawing.Size(632, 29);
            this.wheelTextBox.TabIndex = 3;
            this.wheelTextBox.Text = "$0";
            this.wheelTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(552, 409);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // answerEntryTextBox
            // 
            this.answerEntryTextBox.Location = new System.Drawing.Point(3, 409);
            this.answerEntryTextBox.Name = "answerEntryTextBox";
            this.answerEntryTextBox.ReadOnly = true;
            this.answerEntryTextBox.Size = new System.Drawing.Size(238, 20);
            this.answerEntryTextBox.TabIndex = 10;
            this.answerEntryTextBox.TextChanged += new System.EventHandler(this.OnTextChange);
            // 
            // enterButton
            // 
            this.enterButton.Location = new System.Drawing.Point(248, 406);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(75, 23);
            this.enterButton.TabIndex = 11;
            this.enterButton.Text = "Enter";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // spinRadio
            // 
            this.spinRadio.AutoSize = true;
            this.spinRadio.BackColor = System.Drawing.Color.Transparent;
            this.spinRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spinRadio.ForeColor = System.Drawing.Color.Yellow;
            this.spinRadio.Location = new System.Drawing.Point(12, 380);
            this.spinRadio.Name = "spinRadio";
            this.spinRadio.Size = new System.Drawing.Size(63, 24);
            this.spinRadio.TabIndex = 12;
            this.spinRadio.TabStop = true;
            this.spinRadio.Text = "Spin";
            this.spinRadio.UseVisualStyleBackColor = false;
            this.spinRadio.CheckedChanged += new System.EventHandler(this.OnCheckedChange);
            // 
            // buyVowelRadio
            // 
            this.buyVowelRadio.AutoSize = true;
            this.buyVowelRadio.BackColor = System.Drawing.Color.Transparent;
            this.buyVowelRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyVowelRadio.ForeColor = System.Drawing.Color.Yellow;
            this.buyVowelRadio.Location = new System.Drawing.Point(81, 380);
            this.buyVowelRadio.Name = "buyVowelRadio";
            this.buyVowelRadio.Size = new System.Drawing.Size(110, 24);
            this.buyVowelRadio.TabIndex = 13;
            this.buyVowelRadio.TabStop = true;
            this.buyVowelRadio.Text = "Buy Vowel";
            this.buyVowelRadio.UseVisualStyleBackColor = false;
            this.buyVowelRadio.CheckedChanged += new System.EventHandler(this.OnCheckedChange);
            // 
            // solvePuzzleRadio
            // 
            this.solvePuzzleRadio.AutoSize = true;
            this.solvePuzzleRadio.BackColor = System.Drawing.Color.Transparent;
            this.solvePuzzleRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.solvePuzzleRadio.ForeColor = System.Drawing.Color.Yellow;
            this.solvePuzzleRadio.Location = new System.Drawing.Point(197, 380);
            this.solvePuzzleRadio.Name = "solvePuzzleRadio";
            this.solvePuzzleRadio.Size = new System.Drawing.Size(129, 24);
            this.solvePuzzleRadio.TabIndex = 14;
            this.solvePuzzleRadio.TabStop = true;
            this.solvePuzzleRadio.Text = "Solve Puzzle";
            this.solvePuzzleRadio.UseVisualStyleBackColor = false;
            this.solvePuzzleRadio.CheckedChanged += new System.EventHandler(this.OnCheckedChange);
            // 
            // lettersLabel
            // 
            this.lettersLabel.AutoSize = true;
            this.lettersLabel.BackColor = System.Drawing.Color.LightSeaGreen;
            this.lettersLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lettersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lettersLabel.Location = new System.Drawing.Point(121, 303);
            this.lettersLabel.Name = "lettersLabel";
            this.lettersLabel.Size = new System.Drawing.Size(394, 22);
            this.lettersLabel.TabIndex = 16;
            this.lettersLabel.Text = "A B C D E F G H I J K L M N O P Q R S T U V W X Y Z";
            // 
            // categoryLabel
            // 
            this.categoryLabel.Location = new System.Drawing.Point(197, 78);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.ReadOnly = true;
            this.categoryLabel.Size = new System.Drawing.Size(240, 62);
            this.categoryLabel.TabIndex = 17;
            this.categoryLabel.Text = "";
            // 
            // WheelOfFortuneForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WheelOfFortune.Properties.Resources.Wheel_of_Fortune_Puzzle_Board_5;
            this.ClientSize = new System.Drawing.Size(639, 433);
            this.Controls.Add(this.categoryLabel);
            this.Controls.Add(this.lettersLabel);
            this.Controls.Add(this.solvePuzzleRadio);
            this.Controls.Add(this.buyVowelRadio);
            this.Controls.Add(this.spinRadio);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.answerEntryTextBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.wheelTextBox);
            this.Controls.Add(this.puzzleText);
            this.Controls.Add(this.playerMoneyLabel);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(655, 471);
            this.MinimumSize = new System.Drawing.Size(655, 471);
            this.Name = "WheelOfFortuneForm";
            this.Text = "Wheel of Fortune";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label playerMoneyLabel;
        private System.Windows.Forms.Label puzzleText;
        private System.Windows.Forms.TextBox wheelTextBox;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox answerEntryTextBox;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.RadioButton spinRadio;
        private System.Windows.Forms.RadioButton buyVowelRadio;
        private System.Windows.Forms.RadioButton solvePuzzleRadio;
        private System.Windows.Forms.Label lettersLabel;
        private System.Windows.Forms.RichTextBox categoryLabel;
    }
}

