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
    public partial class DeliveryUpdView : Form {
        Controller controller = new Controller();
        public int Id { get; set; }
        public string DateOfOrder { get; set; }
        public string DateOfDel { get; set; }

        public DeliveryUpdView(int id, string or, string del) {
            Id = id;
            DateOfOrder = or;
            DateOfDel = del;
            InitializeComponent();
        }

        private void upd_but_Click(object sender, EventArgs e) {
            controller.updateDelivery(Id, comboBox1.Text, DateOfDel, DateOfOrder);
            this.Close();
        }
    }
}
