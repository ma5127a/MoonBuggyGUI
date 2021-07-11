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
    public partial class Camera : Form
    {
        public Camera()
        {
            InitializeComponent();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogInScreen ss = new LogInScreen();
            ss.Show();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            CommandCentre ss = new CommandCentre();
            ss.Show();
        }
    }
}
