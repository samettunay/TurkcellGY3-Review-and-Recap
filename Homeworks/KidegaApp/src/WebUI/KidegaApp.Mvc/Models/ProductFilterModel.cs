namespace KidegaApp.Mvc.Models
{
    public class ProductFilterModel
    {
        public int? CampaignId { get; set; }
        public int? CategoryId { get; set; }
        public int? MinPrice { get; set; }
        public int? MaxPrice { get; set; }
        public string? BrandName { get; set; }
    }
}
