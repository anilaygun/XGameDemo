using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameAppDemo.Entity
{
    public class Campaigns:IEntity
    {
        public int Id { get; set; }
        public string CampaignName { get; set; }
        public string CampaignDescription { get; set; }
        public int CampaignDiscount { get; set; }
    }
}
