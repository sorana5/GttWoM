namespace PortalSpreLumeaMuzicii
{
    partial class Start
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Start));
            this.incepe = new System.Windows.Forms.Button();
            this.titlu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // incepe
            // 
            this.incepe.AutoSize = true;
            this.incepe.BackColor = System.Drawing.Color.Transparent;
            this.incepe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.incepe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incepe.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.incepe.Location = new System.Drawing.Point(448, 431);
            this.incepe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.incepe.Name = "incepe";
            this.incepe.Size = new System.Drawing.Size(149, 60);
            this.incepe.TabIndex = 0;
            this.incepe.Text = "Începe";
            this.incepe.UseVisualStyleBackColor = false;
            this.incepe.Click += new System.EventHandler(this.button1_Click);
            // 
            // titlu
            // 
            this.titlu.AutoSize = true;
            this.titlu.BackColor = System.Drawing.Color.Transparent;
            this.titlu.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titlu.ForeColor = System.Drawing.Color.White;
            this.titlu.Location = new System.Drawing.Point(120, 111);
            this.titlu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titlu.Name = "titlu";
            this.titlu.Size = new System.Drawing.Size(947, 91);
            this.titlu.TabIndex = 1;
            this.titlu.Text = "Portal spre lumea muzicii";
            this.titlu.Click += new System.EventHandler(this.titlu_Click);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1295, 762);
            this.Controls.Add(this.titlu);
            this.Controls.Add(this.incepe);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Start";
            this.Text = "Start";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button incepe;
        private System.Windows.Forms.Label titlu;
    }
}

