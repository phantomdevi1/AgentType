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
    public partial class ViewMaterial : Form
    {
        public ViewMaterial()
        {
            InitializeComponent();
        }

        private void ViewMaterial_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "agentTypeDataSet1.Material". При необходимости она может быть перемещена или удалена.
            this.materialTableAdapter.Fill(this.agentTypeDataSet1.Material);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ViewInFormation form5 = new ViewInFormation();
            form5.Show();
            this.Close();
        }
    }
}
