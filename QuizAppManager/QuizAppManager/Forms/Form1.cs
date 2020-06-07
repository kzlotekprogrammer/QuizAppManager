using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using QuizAppManager.Forms;
using QuizAppManager.Models;

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
            using(QuestionsListForm questionsListForm = new QuestionsListForm())
            {
                questionsListForm.ShowDialog();
            }
        }

        private void buttonStatistics_Click(object sender, EventArgs e)
        {

        }
    }
}
