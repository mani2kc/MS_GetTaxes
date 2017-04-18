using Microservice_GetTaxes_WCF.DataContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Microservice_GetTaxes_WCF
{
    public partial class GetTaxes
    {
        public TaxResponse getTaxes (List<ProductInfo> products)
        {
            TaxResponse taxes = null;

            if(products != null)
            {
                taxes = new TaxResponse();

                decimal monthlytotal = products.Sum(prod => prod.Rate);
                decimal firstBill = monthlytotal + (products.Sum(prod => prod.Rate) / 2);

                //monthly taxes => 10%
                taxes.MonthlyTaxes = monthlytotal / 100 * 10;

                //FirstBill taxes => 10%
                taxes.FirstBillTaxes = firstBill / 100 * 10; 

            }            

            return taxes;
        }
    }
}
