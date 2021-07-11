using System;
using System.Windows.Forms;

namespace MoonBuggyGUI
{
    public partial class ControlCentre : Form
    {
        public ControlCentre()
        {
            InitializeComponent();
        }

        private void triangleButton1_Click(object sender, EventArgs e)
        {

        }

        private void circularButton4_Click(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            CommandCentre ss = new CommandCentre();
            ss.Show();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogInScreen ss = new LogInScreen();
            ss.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = "Autopilot turned on";
            MessageBox.Show(text);
            AutoPilotOff.Enabled = true;
            button1.Enabled = false;

        }

        private void AutoPilotOff_Click(object sender, EventArgs e)
        {
            string text = "Autopilot turned off";
            MessageBox.Show(text);
            AutoPilotOff.Enabled = false;
            button1.Enabled = true;

        }
    }
}
