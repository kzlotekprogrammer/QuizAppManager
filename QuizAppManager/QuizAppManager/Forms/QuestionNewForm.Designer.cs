namespace QuizAppManager.Forms
{
    partial class QuestionNewForm
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
            this.questionTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.answer1TextBox = new System.Windows.Forms.TextBox();
            this.answer2TextBox = new System.Windows.Forms.TextBox();
            this.answer3TextBox = new System.Windows.Forms.TextBox();
            this.answer4TextBox = new System.Windows.Forms.TextBox();
            this.info = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.trueAnswerComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "category";
            // 
            // questionTextBox
            // 
            this.questionTextBox.Location = new System.Drawing.Point(81, 33);
            this.questionTextBox.Multiline = true;
            this.questionTextBox.Name = "questionTextBox";
            this.questionTextBox.Size = new System.Drawing.Size(238, 72);
            this.questionTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "question";
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(81, 6);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(238, 21);
            this.categoryComboBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "answer 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "answer 2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "answer 3";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "answer 4";
            // 
            // answer1TextBox
            // 
            this.answer1TextBox.Location = new System.Drawing.Point(81, 115);
            this.answer1TextBox.Name = "answer1TextBox";
            this.answer1TextBox.Size = new System.Drawing.Size(238, 20);
            this.answer1TextBox.TabIndex = 8;
            // 
            // answer2TextBox
            // 
            this.answer2TextBox.Location = new System.Drawing.Point(81, 141);
            this.answer2TextBox.Name = "answer2TextBox";
            this.answer2TextBox.Size = new System.Drawing.Size(238, 20);
            this.answer2TextBox.TabIndex = 9;
            // 
            // answer3TextBox
            // 
            this.answer3TextBox.Location = new System.Drawing.Point(81, 167);
            this.answer3TextBox.Name = "answer3TextBox";
            this.answer3TextBox.Size = new System.Drawing.Size(238, 20);
            this.answer3TextBox.TabIndex = 10;
            // 
            // answer4TextBox
            // 
            this.answer4TextBox.Location = new System.Drawing.Point(81, 193);
            this.answer4TextBox.Name = "answer4TextBox";
            this.answer4TextBox.Size = new System.Drawing.Size(238, 20);
            this.answer4TextBox.TabIndex = 11;
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Location = new System.Drawing.Point(78, 272);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(0, 13);
            this.info.TabIndex = 27;
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(206, 246);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(113, 23);
            this.close.TabIndex = 26;
            this.close.Text = "Close";
            this.close.UseVisualStyleBackColor = true;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(81, 246);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(119, 23);
            this.add.TabIndex = 25;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // trueAnswerComboBox
            // 
            this.trueAnswerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.trueAnswerComboBox.FormattingEnabled = true;
            this.trueAnswerComboBox.Location = new System.Drawing.Point(81, 219);
            this.trueAnswerComboBox.Name = "trueAnswerComboBox";
            this.trueAnswerComboBox.Size = new System.Drawing.Size(238, 21);
            this.trueAnswerComboBox.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "true answer";
            // 
            // QuestionNewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.trueAnswerComboBox);
            this.Controls.Add(this.info);
            this.Controls.Add(this.close);
            this.Controls.Add(this.add);
            this.Controls.Add(this.answer4TextBox);
            this.Controls.Add(this.answer3TextBox);
            this.Controls.Add(this.answer2TextBox);
            this.Controls.Add(this.answer1TextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.questionTextBox);
            this.Controls.Add(this.label1);
            this.Name = "QuestionNewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "QuestionNewForm";
            this.Load += new System.EventHandler(this.QuestionNewForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox questionTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox answer1TextBox;
        private System.Windows.Forms.TextBox answer2TextBox;
        private System.Windows.Forms.TextBox answer3TextBox;
        private System.Windows.Forms.TextBox answer4TextBox;
        private System.Windows.Forms.Label info;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.ComboBox trueAnswerComboBox;
        private System.Windows.Forms.Label label7;
    }
}