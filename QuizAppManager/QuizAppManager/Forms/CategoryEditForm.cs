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
    public partial class CategoryEditForm : Form
    {
        public bool ChangesExists { get; private set; } = false;

        public CategoryEditForm(Category category)
        {
            InitializeComponent();

            id.Text = category.Id;
            name.Text = category.Name;
            description.Text = category.Description;
        }

        private void CategoryEditForm_Load(object sender, EventArgs e)
        {

        }

        private void save_Click(object sender, EventArgs e)
        {
            using(WaitForm waitForm = new WaitForm(Save))
            {
                waitForm.ShowDialog();
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            using (WaitForm waitForm = new WaitForm(Delete))
            {
                waitForm.ShowDialog();
            }
        }

        private void Save()
        {
            Category category = new Category { Id = id.Text, Name = name.Text, Description = description.Text };
            if (FirebaseHelper.EditCategory(category))
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

        private void Delete()
        {
            Category category = new Category { Id = id.Text };
            if (FirebaseHelper.DeleteCategory(category))
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

        private void CategoryEditForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(ChangesExists)
            {
                DialogResult = DialogResult.OK;
            }
        }
    }
}
