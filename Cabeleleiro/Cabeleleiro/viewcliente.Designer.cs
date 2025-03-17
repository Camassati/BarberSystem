namespace Cabeleleiro
{
    partial class viewcliente
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
            this.btclientes = new System.Windows.Forms.Button();
            this.dtcliente = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtcliente)).BeginInit();
            this.SuspendLayout();
            // 
            // btclientes
            // 
            this.btclientes.Location = new System.Drawing.Point(233, 6);
            this.btclientes.Name = "btclientes";
            this.btclientes.Size = new System.Drawing.Size(84, 23);
            this.btclientes.TabIndex = 3;
            this.btclientes.Text = "button1";
            this.btclientes.UseVisualStyleBackColor = true;
            this.btclientes.Click += new System.EventHandler(this.btclientes_Click);
            // 
            // dtcliente
            // 
            this.dtcliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtcliente.Location = new System.Drawing.Point(7, 35);
            this.dtcliente.Name = "dtcliente";
            this.dtcliente.Size = new System.Drawing.Size(509, 343);
            this.dtcliente.TabIndex = 2;
            // 
            // viewcliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 390);
            this.Controls.Add(this.btclientes);
            this.Controls.Add(this.dtcliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "viewcliente";
            this.Text = "viewcliente";
            ((System.ComponentModel.ISupportInitialize)(this.dtcliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btclientes;
        private System.Windows.Forms.DataGridView dtcliente;
    }
}