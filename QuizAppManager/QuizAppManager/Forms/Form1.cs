using QuizAppManager.Forms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuizAppManager
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnCategories.Image = new Bitmap(btnCategories.Image, new Size(btnCategories.Size.Width, btnCategories.Size.Height));
            btnQuestions.Image = new Bitmap(btnQuestions.Image, new Size(btnQuestions.Size.Width, btnQuestions.Size.Height));
        }

        private void buttonCategories_Click(object sender, EventArgs e)
        {
            using (CategoriesListForm categoriesListForm = new CategoriesListForm())
            {
                categoriesListForm.ShowDialog();
            }
        }

        private void buttonQuestions_Click(object sender, EventArgs e)
        {
            using (QuestionsListForm questionsListForm = new QuestionsListForm())
            {
                questionsListForm.ShowDialog();
            }
        }
    }
}
