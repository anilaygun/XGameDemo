using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameAppDemo.Abstract;
using GameAppDemo.Entity;
using GameAppDemo.MernisServiceReference;

namespace GameAppDemo.Adapters
{
    public class MernisCheckServiceAdapter : IPersonCheckService
    {
        public bool CheckGamer(Gamers gamer)
        {
            MernisServiceReference.KPSPublicSoapClient client = new KPSPublicSoapClient();
            return client.TCKimlikNoDogrula(Convert.ToInt64(gamer.GamerNationalityId), gamer.GamerFirstName.ToUpper(), gamer.GamerLastName.ToUpper(), gamer.GamerDateOfBirth.Year);
        }
    }
}
