
namespace WinForm_Gestion_de_Equipos.Herramientas.Memorias_RAM
{
    partial class frmAltaMemoria
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
            this.txtNombreMemoria = new System.Windows.Forms.TextBox();
            this.lblDescripcionMemoria = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(134, 52);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(130, 23);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(11, 52);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(117, 23);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtNombreMemoria
            // 
            this.txtNombreMemoria.Location = new System.Drawing.Point(12, 26);
            this.txtNombreMemoria.Name = "txtNombreMemoria";
            this.txtNombreMemoria.Size = new System.Drawing.Size(252, 20);
            this.txtNombreMemoria.TabIndex = 9;
            // 
            // lblDescripcionMemoria
            // 
            this.lblDescripcionMemoria.AutoSize = true;
            this.lblDescripcionMemoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionMemoria.Location = new System.Drawing.Point(12, 9);
            this.lblDescripcionMemoria.Name = "lblDescripcionMemoria";
            this.lblDescripcionMemoria.Size = new System.Drawing.Size(169, 16);
            this.lblDescripcionMemoria.TabIndex = 8;
            this.lblDescripcionMemoria.Text = "Descripción de la Memoria";
            // 
            // frmAltaMemoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(278, 87);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtNombreMemoria);
            this.Controls.Add(this.lblDescripcionMemoria);
            this.Name = "frmAltaMemoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cargar Nueva Memoria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtNombreMemoria;
        private System.Windows.Forms.Label lblDescripcionMemoria;
    }
}