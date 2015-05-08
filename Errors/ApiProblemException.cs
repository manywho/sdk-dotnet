using System;

namespace ManyWho.Flow.SDK.Errors
{
    public class ApiProblemException : Exception
    {
        public ApiProblemException(ApiProblem problem)
            : base()
        {
            this.Problem = problem;
        }

        public ApiProblem Problem { get; private set; }
    }
}
