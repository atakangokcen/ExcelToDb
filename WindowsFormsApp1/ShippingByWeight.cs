using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    // Another Table 
    public class ShippingByWeight
    {

        public int ZoneId { get; set; }
        public String Zip { get; set; }
        public int ShippingMethodId { get; set; }
        public decimal From { get; set; }
        public decimal To { get; set; }
        public decimal AdditionalFixedCost { get; set; }
        public decimal PercentageRateOfSubtotal { get; set; }
        public decimal RatePerWeightUnit { get; set; }
        public decimal LowerWeightLimit { get; set; }
        public int StoreId { get; set; }

    }
}
