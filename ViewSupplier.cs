using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgentType
{
    public partial class ViewSupplier : Form
    {
        public ViewSupplier()
        {
            InitializeComponent();
        }

        private void ViewSupplier_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "agentTypeDataSet.Supplier". При необходимости она может быть перемещена или удалена.
            this.supplierTableAdapter.Fill(this.agentTypeDataSet.Supplier);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ViewInFormation form5 = new ViewInFormation();
            form5.Show();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
