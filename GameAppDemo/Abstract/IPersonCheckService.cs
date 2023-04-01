using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameAppDemo.Entity;

namespace GameAppDemo.Abstract
{
    public interface IPersonCheckService
    {
        bool CheckGamer(Gamers gamer);
    }
}
