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
    public partial class ProvidersUpdView : Form {
        Controller controller = new Controller();
        public int Id { get; set; }
        public ProvidersUpdView(int id, string nam, string adress, string ph) {
            InitializeComponent();
            Id = id;
            name.Text = nam;
            adr.Text = adress;
            phone.Text = ph;
        }

        private void Update_btn_Click(object sender, EventArgs e) {
            controller.updateProvider(this.Id, name.Text, adr.Text, phone.Text);
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
