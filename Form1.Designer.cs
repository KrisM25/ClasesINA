namespace ClasesINA
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnValoresCompuestos = new System.Windows.Forms.Button();
            this.btnConstantes = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnValoresCompuestos
            // 
            this.btnValoresCompuestos.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnValoresCompuestos.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValoresCompuestos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnValoresCompuestos.Location = new System.Drawing.Point(187, 25);
            this.btnValoresCompuestos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnValoresCompuestos.Name = "btnValoresCompuestos";
            this.btnValoresCompuestos.Size = new System.Drawing.Size(157, 76);
            this.btnValoresCompuestos.TabIndex = 0;
            this.btnValoresCompuestos.Text = "Valores compuestos";
            this.btnValoresCompuestos.UseVisualStyleBackColor = false;
            this.btnValoresCompuestos.Click += new System.EventHandler(this.btnValoresCompuestos_Click);
            // 
            // btnConstantes
            // 
            this.btnConstantes.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnConstantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConstantes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConstantes.Location = new System.Drawing.Point(17, 25);
            this.btnConstantes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnConstantes.Name = "btnConstantes";
            this.btnConstantes.Size = new System.Drawing.Size(157, 76);
            this.btnConstantes.TabIndex = 1;
            this.btnConstantes.Text = "Constantes";
            this.btnConstantes.UseVisualStyleBackColor = false;
            this.btnConstantes.Click += new System.EventHandler(this.btnConstantes_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(17, 122);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 76);
            this.button1.TabIndex = 2;
            this.button1.Text = "Estructuras de control";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 239);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnConstantes);
            this.Controls.Add(this.btnValoresCompuestos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Clases INA";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnValoresCompuestos;
        private System.Windows.Forms.Button btnConstantes;
        private System.Windows.Forms.Button button1;
    }
}

