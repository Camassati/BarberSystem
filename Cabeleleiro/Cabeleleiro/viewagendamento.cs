using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cabeleleiro
{
    public partial class viewagendamento: Form
    {
        public viewagendamento()
        {
            InitializeComponent();
        }

        MySqlConnection con = new MySqlConnection("server=acessobarber.mysql.dbaas.com.br; uid=acessobarber; pwd=Senha4#; database=acessobarber");


        private void button1_Click(object sender, EventArgs e)
        {
            


        }

        private void dtagendamento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void viewagendamento_Load(object sender, EventArgs e)
        {
            try
            {
                ;

                var sql = "SELECT nome, telefone, data, horario, corte FROM agendamento";
                using (MySqlDataAdapter da = new MySqlDataAdapter(sql, con))
                {
                    con.Open();
                    using (DataTable dt = new DataTable())
                    {
                        da.Fill(dt);
                        dtagendamento.DataSource = dt;
                    }

                    con.Close();



                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro" + ex.Message);
            }
        }

        private void datafiltro_ValueChanged(object sender, EventArgs e)
        {
            try
            {


                var sql = "SELECT nome, telefone, data, horario, corte FROM agendamento WHERE data = '" + datafiltro.Text + "'";
                using (MySqlDataAdapter da = new MySqlDataAdapter(sql, con))
                {
                    con.Open();
                    using (DataTable dt = new DataTable())
                    {
                        da.Fill(dt);
                        dtagendamento.DataSource = dt;
                    }

                    con.Close();



                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro" + ex.Message);

            }
        }
    }
}
