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
    public partial class LogInScreen : Form
    {
        Users users = new Users();
        
        public LogInScreen()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {
           /* string user, pass;
            user = txtUser.text;
            pass = txtPass.text;

            if(user.NavigationTeam == txtUser.text && user.NavigationPwd == txtPass.txt)
            {

            }
            else() { }
           */
        }

        private void LogInScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
