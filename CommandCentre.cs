using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoonBuggyGUI
{
    public partial class CommandCentre : Form
    {
        public CommandCentre()
        {
            InitializeComponent();
        }

        private void Title_Click(object sender, EventArgs e)
        {

        }

        private void ControlCentre_Click(object sender, EventArgs e) // moves to command centre
        {
            this.Hide();
            ControlCentre ss = new ControlCentre();
            ss.Show();
        }

        private void Logout_Click(object sender, EventArgs e)
        { // logs out of device 
            this.Hide();
            LogInScreen ss = new LogInScreen();
            ss.Show();
        }

        private void Network_Click(object sender, EventArgs e) // takes you to network information page
        {
            this.Hide();
            Network ss = new Network();
            ss.Show();
        }

        private void Camera_Click(object sender, EventArgs e) //opens the camera  scren 
        {
            this.Hide();
            Camera ss = new Camera();
            ss.Show();
        }

        private void Sensors_Click(object sender, EventArgs e) // information about sensors
        {
            this.Hide();
            Sensors ss = new Sensors();
            ss.Show();
        }

        private void Issue_Click(object sender, EventArgs e) // issue report form
        {
            this.Hide();
            ProblemForm ss = new ProblemForm();
            ss.Show();
        }

        private void CommandCentre_Load(object sender, EventArgs e)
        {

        }
    }
}
