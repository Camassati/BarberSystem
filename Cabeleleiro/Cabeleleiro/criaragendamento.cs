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
            // Conexão com o banco
            MySqlConnection con = new MySqlConnection("server=acessobarber.mysql.dbaas.com.br; uid=acessobarber; pwd=Senha4#; database=acessobarber");

            try
            {
                con.Open();

                // Verifica se já existe um agendamento com a mesma data e horário
                string verificaQuery = "SELECT COUNT(*) FROM agendamento WHERE data = @data AND horario = @horario";
                MySqlCommand verificaCmd = new MySqlCommand(verificaQuery, con);
                verificaCmd.Parameters.AddWithValue("@data", dateTimePicker1.Text);
                verificaCmd.Parameters.AddWithValue("@horario", combohorario.Text);

                int existe = Convert.ToInt32(verificaCmd.ExecuteScalar()); // Obtém o número de registros encontrados

                if (existe > 0)
                {
                    MessageBox.Show("Não foi possível cadastrar! Já existe um cliente agendado neste horário.", "Horário Indisponível", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    // Insere o novo agendamento
                    string query = "INSERT INTO agendamento (nome, horario, preco, telefone, corte, data) VALUES (@nome, @horario, @preco, @telefone, @corte, @data)";
                    MySqlCommand cmd = new MySqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@nome", comboname.Text);
                    cmd.Parameters.AddWithValue("@horario", combohorario.Text);
                    cmd.Parameters.AddWithValue("@telefone", tel.Text);
                    cmd.Parameters.AddWithValue("@corte", comboservico.Text);
                    cmd.Parameters.AddWithValue("@data", dateTimePicker1.Text);
                    cmd.Parameters.AddWithValue("@preco", lbpreco.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Cadastrado com Sucesso!!!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Limpa os campos após o cadastro
                    comboname.Text = "";
                    combohorario.Text = "";
                    tel.Text = "";
                    comboservico.Text = "";
                    lbpreco.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro ao Cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }


        }

        private void criaragendamento_Load(object sender, EventArgs e)
        {
            comboname.Text = "";
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

        private void comboname_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }
    }
}
