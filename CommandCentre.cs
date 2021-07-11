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

        private void ControlCentre_Click(object sender, EventArgs e)
        {
            this.Hide();
            ControlCentre ss = new ControlCentre();
            ss.Show();
        }
    }
}
