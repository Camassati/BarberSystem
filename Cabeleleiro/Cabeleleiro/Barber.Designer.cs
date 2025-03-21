namespace Cabeleleiro
{
    partial class Barber
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.sair = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnagendamento = new System.Windows.Forms.Button();
            this.btncad = new System.Windows.Forms.Button();
            this.btnhoje = new System.Windows.Forms.Button();
            this.btnsemana = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Imprint MT Shadow", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(377, 1);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 71);
            this.label1.TabIndex = 1;
            this.label1.Text = "Menu barber";
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.Black;
            this.panel.Location = new System.Drawing.Point(304, 1);
            this.panel.Margin = new System.Windows.Forms.Padding(4);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(789, 649);
            this.panel.TabIndex = 2;
            // 
            // sair
            // 
            this.sair.BackColor = System.Drawing.Color.DarkRed;
            this.sair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.sair.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.sair.FlatAppearance.BorderSize = 2;
            this.sair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sair.Location = new System.Drawing.Point(1018, 1);
            this.sair.Margin = new System.Windows.Forms.Padding(4);
            this.sair.Name = "sair";
            this.sair.Size = new System.Drawing.Size(63, 53);
            this.sair.TabIndex = 3;
            this.sair.Text = "X";
            this.sair.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.sair.UseVisualStyleBackColor = false;
            this.sair.Click += new System.EventHandler(this.sair_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.BackgroundImage = global::Cabeleleiro.Properties.Resources.yct4utgn__1_1;
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(-29, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(343, 678);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btnagendamento, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btncad, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnhoje, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnsemana, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 196);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.84211F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.31579F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.36842F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(325, 380);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // btnagendamento
            // 
            this.btnagendamento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnagendamento.BackColor = System.Drawing.Color.DarkRed;
            this.btnagendamento.FlatAppearance.BorderSize = 0;
            this.btnagendamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnagendamento.Font = new System.Drawing.Font("Dubai Medium", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnagendamento.ForeColor = System.Drawing.Color.Snow;
            this.btnagendamento.Location = new System.Drawing.Point(34, 241);
            this.btnagendamento.Margin = new System.Windows.Forms.Padding(4);
            this.btnagendamento.Name = "btnagendamento";
            this.btnagendamento.Size = new System.Drawing.Size(287, 54);
            this.btnagendamento.TabIndex = 3;
            this.btnagendamento.Text = "Criar Agendamento";
            this.btnagendamento.UseVisualStyleBackColor = false;
            this.btnagendamento.Click += new System.EventHandler(this.btnagendamento_Click);
            // 
            // btncad
            // 
            this.btncad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btncad.BackColor = System.Drawing.Color.DarkRed;
            this.btncad.FlatAppearance.BorderSize = 0;
            this.btncad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncad.Font = new System.Drawing.Font("Dubai Medium", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncad.ForeColor = System.Drawing.Color.Snow;
            this.btncad.Location = new System.Drawing.Point(34, 161);
            this.btncad.Margin = new System.Windows.Forms.Padding(4);
            this.btncad.Name = "btncad";
            this.btncad.Size = new System.Drawing.Size(287, 54);
            this.btncad.TabIndex = 2;
            this.btncad.Text = "Cadastrar Clientes";
            this.btncad.UseVisualStyleBackColor = false;
            this.btncad.Click += new System.EventHandler(this.btncad_Click);
            // 
            // btnhoje
            // 
            this.btnhoje.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnhoje.BackColor = System.Drawing.Color.DarkRed;
            this.btnhoje.FlatAppearance.BorderSize = 0;
            this.btnhoje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnhoje.Font = new System.Drawing.Font("Dubai Medium", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhoje.ForeColor = System.Drawing.Color.Snow;
            this.btnhoje.Location = new System.Drawing.Point(34, 10);
            this.btnhoje.Margin = new System.Windows.Forms.Padding(4);
            this.btnhoje.Name = "btnhoje";
            this.btnhoje.Size = new System.Drawing.Size(287, 54);
            this.btnhoje.TabIndex = 1;
            this.btnhoje.Text = "Agendamentos";
            this.btnhoje.UseVisualStyleBackColor = false;
            this.btnhoje.Click += new System.EventHandler(this.btnhoje_Click);
            // 
            // btnsemana
            // 
            this.btnsemana.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnsemana.BackColor = System.Drawing.Color.DarkRed;
            this.btnsemana.FlatAppearance.BorderSize = 0;
            this.btnsemana.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsemana.Font = new System.Drawing.Font("Dubai Medium", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsemana.ForeColor = System.Drawing.Color.Snow;
            this.btnsemana.Location = new System.Drawing.Point(34, 79);
            this.btnsemana.Margin = new System.Windows.Forms.Padding(4);
            this.btnsemana.Name = "btnsemana";
            this.btnsemana.Size = new System.Drawing.Size(287, 54);
            this.btnsemana.TabIndex = 2;
            this.btnsemana.Text = "Clientes Cadastrados";
            this.btnsemana.UseVisualStyleBackColor = false;
            this.btnsemana.Click += new System.EventHandler(this.btnsemana_Click);
            // 
            // Barber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1093, 644);
            this.Controls.Add(this.sair);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Barber";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Barber";
            this.Load += new System.EventHandler(this.Barber_Load);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnhoje;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btncad;
        private System.Windows.Forms.Button btnsemana;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnagendamento;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button sair;
    }
}