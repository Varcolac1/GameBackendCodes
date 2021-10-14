using GameBackendCodes.Abstract;
using GameBackendCodes.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackendCodes.Concrete
{
    class CampaigManager : ICampaignService
    {
        public void AddCampaign(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignGame + " " + campaign.CampaignExplanation);
        }

        public void DeleteCampaign(Campaign campaign)
        {
            Console.WriteLine("The offer on the game " + campaign.CampaignGame + " is no longer viable.");
        }

        public void UpdateCampaign(Campaign campaign)
        {
            Console.WriteLine("the offer on the game " + campaign.CampaignGame + " has been changed.");
        }
    }
}
