namespace OpenClosedPrinciple
{
    public class JusticeMinistry : IMinistry
    {
        public List<Policy> CheckPolicies(Policy policy)
        {
            return new List<Policy>().FindAll(p => p.AllowInternational == false);
        }
    }


}
