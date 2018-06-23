using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace QAManagement.AgentService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "User" in code, svc and config file together.
    public class User : IUser
    {
        public bool ValidateUser(string Username, string Password)
        {
            return true;
        }


        public bool ResendPassword(string Username)
        {
            return true;
        }
    }
}
