using System.ComponentModel.DataAnnotations;

namespace KidegaApp.DataTransferObjects.Requests
{
    public class CreateNewCampaignRequest
    {
        [MinLength(3, ErrorMessage = "En az 3 harf")]
        [Required(ErrorMessage = "Kurs Adını Boş Bırakmayınız!")]
        public string Name { get; set; }
        public string? Description { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int DiscountRate { get; set; }
        public string ImageUrl { get; set; } = "https://mybiros.com/wp-content/themes/qik/assets/images/no-image/No-Image-Found-400x264.png";

    }
}
