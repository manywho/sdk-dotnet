using System;

namespace ManyWho.Flow.SDK.Errors
{
    public class ApiProblemException : Exception
    {
        public ApiProblemException(ApiProblem problem)
            : base(problem.Message)
        {
            Problem = problem;
        }

        public ApiProblem Problem { get; private set; }
    }
}
