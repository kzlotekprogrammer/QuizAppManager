namespace QuizAppManager
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
            this.buttonCategories = new System.Windows.Forms.Button();
            this.buttonQuestions = new System.Windows.Forms.Button();
            this.buttonStatistics = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCategories
            // 
            this.buttonCategories.Location = new System.Drawing.Point(13, 13);
            this.buttonCategories.Name = "buttonCategories";
            this.buttonCategories.Size = new System.Drawing.Size(196, 129);
            this.buttonCategories.TabIndex = 1;
            this.buttonCategories.Text = "Categories";
            this.buttonCategories.UseVisualStyleBackColor = true;
            this.buttonCategories.Click += new System.EventHandler(this.buttonCategories_Click);
            // 
            // buttonQuestions
            // 
            this.buttonQuestions.Location = new System.Drawing.Point(215, 13);
            this.buttonQuestions.Name = "buttonQuestions";
            this.buttonQuestions.Size = new System.Drawing.Size(196, 129);
            this.buttonQuestions.TabIndex = 2;
            this.buttonQuestions.Text = "Questions";
            this.buttonQuestions.UseVisualStyleBackColor = true;
            this.buttonQuestions.Click += new System.EventHandler(this.buttonQuestions_Click);
            // 
            // buttonStatistics
            // 
            this.buttonStatistics.Location = new System.Drawing.Point(417, 13);
            this.buttonStatistics.Name = "buttonStatistics";
            this.buttonStatistics.Size = new System.Drawing.Size(196, 129);
            this.buttonStatistics.TabIndex = 3;
            this.buttonStatistics.Text = "Statistics";
            this.buttonStatistics.UseVisualStyleBackColor = true;
            this.buttonStatistics.Click += new System.EventHandler(this.buttonStatistics_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonStatistics);
            this.Controls.Add(this.buttonQuestions);
            this.Controls.Add(this.buttonCategories);
            this.Name = "Form1";
            this.Text = "QuizAppManager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonCategories;
        private System.Windows.Forms.Button buttonQuestions;
        private System.Windows.Forms.Button buttonStatistics;
    }
}

