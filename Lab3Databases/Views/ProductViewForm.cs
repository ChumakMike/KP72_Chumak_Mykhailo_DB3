using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3Databases {
    public partial class ProductViewForm : Form {
        Controller controller = new Controller();
        public ProductViewForm() {
            InitializeComponent();
            upload();
        }

        private void All_Click(object sender, EventArgs e) {
            upload();
        }

        private void Add_Click(object sender, EventArgs e) {
            ProductAddForm productAddView = new ProductAddForm();
            productAddView.Show();
        }

        private void Remove_Click(object sender, EventArgs e) {
            controller.deleteProduct(Int32.Parse((ProductsGrid.Rows[ProductsGrid.CurrentRow.Index].Cells[0].Value).ToString()));
            upload();
        }

        private void Update_Click(object sender, EventArgs e) {
            ProductUpdcs productUpdView = new ProductUpdcs(Int32.Parse((ProductsGrid.Rows[ProductsGrid.CurrentRow.Index].Cells[0].Value).ToString()),
                (ProductsGrid.Rows[ProductsGrid.CurrentRow.Index].Cells[1].Value).ToString(),
                (ProductsGrid.Rows[ProductsGrid.CurrentRow.Index].Cells[2].Value).ToString(),
                Int32.Parse((ProductsGrid.Rows[ProductsGrid.CurrentRow.Index].Cells[3].Value).ToString()));
            productUpdView.Show();
        }

        private void RandomFill_Click(object sender, EventArgs e) {
            controller.InsertRandomProducts();
        }

        private void upload() {
            using (Context ent = new Context()) {
                ProductsGrid.DataSource = ent.Product.ToList();
                ProductsGrid.Columns[0].Visible = false;
            }
        }

        private void ProductsGrid_SelectionChanged(object sender, EventArgs e) {
            controller.activateRemBtn(Remove);
        }
    }
}
