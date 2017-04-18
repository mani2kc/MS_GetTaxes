using Microservice_GetTaxes_WCF.DataContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Microservice_GetTaxes_WCF
{
        
    public partial class GetTaxes : IGetTaxes
    { 
       
        public TaxResponse GetSOCTaxes(TaxRequest taxrequest)
        {
            TaxResponse taxresponse = new TaxResponse();

            if (taxrequest != null && taxrequest.Products != null)
            {
                taxresponse = getTaxes(taxrequest.Products);

            }


            return taxresponse;
        
        } 

    }
}
