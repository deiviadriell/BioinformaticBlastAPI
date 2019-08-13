namespace BlastAPI
{
    partial class frm_BlastAPI
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
            this.txt_Secuencia = new System.Windows.Forms.TextBox();
            this.btnBlast = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Secuencia / Sequence";
            // 
            // txt_Secuencia
            // 
            this.txt_Secuencia.Location = new System.Drawing.Point(12, 36);
            this.txt_Secuencia.Multiline = true;
            this.txt_Secuencia.Name = "txt_Secuencia";
            this.txt_Secuencia.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Secuencia.Size = new System.Drawing.Size(435, 284);
            this.txt_Secuencia.TabIndex = 1;
            // 
            // btnBlast
            // 
            this.btnBlast.Location = new System.Drawing.Point(372, 326);
            this.btnBlast.Name = "btnBlast";
            this.btnBlast.Size = new System.Drawing.Size(75, 23);
            this.btnBlast.TabIndex = 2;
            this.btnBlast.Text = "BLAST";
            this.btnBlast.UseVisualStyleBackColor = true;
            this.btnBlast.Click += new System.EventHandler(this.btnBlast_Click);
            // 
            // frm_BlastAPI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 361);
            this.Controls.Add(this.btnBlast);
            this.Controls.Add(this.txt_Secuencia);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "frm_BlastAPI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Blast API";
            this.Load += new System.EventHandler(this.frm_BlastAPI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Secuencia;
        private System.Windows.Forms.Button btnBlast;
    }
}

