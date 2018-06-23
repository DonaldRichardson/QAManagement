using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using QAManagement.Data.Services.DataContracts;

namespace QAManagement.Data.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ProjectUserService" in code, svc and config file together.
    public class ProjectUserService : IProjectUserService
    {
        public void DoWork()
        {
        }

        public ProjectUsers GetProjectUsersContract(int id)
        {
            throw new NotImplementedException();
        }

        public List<ProjectUsers> GetAllProjectUsersContract()
        {
            throw new NotImplementedException();
        }
    }
}
