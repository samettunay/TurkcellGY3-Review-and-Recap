using KidegaApp.DataTransferObjects.Responses;
using KidegaApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KidegaApp.Services.Services
{
    public interface ICampaignService
    {
        IEnumerable<CampaignDisplayResponse> GetCampaignsForList();
        Task<IEnumerable<CampaignDisplayResponse>> GetCampaignsForListAsync();
    }
}
