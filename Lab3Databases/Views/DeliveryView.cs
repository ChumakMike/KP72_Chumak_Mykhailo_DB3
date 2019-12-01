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
    public partial class DeliveryView : Form {
        Controller controller = new Controller();

        public DeliveryView() {
            InitializeComponent();
            upload();
        }

        private void DeliveryView_Load(object sender, EventArgs e) { }

        private void All_Click(object sender, EventArgs e) {
            upload();
        }

        private void Add_Click(object sender, EventArgs e) {
            DeliveryAddView deliveryAddView = new DeliveryAddView();
            deliveryAddView.Show();
        }

        private void Remove_Click(object sender, EventArgs e) {
            controller.deleteDelivery(Int32.Parse((DeliveriesGrid.Rows[DeliveriesGrid.CurrentRow.Index].Cells[0].Value).ToString()));
            upload();
        }

        private void button4_Click(object sender, EventArgs e) {
            DeliveryUpdView deliveryUpdView = new DeliveryUpdView(Int32.Parse((DeliveriesGrid.Rows[DeliveriesGrid.CurrentRow.Index].Cells[0].Value).ToString()), (DeliveriesGrid.Rows[DeliveriesGrid.CurrentRow.Index].Cells[4].ToString()),
               (DeliveriesGrid.Rows[DeliveriesGrid.CurrentRow.Index].Cells[5].ToString()));
            deliveryUpdView.Show();
        }

        private void RandomFill_Click(object sender, EventArgs e) {
            controller.InsertRandomDeliveries();
            upload();
        }

        private void DeliveriesGrid_SelectionChanged(object sender, EventArgs e) {
            controller.activateRemBtn(Remove);
        }

        private void upload() {
            using (Context ent = new Context()) {
                DeliveriesGrid.DataSource = ent.Delivery.ToList();
                DeliveriesGrid.Columns[0].Visible = false;
            }
        }
    }
}
