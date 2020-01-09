using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using ManyWho.Flow.SDK.Translate;

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

namespace ManyWho.Flow.SDK.Run.Elements.Type
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class ObjectDataResponseAPI
    {
        /// <summary>
        /// The culture for the service response.
        /// </summary>
        [DataMember]
        public CultureAPI culture
        {
            get;
            set;
        }

        /// <summary>
        /// The list of objects post select, insert, update, delete
        /// </summary>
        [DataMember]
        public List<ObjectAPI> objectData
        {
            get;
            set;
        }

        /// <summary>
        /// Indicates if there are more results available based on the offset and limit provided
        /// </summary>
        [DataMember]
        public bool hasMoreResults
        {
            get;
            set;
        }

        /// <summary>
        /// An optional offset token, sent by the service if required for pagination
        /// </summary>
        [DataMember]
        public string offsetToken
        {
            get;
            set;
        }
        
        /// <summary>
        /// The unique ID of the state
        /// </summary>
        [DataMember]
        public Guid stateId
        {
            get;
            set;
        }
    }
}