using GameAppDemo.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameAppDemo.Abstract
{
    public interface IGamerManager
    {
        void Register(Gamers gamer);
        void Unregister(Gamers gamer);
        void UpdateInfo(Gamers gamer);
    }
}
