namespace ClasesINA.Formularios
{
    partial class Constantes
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
            this.lblValorConstante = new System.Windows.Forms.Label();
            this.btnImprimirConstante = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblValorConstante
            // 
            this.lblValorConstante.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblValorConstante.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblValorConstante.Location = new System.Drawing.Point(65, 88);
            this.lblValorConstante.Name = "lblValorConstante";
            this.lblValorConstante.Size = new System.Drawing.Size(370, 56);
            this.lblValorConstante.TabIndex = 0;
            this.lblValorConstante.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnImprimirConstante
            // 
            this.btnImprimirConstante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimirConstante.Location = new System.Drawing.Point(65, 12);
            this.btnImprimirConstante.Name = "btnImprimirConstante";
            this.btnImprimirConstante.Size = new System.Drawing.Size(370, 62);
            this.btnImprimirConstante.TabIndex = 1;
            this.btnImprimirConstante.Text = "Mostrar valor de la constante";
            this.btnImprimirConstante.UseVisualStyleBackColor = true;
            this.btnImprimirConstante.Click += new System.EventHandler(this.btnImprimirConstante_Click);
            // 
            // Constantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnImprimirConstante);
            this.Controls.Add(this.lblValorConstante);
            this.Name = "Constantes";
            this.Text = "Constantes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblValorConstante;
        private System.Windows.Forms.Button btnImprimirConstante;
    }
}