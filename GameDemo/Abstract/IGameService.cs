using GameDemo.Enitities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Abstract
{
   interface IGameService
    {
        void Add(Game gaame);
        void Update(Game game);
        void Delete(Game game);
    }
}
