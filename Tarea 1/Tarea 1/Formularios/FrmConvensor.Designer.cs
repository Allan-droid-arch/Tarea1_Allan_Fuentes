namespace Tarea_1.Formularios
{
    partial class FrmConvensor
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
            this.label1 = new System.Windows.Forms.Label();
            this.BtnMkilometros = new System.Windows.Forms.Button();
            this.BtnMMetros = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione una Opción ";
            // 
            // BtnMkilometros
            // 
            this.BtnMkilometros.Location = new System.Drawing.Point(239, 88);
            this.BtnMkilometros.Name = "BtnMkilometros";
            this.BtnMkilometros.Size = new System.Drawing.Size(139, 30);
            this.BtnMkilometros.TabIndex = 2;
            this.BtnMkilometros.Text = "Millas a Kilómetros";
            this.BtnMkilometros.UseVisualStyleBackColor = true;
            this.BtnMkilometros.Click += new System.EventHandler(this.BtnMkilometros_Click);
            // 
            // BtnMMetros
            // 
            this.BtnMMetros.Location = new System.Drawing.Point(48, 88);
            this.BtnMMetros.Name = "BtnMMetros";
            this.BtnMMetros.Size = new System.Drawing.Size(118, 30);
            this.BtnMMetros.TabIndex = 1;
            this.BtnMMetros.Text = "Millas a Metros";
            this.BtnMMetros.UseVisualStyleBackColor = true;
            this.BtnMMetros.Click += new System.EventHandler(this.BtnMMetros_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(356, 211);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 28);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmConvensor
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(443, 251);
            this.ControlBox = false;
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.BtnMkilometros);
            this.Controls.Add(this.BtnMMetros);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmConvensor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversor de Millas";
            this.Load += new System.EventHandler(this.FrmConvensor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnMkilometros;
        private System.Windows.Forms.Button BtnMMetros;
        private System.Windows.Forms.Button btnSalir;
    }
}