using CodeRepository.Repository.CategoryRepo;

namespace CodeRepository.AppForms
{
    public partial class Main : Form
    {
        private readonly ICategoryRepo _category;
        public Main()
        {
            InitializeComponent();
            _category = new CategoryRepo();
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
            var list = await _category.GetListAsync();
            cmbCategories.DataSource = list;
            cmbCategories.DisplayMember = "Name";
            cmbCategories.ValueMember = "CategoryID";

        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            AddCategroy addCategroy = new AddCategroy();
            addCategroy.ShowDialog();
        }
    }
}
