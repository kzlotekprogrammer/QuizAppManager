using QuizAppManager.Forms;
using QuizAppManager.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace QuizAppManager
{
    public partial class CategoriesListForm : Form
    {
        private DataSet dataSet;

        public CategoriesListForm()
        {
            InitializeComponent();
        }

        private void CategoriesListForm_Load(object sender, EventArgs e)
        {
            LoadCategories();
        }

        private void LoadCategories()
        {
            using (WaitForm waitForm = new WaitForm(PrepareDataSet))
            {
                waitForm.ShowDialog();
            }
        }

        private void PrepareDataSet()
        {
            List<Category> categories = FirebaseHelper.GetCategories();

            dataSet = new DataSet();
            DataTable table = dataSet.Tables.Add("categories");
            table.Columns.Add("lp");
            table.Columns.Add("id");
            table.Columns.Add("name");
            table.Columns.Add("description");

            for(int i = 0; i < categories.Count; i++)
            {
                DataRow row = table.NewRow();
                row["lp"] = i+1;
                row["id"] = categories[i].Id;
                row["name"] = categories[i].Name;
                row["description"] = categories[i].Description;
                table.Rows.Add(row);
            }

            categoriesGridView.Invoke(new Action(() => categoriesGridView.DataSource = dataSet.Tables["categories"]));
        }

        private void categoriesGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex < 0 || e.RowIndex >= dataSet.Tables["categories"].Rows.Count)
            {
                return;
            }

            DataGridViewRow row = categoriesGridView.Rows[e.RowIndex];

            Category category = new Category();
            category.Id = row.Cells["id"].Value as string;
            category.Name = row.Cells["name"].Value as string;
            category.Description = row.Cells["description"].Value as string;

            using (CategoryEditForm categoryEditForm = new CategoryEditForm(category))
            {
                categoryEditForm.ShowDialog();
                if (categoryEditForm.DialogResult == DialogResult.OK)
                {
                    LoadCategories();
                    info.Text = "Zapisano pomyślnie dane";
                }
            }
        }

        private void ButtonNew_Click(object sender, EventArgs e)
        {
            using (CategoryEditForm categoryEditForm = new CategoryEditForm())
            {
                categoryEditForm.ShowDialog();
                if(categoryEditForm.DialogResult == DialogResult.OK)
                {
                    LoadCategories();
                    info.Text = "Dodano nową kategorię";
                }
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
