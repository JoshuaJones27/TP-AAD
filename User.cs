using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace TP_AED
{
    public partial class User : Form
    {
        int nif;

        public User(int Nif)
        {
            InitializeComponent();
            nif = Nif;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String connectionString = "database=smartcampusbicicletas;server=localhost;port=3306;user id=root;";
            MySqlConnection conn = new MySqlConnection(connectionString);

            conn.Open();
            //MessageBox.Show(nif.ToString());
            string sql = "SELECT * FROM utilizador WHERE nif=@nif";
            MySqlCommand command = new MySqlCommand(sql, conn);
            command.Parameters.AddWithValue("@nif", nif);
            MySqlDataReader reader = command.ExecuteReader();

            try
            {
                
                while(reader.Read())
                {
                    txb_nome.Text = reader["nome"].ToString();
                    txb_sobrenome.Text = reader["sobrenome"].ToString();
                    txb_idTipoUtilizador.Text = reader["idTipoUtilizador"].ToString();
                    txb_dataNascimento.Text = reader["dataNascimento"].ToString();
                    txb_curso.Text = reader["curso"].ToString();
                    txb_nif.Text = reader["nif"].ToString();
                    txb_nomeUtilizador.Text = reader["nomeUtilizador"].ToString();
                    txb_palavraPasse.Text = reader["palavraPasse"].ToString();
                }

                conn.Close();
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }

            conn.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
            this.Hide();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            String connectionString = "database=smartcampusbicicletas;server=localhost;port=3306;user id=root;";
            MySqlConnection conn = new MySqlConnection(connectionString);          

            try
            {
                conn.Open();
                string query = "UPDATE utilizador SET nome=@nome, sobrenome=@sobrenome, idTipoUtilizador=@idTipoUtilizador, dataNascimento=@dataNascimento, curso=@curso, nif=@nif, nomeUtilizador=@nomeUtilizador, palavraPasse=@palavraPasse WHERE nif= @nif";

                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@nome", txb_nome.Text);
                command.Parameters.AddWithValue("@sobrenome", txb_sobrenome.Text);
                command.Parameters.AddWithValue("@idTipoUtilizador", txb_idTipoUtilizador.Text);
                command.Parameters.AddWithValue("@dataNascimento", txb_dataNascimento.Text);
                command.Parameters.AddWithValue("@curso", txb_curso.Text);
                command.Parameters.AddWithValue("@nif", txb_nif.Text);
                command.Parameters.AddWithValue("@nomeUtilizador", txb_nomeUtilizador.Text);
                command.Parameters.AddWithValue("@palavraPasse", txb_palavraPasse.Text);


                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Utilizador Editado com Sucesso!");
                }
                catch (Exception es)
                {
                    MessageBox.Show(es.Message);
                }
                finally
                {
                    conn.Close();
                }

            }

            catch (Exception es)
            {

                MessageBox.Show(es.Message);
            }
        }

        private void btn_apagar_Click(object sender, EventArgs e)
        {
            String connectionString = "database=smartcampusbicicletas;server=localhost;port=3306;user id=root;";
            MySqlConnection conn = new MySqlConnection(connectionString);

            conn.Open();
            string sql = "DELETE * FROM utilizador WHERE nif=@nif";
            MySqlCommand command = new MySqlCommand(sql, conn);
            command.Parameters.AddWithValue("@nif", nif);

            try
            {
                command.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }

            conn.Close();

        }
    }

}
