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

    public partial class ProviderAdd : Form {
        Controller controller = new Controller();

        public ProviderAdd() {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e) {
            controller.addProvider(name.Text, adr.Text, phone.Text);
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e) {

        }

        private void label2_Click(object sender, EventArgs e) {

        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void phone_TextChanged(object sender, EventArgs e) {

        }

        private void adr_TextChanged(object sender, EventArgs e) {

        }

        private void name_TextChanged(object sender, EventArgs e) {

        }
    }
}
