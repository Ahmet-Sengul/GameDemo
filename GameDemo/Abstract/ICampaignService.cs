using GameDemo.Enitities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Abstract
{
    interface ICampaignService
    {
        void Add(Campaign campaing);
        void Update(Campaign campaing);
        void Delete(Campaign campaing);
    }
}
