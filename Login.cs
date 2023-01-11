using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace TP_AED
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_btn_click_Click(object sender, EventArgs e)
        {
            bool failed = false;
            string nomeUtilizador = txb_utilizador.Text.Trim();
            string palavraPasse = txb_palavraPasse.Text.Trim();

            String connectionString = "database=smartcampusbicicletas;server=localhost;port=3306;user id=root;";
            MySqlConnection conn = new MySqlConnection(connectionString);

            try
            {
                conn.Open();
                string sql = "SELECT * FROM utilizador WHERE nomeUtilizador=@nomeUtilizador AND palavraPasse=@palavraPasse";

                MySqlCommand command = new MySqlCommand(sql, conn);
                command.Parameters.AddWithValue("@nomeUtilizador", txb_utilizador.Text);
                command.Parameters.AddWithValue("@palavraPasse", txb_palavraPasse.Text);

                MySqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while(reader.Read())
                    {
                        int nif = (int)reader["nif"];
                        MessageBox.Show("Acesso Permitido");
                        User userForm = new User(nif);
                        userForm.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Acesso Negado");
                }
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }

            conn.Close();
        }
        
        private void btn_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_registar_Click(object sender, EventArgs e)
        {
            NovoUtilizador novoUtilizadorForm = new NovoUtilizador();
            novoUtilizadorForm.Show();
            this.Hide();
        }
    }
}
