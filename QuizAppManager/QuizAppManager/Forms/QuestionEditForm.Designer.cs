namespace QuizAppManager.Forms
{
    partial class QuestionEditForm
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
            this.label7 = new System.Windows.Forms.Label();
            this.trueAnswerComboBox = new System.Windows.Forms.ComboBox();
            this.info = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.answer4TextBox = new System.Windows.Forms.TextBox();
            this.answer3TextBox = new System.Windows.Forms.TextBox();
            this.answer2TextBox = new System.Windows.Forms.TextBox();
            this.answer1TextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.questionTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 251);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 46;
            this.label7.Text = "true answer";
            // 
            // trueAnswerComboBox
            // 
            this.trueAnswerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.trueAnswerComboBox.FormattingEnabled = true;
            this.trueAnswerComboBox.Location = new System.Drawing.Point(81, 248);
            this.trueAnswerComboBox.Name = "trueAnswerComboBox";
            this.trueAnswerComboBox.Size = new System.Drawing.Size(238, 21);
            this.trueAnswerComboBox.TabIndex = 45;
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Location = new System.Drawing.Point(78, 301);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(0, 13);
            this.info.TabIndex = 44;
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(243, 275);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(76, 23);
            this.close.TabIndex = 43;
            this.close.Text = "Close";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(81, 275);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(73, 23);
            this.save.TabIndex = 42;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // answer4TextBox
            // 
            this.answer4TextBox.Location = new System.Drawing.Point(81, 222);
            this.answer4TextBox.Name = "answer4TextBox";
            this.answer4TextBox.Size = new System.Drawing.Size(238, 20);
            this.answer4TextBox.TabIndex = 41;
            // 
            // answer3TextBox
            // 
            this.answer3TextBox.Location = new System.Drawing.Point(81, 196);
            this.answer3TextBox.Name = "answer3TextBox";
            this.answer3TextBox.Size = new System.Drawing.Size(238, 20);
            this.answer3TextBox.TabIndex = 40;
            // 
            // answer2TextBox
            // 
            this.answer2TextBox.Location = new System.Drawing.Point(81, 170);
            this.answer2TextBox.Name = "answer2TextBox";
            this.answer2TextBox.Size = new System.Drawing.Size(238, 20);
            this.answer2TextBox.TabIndex = 39;
            // 
            // answer1TextBox
            // 
            this.answer1TextBox.Location = new System.Drawing.Point(81, 144);
            this.answer1TextBox.Name = "answer1TextBox";
            this.answer1TextBox.Size = new System.Drawing.Size(238, 20);
            this.answer1TextBox.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "answer 4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "answer 3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "answer 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "answer 1";
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(81, 35);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(238, 21);
            this.categoryComboBox.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "question";
            // 
            // questionTextBox
            // 
            this.questionTextBox.Location = new System.Drawing.Point(81, 62);
            this.questionTextBox.Multiline = true;
            this.questionTextBox.Name = "questionTextBox";
            this.questionTextBox.Size = new System.Drawing.Size(238, 72);
            this.questionTextBox.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "category";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 13);
            this.label8.TabIndex = 47;
            this.label8.Text = "id";
            // 
            // idTextBox
            // 
            this.idTextBox.Enabled = false;
            this.idTextBox.Location = new System.Drawing.Point(81, 9);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(238, 20);
            this.idTextBox.TabIndex = 48;
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(160, 275);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(77, 23);
            this.delete.TabIndex = 49;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // QuestionEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.trueAnswerComboBox);
            this.Controls.Add(this.info);
            this.Controls.Add(this.close);
            this.Controls.Add(this.save);
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
            this.Name = "QuestionEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "QuestionEditForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QuestionEditForm_FormClosing);
            this.Load += new System.EventHandler(this.QuestionEditForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox trueAnswerComboBox;
        private System.Windows.Forms.Label info;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.TextBox answer4TextBox;
        private System.Windows.Forms.TextBox answer3TextBox;
        private System.Windows.Forms.TextBox answer2TextBox;
        private System.Windows.Forms.TextBox answer1TextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox questionTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Button delete;
    }
}