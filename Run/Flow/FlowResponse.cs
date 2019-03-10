using System;
using ManyWho.Flow.SDK.Draw.Flow;
using ManyWho.Flow.SDK.Security;

namespace ManyWho.Flow.SDK.Run.Flow
{
    public class FlowResponse
    {
        /// <summary>
        /// The complete unique identifier for the currently edited version of the flow.
        /// </summary>
        /// <remarks>
        /// This value should not be included when creating new flows.
        /// </remarks>
        public FlowIdAPI Id
        {
            get;
            set;
        }
        
        /// <summary>
        /// The developer name for the flow. When referencing flows by name, this is the name you should use in your referencing.
        /// </summary>
        /// <remarks>
        /// This is typically a helpful name to remind builders of the purpose of the flow.
        /// </remarks>
        public string DeveloperName
        {
            get;
            set;
        }

        /// <summary>
        /// The developer summary the author provided to give more information about the Flow.
        /// </summary>
        public string DeveloperSummary
        {
            get;
            set;
        }
        
        /// <summary>
        /// The date and time the flow was created at
        /// </summary>
        public DateTimeOffset DateCreated
        {
            get;
            set;
        }

        /// <summary>
        /// The date and time of the last modification to the flow
        /// </summary>
        public DateTimeOffset DateModified
        {
            get;
            set;
        }

        /// <summary>
        /// The builder who created the flow
        /// </summary>
        public BuilderWhoAPI WhoCreated
        {
            get;
            set;
        }

        /// <summary>
        /// The builder who last modified the flow
        /// </summary>
        public BuilderWhoAPI WhoModified
        {
            get;
            set;
        }

        /// <summary>
        /// The builder who owns the flow
        /// </summary>
        public BuilderWhoAPI WhoOwner
        {
            get;
            set;
        }

        /// <summary>
        /// The email of the builder who activated the flow
        /// </summary>
        public string AlertEmail
        {
            get;
            set;
        }

        /// <summary>
        /// Indicates if this flow version is the active version.
        /// </summary>
        /// <remarks>
        /// In the case of run operations this will always be true, and for draw operations this will be false.
        /// </remarks>
        public bool IsActive
        {
            get;
            set;
        }

        /// <summary>
        /// Indicates if this flow version is the default version.
        /// </summary>
        /// <remarks>
        /// In the case of run operations this will always be true, and for draw operations this will be false.
        /// </remarks>
        public bool IsDefault
        {
            get;
            set;
        }

        /// <summary>
        /// The activation comment provided by the builder, if given
        /// </summary>
        public string Comment
        {
            get;
            set;
        }
        
        /// <summary>
        /// The unique identifier for the first element in the flow. This element is always of the `START` map element type.
        /// </summary>
        public string StartMapElementId
        {
            get;
            set;
        }
    }
}