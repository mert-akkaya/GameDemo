using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo
{
    class Campaign:IEntities
    {
        public int CampaignId { get; set; }
        public string CampaignDiscountRate { get; set; }
    }
}
