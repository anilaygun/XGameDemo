using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameAppDemo.Adapters;
using GameAppDemo.Concrete;
using GameAppDemo.Entity;

namespace GameAppDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            XGameManager gameManager = new XGameManager(new MernisCheckServiceAdapter());
            gameManager.Register(new Gamers
            {
                Id = 1,
                GamerFirstName = "Anıl",
                GamerLastName = "Aygün",
                GamerDateOfBirth = new DateTime(2001, 1, 28),
                GamerEmail = "gameplayer@xgame.com",
                GamerNationalityId = "11111111111",
                GamerNickName = "corenil",
                GamerPassword = "pass123"
            });
            gameManager.AddCampaign(new Campaigns { Id = 1, CampaignName = "Bir Alana 5 Bedava!!!", CampaignDescription = "Deneme Kamapanya", CampaignDiscount = 10 },new Games{Id = 1,GameName = "The Last Of Us",GamePrice = 599});
            gameManager.GiveOrder(new Orders { Id = 1, OrderName="İlk Sipariş", OderderTime = DateTime.Now, OrderAmount = 0 },new Games{GameName ="GTA 6",GamePrice = 699,Id = 2},new Campaigns{CampaignDescription = "İLK ALIŞVERİŞE ÖZEL %100 İNDİRİM",CampaignDiscount = 100});


            Console.ReadLine();

        }
    }
}
