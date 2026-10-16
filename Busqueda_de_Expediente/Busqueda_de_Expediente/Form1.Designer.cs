namespace Busqueda_de_Expediente
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.grpResultado = new System.Windows.Forms.GroupBox();
            this.lblResultadoCodigo = new System.Windows.Forms.Label();
            this.lblResultadoDni = new System.Windows.Forms.Label();
            this.lblResultadoNombre = new System.Windows.Forms.Label();
            this.lblResultadoTipo = new System.Windows.Forms.Label();
            this.lblResultadoAsunto = new System.Windows.Forms.Label();
            this.lblMensajeDeBusqueda = new System.Windows.Forms.Label();
            this.grpResultado.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(229, 29);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(355, 32);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Busqueda de Expediente";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(71, 99);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(144, 16);
            this.lblCodigo.TabIndex = 1;
            this.lblCodigo.Text = "Codigo de Expediente:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(74, 127);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(316, 22);
            this.txtCodigo.TabIndex = 2;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Bisque;
            this.btnBuscar.Location = new System.Drawing.Point(64, 192);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(153, 51);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnLimpiar.Location = new System.Drawing.Point(345, 192);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(153, 51);
            this.btnLimpiar.TabIndex = 4;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Khaki;
            this.btnSalir.Location = new System.Drawing.Point(616, 192);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(153, 51);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            // 
            // grpResultado
            // 
            this.grpResultado.Controls.Add(this.lblResultadoAsunto);
            this.grpResultado.Controls.Add(this.lblResultadoTipo);
            this.grpResultado.Controls.Add(this.lblResultadoNombre);
            this.grpResultado.Controls.Add(this.lblResultadoDni);
            this.grpResultado.Controls.Add(this.lblResultadoCodigo);
            this.grpResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpResultado.Location = new System.Drawing.Point(64, 290);
            this.grpResultado.Name = "grpResultado";
            this.grpResultado.Size = new System.Drawing.Size(717, 378);
            this.grpResultado.TabIndex = 6;
            this.grpResultado.TabStop = false;
            this.grpResultado.Text = "Resultado de Busqueda";
            // 
            // lblResultadoCodigo
            // 
            this.lblResultadoCodigo.AutoSize = true;
            this.lblResultadoCodigo.Location = new System.Drawing.Point(55, 44);
            this.lblResultadoCodigo.Name = "lblResultadoCodigo";
            this.lblResultadoCodigo.Size = new System.Drawing.Size(73, 20);
            this.lblResultadoCodigo.TabIndex = 0;
            this.lblResultadoCodigo.Text = "Codigo:";
            // 
            // lblResultadoDni
            // 
            this.lblResultadoDni.AutoSize = true;
            this.lblResultadoDni.Location = new System.Drawing.Point(387, 44);
            this.lblResultadoDni.Name = "lblResultadoDni";
            this.lblResultadoDni.Size = new System.Drawing.Size(47, 20);
            this.lblResultadoDni.TabIndex = 1;
            this.lblResultadoDni.Text = "DNI:";
            // 
            // lblResultadoNombre
            // 
            this.lblResultadoNombre.AutoSize = true;
            this.lblResultadoNombre.Location = new System.Drawing.Point(55, 112);
            this.lblResultadoNombre.Name = "lblResultadoNombre";
            this.lblResultadoNombre.Size = new System.Drawing.Size(104, 20);
            this.lblResultadoNombre.TabIndex = 2;
            this.lblResultadoNombre.Text = "Solicitante:";
            // 
            // lblResultadoTipo
            // 
            this.lblResultadoTipo.AutoSize = true;
            this.lblResultadoTipo.Location = new System.Drawing.Point(55, 173);
            this.lblResultadoTipo.Name = "lblResultadoTipo";
            this.lblResultadoTipo.Size = new System.Drawing.Size(178, 20);
            this.lblResultadoTipo.TabIndex = 3;
            this.lblResultadoTipo.Text = "Tipo de Documento:";
            // 
            // lblResultadoAsunto
            // 
            this.lblResultadoAsunto.AutoSize = true;
            this.lblResultadoAsunto.Location = new System.Drawing.Point(55, 242);
            this.lblResultadoAsunto.Name = "lblResultadoAsunto";
            this.lblResultadoAsunto.Size = new System.Drawing.Size(73, 20);
            this.lblResultadoAsunto.TabIndex = 4;
            this.lblResultadoAsunto.Text = "Asunto:";
            // 
            // lblMensajeDeBusqueda
            // 
            this.lblMensajeDeBusqueda.AutoSize = true;
            this.lblMensajeDeBusqueda.Location = new System.Drawing.Point(112, 675);
            this.lblMensajeDeBusqueda.Name = "lblMensajeDeBusqueda";
            this.lblMensajeDeBusqueda.Size = new System.Drawing.Size(0, 16);
            this.lblMensajeDeBusqueda.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 733);
            this.Controls.Add(this.lblMensajeDeBusqueda);
            this.Controls.Add(this.grpResultado);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpResultado.ResumeLayout(false);
            this.grpResultado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox grpResultado;
        private System.Windows.Forms.Label lblResultadoAsunto;
        private System.Windows.Forms.Label lblResultadoTipo;
        private System.Windows.Forms.Label lblResultadoNombre;
        private System.Windows.Forms.Label lblResultadoDni;
        private System.Windows.Forms.Label lblResultadoCodigo;
        private System.Windows.Forms.Label lblMensajeDeBusqueda;
    }
}

