
namespace MoonBuggyGUI
{
    partial class Camera
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
            this.Return = new System.Windows.Forms.Button();
            this.Logout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Return
            // 
            this.Return.Location = new System.Drawing.Point(257, 297);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(95, 23);
            this.Return.TabIndex = 0;
            this.Return.Text = "Return";
            this.Return.UseVisualStyleBackColor = true;
            this.Return.Click += new System.EventHandler(this.Return_Click);
            // 
            // Logout
            // 
            this.Logout.Location = new System.Drawing.Point(358, 297);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(95, 23);
            this.Logout.TabIndex = 1;
            this.Logout.Text = "Logout";
            this.Logout.UseVisualStyleBackColor = true;
            this.Logout.Click += new System.EventHandler(this.Logout_Click_1);
            // 
            // Camera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(465, 332);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.Return);
            this.Name = "Camera";
            this.Text = "MoonBuggy App";
            this.Load += new System.EventHandler(this.Camera_Load);
            this.ResumeLayout(false);

        }

        #endregion
        
           
        private System.Windows.Forms.Button connectBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Return;
        private System.Windows.Forms.Button Logout;
    }
}