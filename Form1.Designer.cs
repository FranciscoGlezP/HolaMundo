
namespace HolaMundo
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
            this.btValida = new System.Windows.Forms.Button();
            this.txtPrincipal = new System.Windows.Forms.TextBox();
            this.txtSecundario = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btValida
            // 
            this.btValida.Location = new System.Drawing.Point(571, 188);
            this.btValida.Name = "btValida";
            this.btValida.Size = new System.Drawing.Size(140, 79);
            this.btValida.TabIndex = 0;
            this.btValida.Text = "Valida";
            this.btValida.UseVisualStyleBackColor = true;
            this.btValida.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPrincipal
            // 
            this.txtPrincipal.Location = new System.Drawing.Point(264, 116);
            this.txtPrincipal.Name = "txtPrincipal";
            this.txtPrincipal.Size = new System.Drawing.Size(181, 22);
            this.txtPrincipal.TabIndex = 1;
            // 
            // txtSecundario
            // 
            this.txtSecundario.Location = new System.Drawing.Point(264, 160);
            this.txtSecundario.Name = "txtSecundario";
            this.txtSecundario.Size = new System.Drawing.Size(181, 22);
            this.txtSecundario.TabIndex = 2;
            this.txtSecundario.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtSecundario);
            this.Controls.Add(this.txtPrincipal);
            this.Controls.Add(this.btValida);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btValida;
        private System.Windows.Forms.TextBox txtPrincipal;
        private System.Windows.Forms.TextBox txtSecundario;
    }
}

