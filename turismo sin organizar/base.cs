using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ConexionMySQL
{
    public partial class Form1 : Form
    {
        private MySqlConnection connection;
        private string connectionString = "server=SELECT * FROM bd_turismorio3.`turismo rió tercero`;;user id=root;password=root;database=bd_TurismoRio3";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                connection = new MySqlConnection(connectionString);
                connection.Open();

                string query = "SELECT * FROM turismo rió tercero"; // Reemplaza "nombre_de_la_tabla" por el nombre de tu tabla

                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();

                adapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar a la base de datos: " + ex.Message);
            }
        }
    }
}
