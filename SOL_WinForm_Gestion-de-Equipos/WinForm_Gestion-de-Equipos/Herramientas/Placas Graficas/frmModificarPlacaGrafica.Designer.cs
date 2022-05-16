
namespace WinForm_Gestion_de_Equipos.Herramientas.PlacasGraficas
{
    partial class frmModificarPlacaGrafica
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
            this.txtNombrePlacaGrafica = new System.Windows.Forms.TextBox();
            this.lblNombrePlacaGrafica = new System.Windows.Forms.Label();
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
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(11, 52);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(117, 23);
            this.btnModificar.TabIndex = 10;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // txtNombrePlacaGrafica
            // 
            this.txtNombrePlacaGrafica.Location = new System.Drawing.Point(12, 26);
            this.txtNombrePlacaGrafica.Name = "txtNombrePlacaGrafica";
            this.txtNombrePlacaGrafica.Size = new System.Drawing.Size(252, 20);
            this.txtNombrePlacaGrafica.TabIndex = 9;
            // 
            // lblNombrePlacaGrafica
            // 
            this.lblNombrePlacaGrafica.AutoSize = true;
            this.lblNombrePlacaGrafica.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombrePlacaGrafica.Location = new System.Drawing.Point(12, 9);
            this.lblNombrePlacaGrafica.Name = "lblNombrePlacaGrafica";
            this.lblNombrePlacaGrafica.Size = new System.Drawing.Size(197, 16);
            this.lblNombrePlacaGrafica.TabIndex = 8;
            this.lblNombrePlacaGrafica.Text = "Descripción de la Placa Gráfica";
            // 
            // frmModificarPlacaGrafica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(278, 87);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.txtNombrePlacaGrafica);
            this.Controls.Add(this.lblNombrePlacaGrafica);
            this.Name = "frmModificarPlacaGrafica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Placa Gráfica";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.TextBox txtNombrePlacaGrafica;
        private System.Windows.Forms.Label lblNombrePlacaGrafica;
    }
}