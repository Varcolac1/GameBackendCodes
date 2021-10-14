using GameBackendCodes.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackendCodes.Abstract
{
    public interface ICampaignService
    {
        void AddCampaign(Campaign campaign);
        void DeleteCampaign(Campaign campaign);
        void UpdateCampaign(Campaign campaign);
    }
}
