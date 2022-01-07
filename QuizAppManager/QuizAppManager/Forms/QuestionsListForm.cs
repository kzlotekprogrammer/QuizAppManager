using QuizAppManager.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace QuizAppManager.Forms
{
    public partial class QuestionsListForm : Form
    {
        private DataSet DataSet;

        public List<Category> Categories { get; private set; }
        public Dictionary<string, Category> CategoriesDictionary { get; private set; }

        public QuestionsListForm()
        {
            InitializeComponent();
        }

        private void QuestionsListForm_Load(object sender, EventArgs e)
        {
            LoadQuestions();
        }

        private void LoadQuestions()
        {
            using (WaitForm waitForm = new WaitForm(PrepareDataSet))
            {
                waitForm.ShowDialog();
            }
        }

        private void ButtonNew_Click(object sender, EventArgs e)
        {
            using (QuestionEditForm questionNewForm = new QuestionEditForm(Categories))
            {
                questionNewForm.ShowDialog();
                if (questionNewForm.DialogResult == DialogResult.OK)
                {
                    LoadQuestions();
                    info.Text = "Dodano nowe pytanie";
                }
            }
        }

        private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex < 0 || e.RowIndex >= DataSet.Tables["questions"].Rows.Count)
            {
                return;
            }

            DataGridViewRow row = questionsGridView.Rows[e.RowIndex];
            Question question = new Question();
            question.Id = row.Cells["id"].Value as string;
            question.CategoryId = row.Cells["categoryId"].Value as string;
            question.Content = row.Cells["content"].Value as string;
            question.Answer1 = row.Cells["answer1"].Value as string;
            question.Answer2 = row.Cells["answer2"].Value as string;
            question.Answer3 = row.Cells["answer3"].Value as string;
            question.Answer4 = row.Cells["answer4"].Value as string;
            question.TrueAnswer = row.Cells["trueAnswer"].Value as string;

            using (QuestionEditForm questionEditForm = new QuestionEditForm(Categories, question))
            {
                questionEditForm.ShowDialog();
                if (questionEditForm.DialogResult == DialogResult.OK)
                {
                    LoadQuestions();
                    info.Text = "Zapisano pomyślnie dane";
                }
            }
        }
        private void PrepareDataSet()
        {
            List<Question> questions = FirebaseHelper.GetQuestions();
            Categories = FirebaseHelper.GetCategories();

            CategoriesDictionary = new Dictionary<string, Category>();
            Categories.ForEach(x =>
            {
                CategoriesDictionary.Add(x.Id, x);
            });

            DataSet = new DataSet();
            DataTable table = DataSet.Tables.Add("questions");
            table.Columns.Add("lp");
            table.Columns.Add("id");
            table.Columns.Add("categoryId");
            table.Columns.Add("categoryName");
            table.Columns.Add("content");
            table.Columns.Add("answer1");
            table.Columns.Add("answer2");
            table.Columns.Add("answer3");
            table.Columns.Add("answer4");
            table.Columns.Add("trueAnswer");

            for(int i = 0; i < questions.Count; i++)
            {
                DataRow row = table.NewRow();
                row["lp"] = i + 1;
                row["id"] = questions[i].Id;
                row["categoryId"] = questions[i].CategoryId;
                row["categoryName"] = CategoriesDictionary.ContainsKey(questions[i].CategoryId) ? CategoriesDictionary[questions[i].CategoryId].Name : null;
                row["content"] = questions[i].Content;
                row["answer1"] = questions[i].Answer1;
                row["answer2"] = questions[i].Answer2;
                row["answer3"] = questions[i].Answer3;
                row["answer4"] = questions[i].Answer4;
                row["trueAnswer"] = questions[i].TrueAnswer;
                table.Rows.Add(row);
            }

            Invoke(new Action(() => questionsGridView.DataSource = DataSet.Tables["questions"]));
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
