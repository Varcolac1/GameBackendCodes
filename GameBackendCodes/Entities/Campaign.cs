using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackendCodes.Entities
{
    public class Campaign : IEntitiy
    {
        public string CampaignId { get; set; }
        public string CampaignGame { get; set; }
        public string CampaignExplanation { get; set; }
    }
}
