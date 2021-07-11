
namespace MoonBuggyGUI
{
    partial class CommandCentre
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
            this.Title = new System.Windows.Forms.Label();
            this.ControlCentre = new System.Windows.Forms.Button();
            this.Network = new System.Windows.Forms.Button();
            this.Camera = new System.Windows.Forms.Button();
            this.Sensors = new System.Windows.Forms.Button();
            this.Issue = new System.Windows.Forms.Button();
            this.Logout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(119, 33);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(245, 33);
            this.Title.TabIndex = 0;
            this.Title.Text = "Command Centre";
            this.Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Title.Click += new System.EventHandler(this.Title_Click);
            // 
            // ControlCentre
            // 
            this.ControlCentre.Location = new System.Drawing.Point(106, 95);
            this.ControlCentre.Name = "ControlCentre";
            this.ControlCentre.Size = new System.Drawing.Size(120, 61);
            this.ControlCentre.TabIndex = 1;
            this.ControlCentre.Text = "Control Centre";
            this.ControlCentre.UseVisualStyleBackColor = true;
            // 
            // Network
            // 
            this.Network.Location = new System.Drawing.Point(263, 95);
            this.Network.Name = "Network";
            this.Network.Size = new System.Drawing.Size(111, 61);
            this.Network.TabIndex = 2;
            this.Network.Text = "Network ";
            this.Network.UseVisualStyleBackColor = true;
            // 
            // Camera
            // 
            this.Camera.Location = new System.Drawing.Point(106, 182);
            this.Camera.Name = "Camera";
            this.Camera.Size = new System.Drawing.Size(120, 63);
            this.Camera.TabIndex = 3;
            this.Camera.Text = "Camera";
            this.Camera.UseVisualStyleBackColor = true;
            // 
            // Sensors
            // 
            this.Sensors.Location = new System.Drawing.Point(263, 182);
            this.Sensors.Name = "Sensors";
            this.Sensors.Size = new System.Drawing.Size(111, 63);
            this.Sensors.TabIndex = 4;
            this.Sensors.Text = "Sensors";
            this.Sensors.UseVisualStyleBackColor = true;
            // 
            // Issue
            // 
            this.Issue.Location = new System.Drawing.Point(194, 269);
            this.Issue.Name = "Issue";
            this.Issue.Size = new System.Drawing.Size(101, 33);
            this.Issue.TabIndex = 5;
            this.Issue.Text = "Report an issue";
            this.Issue.UseVisualStyleBackColor = true;
            // 
            // Logout
            // 
            this.Logout.Location = new System.Drawing.Point(372, 309);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(80, 27);
            this.Logout.TabIndex = 6;
            this.Logout.Text = "Logout";
            this.Logout.UseVisualStyleBackColor = true;
            // 
            // CommandCentre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(475, 352);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.Issue);
            this.Controls.Add(this.Sensors);
            this.Controls.Add(this.Camera);
            this.Controls.Add(this.Network);
            this.Controls.Add(this.ControlCentre);
            this.Controls.Add(this.Title);
            this.Name = "CommandCentre";
            this.Text = "MoonBggy App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button ControlCentre;
        private System.Windows.Forms.Button Network;
        private System.Windows.Forms.Button Camera;
        private System.Windows.Forms.Button Sensors;
        private System.Windows.Forms.Button Issue;
        private System.Windows.Forms.Button Logout;
    }
}