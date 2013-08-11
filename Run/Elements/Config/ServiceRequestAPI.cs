using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace ManyWho.Flow.SDK.Run.Elements.Config
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class ServiceRequestAPI
    {
        /// <summary>
        /// The token for this service request.  The token is needed for the service execution manager to identify the correct state.
        /// </summary>
        [DataMember]
        public String token
        {
            get;
            set;
        }

        /// <summary>
        /// The tenant from which this service request eminated.
        /// </summary>
        [DataMember]
        public String tenantId
        {
            get;
            set;
        }

        /// <summary>
        /// The Uri for any callbacks from the remote service.
        /// </summary>
        [DataMember]
        public String callbackUri
        {
            get;
            set;
        }

        /// <summary>
        /// Provides the caller with the URI for the player this flow is currently using to run.
        /// </summary>
        [DataMember]
        public String joinPlayerUri
        {
            get;
            set;
        }

        /// <summary>
        /// Provides the caller with the URI for the player and the associated app.
        /// </summary>
        [DataMember]
        public String playerUri
        {
            get;
            set;
        }

        /// <summary>
        /// The culture for the service request.
        /// </summary>
        [DataMember]
        public CultureAPI culture
        {
            get;
            set;
        }

        /// <summary>
        /// The Uri for the service to invoke.
        /// </summary>
        [DataMember]
        public String uri
        {
            get;
            set;
        }

        /// <summary>
        /// The configuration information needed for the service to function.
        /// </summary>
        [DataMember]
        public List<EngineValueAPI> configurationValues
        {
            get;
            set;
        }

        /// <summary>
        /// The inputs for the service.
        /// </summary>
        [DataMember]
        public List<EngineValueAPI> inputs
        {
            get;
            set;
        }

        /// <summary>
        /// We pass the annotations as part of the service request.
        /// </summary>
        [DataMember]
        public Dictionary<String, String> annotations
        {
            get;
            set;
        }
    }
}