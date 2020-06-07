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
    public partial class QuestionNewForm : Form
    {
        private List<Category> Categories;

        public QuestionNewForm(List<Category> categories)
        {
            InitializeComponent();

            Categories = categories;
            Categories.ForEach(x => categoryComboBox.Items.Add(x.Name));

            List<string> items = new List<string>() { "Answer 1", "Answer 2", "Answer 3", "Answer 4" };
            items.ForEach(x => trueAnswerComboBox.Items.Add(x));
        }

        private void QuestionNewForm_Load(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
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
                    CategoryId = Categories[categoryComboBox.SelectedIndex].Id,
                    Content = questionTextBox.Text,
                    Answer1 = answer1TextBox.Text,
                    Answer2 = answer2TextBox.Text,
                    Answer3 = answer3TextBox.Text,
                    Answer4 = answer4TextBox.Text,
                    TrueAnswer = trueAnswerComboBox.SelectedItem as string
                };

                using (WaitFormWithParameter waitFormWithParameter = new WaitFormWithParameter(Add, question))
                {
                    waitFormWithParameter.ShowDialog();
                }
            }
            else
            {
                info.Text = "Please fill all data";
            }            
        }

        private void Add(object question)
        {
            if (FirebaseHelper.InsertQuestion(question as Question))
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
                    info.Text = "Operation failed";
                }));
            }
        }
    }
}
