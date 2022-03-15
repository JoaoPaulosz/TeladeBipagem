namespace TeladeBipagem
{
    partial class CadastroMotivo
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
            this.TabelaMotivo = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // TabelaMotivo
            // 
            this.TabelaMotivo.ColumnCount = 2;
            this.TabelaMotivo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.128631F));
            this.TabelaMotivo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90.87137F));
            this.TabelaMotivo.Location = new System.Drawing.Point(1, 1);
            this.TabelaMotivo.Name = "TabelaMotivo";
            this.TabelaMotivo.RowCount = 2;
            this.TabelaMotivo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.TabelaMotivo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TabelaMotivo.Size = new System.Drawing.Size(241, 261);
            this.TabelaMotivo.TabIndex = 0;
            this.TabelaMotivo.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // CadastroMotivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 261);
            this.Controls.Add(this.TabelaMotivo);
            this.Name = "CadastroMotivo";
            this.Text = "CadastroMotivo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TabelaMotivo;
    }
}