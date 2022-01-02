using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    // Main table
    public class ShippingByWeightByTotalRecord
    {
        public int Id { get; set; }
        public int StoreId { get; set; }
        public int WarehouseId { get; set; }
        public int CountryId { get; set; }
        public int StateProvinceId { get; set; }
        public String Zip { get; set; }
        public int ShippingMethodId { get; set; }
        public decimal WeightFrom { get; set; }
        public decimal WeightTo { get; set; }
        public decimal OrderSubtotalFrom { get; set; }
        public decimal OrderSubtotalTo { get; set; }
        public decimal AdditionalFixedCost { get; set; }
        public decimal PercentageRateOfSubtotal { get; set; }
        public decimal RatePerWeightUnit { get; set; }
        public decimal LowerWeightLimit { get; set; }

    }
}
