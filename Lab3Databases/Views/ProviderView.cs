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
    public partial class ProviderView : Form {
        Controller controller = new Controller();
        public ProviderView() {
            InitializeComponent();
            upload();
        }

        private void All_Click(object sender, EventArgs e) {
            upload();
        }

        private void upload() {
            using (Context ent = new Context()) {
                ProvidersGrid.DataSource = ent.Provider.ToList();
                ProvidersGrid.Columns[0].Visible = false;
            }
        }

        private void Add_Click(object sender, EventArgs e) {
            ProviderAdd providersAddViewcs = new ProviderAdd();
            providersAddViewcs.Show();
        }

        private void Remove_Click(object sender, EventArgs e) {
            controller.deleteProvider(Int32.Parse((ProvidersGrid.Rows[ProvidersGrid.CurrentRow.Index].Cells[0].Value).ToString()));
            upload();
        }

        private void Update_Click(object sender, EventArgs e) {
            ProvidersUpdView providersUpdView = new ProvidersUpdView(Int32.Parse((ProvidersGrid.Rows[ProvidersGrid.CurrentRow.Index].Cells[0].Value).ToString()),
                (ProvidersGrid.Rows[ProvidersGrid.CurrentRow.Index].Cells[1].Value).ToString(),
                (ProvidersGrid.Rows[ProvidersGrid.CurrentRow.Index].Cells[2].Value).ToString(),
                (ProvidersGrid.Rows[ProvidersGrid.CurrentRow.Index].Cells[3].Value).ToString());
            providersUpdView.Show();
        }

        private void RandomFill_Click(object sender, EventArgs e) {
            controller.InsertRandomProviders();
            upload();
        }

        private void ProvidersGrid_SelectionChanged(object sender, EventArgs e) {
            controller.activateRemBtn(Remove);
        }
    }
}
