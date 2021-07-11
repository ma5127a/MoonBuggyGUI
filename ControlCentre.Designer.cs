
namespace MoonBuggyGUI
{
    partial class ControlCentre
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
            this.triangleButton1 = new MoonBuggyGUI.TriangleButton();
            this.triangleButton2 = new MoonBuggyGUI.TriangleButton();
            this.triangleButton3 = new MoonBuggyGUI.TriangleButton();
            this.triangleButton4 = new MoonBuggyGUI.TriangleButton();
            this.SuspendLayout();
            // 
            // triangleButton1
            // 
            this.triangleButton1.Location = new System.Drawing.Point(90, 84);
            this.triangleButton1.Name = "triangleButton1";
            this.triangleButton1.Size = new System.Drawing.Size(77, 75);
            this.triangleButton1.TabIndex = 0;
            this.triangleButton1.Text = "triangleButton1";
            this.triangleButton1.UseVisualStyleBackColor = true;
            // 
            // triangleButton2
            // 
            this.triangleButton2.Location = new System.Drawing.Point(159, 165);
            this.triangleButton2.Name = "triangleButton2";
            this.triangleButton2.Size = new System.Drawing.Size(77, 75);
            this.triangleButton2.TabIndex = 1;
            this.triangleButton2.Text = "triangleButton2";
            this.triangleButton2.UseVisualStyleBackColor = true;
            // 
            // triangleButton3
            // 
            this.triangleButton3.Location = new System.Drawing.Point(21, 165);
            this.triangleButton3.Name = "triangleButton3";
            this.triangleButton3.Size = new System.Drawing.Size(77, 75);
            this.triangleButton3.TabIndex = 2;
            this.triangleButton3.Text = "triangleButton3";
            this.triangleButton3.UseVisualStyleBackColor = true;
            // 
            // triangleButton4
            // 
            this.triangleButton4.Location = new System.Drawing.Point(90, 257);
            this.triangleButton4.Name = "triangleButton4";
            this.triangleButton4.Size = new System.Drawing.Size(77, 75);
            this.triangleButton4.TabIndex = 3;
            this.triangleButton4.Text = "triangleButton4";
            this.triangleButton4.UseVisualStyleBackColor = true;
            // 
            // ControlCentre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(640, 450);
            this.Controls.Add(this.triangleButton4);
            this.Controls.Add(this.triangleButton3);
            this.Controls.Add(this.triangleButton2);
            this.Controls.Add(this.triangleButton1);
            this.Name = "ControlCentre";
            this.Text = "MoonBggy App";
            this.ResumeLayout(false);

        }

        #endregion

        private TriangleButton triangleButton1;
        private TriangleButton triangleButton2;
        private TriangleButton triangleButton3;
        private TriangleButton triangleButton4;
    }
}