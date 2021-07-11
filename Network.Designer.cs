
namespace MoonBuggyGUI
{
    partial class Network
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
            this.Back = new System.Windows.Forms.Button();
            this.Logout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(346, 308);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(78, 26);
            this.Back.TabIndex = 13;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Logout
            // 
            this.Logout.Location = new System.Drawing.Point(437, 308);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(78, 26);
            this.Logout.TabIndex = 12;
            this.Logout.Text = "Logout";
            this.Logout.UseVisualStyleBackColor = true;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // Network
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(527, 346);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Logout);
            this.Name = "Network";
            this.Text = "MoonBuggy App";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Logout;
    }
}