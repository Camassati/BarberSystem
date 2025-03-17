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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Cabeleleiro
{
    public partial class cadcliente: Form
    {
        public cadcliente()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("server=acessobarber.mysql.dbaas.com.br; uid=acessobarber; pwd=Senha4#; database=acessobarber");
            con.Open();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO cliente (nome, telefone) VALUES (@nome, @telefone)", con);
            
            cmd.Parameters.AddWithValue("@nome", (txtnome.Text));
            cmd.Parameters.AddWithValue("@telefone", (txttelefone.Text));
            cmd.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Cadastrado com Sucesso!!!");
        }

        private void cadcliente_Load(object sender, EventArgs e)
        {

        }
    }
}
