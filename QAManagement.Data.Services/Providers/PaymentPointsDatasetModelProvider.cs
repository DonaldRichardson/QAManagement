using System.Collections.Generic;
using QAManagement.Data.Services.Providers;
using QAManagement.Data.Services.DataContracts;
namespace QAManagement.Data.Services.Providers
{
    public class PaymentPointsProvider : baseDataProvider
    {
        public PaymentPoints ConvertToModel(QAManagement.Data.dsQAManager.PaymentPointsRow item)
        {
            PaymentPoints model = new PaymentPoints();
            model.ID = item.ID;
            model.UserID = item.UserID;
            model.Points = item.Points;
            return model;
        }
        public List<PaymentPoints> ConvertToModelList(QAManagement.Data.dsQAManager.PaymentPointsDataTable itemlist)
        {
            List<PaymentPoints> lst = new List<PaymentPoints>();
            foreach (QAManagement.Data.dsQAManager.PaymentPointsRow item in itemlist)
                lst.Add(ConvertToModel(item));
            return lst;
        }
        public QAManagement.Data.dsQAManager.PaymentPointsRow ConvertToDataRow(PaymentPoints item)
        {
            QAManagement.Data.dsQAManager.PaymentPointsRow model = new QAManagement.Data.dsQAManager.PaymentPointsDataTable().NewPaymentPointsRow();
            model.ID = item.ID;
            model.UserID = item.UserID;
            model.Points = item.Points;
            return model;
        }
        public QAManagement.Data.dsQAManager.PaymentPointsDataTable ConvertToDataTable(List<PaymentPoints> itemlist)
        {
            QAManagement.Data.dsQAManager.PaymentPointsDataTable lst = new QAManagement.Data.dsQAManager.PaymentPointsDataTable();
            foreach (PaymentPoints item in itemlist)
                lst.AddPaymentPointsRow(ConvertToDataRow(item));
            return lst;
        }

    }
}
