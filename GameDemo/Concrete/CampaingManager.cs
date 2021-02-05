using GameDemo.Abstract;
using GameDemo.Enitities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Concrete
{
    class CampaingManager : ICampaignService
    {
        public void Add(Campaign campaing)
        {
            Console.WriteLine(campaing.CampaignName + " yüklendi.");
        }

        public void Delete(Campaign campaing)
        {
            Console.WriteLine(campaing.CampaignName + " silindi.");
        }

        public void Update(Campaign campaing)
        {
             Console.WriteLine(campaing.CampaignName + " güncellendi.");
        }
    }
}
