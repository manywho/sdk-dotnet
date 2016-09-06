using System;
using System.Runtime.Serialization;
using ManyWho.Flow.SDK.Draw.Elements.Value;

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

namespace ManyWho.Flow.SDK.Draw.Elements.Map
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class OperationAPI
    {
        [DataMember]
        public ValueElementIdAPI valueElementToApplyId
        {
            get;
            set;
        }

        [DataMember]
        public ValueElementIdAPI valueElementToReferenceId
        {
            get;
            set;
        }

        [DataMember]
        public String macroElementToExecuteId
        {
            get;
            set;
        }

        [DataMember]
        public Int32 order
        {
            get;
            set;
        }

        [DataMember]
        public bool disabled
        {
            get;
            set;
        }

        [DataMember]
        public string valueElementToApplyDeveloperName
        {
            get;
            set;
        }

        [DataMember]
        public string valueElementToReferenceDeveloperName
        {
            get;
            set;
        }

        [DataMember]
        public string valueElementToApplyCommand
        {
            get;
            set;
        }

        [DataMember]
        public string valueElementToReferenceCommand
        {
            get;
            set;
        }

        [DataMember]
        public string valueElementToApplyCommandFriendly
        {
            get;
            set;
        }

        [DataMember]
        public string valueElementToReferenceCommandFriendly
        {
            get;
            set;
        }

        [DataMember]
        public string valueElementToApplyContentType
        {
            get;
            set;
        }

        [DataMember]
        public string valueElementToApplyTypeElementId
        {
            get;
            set;
        }

        [DataMember]
        public string valueElementToReferenceContentType
        {
            get;
            set;
        }

        [DataMember]
        public string valueElementToReferenceTypeElementId
        {
            get;
            set;
        }
    }
}
