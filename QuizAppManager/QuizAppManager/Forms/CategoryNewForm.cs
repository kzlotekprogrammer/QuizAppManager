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
    public partial class CategoryNewForm : Form
    {
        public CategoryNewForm()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(name.Text))
            {
                using(WaitForm waitForm = new WaitForm(Add))
                {
                    waitForm.ShowDialog();
                }
            }
            else
            {
                info.Text = "Name can't be empty";
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Add()
        {
            if (FirebaseHelper.InsertCategory(new Category { Name = name.Text, Description = description.Text }))
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
