namespace Cabeleleiro
{
    partial class viewagendamento
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtagendamento = new System.Windows.Forms.DataGridView();
            this.datafiltro = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dtagendamento)).BeginInit();
            this.SuspendLayout();
            // 
            // dtagendamento
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F);
            this.dtagendamento.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtagendamento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtagendamento.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtagendamento.BackgroundColor = System.Drawing.Color.White;
            this.dtagendamento.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtagendamento.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtagendamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtagendamento.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Comic Sans MS", 9.75F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtagendamento.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtagendamento.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtagendamento.Location = new System.Drawing.Point(12, 53);
            this.dtagendamento.MultiSelect = false;
            this.dtagendamento.Name = "dtagendamento";
            this.dtagendamento.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Comic Sans MS", 9.75F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtagendamento.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Comic Sans MS", 9.75F);
            this.dtagendamento.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dtagendamento.Size = new System.Drawing.Size(488, 327);
            this.dtagendamento.TabIndex = 0;
            this.dtagendamento.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtagendamento_CellContentClick);
            // 
            // datafiltro
            // 
            this.datafiltro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datafiltro.Font = new System.Drawing.Font("Comic Sans MS", 10.75F);
            this.datafiltro.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datafiltro.Location = new System.Drawing.Point(165, 12);
            this.datafiltro.Name = "datafiltro";
            this.datafiltro.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.datafiltro.Size = new System.Drawing.Size(149, 27);
            this.datafiltro.TabIndex = 2;
            this.datafiltro.ValueChanged += new System.EventHandler(this.datafiltro_ValueChanged);
            // 
            // viewagendamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Cabeleleiro.Properties.Resources.panel1;
            this.ClientSize = new System.Drawing.Size(516, 390);
            this.Controls.Add(this.datafiltro);
            this.Controls.Add(this.dtagendamento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "viewagendamento";
            this.Text = "viewagendamento";
            this.Load += new System.EventHandler(this.viewagendamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtagendamento)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtagendamento;
        private System.Windows.Forms.DateTimePicker datafiltro;
    }
}