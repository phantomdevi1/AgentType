using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AgentType
{
    public partial class AddMaterial : Form
    {
        public AddMaterial()
        {
            InitializeComponent();
        }    
        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=AgentType; Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string title = TitletextBox1.Text;
                string pack = PacktextBox2.Text;
                string unit = UnittextBox3.Text;
                int countInStock = (int)StocknumericUpDown1.Value;
                int minCount = (int)MinCountnumericUpDown2.Value;
                string description = DescriptiontextBox4.Text;
                decimal cost = CostnumericUpDown3.Value;
                string image = ImgtextBox5.Text;

                int materialTypeID = Convert.ToInt32(MaterialcomboBox1.SelectedValue);
                string query = "INSERT INTO Material (Title, CountInPack, Unit, CountInStock, MinCount, Description, Cost, Image, MaterialTypeID) " +
                               "VALUES (@Title, @CountInPack, @Unit, @CountInStock, @MinCount, @Description, @Cost, @Image, @MaterialTypeID)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Title", title);
                    command.Parameters.AddWithValue("@CountInPack", pack);
                    command.Parameters.AddWithValue("@Unit", unit);
                    command.Parameters.AddWithValue("@CountInStock", countInStock);
                    command.Parameters.AddWithValue("@MinCount", minCount);
                    command.Parameters.AddWithValue("@Description", description);
                    command.Parameters.AddWithValue("@Cost", cost);
                    command.Parameters.AddWithValue("@Image", image);
                    command.Parameters.AddWithValue("@MaterialTypeID", materialTypeID);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Данные успешно добавлены в базу данных.");
                    }
                    else
                    {
                        MessageBox.Show("Произошла ошибка при добавлении данных в базу данных.");
                    }

                }
                
            }
        }

        private void AddMaterial_Load(object sender, EventArgs e)
        {
            StocknumericUpDown1.Maximum = decimal.MaxValue;
            MinCountnumericUpDown2.Maximum = decimal.MaxValue;
            CostnumericUpDown3.Maximum = decimal.MaxValue;

            // TODO: данная строка кода позволяет загрузить данные в таблицу "agentTypeDataSet2.MaterialType". При необходимости она может быть перемещена или удалена.
            this.materialTypeTableAdapter.Fill(this.agentTypeDataSet2.MaterialType);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "agentTypeDataSet1.Material". При необходимости она может быть перемещена или удалена.
            this.materialTableAdapter.Fill(this.agentTypeDataSet1.Material);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddPage form1 = new AddPage();
            form1.Show();
            this.Close();
        }
    }

}
