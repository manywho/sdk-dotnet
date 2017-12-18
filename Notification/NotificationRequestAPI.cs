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

namespace ManyWho.Flow.SDK.Notification
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class NotificationRequestAPI
    {
        /// <summary>
        /// The reason for the notification. Typically, the reason will be provided as the 'subject' for email notifications.
        /// </summary>
        [DataMember]
        public String reason
        {
            get;
            set;
        }

        /// <summary>
        /// The Url to redirect the user to once this notification has been processed by the platform.
        /// </summary>
        [DataMember]
        public String redirectUrl
        {
            get;
            set;
        }

        /// <summary>
        /// The list of notification messages to be sent.
        /// </summary>
        [DataMember]
        public List<NotificationMessageAPI> notificationMessages
        {
            get;
            set;
        }
    }
}
