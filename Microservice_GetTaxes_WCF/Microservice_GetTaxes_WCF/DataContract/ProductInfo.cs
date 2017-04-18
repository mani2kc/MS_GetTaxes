using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Microservice_GetTaxes_WCF.DataContract
{
    [DataContract]
    public class ProductInfo
    {         
        private String productIOSC;

        [DataMember]
        public String ProductIOSC
        {
            get { return productIOSC; }
            set { productIOSC = value; }
        } 
       
        private decimal  rate;

        [DataMember]
        public decimal  Rate
        {
            get { return rate; }
            set { rate = value; }
        }

    }
}
