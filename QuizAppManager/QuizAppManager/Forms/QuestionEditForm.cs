using QuizAppManager.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QuizAppManager.Forms
{
    public partial class QuestionEditForm : Form
    {
        private List<Category> Categories;
        private Question CurrentQuestion;

        public bool ChangesExists { get; private set; } = false;

        public QuestionEditForm(List<Category> categories, Question question = null)
        {
            InitializeComponent();

            Categories = categories;
            Categories.ForEach(x => categoryComboBox.Items.Add(x.Name));

            CurrentQuestion = question;

            List<Answer> items = new List<Answer>() { Answer.A, Answer.B, Answer.C, Answer.D };
            items.ForEach(x => trueAnswerComboBox.Items.Add(x));

            if (CurrentQuestion != null)
            {
                SetControlsData(question);                
            }
            else
            {
                delete.Visible = false;
            }
        }

        private void SetControlsData(Question question)
        {
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

        private void Save_Click(object sender, EventArgs e)
        {
            if (FormFilled())
            {
                Action<Question> action;
                if (CurrentQuestion == null)
                    action = Add;
                else
                    action = Save;

                Question question = CreateQuestionFromControlls();

                using (WaitForm waitForm = new WaitForm(() => action.Invoke(question)))
                {
                    waitForm.ShowDialog();
                }
            }
            else
            {
                info.Text = "Nie wprowadzono wszystkich wymaganych danych";
            }
        }

        private Question CreateQuestionFromControlls()
        {
            Question question = new Question
            {
                CategoryId = Categories[categoryComboBox.SelectedIndex].Id,
                Content = questionTextBox.Text,
                Answer1 = answer1TextBox.Text,
                Answer2 = answer2TextBox.Text,
                Answer3 = answer3TextBox.Text,
                Answer4 = answer4TextBox.Text,
                TrueAnswer = trueAnswerComboBox.SelectedItem.ToString()
            };

            if (CurrentQuestion != null)
            {
                question.Id = idTextBox.Text;
            }

            return question;
        }

        private bool FormFilled()
        {
            return categoryComboBox.SelectedItem != null
                && !string.IsNullOrEmpty(categoryComboBox.SelectedItem as string)
                && trueAnswerComboBox.SelectedItem != null
                && !string.IsNullOrEmpty(trueAnswerComboBox.SelectedItem.ToString())
                && !string.IsNullOrEmpty(questionTextBox.Text)
                && !string.IsNullOrEmpty(answer1TextBox.Text)
                && !string.IsNullOrEmpty(answer2TextBox.Text)
                && !string.IsNullOrEmpty(answer3TextBox.Text)
                && !string.IsNullOrEmpty(answer4TextBox.Text);
        }

        private void Save(Question question)
        {
            if (FirebaseHelper.EditQuestion(question))
            {
                Invoke(new Action(() =>
                {
                    DialogResult = DialogResult.OK;
                    Close();
                }));
            }
            else
            {
                Invoke(new Action(() =>
                {
                    info.Text = "Operacja nie powiodła się";
                }));
            }
        }

        private void Add(Question question)
        {
            if (FirebaseHelper.InsertQuestion(question))
            {
                Invoke(new Action(() =>
                {
                    DialogResult = DialogResult.OK;
                    Close();
                }));
            }
            else
            {
                Invoke(new Action(() =>
                {
                    info.Text = "Operacja nie powiodła się";
                }));
            }
        }
        private void Delete_Click(object sender, EventArgs e)
        {
            using (WaitForm waitForm = new WaitForm(Delete))
            {
                waitForm.ShowDialog();
            }
        }

        private void Delete()
        {
            if (FirebaseHelper.DeleteQuestion(new Question { Id = idTextBox.Text }))
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
                    info.Text = "Operacja nie powiodła się";
                }));
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void QuestionEditForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ChangesExists)
            {
                DialogResult = DialogResult.OK;
            }
        }
    }
}
