using GameDemo.Enitities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Abstract
{
    interface IGameSellService
    {
        void sell(Game game,Gamer gamer,Campaign campaing);
    }
}
