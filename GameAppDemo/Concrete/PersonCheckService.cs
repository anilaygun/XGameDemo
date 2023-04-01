using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameAppDemo.Abstract;
using GameAppDemo.Entity;

namespace GameAppDemo.Concrete
{
    public class PersonCheckService:IPersonCheckService
    {
        public bool CheckGamer(Gamers gamer)
        {
            return true;
        }
    }
}
