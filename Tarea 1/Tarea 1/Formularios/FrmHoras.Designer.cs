namespace Tarea_1.Formularios
{
    partial class FrmHoras
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnCalcular2 = new System.Windows.Forms.Button();
            this.BtnBorrar2 = new System.Windows.Forms.Button();
            this.BtnSalir2 = new System.Windows.Forms.Button();
            this.textDiast = new System.Windows.Forms.TextBox();
            this.textHoras = new System.Windows.Forms.TextBox();
            this.textPdias = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textPhoras = new System.Windows.Forms.TextBox();
            this.textTotalpagar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ingrese Dias Trabajados ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Precio por Dia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Total a Pagar";
            // 
            // BtnCalcular2
            // 
            this.BtnCalcular2.Location = new System.Drawing.Point(19, 316);
            this.BtnCalcular2.Name = "BtnCalcular2";
            this.BtnCalcular2.Size = new System.Drawing.Size(75, 27);
            this.BtnCalcular2.TabIndex = 7;
            this.BtnCalcular2.Text = "Calcular";
            this.BtnCalcular2.UseVisualStyleBackColor = true;
            this.BtnCalcular2.Click += new System.EventHandler(this.BtnCalcular2_Click);
            // 
            // BtnBorrar2
            // 
            this.BtnBorrar2.Location = new System.Drawing.Point(161, 316);
            this.BtnBorrar2.Name = "BtnBorrar2";
            this.BtnBorrar2.Size = new System.Drawing.Size(75, 27);
            this.BtnBorrar2.TabIndex = 8;
            this.BtnBorrar2.Text = "Borrar";
            this.BtnBorrar2.UseVisualStyleBackColor = true;
            this.BtnBorrar2.Click += new System.EventHandler(this.BtnBorrar2_Click);
            // 
            // BtnSalir2
            // 
            this.BtnSalir2.Location = new System.Drawing.Point(306, 316);
            this.BtnSalir2.Name = "BtnSalir2";
            this.BtnSalir2.Size = new System.Drawing.Size(75, 27);
            this.BtnSalir2.TabIndex = 9;
            this.BtnSalir2.Text = "Salir";
            this.BtnSalir2.UseVisualStyleBackColor = true;
            this.BtnSalir2.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // textDiast
            // 
            this.textDiast.Location = new System.Drawing.Point(179, 44);
            this.textDiast.Name = "textDiast";
            this.textDiast.Size = new System.Drawing.Size(100, 25);
            this.textDiast.TabIndex = 10;
            // 
            // textHoras
            // 
            this.textHoras.Location = new System.Drawing.Point(179, 97);
            this.textHoras.Name = "textHoras";
            this.textHoras.Size = new System.Drawing.Size(100, 25);
            this.textHoras.TabIndex = 11;
            // 
            // textPdias
            // 
            this.textPdias.Location = new System.Drawing.Point(179, 151);
            this.textPdias.Name = "textPdias";
            this.textPdias.Size = new System.Drawing.Size(100, 25);
            this.textPdias.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Precio  por Hora";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Horas Extras";
            // 
            // textPhoras
            // 
            this.textPhoras.Location = new System.Drawing.Point(179, 194);
            this.textPhoras.Name = "textPhoras";
            this.textPhoras.Size = new System.Drawing.Size(100, 25);
            this.textPhoras.TabIndex = 15;
            // 
            // textTotalpagar
            // 
            this.textTotalpagar.BackColor = System.Drawing.Color.White;
            this.textTotalpagar.Location = new System.Drawing.Point(179, 243);
            this.textTotalpagar.Name = "textTotalpagar";
            this.textTotalpagar.ReadOnly = true;
            this.textTotalpagar.Size = new System.Drawing.Size(100, 25);
            this.textTotalpagar.TabIndex = 16;
            // 
            // FrmHoras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 355);
            this.Controls.Add(this.textTotalpagar);
            this.Controls.Add(this.textPhoras);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textPdias);
            this.Controls.Add(this.textHoras);
            this.Controls.Add(this.textDiast);
            this.Controls.Add(this.BtnSalir2);
            this.Controls.Add(this.BtnBorrar2);
            this.Controls.Add(this.BtnCalcular2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmHoras";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Horas Extras";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnCalcular2;
        private System.Windows.Forms.Button BtnBorrar2;
        private System.Windows.Forms.Button BtnSalir2;
        private System.Windows.Forms.TextBox textDiast;
        private System.Windows.Forms.TextBox textHoras;
        private System.Windows.Forms.TextBox textPdias;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textPhoras;
        private System.Windows.Forms.TextBox textTotalpagar;
    }
}