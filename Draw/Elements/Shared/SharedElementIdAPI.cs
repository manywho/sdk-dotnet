using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace ManyWho.Flow.SDK.Draw.Elements.Shared
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class SharedElementIdAPI
    {
        public SharedElementIdAPI()
        {

        }

        public SharedElementIdAPI(Guid id, Guid typeElementEntryId, String command)
        {
            this.id = id.ToString();

            if (typeElementEntryId != null &&
                typeElementEntryId != Guid.Empty)
            {
                this.typeElementEntryId = typeElementEntryId.ToString();
            }

            this.command = command;
        }

        public SharedElementIdAPI(String id, String typeElementEntryId, String command)
        {
            this.id = id;
            this.typeElementEntryId = typeElementEntryId;
            this.command = command;
        }

        [DataMember]
        public String id
        {
            get;
            set;
        }

        [DataMember]
        public String versionId
        {
            get;
            set;
        }

        [DataMember]
        public String command
        {
            get;
            set;
        }

        [DataMember]
        public String developerName
        {
            get;
            set;
        }

        [DataMember]
        public String typeElementDeveloperName
        {
            get;
            set;
        }

        [DataMember]
        public String typeElementEntryDeveloperName
        {
            get;
            set;
        }

        [DataMember]
        public String typeElementEntryTypeElementId
        {
            get;
            set;
        }

        [DataMember]
        public String elementType
        {
            get;
            set;
        }

        [DataMember]
        public String typeElementId
        {
            get;
            set;
        }

        [DataMember]
        public String typeElementEntryId
        {
            get;
            set;
        }

        [DataMember]
        public String contentType
        {
            get;
            set;
        }

        [DataMember]
        public Boolean isFixed
        {
            get;
            set;
        }
    }
}