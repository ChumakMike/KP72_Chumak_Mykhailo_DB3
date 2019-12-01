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
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            BuyersView buyersViewForm = new BuyersView();
            buyersViewForm.Show();
        }

        private void button4_Click(object sender, EventArgs e) {
            ProductViewForm productViewForm = new ProductViewForm();
            productViewForm.Show();
        }

        private void button2_Click(object sender, EventArgs e) {
            ProviderView providerView = new ProviderView();
            providerView.Show();
        }

        private void button3_Click(object sender, EventArgs e) {
            DeliveryView deliveryView = new DeliveryView();
            deliveryView.Show();
        }
    }
}
