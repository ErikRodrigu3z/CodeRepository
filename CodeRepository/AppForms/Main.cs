using CodeRepository.Models;
using CodeRepository.Repository.ArticleRepo;
using CodeRepository.Repository.CategoryRepo;
using CodeRepository.Utils;

namespace CodeRepository.AppForms
{
    public partial class Main : Form
    {
        #region Variables and objets, global scope
        private readonly ICategoryRepo _category;
        private readonly IArticleRepo _article;
        AddCategroy addCategoryForm = new AddCategroy();
        EditCategory editCategory = new EditCategory();
        #endregion

        #region Constructors
        public Main()
        {
            InitializeComponent();
            _category = new CategoryRepo();
            _article = new ArticleRepo();
        }
        #endregion

        #region Main form events
        private void Main_Load(object sender, EventArgs e)
        {            
            #region event handler -> AddCategory, EditCategory forms
            addCategoryForm.RefreshCmb += new AddCategroy.RefreshCmbCategory(FillCmbCategory);
            editCategory.RefreshCmb += new EditCategory.RefreshCmbCategory(FillCmbCategory);
            #endregion            

            #region gvArticle
            FillGvArticle(1);            
            gvArticle.Columns[0].Visible = false;
            gvArticle.Columns[1].Visible = false;
            gvArticle.Columns[3].Visible = false;
            gvArticle.Columns[4].Visible = false;
            gvArticle.Columns[2].Width = 400;
            gvArticle.Columns[2].HeaderText = "Titulo";
            #endregion

            btnAddArticle.Enabled = false;

            FillCmbCategory();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Salir de la APP?", "Salir", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Dispose();
                Application.Exit();
            }
            else
            {
                e.Cancel = true;
            }
        }



        #endregion

        #region gvArticle events
        private void gvArticle_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = gvArticle.CurrentRow; // obtengo la fila actualmente seleccionada en el dataGridView
            if (fila != null)
            {
                lblIdArticle.Text = Convert.ToString(fila.Cells[0].Value); //optengo valor de la primer columna
                txtArticle.Text = Convert.ToString(fila.Cells[1].Value).Replace("char(39)", "'"); //optengo valor de la segunda columna
                txtTitle.Text = Convert.ToString(fila.Cells[2].Value); //optengo valor de la tercer columna
                lblDate.Text = Convert.ToString(fila.Cells[4].Value); //optengo valor de la quinta columna
                SD.IdArticle = Convert.ToInt32(fila.Cells[0].Value);
                btnAddArticle.Enabled = false;
                btnEditArticle.Enabled = true;
            }
            
        }

        #endregion

        #region Common controls events   
        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            addCategoryForm.ShowDialog();
        }

        private void btnEditCategory_Click(object sender, EventArgs e)
        {
            editCategory.ShowDialog();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearArticle();
        }
        private void btnAddArticle_Click(object sender, EventArgs e)
        {
            if (ValidateArticle())
            {
                AddArticle();
                FillGvArticle(SD.IdCategory);
            }
            
        }

        private void btnEditArticle_Click(object sender, EventArgs e)
        {
            if (ValidateArticle())
            {
                EditArticle();
                FillGvArticle(SD.IdCategory);
            }
        }

        private void cmbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id;
            bool change = int.TryParse(cmbCategories.SelectedValue.ToString(), out id);
            if (change)
            {
                FillGvArticle(id);
                SD.IdCategory = id;
                lblIdCategory.Text = SD.IdCategory.ToString();
            }
        }

       

        #endregion

        #region Methods

        public void FillGvArticle(int id) 
        {
            var list = _article.FindByCondition(x => x.IdCategory == id);
            gvArticle.DataSource = list;          
        }

        public void FillGvArticle() 
        {
            var list = _article.FindAll();
            gvArticle.DataSource = list;
        }

        public void FillCmbCategory()
        {
            var list = _category.FindAll();
            cmbCategories.DataSource = list;
            cmbCategories.DisplayMember = "Name";
            cmbCategories.ValueMember = "CategoryID";
        }

        public void ClearArticle()
        {
            txtArticle.ResetText();
            txtTitle.ResetText();
            btnAddArticle.Enabled = true;
            btnEditArticle.Enabled = false;
        }

        public bool ValidateArticle()
        {
            if (txtTitle.Text == "" || txtArticle.Text == "")
            {
                MessageBox.Show("Debe llenar ambs campos");
                return false;
            }
            else
            {
                return true;
            }
        }

        public void AddArticle()
        {
            try
            {
                Articles articles = new Articles
                {
                    IdCategory = SD.IdCategory,
                    Title = txtTitle.Text,
                    Content = txtArticle.Text.Replace("'", "char(39)"),
                };

                _article.Create(articles);
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

        public void EditArticle() 
        {
            try
            {
                var article = _article.GetById(SD.IdArticle);
                if (article != null)
                {
                    article.Title = txtTitle.Text;
                    article.Content = txtArticle.Text.Replace("'", "char(39)");
                    _article.Update(article);
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
