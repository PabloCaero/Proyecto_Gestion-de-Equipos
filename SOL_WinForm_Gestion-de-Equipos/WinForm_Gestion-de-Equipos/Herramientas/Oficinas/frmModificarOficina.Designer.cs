
namespace WinForm_Gestion_de_Equipos.Herramientas.Oficinas
{
    partial class frmModificarOficina
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
            this.btnModificar = new System.Windows.Forms.Button();
            this.txtNombreOficina = new System.Windows.Forms.TextBox();
            this.lblNombreOficina = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(134, 52);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(130, 23);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(11, 52);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(117, 23);
            this.btnModificar.TabIndex = 14;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // txtNombreOficina
            // 
            this.txtNombreOficina.Location = new System.Drawing.Point(12, 26);
            this.txtNombreOficina.Name = "txtNombreOficina";
            this.txtNombreOficina.Size = new System.Drawing.Size(252, 20);
            this.txtNombreOficina.TabIndex = 13;
            // 
            // lblNombreOficina
            // 
            this.lblNombreOficina.AutoSize = true;
            this.lblNombreOficina.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreOficina.Location = new System.Drawing.Point(12, 9);
            this.lblNombreOficina.Name = "lblNombreOficina";
            this.lblNombreOficina.Size = new System.Drawing.Size(120, 16);
            this.lblNombreOficina.TabIndex = 12;
            this.lblNombreOficina.Text = "Nombre de Oficina";
            // 
            // frmModificarOficina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(278, 87);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.txtNombreOficina);
            this.Controls.Add(this.lblNombreOficina);
            this.Name = "frmModificarOficina";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Oficina";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.TextBox txtNombreOficina;
        private System.Windows.Forms.Label lblNombreOficina;
    }
}