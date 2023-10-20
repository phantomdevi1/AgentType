using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AgentType
{
    public partial class AddNewMaterialType : Form
    {
        
        private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=AgentType; Integrated Security=True";

        public AddNewMaterialType()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string typeMaterial = TypeMaterialTextBox.Text;
            string procentBadText = ProcentBad.Text;
            if (!int.TryParse(procentBadText, out int procentBad) || procentBad <= 0 || procentBad >= 100)
            {
                MessageBox.Show("Введите корректный процент брака (значение должно быть целым числом от 1 до 99).");
                return;
            }



            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                
                string query = "INSERT INTO MaterialType (Title, DefectedPercent) VALUES (@TypeMaterial, @ProcentBad)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    
                    command.Parameters.AddWithValue("@TypeMaterial", typeMaterial);
                    command.Parameters.AddWithValue("@ProcentBad", procentBadText);

                    try
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("Данные успешно добавлены в базу данных.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка при добавлении данных: " + ex.Message);
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddPage form2 = new AddPage();
            form2.Show();
            this.Hide();
        }

        private void AddNewMaterialType_Load(object sender, EventArgs e)
        {

        }
    }
}
