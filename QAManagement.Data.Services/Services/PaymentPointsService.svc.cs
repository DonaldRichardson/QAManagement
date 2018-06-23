using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using QAManagement.Data.Services.DataContracts;

namespace QAManagement.Data.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "PaymentPointsService" in code, svc and config file together.
    public class PaymentPointsService : IPaymentPointsService
    {
        public void DoWork()
        {
        }

        public PaymentPoints GetPaymentPoints(int id)
        {
            throw new NotImplementedException();
        }

        public List<PaymentPoints> GetAllPaymentPoints()
        {
            throw new NotImplementedException();
        }
    }
}
