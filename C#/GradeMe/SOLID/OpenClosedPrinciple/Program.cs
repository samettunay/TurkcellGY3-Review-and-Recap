using OpenClosedPrinciple;

Policy policy = new Policy()
{
    PolicyName = "Sigara İçme Yasaklarına İlişkin Politika",
    MinimumAge = 18,
    MaximumBudget = 10000,
    AllowInternational = false
};

IMinistry healthMinistry = new HealthMinistry();
IMinistry justiceMinistry = new JusticeMinistry();

healthMinistry.CheckPolicies(policy);
justiceMinistry.CheckPolicies(policy);


