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
            // password entered here. the password is invisible however key works
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {
           
            // a check  when loging in to check if the right user is logging in
            if(users.NavigationTeam == textBox1.Text && users.NavigationPwd == textBox2.Text || users.NetworkingTeam == textBox1.Text && users.NetworkingPwd == textBox2.Text
                || users.TestTeam == textBox1.Text && users.TestPwd == textBox2.Text || users.EDTeam == textBox1.Text && users.EDPwd == textBox2.Text
                || users.BuggyTeam == textBox1.Text && users.BuggyPwd == textBox2.Text || users.ArmTeam == textBox1.Text && users.ArmPwd == textBox2.Text ||
                users.VisualTeam == textBox1.Text && users.VisualPwd == textBox2.Text)
            {
                this.Hide();
                CommandCentre ss = new CommandCentre();
                ss.Show();
             }
            else // error message
            {
                MessageBox.Show("Plaease enter the correct username or password!");
            }
           
        }

        private void LogInScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
