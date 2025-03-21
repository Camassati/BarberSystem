using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
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

                        con.Close();



                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro" + ex.Message);
                }


            }
        }

        private void dtcliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica se o clique não foi no cabeçalho
            if (e.RowIndex >= 0)
            {
                // Obtém a linha selecionada
                DataGridViewRow row = dtcliente.Rows[e.RowIndex];

                // Preenche as TextBox com os valores da linha
                txtid.Text = row.Cells["id"].Value.ToString();
                txtnome.Text = row.Cells["nome"].Value.ToString();
                txttel.Text = row.Cells["telefone"].Value.ToString();
            }
        }

        private void viewcliente_Load(object sender, EventArgs e)
        {
            try
            {
                ;

                var sql = "SELECT id, nome, telefone FROM cliente";
                using (MySqlDataAdapter da = new MySqlDataAdapter(sql, con))
                {
                    con.Open();
                    using (DataTable dt = new DataTable())
                    {
                        da.Fill(dt);
                        dtcliente.DataSource = dt;
                    }

                    con.Close();



                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro" + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("server=acessobarber.mysql.dbaas.com.br; uid=acessobarber; pwd=Senha4#; database=acessobarber");
            con.Open();
            MySqlCommand cmd = new MySqlCommand("UPDATE cliente set nome=@nome, telefone=@telefone where id=@id", con);

            cmd.Parameters.AddWithValue("@id", (txtid.Text));
            cmd.Parameters.AddWithValue("@nome", (txtnome.Text));
            cmd.Parameters.AddWithValue("@telefone", (txttel.Text));
            

            cmd.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Atualizado com Sucesso!!!");

            txtid.Text = ("");
            txtnome.Text = ("");
            txttel.Text = ("");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

