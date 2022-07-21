
namespace WinForm_Gestion_de_Equipos.Herramientas.Oficinas
{
    partial class frmAltaOficina
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtNombreOficina = new System.Windows.Forms.TextBox();
            this.lblNombreOficina = new System.Windows.Forms.Label();
            this.txtNumeroOficina = new System.Windows.Forms.TextBox();
            this.lblNumeroOficina = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(134, 77);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(130, 23);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(11, 77);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(117, 23);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtNombreOficina
            // 
            this.txtNombreOficina.Location = new System.Drawing.Point(12, 51);
            this.txtNombreOficina.Name = "txtNombreOficina";
            this.txtNombreOficina.Size = new System.Drawing.Size(252, 20);
            this.txtNombreOficina.TabIndex = 9;
            // 
            // lblNombreOficina
            // 
            this.lblNombreOficina.AutoSize = true;
            this.lblNombreOficina.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreOficina.Location = new System.Drawing.Point(12, 34);
            this.lblNombreOficina.Name = "lblNombreOficina";
            this.lblNombreOficina.Size = new System.Drawing.Size(134, 16);
            this.lblNombreOficina.TabIndex = 8;
            this.lblNombreOficina.Text = "Nombre de la Oficina";
            // 
            // txtNumeroOficina
            // 
            this.txtNumeroOficina.Location = new System.Drawing.Point(103, 8);
            this.txtNumeroOficina.Name = "txtNumeroOficina";
            this.txtNumeroOficina.Size = new System.Drawing.Size(161, 20);
            this.txtNumeroOficina.TabIndex = 13;
            // 
            // lblNumeroOficina
            // 
            this.lblNumeroOficina.AutoSize = true;
            this.lblNumeroOficina.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroOficina.Location = new System.Drawing.Point(12, 9);
            this.lblNumeroOficina.Name = "lblNumeroOficina";
            this.lblNumeroOficina.Size = new System.Drawing.Size(85, 16);
            this.lblNumeroOficina.TabIndex = 12;
            this.lblNumeroOficina.Text = "N° de Oficina";
            // 
            // frmAltaOficina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(278, 107);
            this.Controls.Add(this.txtNumeroOficina);
            this.Controls.Add(this.lblNumeroOficina);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtNombreOficina);
            this.Controls.Add(this.lblNombreOficina);
            this.Name = "frmAltaOficina";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cargar Nueva Oficina";
            this.Load += new System.EventHandler(this.frmAltaOficina_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtNombreOficina;
        private System.Windows.Forms.Label lblNombreOficina;
        private System.Windows.Forms.TextBox txtNumeroOficina;
        private System.Windows.Forms.Label lblNumeroOficina;
    }
}