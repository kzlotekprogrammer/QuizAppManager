namespace QuizAppManager.Forms
{
    partial class QuestionsListForm
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
            this.questionsGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Button();
            this.buttonNew = new System.Windows.Forms.Button();
            this.lp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.content = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.answer1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.answer2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.answer3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.answer4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trueAnswer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.questionsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // questionsGridView
            // 
            this.questionsGridView.AllowUserToAddRows = false;
            this.questionsGridView.AllowUserToDeleteRows = false;
            this.questionsGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.questionsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.questionsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lp,
            this.id,
            this.categoryId,
            this.categoryName,
            this.content,
            this.answer1,
            this.answer2,
            this.answer3,
            this.answer4,
            this.trueAnswer});
            this.questionsGridView.Location = new System.Drawing.Point(12, 29);
            this.questionsGridView.Name = "questionsGridView";
            this.questionsGridView.ReadOnly = true;
            this.questionsGridView.Size = new System.Drawing.Size(842, 343);
            this.questionsGridView.TabIndex = 0;
            this.questionsGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Double click on row to make changes";
            // 
            // info
            // 
            this.info.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.info.AutoSize = true;
            this.info.Location = new System.Drawing.Point(20, 375);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(0, 13);
            this.info.TabIndex = 10;
            // 
            // close
            // 
            this.close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.close.Location = new System.Drawing.Point(214, 395);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(196, 43);
            this.close.TabIndex = 9;
            this.close.Text = "Close";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // buttonNew
            // 
            this.buttonNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonNew.Location = new System.Drawing.Point(12, 395);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(196, 43);
            this.buttonNew.TabIndex = 11;
            this.buttonNew.Text = "New";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // lp
            // 
            this.lp.DataPropertyName = "lp";
            this.lp.HeaderText = "Lp";
            this.lp.Name = "lp";
            this.lp.ReadOnly = true;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // categoryId
            // 
            this.categoryId.DataPropertyName = "categoryId";
            this.categoryId.HeaderText = "Category id";
            this.categoryId.Name = "categoryId";
            this.categoryId.ReadOnly = true;
            this.categoryId.Visible = false;
            // 
            // categoryName
            // 
            this.categoryName.DataPropertyName = "categoryName";
            this.categoryName.HeaderText = "Category name";
            this.categoryName.Name = "categoryName";
            this.categoryName.ReadOnly = true;
            // 
            // content
            // 
            this.content.DataPropertyName = "content";
            this.content.HeaderText = "Content";
            this.content.Name = "content";
            this.content.ReadOnly = true;
            // 
            // answer1
            // 
            this.answer1.DataPropertyName = "answer1";
            this.answer1.HeaderText = "Answer 1";
            this.answer1.Name = "answer1";
            this.answer1.ReadOnly = true;
            // 
            // answer2
            // 
            this.answer2.DataPropertyName = "answer2";
            this.answer2.HeaderText = "Answer 2";
            this.answer2.Name = "answer2";
            this.answer2.ReadOnly = true;
            // 
            // answer3
            // 
            this.answer3.DataPropertyName = "answer3";
            this.answer3.HeaderText = "Answer 3";
            this.answer3.Name = "answer3";
            this.answer3.ReadOnly = true;
            // 
            // answer4
            // 
            this.answer4.DataPropertyName = "answer4";
            this.answer4.HeaderText = "Answer 4";
            this.answer4.Name = "answer4";
            this.answer4.ReadOnly = true;
            // 
            // trueAnswer
            // 
            this.trueAnswer.DataPropertyName = "trueAnswer";
            this.trueAnswer.HeaderText = "True answer";
            this.trueAnswer.Name = "trueAnswer";
            this.trueAnswer.ReadOnly = true;
            // 
            // QuestionsListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 450);
            this.Controls.Add(this.buttonNew);
            this.Controls.Add(this.info);
            this.Controls.Add(this.close);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.questionsGridView);
            this.Name = "QuestionsListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "QuestionsList";
            this.Load += new System.EventHandler(this.QuestionsListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.questionsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView questionsGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label info;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.DataGridViewTextBoxColumn lp;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryId;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn content;
        private System.Windows.Forms.DataGridViewTextBoxColumn answer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn answer2;
        private System.Windows.Forms.DataGridViewTextBoxColumn answer3;
        private System.Windows.Forms.DataGridViewTextBoxColumn answer4;
        private System.Windows.Forms.DataGridViewTextBoxColumn trueAnswer;
    }
}