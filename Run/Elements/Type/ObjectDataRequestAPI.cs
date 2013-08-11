using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
using ManyWho.Flow.SDK.Run.State;
using ManyWho.Flow.SDK.Run.Elements.Config;

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
    public class ObjectDataRequestAPI
    {
        /// <summary>
        /// The state id that allows us to make the correct version references.
        /// </summary>
        [DataMember]
        public String stateId
        {
            get;
            set;
        }

        /// <summary>
        /// The Id for the service element associated with this object data.  The service element will give us the connection settings
        /// and allow us to validate various info around the type.
        /// </summary>
        [DataMember]
        public String bindingId
        {
            get;
            set;
        }

        /// <summary>
        /// The authorization information for this element.  The authorization information will be used to validate user queries but can
        /// also be used in messages etc, to manage notification.
        /// </summary>
        [DataMember]
        public AuthorizationAPI authorization
        {
            get;
            set;
        }

        /// <summary>
        /// The configuration information that comes from the service element.
        /// </summary>
        [DataMember]
        public List<EngineValueAPI> configurationValues
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
        /// The filter to apply to the data at runtime.
        /// </summary>
        [DataMember]
        public ListFilterAPI listFilter
        {
            get;
            set;
        }

        /// <summary>
        /// This gives the data service the descriptor information needed to pull the information together on the server side.  We use
        /// a separate object as we may not want to do a full property selection - the contents and tree included in here will give us a
        /// full query for the data service.
        /// </summary>
        [DataMember]
        public ObjectDataTypeAPI objectDataType
        {
            get;
            set;
        }

        /// <summary>
        /// The list of objects to insert, update or delete.
        /// </summary>
        [DataMember]
        public List<ObjectAPI> objectData
        {
            get;
            set;
        }
    }
}