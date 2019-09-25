namespace ManyWho.Flow.SDK.Package
{
    /// <summary>
    /// A response that details the conflicts that arose from a packaging operation.
    /// </summary>
    public class PackageConflictResponse
    {
        /// <summary>
        /// Information about any existing elements that were detected
        /// </summary>
        public PackageElements ExistingElements
        {
            get;
            set;
        }
    }
}