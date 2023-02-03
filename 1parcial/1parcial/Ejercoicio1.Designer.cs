namespace _1parcial
{
    partial class Ejercoicio1
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
            this.label2 = new System.Windows.Forms.Label();
            this.numero1textBox1 = new System.Windows.Forms.TextBox();
            this.numero2textBox2 = new System.Windows.Forms.TextBox();
            this.sumarbutton1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero 2";
            // 
            // numero1textBox1
            // 
            this.numero1textBox1.Location = new System.Drawing.Point(249, 64);
            this.numero1textBox1.Name = "numero1textBox1";
            this.numero1textBox1.Size = new System.Drawing.Size(100, 20);
            this.numero1textBox1.TabIndex = 2;
            this.numero1textBox1.TextChanged += new System.EventHandler(this.numero1textBox1_TextChanged);
            // 
            // numero2textBox2
            // 
            this.numero2textBox2.Location = new System.Drawing.Point(249, 96);
            this.numero2textBox2.Name = "numero2textBox2";
            this.numero2textBox2.Size = new System.Drawing.Size(100, 20);
            this.numero2textBox2.TabIndex = 3;
            // 
            // sumarbutton1
            // 
            this.sumarbutton1.Location = new System.Drawing.Point(249, 166);
            this.sumarbutton1.Name = "sumarbutton1";
            this.sumarbutton1.Size = new System.Drawing.Size(75, 23);
            this.sumarbutton1.TabIndex = 4;
            this.sumarbutton1.Text = "Sumar";
            this.sumarbutton1.UseVisualStyleBackColor = true;
            this.sumarbutton1.Click += new System.EventHandler(this.sumarbutton1_Click);
            // 
            // Ejercoicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sumarbutton1);
            this.Controls.Add(this.numero2textBox2);
            this.Controls.Add(this.numero1textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Ejercoicio1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox numero1textBox1;
        private System.Windows.Forms.TextBox numero2textBox2;
        private System.Windows.Forms.Button sumarbutton1;
    }
}

