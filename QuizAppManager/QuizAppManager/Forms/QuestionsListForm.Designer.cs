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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuestionsListForm));
            this.questionsGridView = new System.Windows.Forms.DataGridView();
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
            this.label1 = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
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
            this.questionsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
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
            this.questionsGridView.Size = new System.Drawing.Size(775, 361);
            this.questionsGridView.TabIndex = 0;
            this.questionsGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellDoubleClick);
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
            this.id.HeaderText = "Id pytania";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // categoryId
            // 
            this.categoryId.DataPropertyName = "categoryId";
            this.categoryId.HeaderText = "Id kategorii";
            this.categoryId.Name = "categoryId";
            this.categoryId.ReadOnly = true;
            // 
            // categoryName
            // 
            this.categoryName.DataPropertyName = "categoryName";
            this.categoryName.HeaderText = "Nazwa kategorii";
            this.categoryName.Name = "categoryName";
            this.categoryName.ReadOnly = true;
            // 
            // content
            // 
            this.content.DataPropertyName = "content";
            this.content.HeaderText = "Treść pytania";
            this.content.Name = "content";
            this.content.ReadOnly = true;
            // 
            // answer1
            // 
            this.answer1.DataPropertyName = "answer1";
            this.answer1.HeaderText = "Odpowiedź A";
            this.answer1.Name = "answer1";
            this.answer1.ReadOnly = true;
            // 
            // answer2
            // 
            this.answer2.DataPropertyName = "answer2";
            this.answer2.HeaderText = "Odpowiedź B";
            this.answer2.Name = "answer2";
            this.answer2.ReadOnly = true;
            // 
            // answer3
            // 
            this.answer3.DataPropertyName = "answer3";
            this.answer3.HeaderText = "Odpowiedź C";
            this.answer3.Name = "answer3";
            this.answer3.ReadOnly = true;
            // 
            // answer4
            // 
            this.answer4.DataPropertyName = "answer4";
            this.answer4.HeaderText = "Odpowiedź D";
            this.answer4.Name = "answer4";
            this.answer4.ReadOnly = true;
            // 
            // trueAnswer
            // 
            this.trueAnswer.DataPropertyName = "trueAnswer";
            this.trueAnswer.HeaderText = "Poprawna odpowiedź";
            this.trueAnswer.Name = "trueAnswer";
            this.trueAnswer.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kliknij dwukrotnie wiersz, aby edytować";
            // 
            // info
            // 
            this.info.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.info.AutoSize = true;
            this.info.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.info.Location = new System.Drawing.Point(12, 395);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(0, 13);
            this.info.TabIndex = 10;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Chocolate;
            this.btnClose.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClose.Location = new System.Drawing.Point(688, 415);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 23);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Zamknij";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.close_Click);
            // 
            // btnNew
            // 
            this.btnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNew.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnNew.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNew.Location = new System.Drawing.Point(12, 415);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(100, 23);
            this.btnNew.TabIndex = 11;
            this.btnNew.Text = "Dodaj";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.ButtonNew_Click);
            // 
            // QuestionsListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.info);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.questionsGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "QuestionsListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Lista pytań";
            this.Load += new System.EventHandler(this.QuestionsListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.questionsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView questionsGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label info;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnNew;
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