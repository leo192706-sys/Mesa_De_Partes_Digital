namespace Menú_Mesa_de_Partes_Digital
{
    partial class Form1
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
            this.lblMenu = new System.Windows.Forms.Label();
            this.btnRegistro = new System.Windows.Forms.Button();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.btnBusqueda = new System.Windows.Forms.Button();
            this.btnSalirSistema = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.Location = new System.Drawing.Point(231, 26);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(404, 32);
            this.lblMenu.TabIndex = 0;
            this.lblMenu.Text = "Menú Mesa de Partes Digital";
            // 
            // btnRegistro
            // 
            this.btnRegistro.BackColor = System.Drawing.Color.AliceBlue;
            this.btnRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistro.Location = new System.Drawing.Point(44, 168);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(306, 62);
            this.btnRegistro.TabIndex = 1;
            this.btnRegistro.Text = "Registro de Expediente";
            this.btnRegistro.UseVisualStyleBackColor = false;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(321, 73);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(236, 18);
            this.lblDescripcion.TabIndex = 2;
            this.lblDescripcion.Text = "Sistema de gestión de expedientes";
            // 
            // btnConsulta
            // 
            this.btnConsulta.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsulta.Location = new System.Drawing.Point(448, 168);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(306, 62);
            this.btnConsulta.TabIndex = 3;
            this.btnConsulta.Text = "Consulta de Expedientes";
            this.btnConsulta.UseVisualStyleBackColor = false;
            // 
            // btnBusqueda
            // 
            this.btnBusqueda.BackColor = System.Drawing.Color.Moccasin;
            this.btnBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBusqueda.Location = new System.Drawing.Point(251, 272);
            this.btnBusqueda.Name = "btnBusqueda";
            this.btnBusqueda.Size = new System.Drawing.Size(306, 62);
            this.btnBusqueda.TabIndex = 4;
            this.btnBusqueda.Text = "Búsqueda de Expediente";
            this.btnBusqueda.UseVisualStyleBackColor = false;
            // 
            // btnSalirSistema
            // 
            this.btnSalirSistema.BackColor = System.Drawing.Color.MistyRose;
            this.btnSalirSistema.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirSistema.Location = new System.Drawing.Point(308, 423);
            this.btnSalirSistema.Name = "btnSalirSistema";
            this.btnSalirSistema.Size = new System.Drawing.Size(195, 85);
            this.btnSalirSistema.TabIndex = 5;
            this.btnSalirSistema.Text = "Salir del Sistema";
            this.btnSalirSistema.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 667);
            this.Controls.Add(this.btnSalirSistema);
            this.Controls.Add(this.btnBusqueda);
            this.Controls.Add(this.btnConsulta);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.btnRegistro);
            this.Controls.Add(this.lblMenu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Button btnRegistro;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.Button btnBusqueda;
        private System.Windows.Forms.Button btnSalirSistema;
    }
}

