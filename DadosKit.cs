using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace TP_AED
{
    public partial class DadosKit : Form
    {
        public DadosKit()
        {
            InitializeComponent();
        }

        private void btn_dados_Click(object sender, EventArgs e)
        {
            String connectionString = "database=smartcampusbicicletas;server=localhost;port=3306;user id=root;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand("DadosKit", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            //string idUtilizador = reader["idUtilizador"].ToString();
                            //string message = "ID: " + idUtilizador;
                            //MessageBox.Show(message);
                            txb_idUtilizador.Text = reader["idUtilizador"].ToString();
                            txb_idContrato.Text = reader["idContrato"].ToString();
                            txb_idBicicleta.Text = reader["idBicicleta"].ToString();
                            txb_idCapacete.Text = reader["idCapacete"].ToString();
                            txb_idKitReparacao.Text = reader["idKitReparacao"].ToString();
                            txb_idColete.Text = reader["idColete"].ToString();
                        }
                    }
                }
                connection.Close();
            }
        }
    }    
}
