using System.Collections.Generic;
using QAManagement.Data.Services.DataContracts;
namespace QAManagement.Views
{
    public class PaymentPointsProvider : baseProvider, IPaymentPointsProvider
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

    }
}
