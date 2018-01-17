using System.Collections.Generic;
using System.Linq;

namespace Google.Analytics.Model.Ga.Dimensions
{
    public abstract class DimensionsBase
    {
        protected List<string> DimensionsSet = new List<string>();
        protected List<string> MetricsSet = new List<string> { "ga:visits" };
        protected List<string> Filters;
        protected List<string> Sort;

        public string GetDimension()
        {
            return string.Join(", ", DimensionsSet.Select(x => x));
        }

        public string GetMetrics()
        {
            return string.Join(", ", MetricsSet.Select(x => x));
        }

        public string GetFilters()
        {
            return (Filters == null || Filters.Count == 0) ? null : string.Join(", ", Filters);
        }

        public string GetSort()
        {
            return (Sort == null || Sort.Count == 0) ? null : string.Join(", ", Sort);
        }
    }
}
