using Elsa.Jobs.Services;

namespace Elsa.Jobs.Implementations;

public class JobFactory : IJobFactory
{
    public IJob Create(Type jobType)
    {
        var job = (IJob)Activator.CreateInstance(jobType)!;
        job.Id = Guid.NewGuid().ToString(); // TODO: Consider moving IIdentityGenerator from Elsa.Workflows.Core to a shared class library.

        return job;
    }
}