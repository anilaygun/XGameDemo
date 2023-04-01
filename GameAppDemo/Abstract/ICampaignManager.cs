using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameAppDemo.Entity;

namespace GameAppDemo.Abstract
{
    public interface ICampaignManager
    {
        void AddCampaign(Campaigns campaign, Games game);
        void RemoveCampaign(Campaigns campaign, Games game);
        void UpdateCampaign(Campaigns campaign, Games game);
    }
}
