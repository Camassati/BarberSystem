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
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 35.75F);
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(336, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 67);
            this.label1.TabIndex = 1;
            this.label1.Text = "Menu Barber";
            // 
            // panel
            // 
            this.panel.Location = new System.Drawing.Point(228, 70);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(544, 429);
            this.panel.TabIndex = 2;
            // 
            // sair
            // 
            this.sair.BackColor = System.Drawing.Color.Red;
            this.sair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.sair.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.sair.FlatAppearance.BorderSize = 2;
            this.sair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sair.Location = new System.Drawing.Point(737, 1);
            this.sair.Name = "sair";
            this.sair.Size = new System.Drawing.Size(47, 43);
            this.sair.TabIndex = 3;
            this.sair.Text = "X";
            this.sair.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.sair.UseVisualStyleBackColor = false;
            this.sair.Click += new System.EventHandler(this.sair_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.BackgroundImage = global::Cabeleleiro.Properties.Resources.panel;
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 510);
            this.panel1.TabIndex = 0;
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 159);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(221, 309);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // btnagendamento
            // 
            this.btnagendamento.BackColor = System.Drawing.Color.Maroon;
            this.btnagendamento.FlatAppearance.BorderSize = 0;
            this.btnagendamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnagendamento.Font = new System.Drawing.Font("Comic Sans MS", 14F);
            this.btnagendamento.Location = new System.Drawing.Point(3, 234);
            this.btnagendamento.Name = "btnagendamento";
            this.btnagendamento.Size = new System.Drawing.Size(215, 44);
            this.btnagendamento.TabIndex = 3;
            this.btnagendamento.Text = "Criar Agendamento";
            this.btnagendamento.UseVisualStyleBackColor = false;
            this.btnagendamento.Click += new System.EventHandler(this.btnagendamento_Click);
            // 
            // btncad
            // 
            this.btncad.BackColor = System.Drawing.Color.Maroon;
            this.btncad.FlatAppearance.BorderSize = 0;
            this.btncad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncad.Font = new System.Drawing.Font("Comic Sans MS", 14F);
            this.btncad.Location = new System.Drawing.Point(3, 157);
            this.btncad.Name = "btncad";
            this.btncad.Size = new System.Drawing.Size(215, 44);
            this.btncad.TabIndex = 2;
            this.btncad.Text = "Cadastro Clientes";
            this.btncad.UseVisualStyleBackColor = false;
            this.btncad.Click += new System.EventHandler(this.btncad_Click);
            // 
            // btnhoje
            // 
            this.btnhoje.BackColor = System.Drawing.Color.Maroon;
            this.btnhoje.FlatAppearance.BorderSize = 0;
            this.btnhoje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnhoje.Font = new System.Drawing.Font("Comic Sans MS", 14F);
            this.btnhoje.Location = new System.Drawing.Point(3, 3);
            this.btnhoje.Name = "btnhoje";
            this.btnhoje.Size = new System.Drawing.Size(215, 44);
            this.btnhoje.TabIndex = 1;
            this.btnhoje.Text = "Agendados de Hoje";
            this.btnhoje.UseVisualStyleBackColor = false;
            this.btnhoje.Click += new System.EventHandler(this.btnhoje_Click);
            // 
            // btnsemana
            // 
            this.btnsemana.BackColor = System.Drawing.Color.Maroon;
            this.btnsemana.FlatAppearance.BorderSize = 0;
            this.btnsemana.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsemana.Font = new System.Drawing.Font("Comic Sans MS", 14F);
            this.btnsemana.Location = new System.Drawing.Point(3, 80);
            this.btnsemana.Name = "btnsemana";
            this.btnsemana.Size = new System.Drawing.Size(215, 44);
            this.btnsemana.TabIndex = 2;
            this.btnsemana.Text = "Agendados Semana";
            this.btnsemana.UseVisualStyleBackColor = false;
            // 
            // Barber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 511);
            this.Controls.Add(this.sair);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
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