namespace SingleResponsibilityPrinciple
{
    public interface IEarthquakeAPI
    {
        Task<string> GetAsync();
    }
}