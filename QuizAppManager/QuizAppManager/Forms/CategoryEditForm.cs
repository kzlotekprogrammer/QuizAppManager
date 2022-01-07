using QuizAppManager.Models;
using System;
using System.Windows.Forms;

namespace QuizAppManager.Forms
{
    public partial class CategoryEditForm : Form
    {
        private Category CurrentCategory;

        public bool ChangesExists { get; private set; } = false;

        public CategoryEditForm(Category category = null)
        {
            InitializeComponent();

            CurrentCategory = category;

            if (CurrentCategory != null)
            {
                id.Text = category.Id;
                name.Text = category.Name;
                description.Text = category.Description;
            }
            else
            {
                btnDelete.Visible = false;
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
                return;

            Category category = new Category { Name = name.Text, Description = description.Text };

            Action<Category> action;
            if (CurrentCategory == null)
            {
                action = Add;
            }
            else
            {
                action = Save;
                category.Id = id.Text;
            }

            using (WaitForm waitForm = new WaitForm(() => action.Invoke(category)))
            {
                waitForm.ShowDialog();
            }
        }

        private bool ValidateForm()
        {
            if (string.IsNullOrEmpty(name.Text))
            {
                info.Text = "Nie wprowadzono nazwy kategorii";
                return false;
            }

            return true;
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            using (WaitForm waitForm = new WaitForm(Delete))
            {
                waitForm.ShowDialog();
            }
        }

        private void Save(Category category)
        {
            if (FirebaseHelper.EditCategory(category))
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

        private void Add(Category category)
        {
            if (FirebaseHelper.InsertCategory(category))
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
                    info.Text = "Operacja nie powiodła się";
                }));
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CategoryEditForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ChangesExists)
            {
                DialogResult = DialogResult.OK;
            }
        }
    }
}
