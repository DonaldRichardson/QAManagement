using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using QAManagement.Data.Services.DataContracts;
using QAManagement.Views.ViewInterfaces;
namespace QAManagement.Views
{
    public class baseCompanyView : Company, QAManagement.Views.ViewInterfaces.ICompanyView  
    {

    }
}
