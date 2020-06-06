using QuizAppManager.Forms;
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
            table.Columns.Add("id");
            table.Columns.Add("name");
            table.Columns.Add("description");

            foreach (Category category in categories)
            {
                DataRow row = table.NewRow();
                row["id"] = category.Id;
                row["name"] = category.Name;
                row["description"] = category.Description;
                table.Rows.Add(row);
            }

            categoriesGridView.Invoke(new Action(() => categoriesGridView.DataSource = dataSet.Tables["categories"]));
        }

        private void categoriesGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataRow row = dataSet.Tables["categories"].Rows[e.RowIndex];
            Category category = new Category();
            category.Id = row["id"] as string;
            category.Name = row["name"] as string;
            category.Description = row["description"] as string;

            using (CategoryEditForm categoryEditForm = new CategoryEditForm(category))
            {
                categoryEditForm.ShowDialog();
                if (categoryEditForm.DialogResult == DialogResult.OK)
                {
                    LoadCategories();
                    info.Text = "Changes made successfully";
                }
            }
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            using (CategoryNewForm categoryNewForm = new CategoryNewForm())
            {
                categoryNewForm.ShowDialog();
                if(categoryNewForm.DialogResult == DialogResult.OK)
                {
                    LoadCategories();
                    info.Text = "Category added successfully";
                }
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
