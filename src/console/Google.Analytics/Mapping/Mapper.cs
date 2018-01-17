using System.Collections.Generic;
using System.Linq;
using Google.Analytics.Model.Ga.Entity;

namespace Google.Analytics.Mapping
{
    public class Mapper
    {
        public List<BufferDicClient> MapOne(IList<IList<string>> analyticsOne)
        {
            return analyticsOne.Select(gaEntity => new BufferDicClient
            {
                client_id = gaEntity[0],
                regions = gaEntity[1],
                browser = gaEntity[2]
            }).ToList();
        }

        public List<BufferFctSession> MapTwo(IList<IList<string>> analyticsTwo)
        {
            return analyticsTwo.Select(gaEntity => new BufferFctSession
            {
                session_id = gaEntity[0],
                client_id = gaEntity[1],
                session_time = gaEntity[2],
                is_reg = gaEntity[4] == "1"
            }).ToList();
        }

        public List<BufferFctSessionChannel> MapThree(IList<IList<string>> analyticsThree)
        {
            return analyticsThree.Select(gaEntity => new BufferFctSessionChannel
            {
                session_id = gaEntity[0],
                utm_source = gaEntity[1],
                utm_medium = gaEntity[2],
                utm_campaign = gaEntity[3],
                utm_term = gaEntity[4],
                utm_placement = gaEntity[5]
            }).ToList();
        }

        public List<BufferFctSessionHits> MapFour(IList<IList<string>> analyticsFour)
        {
            return analyticsFour.Select(gaEntity => new BufferFctSessionHits
            {
                session_id = gaEntity[0],
                page_in_url = gaEntity[1],
                page_out_url = gaEntity[2],
                hit_id = gaEntity[3]
            }).ToList();
        }
    }
}