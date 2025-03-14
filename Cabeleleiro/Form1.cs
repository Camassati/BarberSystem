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
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var strConexao = "server=acessobarber.mysql.dbaas.com.br; uid=acessobarber; pwd=Senha4#; database=acessobarber;";
            var conexao = new MySqlConnection(strConexao);
            conexao.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = txtusuario.Text;
            string senha = txtsenha.Text;

            if (usuario == "" || senha == "")
            {
                MessageBox.Show("PREENCHA OS CAMPOS FALTANTES!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            
            }else if (ValidarLogin(usuario, senha))
            {
               
                Barber barber = new Barber();
                barber.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login ou Senha incorretos!!!!!!");
            }

        }
        private bool ValidarLogin(string usuario, string senha)
        {
            bool loginValido = false;
            var strConexao = "server=acessobarber.mysql.dbaas.com.br; uid=acessobarber; pwd=Senha4#; database=acessobarber;";
            var conexao = new MySqlConnection(strConexao);
            conexao.Open();
            
            {
                string query = "SELECT COUNT(*) FROM acesso WHERE usuario = @usuario AND senha = @senha";

                using (MySqlCommand cmd = new MySqlCommand(query, conexao))
                {
                    cmd.Parameters.AddWithValue("@usuario", usuario);
                    cmd.Parameters.AddWithValue("@senha", senha); // Para senhas hash, use `password_verify` no MySQL

                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    loginValido = (count > 0);
                }
            }

            return loginValido;
        }

        private void exibir_CheckedChanged(object sender, EventArgs e)
        {
            if (exibir.CheckState == CheckState.Checked)
            {
                txtsenha.UseSystemPasswordChar = false;
            }
            else
            {
                txtsenha.UseSystemPasswordChar = true;
            }
        }

        private void sair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
