using Abp.Domain.Entities;
using GWebsite.AbpZeroTemplate.Core.Models;

namespace GWebsite.AbpZeroTemplate.Application.Share.Liquidations.Dto
{
    /// <summary>
    /// <model cref="Liquidation"></model>
    /// </summary>
    public class LiquidationInput : Entity<int>
    {
        public string LiquidatorName { get; set; }
        public string ContractCode { get; set; }
        public string Date { get; set; }
        public string TotalAsset { get; set; }
        public string TotalPrice { get; set; }
    }
}
