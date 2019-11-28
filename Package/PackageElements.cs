using System.Collections.Generic;

namespace ManyWho.Flow.SDK.Package
{
    public class PackageElements
    {
        public IEnumerable<PackageElement> Flows
        {
            get;
            set;
        } = new List<PackageElement>();

        public IEnumerable<PackageElement> GroupElements
        {
            get;
            set;
        } = new List<PackageElement>();

        public IEnumerable<PackageElement> MacroElements
        {
            get;
            set;
        } = new List<PackageElement>();

        public IEnumerable<PackageElement> MapElements
        {
            get;
            set;
        } = new List<PackageElement>();

        public IEnumerable<PackageElement> NavigationElements
        {
            get;
            set;
        } = new List<PackageElement>();

        public IEnumerable<PackageElement> PageElements
        {
            get;
            set;
        } = new List<PackageElement>();

        public IEnumerable<PackageElement> ServiceElements
        {
            get;
            set;
        } = new List<PackageElement>();

        public IEnumerable<PackageElement> TagElements
        {
            get;
            set;
        } = new List<PackageElement>();

        public IEnumerable<PackageElement> TypeElements
        {
            get;
            set;
        } = new List<PackageElement>();

        public IEnumerable<PackageElement> ValueElements
        {
            get;
            set;
        } = new List<PackageElement>();
    }
}