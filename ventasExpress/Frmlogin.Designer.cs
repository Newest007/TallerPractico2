namespace ventasExpress
{
    partial class Frmlogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmlogin));
            this.labelacceder = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtlogincontra = new System.Windows.Forms.TextBox();
            this.txtloginusuario = new System.Windows.Forms.TextBox();
            this.btnacceder = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(397, 249);
            this.btnsalir.Size = new System.Drawing.Size(79, 28);
            // 
            // labelacceder
            // 
            this.labelacceder.AutoSize = true;
            this.labelacceder.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelacceder.Location = new System.Drawing.Point(188, 18);
            this.labelacceder.Name = "labelacceder";
            this.labelacceder.Size = new System.Drawing.Size(98, 25);
            this.labelacceder.TabIndex = 1;
            this.labelacceder.Text = "Acceder";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(103, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bienvenido al sistema de ventas Don Diego";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ingresar usuario:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ingresar contraseña:";
            // 
            // txtlogincontra
            // 
            this.txtlogincontra.Location = new System.Drawing.Point(159, 172);
            this.txtlogincontra.Name = "txtlogincontra";
            this.txtlogincontra.Size = new System.Drawing.Size(248, 20);
            this.txtlogincontra.TabIndex = 5;
            // 
            // txtloginusuario
            // 
            this.txtloginusuario.Location = new System.Drawing.Point(156, 121);
            this.txtloginusuario.Name = "txtloginusuario";
            this.txtloginusuario.Size = new System.Drawing.Size(251, 20);
            this.txtloginusuario.TabIndex = 6;
            // 
            // btnacceder
            // 
            this.btnacceder.Location = new System.Drawing.Point(229, 210);
            this.btnacceder.Name = "btnacceder";
            this.btnacceder.Size = new System.Drawing.Size(100, 38);
            this.btnacceder.TabIndex = 7;
            this.btnacceder.Text = "Iniciar sesión";
            this.btnacceder.UseVisualStyleBackColor = true;
            this.btnacceder.Click += new System.EventHandler(this.btnacceder_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(153, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Favor ingresar credenciales";
            // 
            // Frmlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(490, 289);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnacceder);
            this.Controls.Add(this.txtloginusuario);
            this.Controls.Add(this.txtlogincontra);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelacceder);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frmlogin";
            this.Text = "Taller practico #2";
            this.Load += new System.EventHandler(this.Frmlogin_Load);
            this.Controls.SetChildIndex(this.btnsalir, 0);
            this.Controls.SetChildIndex(this.labelacceder, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtlogincontra, 0);
            this.Controls.SetChildIndex(this.txtloginusuario, 0);
            this.Controls.SetChildIndex(this.btnacceder, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelacceder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtlogincontra;
        private System.Windows.Forms.TextBox txtloginusuario;
        private System.Windows.Forms.Button btnacceder;
        private System.Windows.Forms.Label label4;
    }
}
