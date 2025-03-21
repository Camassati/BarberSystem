using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        

        private void ExcluirRegistro(string nome)
        {
            string conexaoString = "server=acessobarber.mysql.dbaas.com.br; uid=acessobarber; pwd=Senha4#; database=acessobarber;";

            using (MySqlConnection conexao = new MySqlConnection(conexaoString))
            {
                try
                {
                    conexao.Open();

                    string query = "DELETE FROM agendamento WHERE nome = @nome";

                    using (MySqlCommand comando = new MySqlCommand(query, conexao))
                    {
                        comando.Parameters.AddWithValue("@nome", nome);
                        int linhasAfetadas = comando.ExecuteNonQuery();

                        if (linhasAfetadas > 0)
                        {
                            MessageBox.Show("Registro excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            
                            conexao.Close();
                        }
                        else
                        {
                            MessageBox.Show("Erro ao excluir o registro.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        


        private void dtagendamento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        
            if (e.RowIndex >= 0) // Garante que não está clicando no cabeçalho
            {
                // Obtém o ID da linha selecionada
                string nome = dtagendamento.Rows[e.RowIndex].Cells["nome"].Value.ToString();

                // Pergunta se deseja excluir o item
                DialogResult resultado = MessageBox.Show("Deseja realmente excluir este cliente?", "Confirmação",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    ExcluirRegistro(nome); // Chama a função para deletar do banco
                }
            }
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
