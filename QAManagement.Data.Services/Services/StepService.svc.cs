using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using QAManagement.Data.Services.DataContracts;

namespace QAManagement.Data.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "StepService" in code, svc and config file together.
    public class StepService : IStepService
    {
        public void DoWork()
        {
        }

        public Step GetStepContract(int id)
        {
            throw new NotImplementedException();
        }

        public List<Step> GetAllStepContract()
        {
            throw new NotImplementedException();
        }
    }
}
