using KidegaApp.Services;
using KidegaApp.Services.Services;
using Microsoft.AspNetCore.Mvc;

namespace KidegaApp.Mvc.ViewComponents
{
    public class CampaignListViewComponent : ViewComponent
    {
        private readonly ICampaignService _campaignService;

        public CampaignListViewComponent(ICampaignService campaignService)
        {
            _campaignService = campaignService;
        }

        public async Task<IViewComponentResult> InvokeAsync(string? viewName)
        {
            var campaigns = await _campaignService.GetCampaignsForListAsync();
            return View(viewName,campaigns);
        }
    }
}
