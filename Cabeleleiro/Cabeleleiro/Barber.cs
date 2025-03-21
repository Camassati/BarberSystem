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
using System.Runtime.InteropServices;

namespace Cabeleleiro
{
    public partial class Barber: Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );
        public Barber()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 40, 40));

            btnhoje.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnhoje.Width, btnhoje.Height, 40, 40));
            btnsemana.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnsemana.Width, btnsemana.Height, 40, 40));
            btncad.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btncad.Width, btncad.Height, 40, 40));
            btnagendamento.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnagendamento.Width, btnagendamento.Height, 40, 40));
            sair.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, sair.Width, sair.Height, 20, 20));






        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conexao = new MySqlConnection("server=cabeleleiro.mysql.dbaas.com.br;uid=cabeleleiro;pwd=Senha4#;database=cabeleleiro;"))
                {
                    conexao.Open();
                    string query = "SELECT * FROM acesso"; // Altere para sua tabela

                    using (MySqlCommand cmd = new MySqlCommand(query, conexao))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                           // dgvdados.DataSource = dt; // Exibe os dados no DataGridView
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os dados: " + ex.Message);
            }
        }

        private void Barber_Load(object sender, EventArgs e)
        {

        }

        private void sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btncad_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            cadcliente Frm = new cadcliente();
            Frm.TopLevel = false;
            panel.Controls.Add(Frm);
            Frm.Show();
            label1.Text = "Cadastro Clientes";
        }

        private void sair_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnagendamento_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            criaragendamento Frm = new criaragendamento();
            Frm.TopLevel = false;
            panel.Controls.Add(Frm);
            Frm.Show();
            label1.Text = "Criar Agendamento";

                }

        private void btnhoje_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            viewagendamento Frm = new viewagendamento();
            Frm.TopLevel = false;
            panel.Controls.Add(Frm);
            Frm.Show();
            label1.Text = "Agendamentos";
        }

        private void btnsemana_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            viewcliente Frm = new viewcliente();
            Frm.TopLevel = false;
            panel.Controls.Add(Frm);
            Frm.Show();
            label1.Text = "Clientes Cadastrados";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    }

