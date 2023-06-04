using AutoMapper;
using KidegaApp.DataTransferObjects.Responses;
using KidegaApp.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KidegaApp.Services.Services
{
    public class CampaignService : ICampaignService
    {
        private readonly ICampaignRepository repository;
        private readonly IMapper _mapper;

        public CampaignService(ICampaignRepository repository, IMapper mapper)
        {
            this.repository = repository;
            _mapper = mapper;
        }

        public IEnumerable<CampaignDisplayResponse> GetCampaignsForList()
        {
            var campaigns = repository.GetAll();
            var response = _mapper.Map<IEnumerable<CampaignDisplayResponse>>(campaigns);
            return response;
        }

        public async Task<IEnumerable<CampaignDisplayResponse>> GetCampaignsForListAsync()
        {
            var campaigns = await repository.GetAllAsync();
            var response = _mapper.Map<IEnumerable<CampaignDisplayResponse>>(campaigns);
            return response;
        }
    }
}
