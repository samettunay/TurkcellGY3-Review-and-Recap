using KidegaApp.Entities;
using KidegaApp.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace KidegaApp.Infrastructure.Repositories
{
    public class EFCampaignRepository : EFBaseRepository<KidegaDbContext, Campaign>, ICampaignRepository
    {
        public EFCampaignRepository(KidegaDbContext context) : base(context)
        {

        }
    }
}
