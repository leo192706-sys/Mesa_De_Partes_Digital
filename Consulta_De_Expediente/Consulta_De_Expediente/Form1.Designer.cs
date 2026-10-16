namespace Consulta_De_Expediente
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvExpedientes = new System.Windows.Forms.DataGridView();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSolicitante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipoDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAsunto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnOrdenarCodigo = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblMensajeConsulta = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpedientes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(248, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consulta de Expedientes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(286, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(284, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lista de expedientes registrados en el sistema";
            // 
            // dgvExpedientes
            // 
            this.dgvExpedientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExpedientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigo,
            this.colDni,
            this.ColSolicitante,
            this.colTipoDocumento,
            this.colAsunto});
            this.dgvExpedientes.Location = new System.Drawing.Point(94, 159);
            this.dgvExpedientes.Name = "dgvExpedientes";
            this.dgvExpedientes.RowHeadersWidth = 51;
            this.dgvExpedientes.RowTemplate.Height = 24;
            this.dgvExpedientes.Size = new System.Drawing.Size(680, 170);
            this.dgvExpedientes.TabIndex = 2;
            // 
            // colCodigo
            // 
            this.colCodigo.HeaderText = "Código";
            this.colCodigo.MinimumWidth = 6;
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.Width = 125;
            // 
            // colDni
            // 
            this.colDni.HeaderText = "DNI";
            this.colDni.MinimumWidth = 6;
            this.colDni.Name = "colDni";
            this.colDni.Width = 125;
            // 
            // ColSolicitante
            // 
            this.ColSolicitante.HeaderText = "Solicitante";
            this.ColSolicitante.MinimumWidth = 6;
            this.ColSolicitante.Name = "ColSolicitante";
            this.ColSolicitante.Width = 125;
            // 
            // colTipoDocumento
            // 
            this.colTipoDocumento.HeaderText = "Tipo de Documento";
            this.colTipoDocumento.MinimumWidth = 6;
            this.colTipoDocumento.Name = "colTipoDocumento";
            this.colTipoDocumento.Width = 125;
            // 
            // colAsunto
            // 
            this.colAsunto.HeaderText = "Asunto";
            this.colAsunto.MinimumWidth = 6;
            this.colAsunto.Name = "colAsunto";
            this.colAsunto.Width = 125;
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.Linen;
            this.btnActualizar.Location = new System.Drawing.Point(65, 377);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(168, 69);
            this.btnActualizar.TabIndex = 3;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            // 
            // btnOrdenarCodigo
            // 
            this.btnOrdenarCodigo.BackColor = System.Drawing.Color.FloralWhite;
            this.btnOrdenarCodigo.Location = new System.Drawing.Point(355, 377);
            this.btnOrdenarCodigo.Name = "btnOrdenarCodigo";
            this.btnOrdenarCodigo.Size = new System.Drawing.Size(168, 69);
            this.btnOrdenarCodigo.TabIndex = 4;
            this.btnOrdenarCodigo.Text = "Ordenar por Codigo";
            this.btnOrdenarCodigo.UseVisualStyleBackColor = false;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnSalir.Location = new System.Drawing.Point(628, 377);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(168, 69);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            // 
            // lblMensajeConsulta
            // 
            this.lblMensajeConsulta.AutoSize = true;
            this.lblMensajeConsulta.Location = new System.Drawing.Point(62, 500);
            this.lblMensajeConsulta.Name = "lblMensajeConsulta";
            this.lblMensajeConsulta.Size = new System.Drawing.Size(270, 16);
            this.lblMensajeConsulta.TabIndex = 6;
            this.lblMensajeConsulta.Text = "Aqui se mostraran los mensajes del sistema";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 586);
            this.Controls.Add(this.lblMensajeConsulta);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnOrdenarCodigo);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.dgvExpedientes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpedientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvExpedientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDni;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSolicitante;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipoDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAsunto;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnOrdenarCodigo;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblMensajeConsulta;
    }
}

