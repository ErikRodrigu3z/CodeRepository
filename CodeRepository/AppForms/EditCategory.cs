using CodeRepository.Models;
using CodeRepository.Repository.CategoryRepo;
using CodeRepository.Utils;
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
    public partial class EditCategory : Form
    {
        private readonly ICategoryRepo _category;
        private Category category;  

        #region Delegado
        //delegado
        public delegate void RefreshCmbCategory();
        //evento
        public event RefreshCmbCategory RefreshCmb;
        #endregion

        public EditCategory()
        {
            InitializeComponent();
            _category = new CategoryRepo();
        }
        private void EditCategory_Load(object sender, EventArgs e)
        {
            lblValAddCategory.Visible = false;
            category = _category.GetById(SD.IdCategory);
            txtEditCategory.Text = category.Name;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            UpdateCategory();
        }

        private void txtEditCategory_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                UpdateCategory();
            }            
        }

        #region Save Category
        public void UpdateCategory() 
        {
            try
            {
                if (string.IsNullOrEmpty(txtEditCategory.Text))
                {
                    lblValAddCategory.Visible = true;
                }
                else
                {
                    category.Name = txtEditCategory.Text;
                    _category.Update(category);
                    txtEditCategory.ResetText();
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
