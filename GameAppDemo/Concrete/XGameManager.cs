using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameAppDemo.Abstract;
using GameAppDemo.Entity;

namespace GameAppDemo.Concrete
{
    public class XGameManager : IGamerManager, ICampaignManager, IOrderManager
    {
        private IPersonCheckService _personCheckService;

        public XGameManager(IPersonCheckService personCheckService)
        {
            _personCheckService = personCheckService;
        }

        // Gamer Side
        public void Register(Gamers gamer)
        {
            if (_personCheckService.CheckGamer(gamer))
            {
                Console.WriteLine("Oyuncu kaydı oluşturuldu: " + gamer.GamerFirstName + " " + gamer.GamerLastName);
            }
            else
            {
                throw new Exception("Kişi Bilgileri Uyumsuz!");
            }

        }

        public void Unregister(Gamers gamer)
        {
            Console.WriteLine("Oyuncu kaydı kaldırıldı: " + gamer.GamerFirstName + " " + gamer.GamerLastName);
        }

        public void UpdateInfo(Gamers gamer)
        {
            Console.WriteLine("Oyuncu kaydı güncellendi: " + gamer.GamerFirstName + " " + gamer.GamerLastName);
        }

        //Campaign Side
        public void AddCampaign(Campaigns campaign, Games game)
        {
            Console.WriteLine("Kampanya eklendi: " + campaign.CampaignName + "-> " + game.GameName+" | "+campaign.CampaignDescription);
        }

        public void RemoveCampaign(Campaigns campaign, Games game)
        {
            Console.WriteLine("Kampanya silindi: " + campaign.CampaignName + "-> " + game.GameName);
        }

        public void UpdateCampaign(Campaigns campaign, Games game)
        {
            Console.WriteLine("Kampanya güncellendi: " + campaign.CampaignName + "-> " + game.GameName+campaign);
        }

        //Order Side
        public void GiveOrder(Orders order, Games game, Campaigns campaign)
        {
            Console.WriteLine("Sipariş oluşturuldu: " + order.OrderName + "->" + game.GameName + "->" + campaign.CampaignName + "Toplam Tutar: " + order.OrderAmount);
        }

        public void DeleteOrder(Orders order, Games game, Campaigns campaign)
        {
            Console.WriteLine("Sipariş silindi: " + order.OrderName + "->" + game.GameName + "->" + campaign.CampaignName + "Toplam Tutar: " + order.OrderAmount);
        }

        public void UpdateOrder(Orders order, Games game, Campaigns campaign)
        {
            Console.WriteLine("Sipariş güncellendi: " + order.OrderName + "->" + game.GameName + "->" + campaign.CampaignName + "Toplam Tutar: " + order.OrderAmount);
        }

    }
}
