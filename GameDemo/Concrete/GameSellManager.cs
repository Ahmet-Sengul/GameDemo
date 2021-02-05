using GameDemo.Abstract;
using GameDemo.Enitities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Concrete
{
    class GameSellManager : IGameSellService
    {
        public double _campaignPrice;

        public GameSellManager(Campaign campaign, Game game)
        {
            _campaignPrice = game.Price * campaign.CampaignRate;
        }

        public void sell(Game game, Gamer gamer, Campaign campaign)
        {
            if (campaign != null)
            {
                Console.WriteLine(game.GameName + " adlı oyun " + gamer.FirstName + " oyuncusu tarafından " + campaign.CampaignName + " adlı kampanyayı kullanarak " + _campaignPrice + " indirim yapılarak satın alındı.");
            }
            else
            {
                Console.WriteLine(game.GameName + " adlı oyun " + gamer.FirstName + " oyuncusu tarafından " + " kampanya kullanılmayarak satın alındı.");
            }
        }


    }
}
