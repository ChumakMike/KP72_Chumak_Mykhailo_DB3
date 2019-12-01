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
    public partial class BuyersView : Form {
        Controller controller = new Controller();
        public BuyersView() {
            InitializeComponent();
            upload();
        }

        private void All_Click(object sender, EventArgs e) {
            upload();
        }
        private void upload() {
            using (Context ent = new Context()) {
                BuyersGrid.DataSource = ent.Buyer.ToList();
                BuyersGrid.Columns[0].Visible = false;
            }
        }

        private void Add_Click(object sender, EventArgs e) {
            BuyersAdd buyersAddView = new BuyersAdd();
            buyersAddView.Show();
        }

        private void button4_Click(object sender, EventArgs e) {
            BuyersUpd buyersUpd = new BuyersUpd(Int32.Parse((BuyersGrid.Rows[BuyersGrid.CurrentRow.Index].Cells[0].Value).ToString()),
                (BuyersGrid.Rows[BuyersGrid.CurrentRow.Index].Cells[1].Value).ToString(),
                (BuyersGrid.Rows[BuyersGrid.CurrentRow.Index].Cells[2].Value).ToString(),
                (BuyersGrid.Rows[BuyersGrid.CurrentRow.Index].Cells[3].Value).ToString());
            buyersUpd.Show();
        }

        private void Remove_Click(object sender, EventArgs e) {
            controller.deleteBuyer(Int32.Parse((BuyersGrid.Rows[BuyersGrid.CurrentRow.Index].Cells[0].Value).ToString()));
            upload();
        }

        private void BuyersGrid_SelectionChanged(object sender, EventArgs e) {
            controller.activateRemBtn(Remove);
        }

        private void RandomFill_Click(object sender, EventArgs e) {
            controller.InsertRandomBuyers();
        }
    }
}
