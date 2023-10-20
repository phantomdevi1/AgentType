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
    public partial class ViewInFormation : Form
    {
        public ViewInFormation()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ViewSupplier form5 = new ViewSupplier();
            form5.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ViewMaterial form6 = new ViewMaterial();
            form6.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HomeForm form1 = new HomeForm();
            form1.Show();
            this.Close();
        }
    }
}
