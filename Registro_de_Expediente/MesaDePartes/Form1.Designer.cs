namespace MesaDePartes
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblDni = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.cbmTipo = new System.Windows.Forms.ComboBox();
            this.lblAsunto = new System.Windows.Forms.Label();
            this.txtAsunto = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(305, 27);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(332, 32);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Registro de Expediente";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(78, 85);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(156, 18);
            this.lblCodigo.TabIndex = 1;
            this.lblCodigo.Text = "Código de Expediente:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(78, 172);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(150, 16);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre del Ciudadano:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(254, 85);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(251, 22);
            this.txtCodigo.TabIndex = 3;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(81, 209);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(673, 22);
            this.txtNombre.TabIndex = 4;
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(78, 132);
            this.lblDni.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(33, 16);
            this.lblDni.TabIndex = 5;
            this.lblDni.Text = "DNI:";
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(134, 132);
            this.txtDni.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(251, 22);
            this.txtDni.TabIndex = 6;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(81, 253);
            this.lblTipo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(129, 16);
            this.lblTipo.TabIndex = 7;
            this.lblTipo.Text = "Tipo de Documento:";
            // 
            // cbmTipo
            // 
            this.cbmTipo.FormattingEnabled = true;
            this.cbmTipo.Location = new System.Drawing.Point(254, 253);
            this.cbmTipo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbmTipo.Name = "cbmTipo";
            this.cbmTipo.Size = new System.Drawing.Size(241, 24);
            this.cbmTipo.TabIndex = 8;
            // 
            // lblAsunto
            // 
            this.lblAsunto.AutoSize = true;
            this.lblAsunto.Location = new System.Drawing.Point(81, 301);
            this.lblAsunto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAsunto.Name = "lblAsunto";
            this.lblAsunto.Size = new System.Drawing.Size(122, 16);
            this.lblAsunto.TabIndex = 9;
            this.lblAsunto.Text = "Asunto del Trámite:";
            // 
            // txtAsunto
            // 
            this.txtAsunto.Location = new System.Drawing.Point(84, 335);
            this.txtAsunto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAsunto.Multiline = true;
            this.txtAsunto.Name = "txtAsunto";
            this.txtAsunto.Size = new System.Drawing.Size(759, 118);
            this.txtAsunto.TabIndex = 10;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(85, 480);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(136, 16);
            this.lblFecha.TabIndex = 11;
            this.lblFecha.Text = "Fecha de Recepción:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(254, 493);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(265, 22);
            this.dtpFecha.TabIndex = 12;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRegistrar.Location = new System.Drawing.Point(88, 574);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(201, 73);
            this.btnRegistrar.TabIndex = 13;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.btnLimpiar.Location = new System.Drawing.Point(384, 574);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(201, 73);
            this.btnLimpiar.TabIndex = 14;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.RosyBrown;
            this.btnCerrar.Location = new System.Drawing.Point(685, 574);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(201, 73);
            this.btnCerrar.TabIndex = 15;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 689);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.txtAsunto);
            this.Controls.Add(this.lblAsunto);
            this.Controls.Add(this.cbmTipo);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblTitulo);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox cbmTipo;
        private System.Windows.Forms.Label lblAsunto;
        private System.Windows.Forms.TextBox txtAsunto;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCerrar;
    }
}

