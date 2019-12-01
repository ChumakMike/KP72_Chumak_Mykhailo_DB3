using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3Databases{
    public partial class ProductUpdcs : Form {
        Controller controller = new Controller();
        public int Id { get; set; }

        public ProductUpdcs(int id, string nam, string cat, int prodID) {
            InitializeComponent();
            Id = id;
            name.Text = nam;
            category.Text = cat;
            controller.fillComboBox(comboBox);
            comboBox.SelectedItem = prodID;
        }

        private void Update_btn_Click(object sender, EventArgs e) {
            controller.updateProduct(Id, name.Text, category.Text, Int32.Parse(comboBox.Text));
            this.Close();
        }
    }
}
