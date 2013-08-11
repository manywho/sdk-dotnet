using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace ManyWho.Flow.SDK.Draw.Util
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class ModelBuilderQueryAPI
    {
        [DataMember]
        public String search
        {
            get;
            set;
        }

        [DataMember]
        public String comparisionType
        {
            get;
            set;
        }

        [DataMember]
        public List<ModelBuilderQueryWhereAPI> where
        {
            get;
            set;
        }

        [DataMember]
        public Int32 limit
        {
            get;
            set;
        }

        [DataMember]
        public Int32 size
        {
            get;
            set;
        }

        [DataMember]
        public String orderBy
        {
            get;
            set;
        }

        [DataMember]
        public String orderDirection
        {
            get;
            set;
        }

        [DataMember]
        public String flowId
        {
            get;
            set;
        }

        [DataMember]
        public Boolean isSnapShot
        {
            get;
            set;
        }
    }
}
