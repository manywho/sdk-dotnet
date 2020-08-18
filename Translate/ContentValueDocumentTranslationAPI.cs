using System.Collections.Generic;
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

namespace ManyWho.Flow.SDK.Translate
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class ContentValueDocumentTranslationAPI
    {
        /// <summary>
        /// The set of content value translations for a particular element. The key of the content value is the identifier for the
        /// property in the element.
        /// </summary>
        [DataMember]
        public Dictionary<string, string> contentValues
        {
            get;
            set;
        }

        /// <summary>
        /// The set of object data translations for a particular element. The key of the object data is the identifier for the
        /// property in the element.
        /// </summary>
        [DataMember]
        public Dictionary<string, List<ObjectAPI>> objectData
        {
            get;
            set;
        }
    }
}
