namespace PostOfficeManagement
{
    partial class admin
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
            this.btnPostman = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPostman
            // 
            this.btnPostman.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPostman.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPostman.Location = new System.Drawing.Point(69, 51);
            this.btnPostman.Name = "btnPostman";
            this.btnPostman.Size = new System.Drawing.Size(243, 90);
            this.btnPostman.TabIndex = 0;
            this.btnPostman.Text = "Login to Postman Dashboard";
            this.btnPostman.UseVisualStyleBackColor = true;
            this.btnPostman.Click += new System.EventHandler(this.btnPostman_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(69, 167);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(243, 90);
            this.button2.TabIndex = 1;
            this.button2.Text = "Login to Staff Dashboard";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 313);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnPostman);
            this.MaximumSize = new System.Drawing.Size(422, 360);
            this.MinimumSize = new System.Drawing.Size(422, 360);
            this.Name = "admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "admin";
            this.Load += new System.EventHandler(this.admin_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPostman;
        private System.Windows.Forms.Button button2;
    }
}