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
    public partial class AddPage : Form
    {
        public AddPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddNewMaterialType form3 = new AddNewMaterialType();
            form3.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddMaterial form4 = new AddMaterial();
            form4.Show();
            this.Close();
        }
    }
}
