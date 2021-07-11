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

        }
    }
}
