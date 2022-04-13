namespace Core.ElasticSearch
{
    public interface IResult
    {
        bool Success { get; }
        string Message { get; }
    }
}
