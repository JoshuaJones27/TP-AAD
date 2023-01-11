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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace TP_AED
{
    public partial class NovoUtilizador : Form
    {
        public NovoUtilizador()
        {
            InitializeComponent();
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            string nome = txb_nome.Text.Trim();
            string sobrenome = txb_sobrenome.Text.Trim();
            string sidTipoUtilizador = txb_tipoUtilizador.Text.Trim();
            string dataNascimento = txb_dataNascimento.Text.Trim();
            string curso = txb_curso.Text.Trim();
            string snif = txb_nif.Text.Trim();
            string nomeUtilizador = txb_nomeUtilizador.Text.Trim();
            string palavraPasse = txb_palavraPasse.Text.Trim();

            String connectionString = "database=smartcampusbicicletas;server=localhost;port=3306;user id=root;";
            MySqlConnection conn = new MySqlConnection(connectionString);


            int nif,idTipoUtilizador;

            if (Int32.TryParse(sidTipoUtilizador, out idTipoUtilizador) == false)
            {
                MessageBox.Show("So pode usar numeros inteiros no ID Tipo Utilizador!");
                return;
            }
            if (Int32.TryParse(snif, out nif) == false)
            {
                MessageBox.Show("So pode usar numeros inteiros no NIF!");
                return;
            }

            try
            {
                conn.Open();
                String sql = "INSERT INTO utilizador (nome, sobrenome, idTipoUtilizador, dataNascimento, curso, nif, nomeUtilizador, palavraPasse) VALUES (@nome, @sobrenome, @idTipoUtilizador, @dataNascimento, @curso, @nif, @nomeUtilizador, @palavraPasse)";

                MySqlCommand command = new MySqlCommand(sql, conn);
                command.Parameters.AddWithValue("@nome", nome);
                command.Parameters.AddWithValue("@sobrenome", sobrenome);
                command.Parameters.AddWithValue("@idTipoUtilizador", sidTipoUtilizador);
                command.Parameters.AddWithValue("@dataNascimento", dataNascimento);
                command.Parameters.AddWithValue("@curso", curso);
                command.Parameters.AddWithValue("@nif", snif);
                command.Parameters.AddWithValue("@nomeUtilizador", nomeUtilizador);
                command.Parameters.AddWithValue("@palavraPasse", palavraPasse);

                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Utilizador Criado com Sucesso!");
                }
                catch (Exception es)
                {
                    MessageBox.Show(es.Message);
                }
                finally
                {
                    conn.Close();
                    Login login = new Login();
                    login.Show();
                    this.Hide();
                }

            }

            catch (Exception es)
            {

                MessageBox.Show(es.Message);
            }
        }

        private void btn_leave_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
            this.Hide();
        }
    }
}
