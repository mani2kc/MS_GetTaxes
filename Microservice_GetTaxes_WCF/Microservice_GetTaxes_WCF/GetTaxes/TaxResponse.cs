using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Microservice_GetTaxes_WCF.DataContract
{
    [DataContract]
    public class TaxResponse
    {
        
        private decimal firstBillTaxes;

        [DataMember]
        public decimal FirstBillTaxes { get => firstBillTaxes; set => firstBillTaxes = value; }

        
        private decimal monthlyTaxes;

        [DataMember]
        public decimal MonthlyTaxes { get => monthlyTaxes; set => monthlyTaxes = value; }
    }
}
