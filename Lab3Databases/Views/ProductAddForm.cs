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
    public partial class ProductAddForm : Form {
        Controller controller = new Controller();
        public ProductAddForm() {
            InitializeComponent();
            controller.fillComboBox(comboBox);
        }

        private void Add_Click(object sender, EventArgs e) {
            controller.addProduct(name.Text, category.Text, Int32.Parse(comboBox.Text));
            this.Close();
        }
    }
}
