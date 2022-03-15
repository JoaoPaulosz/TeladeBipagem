namespace TeladeBipagem
{
    partial class Parada
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
            this.codMotivo = new System.Windows.Forms.TextBox();
            this.aplicarMotivo = new System.Windows.Forms.Button();
            this.cancelarParada = new System.Windows.Forms.Button();
            this.descMotivo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Motivo:";
            // 
            // codMotivo
            // 
            this.codMotivo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.codMotivo.Location = new System.Drawing.Point(80, 9);
            this.codMotivo.Name = "codMotivo";
            this.codMotivo.Size = new System.Drawing.Size(114, 29);
            this.codMotivo.TabIndex = 1;
            // 
            // aplicarMotivo
            // 
            this.aplicarMotivo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.aplicarMotivo.Location = new System.Drawing.Point(12, 69);
            this.aplicarMotivo.Name = "aplicarMotivo";
            this.aplicarMotivo.Size = new System.Drawing.Size(75, 33);
            this.aplicarMotivo.TabIndex = 3;
            this.aplicarMotivo.Text = "OK";
            this.aplicarMotivo.UseVisualStyleBackColor = true;
            // 
            // cancelarParada
            // 
            this.cancelarParada.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cancelarParada.Location = new System.Drawing.Point(268, 69);
            this.cancelarParada.Name = "cancelarParada";
            this.cancelarParada.Size = new System.Drawing.Size(84, 33);
            this.cancelarParada.TabIndex = 4;
            this.cancelarParada.Text = "Cancelar";
            this.cancelarParada.UseVisualStyleBackColor = true;
            // 
            // descMotivo
            // 
            this.descMotivo.AutoSize = true;
            this.descMotivo.BackColor = System.Drawing.SystemColors.Control;
            this.descMotivo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.descMotivo.ForeColor = System.Drawing.Color.Blue;
            this.descMotivo.Location = new System.Drawing.Point(200, 13);
            this.descMotivo.Name = "descMotivo";
            this.descMotivo.Size = new System.Drawing.Size(152, 21);
            this.descMotivo.TabIndex = 5;
            this.descMotivo.Text = "Descrição do Motivo";
            // 
            // Parada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 114);
            this.Controls.Add(this.descMotivo);
            this.Controls.Add(this.cancelarParada);
            this.Controls.Add(this.aplicarMotivo);
            this.Controls.Add(this.codMotivo);
            this.Controls.Add(this.label1);
            this.Name = "Parada";
            this.Text = "Parada";
            this.Load += new System.EventHandler(this.parada_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox codMotivo;
        private System.Windows.Forms.Button aplicarMotivo;
        private System.Windows.Forms.Button cancelarParada;
        private System.Windows.Forms.Label descMotivo;
    }
}