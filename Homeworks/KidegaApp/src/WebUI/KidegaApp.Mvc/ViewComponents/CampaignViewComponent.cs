using KidegaApp.Services;
using KidegaApp.Services.Services;
using Microsoft.AspNetCore.Mvc;

namespace KidegaApp.Mvc.ViewComponents
{
    public class CampaignViewComponent : ViewComponent
    {
        private readonly ICampaignService _campaignService;

        public CampaignViewComponent(ICampaignService campaignService)
        {
            _campaignService = campaignService;
        }

        public IViewComponentResult Invoke()
        {
            var campaigns = _campaignService.GetCampaignsForList();
            return View(campaigns);
        }
    }
}
