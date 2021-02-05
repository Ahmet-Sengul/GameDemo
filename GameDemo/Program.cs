using GameDemo.Concrete;
using GameDemo.Enitities;
using GameDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            Gamer gamer = new Gamer()
            {
                Id =1,
                FirstName = "AHMET",
                LastName = "ŞENGÜL",
                DogumYılı = 2000,
                TcNo = "12587456398"

            };
            gamerManager.Add(gamer);

            Campaign campaign = new Campaign()
            {
                Id = 1,
                CampaignName = "Ağaya Beleş",
                CampaignRate = 0
            };

            Game game = new Game()
            {
                Id = 1,
                GameName = "Leistok",
                Price = 50,
            };

            CampaingManager campaignManager = new CampaingManager();
            campaignManager.Add(campaign);

            GameSellManager gameSellManager = new GameSellManager(campaign,game);
            gameSellManager.sell(game, gamer, campaign);

            


            Console.ReadLine();










        }
    }
}
