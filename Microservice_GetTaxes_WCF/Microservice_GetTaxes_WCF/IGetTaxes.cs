using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Microservice_GetTaxes_WCF.DataContract; 

namespace Microservice_GetTaxes_WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IGetTaxes
    {
        [OperationContract]
        TaxResponse GetSOCTaxes(TaxRequest taxRequest);

        // TODO: Add your service operations here
    }

    
}
