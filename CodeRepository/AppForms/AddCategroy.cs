using CodeRepository.Models;
using CodeRepository.Repository.CategoryRepo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeRepository.AppForms
{
    public partial class AddCategroy : Form
    {
        private readonly ICategoryRepo _category;

        #region Delegado
        //delegado
        public delegate void RefreshCmbCategory();
        //evento
        public event RefreshCmbCategory RefreshCmb;   
        #endregion

        public AddCategroy()
        {
            InitializeComponent();
            _category = new CategoryRepo();
        }

        private void AddCategroy_Load(object sender, EventArgs e)
        {
           lblValAddCategory.Visible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveCategory();
        }

        private void txtAddCategory_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                SaveCategory();
            }
        }

        #region Save Category
        public void SaveCategory()
        {
            try
            {

                if (string.IsNullOrEmpty(txtAddCategory.Text))
                {
                    lblValAddCategory.Visible = true;
                }
                else
                {
                    Category category = new Category
                    {
                        Name = txtAddCategory.Text
                    };

                    _category.Create(category);
                    txtAddCategory.ResetText();

                    //refresh combo box category of form main
                    this.RefreshCmb();
                    lblValAddCategory.Visible = false;
                }
            }
            catch (Exception ex)
            {
                if (ex.InnerException != null)
                {
                    MessageBox.Show(ex.InnerException.Message);
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        #endregion

    }
}
