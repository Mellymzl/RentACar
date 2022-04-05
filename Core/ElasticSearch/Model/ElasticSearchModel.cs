using Nest;

namespace Core.ElasticSearch.Model
{
    public class ElasticSearchModel
    {
        public Id ElasticId { get; set; }
        public string IndexName { get; set; }
    }
}