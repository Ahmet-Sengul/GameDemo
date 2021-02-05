using GameDemo.Abstract;
using GameDemo.Enitities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Concrete
{
    class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.GameName + "eklendi");
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.GameName + "silindi");
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.GameName + "güncellendi.");
        }
    }
}
