using System.Collections.Generic;

namespace ManyWho.Flow.SDK.Describe
{
    public class DescribeServiceResponseBaseAPI
    {
        /// <summary>
        /// Configuration information that's required to set up the service.  These are values that are typically not associated with
        /// input/output or moment in time information - this is stuff that is required for the service to function correctly.
        /// </summary>
        public List<DescribeValueAPI> ConfigurationValues
        {
            get;
            set;
        }

        /// <summary>
        /// Tells the system whether or not the service exposes logic actions.
        /// </summary>
        public bool ProvidesLogic
        {
            get;
            set;
        }

        /// <summary>
        /// Tells the system whether or not the service exposes views.
        /// </summary>
        public bool ProvidesViews
        {
            get;
            set;
        }

        /// <summary>
        /// Indicates if this service provides object data support for the provided types.
        /// </summary>
        public bool ProvidesDatabase
        {
            get;
            set;
        }

        /// <summary>
        /// Indicates if this service provides identity information for authentication and authorization calls.
        /// </summary>
        public bool ProvidesIdentity
        {
            get;
            set;
        }

        /// <summary>
        /// Indicates if this service provides social networking capabilities to the flow.
        /// </summary>
        public bool ProvidesSocial
        {
            get;
            set;
        }

        /// <summary>
        /// Indicates if this service provides files for download and upload. This is logically separate from the social networking where it is
        /// assumed the feed supports basic file attachments.
        /// </summary>
        public bool ProvidesFiles
        {
            get;
            set;
        }

        public bool ProvidesAutoBinding
        {
            get;
            set;
        }

        public bool ProvidesConsuming
        {
            get;
            set;
        }
    }
}
