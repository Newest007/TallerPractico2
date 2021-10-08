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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtconsult = new System.Windows.Forms.TextBox();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NuevaVenta = new System.Windows.Forms.TabPage();
            this.labelbienvenida = new System.Windows.Forms.Label();
            this.btnacceder = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtcomprar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.Consultstorage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.NuevaVenta.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(636, 445);
            this.btnsalir.Margin = new System.Windows.Forms.Padding(8, 12, 8, 12);
            this.btnsalir.Size = new System.Drawing.Size(85, 46);
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.NuevaVenta);
            this.tabControl1.Controls.Add(this.Consultstorage);
            this.tabControl1.Location = new System.Drawing.Point(18, 34);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(609, 463);
            this.tabControl1.TabIndex = 1;
            // 
            // Consultstorage
            // 
            this.Consultstorage.Controls.Add(this.btnacceder);
            this.Consultstorage.Controls.Add(this.dataGridView1);
            this.Consultstorage.Controls.Add(this.txtconsult);
            this.Consultstorage.Controls.Add(this.btnbuscar);
            this.Consultstorage.Controls.Add(this.label2);
            this.Consultstorage.Controls.Add(this.label1);
            this.Consultstorage.Location = new System.Drawing.Point(4, 35);
            this.Consultstorage.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Consultstorage.Name = "Consultstorage";
            this.Consultstorage.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Consultstorage.Size = new System.Drawing.Size(601, 375);
            this.Consultstorage.TabIndex = 1;
            this.Consultstorage.Text = "Consultar inventarios";
            this.Consultstorage.UseVisualStyleBackColor = true;
            this.Consultstorage.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(43, 129);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(523, 192);
            this.dataGridView1.TabIndex = 4;
            // 
            // txtconsult
            // 
            this.txtconsult.Location = new System.Drawing.Point(221, 81);
            this.txtconsult.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtconsult.Name = "txtconsult";
            this.txtconsult.Size = new System.Drawing.Size(147, 34);
            this.txtconsult.TabIndex = 3;
            this.txtconsult.TextChanged += new System.EventHandler(this.txtconsult_TextChanged);
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(808, 64);
            this.btnbuscar.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(125, 46);
            this.btnbuscar.TabIndex = 2;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre o código:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(511, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "*Introduzca el nombre o código del producto que desea consultar:";
            // 
            // NuevaVenta
            // 
            this.NuevaVenta.Controls.Add(this.label18);
            this.NuevaVenta.Controls.Add(this.label17);
            this.NuevaVenta.Controls.Add(this.label16);
            this.NuevaVenta.Controls.Add(this.label15);
            this.NuevaVenta.Controls.Add(this.label14);
            this.NuevaVenta.Controls.Add(this.label12);
            this.NuevaVenta.Controls.Add(this.label11);
            this.NuevaVenta.Controls.Add(this.label10);
            this.NuevaVenta.Controls.Add(this.label9);
            this.NuevaVenta.Controls.Add(this.label8);
            this.NuevaVenta.Controls.Add(this.button1);
            this.NuevaVenta.Controls.Add(this.label7);
            this.NuevaVenta.Controls.Add(this.label6);
            this.NuevaVenta.Controls.Add(this.txtcomprar);
            this.NuevaVenta.Controls.Add(this.label5);
            this.NuevaVenta.Controls.Add(this.label4);
            this.NuevaVenta.Controls.Add(this.label3);
            this.NuevaVenta.Controls.Add(this.label13);
            this.NuevaVenta.Location = new System.Drawing.Point(4, 35);
            this.NuevaVenta.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.NuevaVenta.Name = "NuevaVenta";
            this.NuevaVenta.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.NuevaVenta.Size = new System.Drawing.Size(601, 424);
            this.NuevaVenta.TabIndex = 0;
            this.NuevaVenta.Text = "Venta nueva";
            this.NuevaVenta.UseVisualStyleBackColor = true;
            // 
            // labelbienvenida
            // 
            this.labelbienvenida.AutoSize = true;
            this.labelbienvenida.Location = new System.Drawing.Point(596, 9);
            this.labelbienvenida.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelbienvenida.Name = "labelbienvenida";
            this.labelbienvenida.Size = new System.Drawing.Size(57, 26);
            this.labelbienvenida.TabIndex = 2;
            this.labelbienvenida.Text = "label1";
            this.labelbienvenida.Click += new System.EventHandler(this.labelbienvenida_Click);
            // 
            // btnacceder
            // 
            this.btnacceder.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnacceder.Location = new System.Drawing.Point(400, 77);
            this.btnacceder.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnacceder.Name = "btnacceder";
            this.btnacceder.Size = new System.Drawing.Size(118, 40);
            this.btnacceder.TabIndex = 8;
            this.btnacceder.Text = "Buscar";
            this.btnacceder.UseVisualStyleBackColor = true;
            this.btnacceder.Click += new System.EventHandler(this.btnacceder_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(383, 70);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 26);
            this.label10.TabIndex = 23;
            this.label10.Text = "$0.10";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(276, 99);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 26);
            this.label9.TabIndex = 22;
            this.label9.Text = "Pollos";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(276, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 26);
            this.label8.TabIndex = 21;
            this.label8.Text = "Huevos";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(255, 368);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 40);
            this.button1.TabIndex = 20;
            this.button1.Text = "Comprar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(198, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 26);
            this.label7.TabIndex = 19;
            this.label7.Text = "2.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(198, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 26);
            this.label6.TabIndex = 18;
            this.label6.Text = "1.";
            // 
            // txtcomprar
            // 
            this.txtcomprar.Location = new System.Drawing.Point(206, 315);
            this.txtcomprar.Name = "txtcomprar";
            this.txtcomprar.Size = new System.Drawing.Size(201, 34);
            this.txtcomprar.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(184, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(256, 26);
            this.label5.TabIndex = 16;
            this.label5.Text = "Introducir productos a comprar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(362, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 26);
            this.label4.TabIndex = 15;
            this.label4.Text = "Precio c/u";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(260, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 26);
            this.label3.TabIndex = 14;
            this.label3.Text = "Producto";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(160, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 26);
            this.label13.TabIndex = 13;
            this.label13.Text = "Código";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(383, 99);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 26);
            this.label11.TabIndex = 24;
            this.label11.Text = "$5.00";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(198, 129);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(27, 26);
            this.label12.TabIndex = 25;
            this.label12.Text = "3.";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(276, 129);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 26);
            this.label14.TabIndex = 26;
            this.label14.Text = "Aceite";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(383, 129);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(57, 26);
            this.label15.TabIndex = 27;
            this.label15.Text = "$3.00";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(198, 161);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(27, 26);
            this.label16.TabIndex = 28;
            this.label16.Text = "4.";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(271, 161);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(71, 26);
            this.label17.TabIndex = 29;
            this.label17.Text = "Fósforos";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(383, 161);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(57, 26);
            this.label18.TabIndex = 30;
            this.label18.Text = "$0.50";
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 26F);
            this.ClientSize = new System.Drawing.Size(738, 512);
            this.Controls.Add(this.labelbienvenida);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(8, 12, 8, 12);
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMenu_FormClosed);
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.Controls.SetChildIndex(this.tabControl1, 0);
            this.Controls.SetChildIndex(this.btnsalir, 0);
            this.Controls.SetChildIndex(this.labelbienvenida, 0);
            this.tabControl1.ResumeLayout(false);
            this.Consultstorage.ResumeLayout(false);
            this.Consultstorage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.NuevaVenta.ResumeLayout(false);
            this.NuevaVenta.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Consultstorage;
        private System.Windows.Forms.TabPage NuevaVenta;
        private System.Windows.Forms.Label labelbienvenida;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtconsult;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnacceder;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtcomprar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
    }
}
