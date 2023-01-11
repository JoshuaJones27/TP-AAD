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
    public partial class User : Form
    {
        public User(int nif)
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String connectionString = "database=smartcampusbicicletas;server=localhost;port=3306;user id=root;";
            MySqlConnection conn = new MySqlConnection(connectionString);

            try
            {
                conn.Open();
                string sql = "SELECT * FROM utilizador WHERE nif=@nif";
                MySqlCommand command = new MySqlCommand(sql, conn);
                MySqlDataReader reader = command.ExecuteReader();
                while(reader.Read())
                {
                    
                }

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
