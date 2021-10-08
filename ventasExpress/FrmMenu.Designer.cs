namespace ventasExpress
{
    partial class FrmMenu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Consultstorage = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.labelbienvenida = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.txtconsult = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.Consultstorage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(540, 246);
            this.btnsalir.Text = "";
            this.btnsalir.Visible = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Consultstorage);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(13, 25);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(615, 272);
            this.tabControl1.TabIndex = 1;
            // 
            // Consultstorage
            // 
            this.Consultstorage.Controls.Add(this.dataGridView1);
            this.Consultstorage.Controls.Add(this.txtconsult);
            this.Consultstorage.Controls.Add(this.btnbuscar);
            this.Consultstorage.Controls.Add(this.label2);
            this.Consultstorage.Controls.Add(this.label1);
            this.Consultstorage.Location = new System.Drawing.Point(4, 22);
            this.Consultstorage.Name = "Consultstorage";
            this.Consultstorage.Padding = new System.Windows.Forms.Padding(3);
            this.Consultstorage.Size = new System.Drawing.Size(607, 246);
            this.Consultstorage.TabIndex = 1;
            this.Consultstorage.Text = "Consultar inventarios";
            this.Consultstorage.UseVisualStyleBackColor = true;
            this.Consultstorage.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(607, 246);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Venta nueva";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(607, 246);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Salir del sistema";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // labelbienvenida
            // 
            this.labelbienvenida.AutoSize = true;
            this.labelbienvenida.Location = new System.Drawing.Point(508, 9);
            this.labelbienvenida.Name = "labelbienvenida";
            this.labelbienvenida.Size = new System.Drawing.Size(35, 13);
            this.labelbienvenida.TabIndex = 2;
            this.labelbienvenida.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "*Introduzca el nombre o código del producto que desea consultar:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre o código:";
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(485, 32);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(75, 23);
            this.btnbuscar.TabIndex = 2;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            // 
            // txtconsult
            // 
            this.txtconsult.Location = new System.Drawing.Point(121, 23);
            this.txtconsult.Name = "txtconsult";
            this.txtconsult.Size = new System.Drawing.Size(220, 20);
            this.txtconsult.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(572, 150);
            this.dataGridView1.TabIndex = 4;
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(627, 309);
            this.Controls.Add(this.labelbienvenida);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmMenu";
            this.Controls.SetChildIndex(this.tabControl1, 0);
            this.Controls.SetChildIndex(this.btnsalir, 0);
            this.Controls.SetChildIndex(this.labelbienvenida, 0);
            this.tabControl1.ResumeLayout(false);
            this.Consultstorage.ResumeLayout(false);
            this.Consultstorage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Consultstorage;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label labelbienvenida;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtconsult;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
