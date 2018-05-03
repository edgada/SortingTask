namespace ACDtask
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
            this.btnRikiuojam = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRikiuojam
            // 
            this.btnRikiuojam.Location = new System.Drawing.Point(111, 150);
            this.btnRikiuojam.Name = "btnRikiuojam";
            this.btnRikiuojam.Size = new System.Drawing.Size(148, 37);
            this.btnRikiuojam.TabIndex = 0;
            this.btnRikiuojam.Text = "Rikiuojam";
            this.btnRikiuojam.UseVisualStyleBackColor = true;
            this.btnRikiuojam.Click += new System.EventHandler(this.btnRikiuojam_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 342);
            this.Controls.Add(this.btnRikiuojam);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRikiuojam;
    }
}

