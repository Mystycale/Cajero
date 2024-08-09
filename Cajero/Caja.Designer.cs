namespace Cajero
{
    partial class Caja
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
            this.Cerrarcaja = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Cerrarcaja
            // 
            this.Cerrarcaja.BackColor = System.Drawing.Color.Red;
            this.Cerrarcaja.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Cerrarcaja.Location = new System.Drawing.Point(12, 473);
            this.Cerrarcaja.Name = "Cerrarcaja";
            this.Cerrarcaja.Size = new System.Drawing.Size(112, 44);
            this.Cerrarcaja.TabIndex = 0;
            this.Cerrarcaja.Text = "Cerrar";
            this.Cerrarcaja.UseVisualStyleBackColor = false;
            this.Cerrarcaja.Click += new System.EventHandler(this.Cerrarcaja_Click);
            // 
            // Caja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 529);
            this.Controls.Add(this.Cerrarcaja);
            this.Name = "Caja";
            this.Text = "Caja";
            this.ResumeLayout(false);

        }

        #endregion

        private Button Cerrarcaja;
    }
}