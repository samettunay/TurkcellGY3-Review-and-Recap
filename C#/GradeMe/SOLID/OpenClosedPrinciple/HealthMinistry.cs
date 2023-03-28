namespace OpenClosedPrinciple
{
    public class HealthMinistry : IMinistry
    {
        public List<Policy> CheckPolicies(Policy policy)
        {
            return new List<Policy>().FindAll(p => p.MinimumAge < 18);
        }
    }


}
