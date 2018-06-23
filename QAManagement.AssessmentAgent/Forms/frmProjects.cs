using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QAManagement.AssessmentAgent.Forms
{
     [DataObject(true)]
    public partial class frmProjects : Form
    {
       
        public ProjectService.Project Project { get; set; }


        public frmProjects()
        {
            InitializeComponent();
        }

        private void frmProjects_Load(object sender, EventArgs e)
        {
            ProjectService.ProjectsClient client = new ProjectService.ProjectsClient();
            ProjectService.GetProjectsByCompanyRequest req = new ProjectService.GetProjectsByCompanyRequest();
            req.CompanyID = 0;

            ProjectService.GetProjectsByCompanyResponse resp =  client.GetProjectsByCompany(req);
            Project = resp.GetProjectsByCompanyResult.FirstOrDefault();
        }
    }
}
