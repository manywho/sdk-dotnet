using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

/*!

Copyright 2013 Manywho, Inc.

Licensed under the Manywho License, Version 1.0 (the "License"); you may not use this
file except in compliance with the License.

You may obtain a copy of the License at: http://manywho.com/sharedsource

Unless required by applicable law or agreed to in writing, software distributed under
the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
KIND, either express or implied. See the License for the specific language governing
permissions and limitations under the License.

*/

namespace ManyWho.Flow.SDK.Draw.Util
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class ModelBuilderQueryAPI
    {
        [DataMember]
        public string search
        {
            get;
            set;
        }

        [DataMember]
        public string comparisionType
        {
            get;
            set;
        }

        [DataMember]
        public List<ModelBuilderQueryWhereAPI> where
        {
            get;
            set;
        } = new List<ModelBuilderQueryWhereAPI>();

        [DataMember]
        public int? limit
        {
            get;
            set;
        }

        [DataMember]
        public int size
        {
            get;
            set;
        }

        [DataMember]
        public string orderBy
        {
            get;
            set;
        }

        [DataMember]
        public string orderDirection
        {
            get;
            set;
        }

        [DataMember]
        public string flowId
        {
            get;
            set;
        }

        [DataMember]
        public bool isSnapShot
        {
            get;
            set;
        }

        [DataMember]
        public bool includeContent
        {
            get;
            set;
        } = true;
    }
}
