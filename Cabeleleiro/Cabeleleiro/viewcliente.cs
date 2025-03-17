using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cabeleleiro
{
    public partial class viewcliente: Form
    {
        public viewcliente()
        {
            InitializeComponent();
        }

        MySqlConnection con = new MySqlConnection("server=acessobarber.mysql.dbaas.com.br; uid=acessobarber; pwd=Senha4#; database=acessobarber");

        private void btclientes_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    con.Open();

                    var sql = "SELECT * FROM cliente";
                    using (MySqlDataAdapter da = new MySqlDataAdapter(sql, con))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            da.Fill(dt);
                            dtcliente.DataSource = dt;
                        }





                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro" + ex.Message);
                }


            }
        }
    }
}
