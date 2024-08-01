namespace ApartmanOtomasyonDeneme
{
    partial class Form1
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
            this.btngelirler = new System.Windows.Forms.Button();
            this.btngiderler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btngelirler
            // 
            this.btngelirler.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btngelirler.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btngelirler.Location = new System.Drawing.Point(153, 85);
            this.btngelirler.Name = "btngelirler";
            this.btngelirler.Size = new System.Drawing.Size(146, 256);
            this.btngelirler.TabIndex = 0;
            this.btngelirler.Text = "Gelirler";
            this.btngelirler.UseVisualStyleBackColor = true;
            this.btngelirler.Click += new System.EventHandler(this.btngelirler_Click);
            // 
            // btngiderler
            // 
            this.btngiderler.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btngiderler.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btngiderler.Location = new System.Drawing.Point(458, 85);
            this.btngiderler.Name = "btngiderler";
            this.btngiderler.Size = new System.Drawing.Size(146, 256);
            this.btngiderler.TabIndex = 1;
            this.btngiderler.Text = "Giderler";
            this.btngiderler.UseVisualStyleBackColor = true;
            this.btngiderler.Click += new System.EventHandler(this.btngiderler_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btngiderler);
            this.Controls.Add(this.btngelirler);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btngelirler;
        private System.Windows.Forms.Button btngiderler;
    }
}

