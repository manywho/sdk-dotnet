using System;

namespace ManyWho.Flow.SDK.Package
{
    /// <summary>
    /// A summary of an element from a packaging operation.
    /// </summary>
    public class PackageElement
    {
        /// <summary>
        /// The ID of the element
        /// </summary>
        public Guid Id
        {
            get;
            set;
        }

        /// <summary>
        /// The name of the element
        /// </summary>
        public string DeveloperName
        {
            get;
            set;
        }
    }
}