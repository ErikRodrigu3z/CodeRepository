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
        public AddCategroy()
        {
            InitializeComponent();
            _category = new CategoryRepo();
        }

        private async void AddCategroy_Load(object sender, EventArgs e)
        {
            var list = await _category.GetListAsync();
            gvCategory.DataSource = list;
        }
    }
}
