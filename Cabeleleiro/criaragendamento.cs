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

namespace Cabeleleiro
{
    public partial class criaragendamento: Form
    {
        public criaragendamento()
        {
            InitializeComponent();
            combonome();
        }
        MySqlConnection con = new MySqlConnection("server=acessobarber.mysql.dbaas.com.br; uid=acessobarber; pwd=Senha4#; database=acessobarber");

        void combonome()
        {
            try
            {
                string cbnome = "select * from cliente";
                MySqlCommand cmdsalvar = new MySqlCommand(cbnome, con);
                con.Open();
                DataSet ds = new DataSet();
                MySqlDataAdapter adpt = new MySqlDataAdapter(cmdsalvar);
                adpt.Fill(ds);
                comboname.DataSource = ds.Tables[0];
                comboname.DisplayMember = "nome";
                comboname.ValueMember = "id";

                con.Close();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("server=acessobarber.mysql.dbaas.com.br; uid=acessobarber; pwd=Senha4#; database=acessobarber");
            con.Open();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO agendamento (nome, horario, preco, telefone,corte,data) VALUES (@nome, @horario, @preco,@telefone,@corte,@data)", con);

            cmd.Parameters.AddWithValue("@nome", (comboname.Text));
            cmd.Parameters.AddWithValue("@horario", (combohorario.Text));
            cmd.Parameters.AddWithValue("@telefone", (tel.Text));
            cmd.Parameters.AddWithValue("@corte", (comboservico.Text));
            cmd.Parameters.AddWithValue("@data", (dateTimePicker1.Text));
            cmd.Parameters.AddWithValue("@preco", (lbpreco.Text));

            cmd.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Cadastrado com Sucesso!!!");
        }

        private void criaragendamento_Load(object sender, EventArgs e)
        {

        }

        private void lbpreco_Click(object sender, EventArgs e)
        {
            
        }

        private void comboservico_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = comboservico.SelectedItem.ToString();

            if (selectedValue == "Cabelo")
            {
                lbpreco.Text = "30.00";
            }
            else if (selectedValue == "Opção 2")
            {
                lbpreco.Text = "40";
            }
            else
            {
                lbpreco.Text = "50";
            }
        }
    }
}
