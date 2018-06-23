using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QAManagement.AssessmentAgent
{
    public partial class frmLogin : Form
    {
        public Form LoadedForm { get; set; }
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            UserService.UserClient client = new UserService.UserClient();
            UserService.ValidateUserRequest req =new UserService.ValidateUserRequest();
            req.Password = txtPassword.Text;
            req.Username = txtUserName.Text;
            UserService.ValidateUserResponse response =  client.ValidateUser(req);
            this.Hide();
            LoadedForm = new Forms.frmProjects();
            LoadedForm.Show();
        }

    }
}
