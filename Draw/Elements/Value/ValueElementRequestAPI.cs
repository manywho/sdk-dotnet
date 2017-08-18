using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using ManyWho.Flow.SDK.Run.Elements.Type;
using ManyWho.Flow.SDK.Draw.Elements.Map;

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

namespace ManyWho.Flow.SDK.Draw.Elements.Value
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class ValueElementRequestAPI : ValueElementAPI
    {
        [DataMember]
        public Boolean isFixed
        {
            get;
            set;
        }

        [DataMember]
        public Boolean isVersionless
        {
            get;
            set;
        }

        [DataMember]
        public String access
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
        public String contentFormat
        {
            get;
            set;
        }

        [DataMember]
        public String defaultContentValue
        {
            get;
            set;
        }

        [DataMember]
        public List<ObjectAPI> defaultObjectData
        {
            get;
            set;
        }

        [DataMember]
        public List<OperationAPI> initializationOperations
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
        public String typeElementDeveloperName
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