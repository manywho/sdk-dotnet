using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using ManyWho.Flow.SDK.Run.Elements.Type;

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

namespace ManyWho.Flow.SDK.Run.Elements.UI
{
    [Serializable]
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class PageComponentDataResponseAPI
    {
        [DataMember]
        public String pageComponentId
        {
            get;
            set;
        }

        [DataMember]
        public Boolean isEnabled
        {
            get;
            set;
        }

        [DataMember]
        public Boolean isEditable
        {
            get;
            set;
        }

        [DataMember]
        public Boolean isRequired
        {
            get;
            set;
        }

        [DataMember]
        public Boolean isVisible
        {
            get;
            set;
        }

        [DataMember]
        public List<ObjectAPI> objectData
        {
            get;
            set;
        }

        [DataMember]
        public ObjectDataRequestAPI objectDataRequest
        {
            get;
            set;
        }

        [DataMember]
        public FileDataRequestAPI fileDataRequest
        {
            get;
            set;
        }

        [DataMember]
        public String contentValue
        {
            get;
            set;
        }

        [DataMember]
        public String content
        {
            get;
            set;
        }

        [DataMember]
        public String imageUri
        {
            get;
            set;
        }

        [DataMember]
        public Boolean isValid
        {
            get;
            set;
        }

        [DataMember]
        public String validationMessage
        {
            get;
            set;
        }

        [DataMember]
        public List<EngineValueAPI> tags
        {
            get;
            set;
        }
    }
}
