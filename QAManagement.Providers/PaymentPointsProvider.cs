using System.Collections.Generic;
using QAManagement.Data.Services.DataContracts;
using QAManagement.Views;
using System.ComponentModel;
namespace QAManagement
{
    [DataObject(true)]
    public class PaymentPointsProvider : baseProvider
    {
        public PaymentPoints ConvertToModel(basePaymentPointsView item)
        {
            PaymentPoints model = new PaymentPoints();
            model.ID = item.ID;
            model.UserID = item.UserID;
            model.Points = item.Points;
            return model;
        }
        public List<PaymentPoints> ConvertToModelList(List<basePaymentPointsView> itemlist)
        {
            List<PaymentPoints> lst = new List<PaymentPoints>();
            foreach (basePaymentPointsView item in itemlist)
                lst.Add(ConvertToModel(item));
            return lst;
        }
        public basePaymentPointsView ConvertToView(PaymentPoints item)
        {
            basePaymentPointsView view = new basePaymentPointsView();
            view.ID = item.ID;
            view.UserID = item.UserID;
            view.Points = item.Points;
            return view;
        }
        public List<basePaymentPointsView> ConvertToViewList(List<PaymentPoints> itemlist)
        {
            List<basePaymentPointsView> lst = new List<basePaymentPointsView>();
            foreach (PaymentPoints item in itemlist)
                lst.Add(ConvertToView(item));
            return lst;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public basePaymentPointsView GetPaymentPoint(int id)
        {
            QAManagement.Data.Services.PaymentPointsService svc = new Data.Services.PaymentPointsService();
            Data.Services.DataContracts.PaymentPoints item = svc.GetPaymentPoints(id);

            return this.ConvertToView(item);
        }

    }
}
