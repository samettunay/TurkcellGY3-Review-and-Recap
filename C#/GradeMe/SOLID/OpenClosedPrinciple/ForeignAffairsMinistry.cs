namespace OpenClosedPrinciple
{
    public class ForeignAffairsMinistry : IMinistry
    {
        public List<Policy> CheckPolicies(Policy policy)
        {
            return new List<Policy>().FindAll(p => p.MaximumBudget > 20000);
        }
    }


}
