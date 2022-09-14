namespace Sp1Cantallops
{
    partial class FrmInicio
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
            this.LblBienvenido = new System.Windows.Forms.Label();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblBienvenido
            // 
            this.LblBienvenido.AutoSize = true;
            this.LblBienvenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBienvenido.Location = new System.Drawing.Point(80, 89);
            this.LblBienvenido.Name = "LblBienvenido";
            this.LblBienvenido.Size = new System.Drawing.Size(414, 46);
            this.LblBienvenido.TabIndex = 1;
            this.LblBienvenido.Text = "Bienvenido al Sistema";
            // 
            // BtnSalir
            // 
            this.BtnSalir.Location = new System.Drawing.Point(233, 169);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(98, 33);
            this.BtnSalir.TabIndex = 6;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            // 
            // FrmBienvenida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 288);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.LblBienvenido);
            this.Name = "FrmBienvenida";
            this.Text = "Bienvenido al Sistema";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblBienvenido;
        private System.Windows.Forms.Button BtnSalir;
    }
}