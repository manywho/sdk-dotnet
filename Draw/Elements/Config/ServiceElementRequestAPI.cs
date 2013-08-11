using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
using ManyWho.Flow.SDK.Draw.Elements.Type;

namespace ManyWho.Flow.SDK.Draw.Elements.Config
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class ServiceElementRequestAPI : ServiceElementAPI
    {
        [DataMember]
        public String uri
        {
            get;
            set;
        }

        [DataMember]
        public String format
        {
            get;
            set;
        }

        [DataMember]
        public List<ServiceValueRequestAPI> configurationValues
        {
            get;
            set;
        }

        [DataMember]
        public Boolean exposesLogic
        {
            get;
            set;
        }

        [DataMember]
        public Boolean exposesViews
        {
            get;
            set;
        }

        [DataMember]
        public Boolean exposesTables
        {
            get;
            set;
        }

        [DataMember]
        public Boolean providesIdentity
        {
            get;
            set;
        }

        [DataMember]
        public Boolean providesSocial
        {
            get;
            set;
        }

        [DataMember]
        public List<ServiceActionRequestAPI> actions
        {
            get;
            set;
        }

        [DataMember]
        public ServiceInstallRequestAPI install
        {
            get;
            set;
        }

        [DataMember]
        public Boolean updateByName
        {
            get;
            set;
        }
    }
}