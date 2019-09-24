using ManyWho.Flow.SDK.Draw.Flow;

namespace ManyWho.Flow.SDK.Package
{
    public class PackageImportResponse
    {
        public FlowResponseAPI Flow
        {
            get;
            set;
        }

        public PackageConflictResponse Conflicts
        {
            get;
            set;
        }
    }
}