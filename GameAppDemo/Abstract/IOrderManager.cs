using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameAppDemo.Entity;

namespace GameAppDemo.Abstract
{
    public interface IOrderManager
    {
        void GiveOrder(Orders order, Games game, Campaigns campaign);
        void DeleteOrder(Orders order, Games game, Campaigns campaign);
        void UpdateOrder(Orders order, Games game, Campaigns campaign);
    }
}
