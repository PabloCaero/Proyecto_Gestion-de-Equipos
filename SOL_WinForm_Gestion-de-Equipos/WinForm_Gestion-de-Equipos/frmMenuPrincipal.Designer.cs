
namespace WinForm_Gestion_de_Equipos
{
    partial class frmMenuPrincipal
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
            this.btnEquiposNuevos = new System.Windows.Forms.Button();
            this.btnHerramientas = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pbxMainMenu = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMainMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEquiposNuevos
            // 
            this.btnEquiposNuevos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEquiposNuevos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEquiposNuevos.Location = new System.Drawing.Point(22, 301);
            this.btnEquiposNuevos.Name = "btnEquiposNuevos";
            this.btnEquiposNuevos.Size = new System.Drawing.Size(250, 29);
            this.btnEquiposNuevos.TabIndex = 0;
            this.btnEquiposNuevos.Text = "Cargar Equipo Nuevo";
            this.btnEquiposNuevos.UseVisualStyleBackColor = true;
            // 
            // btnHerramientas
            // 
            this.btnHerramientas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHerramientas.Location = new System.Drawing.Point(22, 336);
            this.btnHerramientas.Name = "btnHerramientas";
            this.btnHerramientas.Size = new System.Drawing.Size(250, 23);
            this.btnHerramientas.TabIndex = 1;
            this.btnHerramientas.Text = "Herramientas";
            this.btnHerramientas.UseVisualStyleBackColor = true;
            this.btnHerramientas.Click += new System.EventHandler(this.btnHerramientas_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(22, 394);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(250, 23);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(22, 365);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(250, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(93, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Menú Principal";
            // 
            // pbxMainMenu
            // 
            this.pbxMainMenu.Image = global::WinForm_Gestion_de_Equipos.Properties.Resources.Microsoft_logo_svg;
            this.pbxMainMenu.InitialImage = global::WinForm_Gestion_de_Equipos.Properties.Resources.Windows_logo___2012;
            this.pbxMainMenu.Location = new System.Drawing.Point(22, 12);
            this.pbxMainMenu.Name = "pbxMainMenu";
            this.pbxMainMenu.Size = new System.Drawing.Size(250, 250);
            this.pbxMainMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxMainMenu.TabIndex = 4;
            this.pbxMainMenu.TabStop = false;
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(292, 431);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbxMainMenu);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnHerramientas);
            this.Controls.Add(this.btnEquiposNuevos);
            this.Name = "frmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Equipos Nuevos";
            ((System.ComponentModel.ISupportInitialize)(this.pbxMainMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEquiposNuevos;
        private System.Windows.Forms.Button btnHerramientas;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.PictureBox pbxMainMenu;
        private System.Windows.Forms.Label label1;
    }
}

