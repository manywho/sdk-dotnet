using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using ManyWho.Flow.SDK.Run.Elements.Type;

namespace ManyWho.Flow.SDK.Run
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class EngineValueRequestAPI
    {
        [DataMember]
        public String Id
        {
            get;
            set;
        }

        [DataMember]
        public String TypeElementEntryId
        {
            get;
            set;
        }

        [DataMember]
        public String DeveloperName
        {
            get;
            set;
        }

        [DataMember]
        public String TypeElementEntryDeveloperName
        {
            get;
            set;
        }

        [DataMember]
        public String ContentValue
        {
            get;
            set;
        }

        [DataMember]
        public String ContentType
        {
            get;
            set;
        }

        [DataMember]
        public List<ObjectAPI> ObjectData
        {
            get;
            set;
        }
    }
}
