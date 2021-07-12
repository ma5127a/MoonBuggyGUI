
namespace MoonBuggyGUI
{
    partial class cameraBackUp
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
            this.label1 = new System.Windows.Forms.Label();
            this.CameraOn = new System.Windows.Forms.Button();
            this.CameraOff = new System.Windows.Forms.Button();
            this.Return = new System.Windows.Forms.Button();
            this.Logout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(195, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Camera ";
            // 
            // CameraOn
            // 
            this.CameraOn.Location = new System.Drawing.Point(137, 302);
            this.CameraOn.Name = "CameraOn";
            this.CameraOn.Size = new System.Drawing.Size(74, 26);
            this.CameraOn.TabIndex = 1;
            this.CameraOn.Text = "Camera On";
            this.CameraOn.UseVisualStyleBackColor = true;
            this.CameraOn.Click += new System.EventHandler(this.CameraOn_Click);
            // 
            // CameraOff
            // 
            this.CameraOff.Location = new System.Drawing.Point(288, 302);
            this.CameraOff.Name = "CameraOff";
            this.CameraOff.Size = new System.Drawing.Size(74, 26);
            this.CameraOff.TabIndex = 2;
            this.CameraOff.Text = "Camera Off";
            this.CameraOff.UseVisualStyleBackColor = true;
            // 
            // Return
            // 
            this.Return.Location = new System.Drawing.Point(340, 358);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(72, 26);
            this.Return.TabIndex = 3;
            this.Return.Text = "Return";
            this.Return.UseVisualStyleBackColor = true;
            this.Return.Click += new System.EventHandler(this.Return_Click);
            // 
            // Logout
            // 
            this.Logout.Location = new System.Drawing.Point(429, 358);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(72, 26);
            this.Logout.TabIndex = 4;
            this.Logout.Text = "Logout";
            this.Logout.UseVisualStyleBackColor = true;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // cameraBackUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(513, 396);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.Return);
            this.Controls.Add(this.CameraOff);
            this.Controls.Add(this.CameraOn);
            this.Controls.Add(this.label1);
            this.Name = "cameraBackUp";
            this.Text = "cameraBackUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CameraOn;
        private System.Windows.Forms.Button CameraOff;
        private System.Windows.Forms.Button Return;
        private System.Windows.Forms.Button Logout;
    }
}