using QuizAppManager.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizAppManager.Forms
{
    public partial class QuestionEditForm : Form
    {
        private List<Category> Categories;

        public bool ChangesExists { get; private set; } = false;

        public QuestionEditForm(Question question, List<Category> categories)
        {
            InitializeComponent();

            Categories = categories;
            Categories.ForEach(x => categoryComboBox.Items.Add(x.Name));

            List<string> items = new List<string>() { "Answer 1", "Answer 2", "Answer 3", "Answer 4" };
            items.ForEach(x => trueAnswerComboBox.Items.Add(x));

            for (int i = 0; i < Categories.Count; i++)
            {
                if (Categories[i].Id == question.CategoryId)
                {
                    categoryComboBox.SelectedIndex = i;
                    break;
                }
            }

            idTextBox.Text = question.Id;
            questionTextBox.Text = question.Content;
            answer1TextBox.Text = question.Answer1;
            answer2TextBox.Text = question.Answer2;
            answer3TextBox.Text = question.Answer3;
            answer4TextBox.Text = question.Answer4;
            trueAnswerComboBox.Text = question.TrueAnswer;
        }

        private void QuestionEditForm_Load(object sender, EventArgs e)
        {

        }

        private void save_Click(object sender, EventArgs e)
        {
            if (categoryComboBox.SelectedItem != null
                && !String.IsNullOrEmpty(categoryComboBox.SelectedItem as string)
                && trueAnswerComboBox.SelectedItem != null
                && !String.IsNullOrEmpty(trueAnswerComboBox.SelectedItem as string)
                && !String.IsNullOrEmpty(questionTextBox.Text)
                && !String.IsNullOrEmpty(answer1TextBox.Text)
                && !String.IsNullOrEmpty(answer2TextBox.Text)
                && !String.IsNullOrEmpty(answer3TextBox.Text)
                && !String.IsNullOrEmpty(answer4TextBox.Text))
            {
                Question question = new Question
                {
                    Id = idTextBox.Text,
                    CategoryId = Categories[categoryComboBox.SelectedIndex].Id,
                    Content = questionTextBox.Text,
                    Answer1 = answer1TextBox.Text,
                    Answer2 = answer2TextBox.Text,
                    Answer3 = answer3TextBox.Text,
                    Answer4 = answer4TextBox.Text,
                    TrueAnswer = trueAnswerComboBox.SelectedItem as string
                };

                using (WaitFormWithParameter waitFormWithParameter = new WaitFormWithParameter(Save, question))
                {
                    waitFormWithParameter.ShowDialog();
                }
            }
            else
            {
                info.Text = "Please fill all data";
            }
        }

        private void Save(object question)
        {
            if (FirebaseHelper.EditQuestion(question as Question))
            {
                Invoke(new Action(() =>
                {
                    ChangesExists = true;
                    info.Text = "Changes made successfully";
                }));
            }
            else
            {
                Invoke(new Action(() =>
                {
                    info.Text = "Operation failed";
                }));
            }
        }


        private void delete_Click(object sender, EventArgs e)
        {
            using (WaitFormWithParameter waitFormWithParameter = new WaitFormWithParameter(Delete, idTextBox.Text))
            {
                waitFormWithParameter.ShowDialog();
            }
        }

        private void Delete(object questionId)
        {
            if(FirebaseHelper.DeleteQuestion(new Question { Id = questionId as string }))
            {
                Invoke(new Action(() =>
                {
                    ChangesExists = true;
                    Close();
                }));
            }
            else
            {
                Invoke(new Action(() =>
                {
                    info.Text = "Operation failed";
                }));
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void QuestionEditForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(ChangesExists)
            {
                DialogResult = DialogResult.OK;
            }
        }
    }
}
