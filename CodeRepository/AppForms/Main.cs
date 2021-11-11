using CodeRepository.Repository.ArticleRepo;
using CodeRepository.Repository.CategoryRepo;

namespace CodeRepository.AppForms
{
    public partial class Main : Form
    {
        private readonly ICategoryRepo _category;
        private readonly IArticleRepo _article; 

        public Main()
        {
            InitializeComponent();
            _category = new CategoryRepo();
            _article = new ArticleRepo();
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

        private async void Main_Load(object sender, EventArgs e)
        {
            #region cmbCategories
            var list = await _category.GetListAsync();
            cmbCategories.DataSource = list;
            cmbCategories.DisplayMember = "Name";
            cmbCategories.ValueMember = "CategoryID";
            #endregion

            #region MyRegion
            FillGvArticle(1);            
            gvArticle.Columns[0].Visible = false;
            gvArticle.Columns[1].Visible = false;
            gvArticle.Columns[3].Visible = false;
            gvArticle.Columns[4].Visible = false;
            gvArticle.Columns[2].Width = 400;
           gvArticle.Columns[2].HeaderText = "Titulo";
            #endregion
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            AddCategroy addCategroy = new AddCategroy();
            addCategroy.ShowDialog();
        }

        private void cmbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id;
            bool change = int.TryParse(cmbCategories.SelectedValue.ToString(), out id);
            if (change)
            {
                FillGvArticle(id);
            }
        }


        #region Methods

        public void FillGvArticle(int id) 
        {
            var list = _article.FindByCondition(x => x.IdCategory == id);
            gvArticle.DataSource = list;          
        }




        #endregion

        private void gvArticle_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = gvArticle.CurrentRow; // obtengo la fila actualmente seleccionada en el dataGridView
            txtTitle.Text = Convert.ToString(fila.Cells[2].Value); //optengo valor de la primar columna
            txtArticle.Text = Convert.ToString(fila.Cells[1].Value); //optengo valor de la segunda columna
            lblDate.Text = Convert.ToString(fila.Cells[4].Value); //optengo valor de la tercer columna
        }
    }
}
