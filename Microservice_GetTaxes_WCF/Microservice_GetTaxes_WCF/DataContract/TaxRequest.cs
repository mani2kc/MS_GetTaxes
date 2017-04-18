using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Microservice_GetTaxes_WCF.DataContract
{
    [DataContract]
    public class TaxRequest
    {       
      private List<ProductInfo> products;

      [DataMember]
      public List<ProductInfo> Products { get => products; set => products = value; }
            
    }
}
