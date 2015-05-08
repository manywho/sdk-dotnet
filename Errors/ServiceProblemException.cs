namespace ManyWho.Flow.SDK.Errors
{    public class ServiceProblemException : ApiProblemException
    {
        public ServiceProblemException(ServiceProblem problem)
            : base(problem)
        {

        }
    }
}
