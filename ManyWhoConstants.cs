using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

namespace ManyWho.Flow.SDK
{
    public class ManyWhoConstants
    {
        // Engine invoke constants
        public const String INVOKE_TYPE_FORWARD = "FORWARD";
        // Tells the caller that the flow has completed - no more steps
        public const String INVOKE_TYPE_DONE = "DONE";
        // Tells the engine we want to join the running flow - this is used internally only - "STATUS" is used externally as we infer a "JOIN" from the GET request
        public const String INVOKE_TYPE_JOIN = "JOIN";
        // Tells the user we're waiting for something on the system side to complete
        public const String INVOKE_TYPE_WAIT = "WAIT";
        // Tells the engine that the system didn't let them in for some reason - most likely authentication, but it could be some
        // other reason as we develop out various grouping use-cases.  This basically says: try again if you like!
        public const String INVOKE_TYPE_STATUS = "STATUS";
        // Tells any calling services that they no longer need to send the message for that token - their message was accepted
        // by the message action
        public const String INVOKE_TYPE_SUCCESS = "SUCCESS";
        // Tells any calling services that the token has already completed - so they should stop sending messages
        public const String INVOKE_TYPE_TOKEN_COMPLETED = "TOKEN_COMPLETED";
        // Tells the engine to sync the data, but not to shut down the optimize memory or execute - this brings in the social
        // element to the engine
        public const String INVOKE_TYPE_SYNC = "SYNC";
        // Tells the engine that the user has clicked on something in the navigation as opposed to an outcome
        public const String INVOKE_TYPE_NAVIGATE = "NAVIGATE";

        // Engine mode constants
        public const String MODE_DEFAULT = null;
        public const String MODE_LOG = "LOG";
        public const String MODE_DEBUG = "DEBUG";
        public const String MODE_DEBUG_STEPTHROUGH = "DEBUG_STEPTHROUGH";

        // Content Value Implementation constants
        public const String CONTENT_VALUE_IMPLEMENTATION_BASE_COMMAND_DETACH = "DETACH"; // Removes the external identifier from the root object only
        public const String CONTENT_VALUE_IMPLEMENTATION_BASE_COMMAND_EMPTY = "EMPTY"; // blanks out the complex object or table with a null value
        public const String CONTENT_VALUE_IMPLEMENTATION_BASE_COMMAND_NEW = "NEW"; // creates a new whole complex object or table
        public const String CONTENT_VALUE_IMPLEMENTATION_BASE_COMMAND_UPDATE = "ADD"; // adds a complex object to the table or updates the existing one in the table or adds to a value
        public const String CONTENT_VALUE_IMPLEMENTATION_BASE_COMMAND_REMOVE = "REMOVE"; // removes a complex object from the table or from the value (subtract)
        public const String CONTENT_VALUE_IMPLEMENTATION_BASE_COMMAND_GET_FIRST = "GET_FIRST"; // gets the first complex object in the table
        public const String CONTENT_VALUE_IMPLEMENTATION_BASE_COMMAND_GET_NEXT = "GET_NEXT"; // gets the next complex object in the table
        public const String CONTENT_VALUE_IMPLEMENTATION_BASE_COMMAND_FILTER = "FILTER";
        public const String CONTENT_VALUE_IMPLEMENTATION_BASE_COMMAND_GET_LENGTH = "GET_LENGTH"; // gets the length of a list, string, content or password

        // These are the command properties associated with the filter
        public const String CONTENT_VALUE_IMPLEMENTATION_BASE_COMMAND_PROPERTY_FILTER_COLUMN = "COLUMN";
        public const String CONTENT_VALUE_IMPLEMENTATION_BASE_COMMAND_PROPERTY_FILTER_CRITERIA = "CRITERIA";
        public const String CONTENT_VALUE_IMPLEMENTATION_BASE_COMMAND_PROPERTY_FILTER_VALUE = "VALUE";
        public const String CONTENT_VALUE_IMPLEMENTATION_BASE_COMMAND_PROPERTY_FILTER_CONTENT_TYPE = "CONTENT_TYPE";
        public const String CONTENT_VALUE_IMPLEMENTATION_BASE_COMMAND_PROPERTY_FILTER_SHARED_ELEMENT_CONTENT_VALUE_TO_REFERENCE_ID = "SHARED_ELEMENT_CONTENT_VALUE_TO_REFERENCE_ID";
        public const String CONTENT_VALUE_IMPLEMENTATION_BASE_COMMAND_PROPERTY_FILTER_SHARED_ELEMENT_CONTENT_VALUE_TO_REFERENCE_TYPE_ELEMENT_ENTRY_ID = "SHARED_ELEMENT_CONTENT_VALUE_TO_REFERENCE_TYPE_ELEMENT_ENTRY_ID";
        public const String CONTENT_VALUE_IMPLEMENTATION_BASE_COMMAND_PROPERTY_FILTER_SHARED_ELEMENT_CONTENT_VALUE_TO_REFERENCE_COMMAND = "SHARED_ELEMENT_CONTENT_VALUE_TO_REFERENCE_COMMAND";

        // Criteria for content values
        public const String CONTENT_VALUE_IMPLEMENTATION_CRITERIA_TYPE_EQUAL = "EQUAL";
        public const String CONTENT_VALUE_IMPLEMENTATION_CRITERIA_TYPE_NOT_EQUAL = "NOT_EQUAL";
        public const String CONTENT_VALUE_IMPLEMENTATION_CRITERIA_TYPE_GREATER_THAN = "GREATER_THAN";
        public const String CONTENT_VALUE_IMPLEMENTATION_CRITERIA_TYPE_GREATER_THAN_OR_EQUAL = "GREATER_THAN_OR_EQUAL";
        public const String CONTENT_VALUE_IMPLEMENTATION_CRITERIA_TYPE_LESS_THAN = "LESS_THAN";
        public const String CONTENT_VALUE_IMPLEMENTATION_CRITERIA_TYPE_LESS_THAN_OR_EQUAL = "LESS_THAN_OR_EQUAL";
        public const String CONTENT_VALUE_IMPLEMENTATION_CRITERIA_TYPE_CONTAINS = "CONTAINS";
        public const String CONTENT_VALUE_IMPLEMENTATION_CRITERIA_TYPE_STARTS_WITH = "STARTS_WITH";
        public const String CONTENT_VALUE_IMPLEMENTATION_CRITERIA_TYPE_ENDS_WITH = "ENDS_WITH";
        public const String CONTENT_VALUE_IMPLEMENTATION_CRITERIA_TYPE_IS_EMPTY = "IS_EMPTY";

        // Constants for the various content types
        public const String CONTENT_TYPE_DATETIME = "ContentDateTime";
        public const String CONTENT_TYPE_NUMBER = "ContentNumber";
        public const String CONTENT_TYPE_OBJECT = "ContentObject";
        public const String CONTENT_TYPE_PASSWORD = "ContentPassword";
        public const String CONTENT_TYPE_STRING = "ContentString";
        public const String CONTENT_TYPE_LIST = "ContentList";
        public const String CONTENT_TYPE_BOOLEAN = "ContentBoolean";
        public const String CONTENT_TYPE_CONTENT = "ContentContent";

        // Content parser strings
        public const String EMBEDDED_KEY_START_INTERNAL = "flowkey___";
        public const String EMBEDDED_KEY_FINISH_INTERNAL = "___flowkey";
        public const String EMBEDDED_KEY_START_EXTERNAL = "{!";
        public const String EMBEDDED_KEY_FINISH_EXTERNAL = "}";
        public const String EMBEDDED_KEY_ELEMENT_PART_WITH_SPACE_START_EXTERNAL = "[";
        public const String EMBEDDED_KEY_ELEMENT_PART_WITH_SPACE_FINISH_EXTERNAL = "]";
        public const String EMBEDDED_KEY_ELEMENT_PART_SEPARATOR = "].[";

        // Authenticated User constants
        public const String AUTHENTICATED_USER_STATUS_ACCESS_DENIED = "ACCESS_DENIED";
        public const String AUTHENTICATED_USER_STATUS_AUTHENTICATED = "AUTHENTICATED";
        public const String AUTHENTICATED_USER_KEY_TOKEN = "TOKEN";
        public const String AUTHENTICATED_USER_KEY_DIRECTORY_ID = "DIRECTORY_ID";
        public const String AUTHENTICATED_USER_PUBLIC_DIRECTORY_ID = "UNAUTHENTICATED";
        public const String AUTHENTICATED_USER_PUBLIC_DIRECTORY_NAME = "UNKNOWN";
        public const String AUTHENTICATED_USER_PUBLIC_EMAIL = "admin@manywho.com";
        public const String AUTHENTICATED_USER_PUBLIC_TENANT_NAME = "UNKNOWN";
        public const String AUTHENTICATED_USER_PUBLIC_USER_ID = "PUBLIC_USER";
        public const String AUTHENTICATED_USER_PUBLIC_IDENTITY_PROVIDER = "NONE";
        public const String AUTHENTICATED_USER_PUBLIC_STATUS = "UKNOWN";
        public const String AUTHENTICATED_USER_PUBLIC_TOKEN = "NONE";
        public const String AUTHENTICATED_WHO_TOKEN_MANYWHO_TENANT_ID = "ManyWhoTenantId";
        public const String AUTHENTICATED_WHO_TOKEN_MANYWHO_USER_ID = "ManyWhoUserId";
        public const String AUTHENTICATED_WHO_TOKEN_MANYWHO_TOKEN = "ManyWhoToken";
        public const String AUTHENTICATED_WHO_TOKEN_DIRECTORY_ID = "DirectoryId";
        public const String AUTHENTICATED_WHO_TOKEN_DIRECTORY_NAME = "DirectoryName";
        public const String AUTHENTICATED_WHO_TOKEN_EMAIL = "Email";
        public const String AUTHENTICATED_WHO_TOKEN_IDENTITY_PROVIDER = "IdentityProvider";
        public const String AUTHENTICATED_WHO_TOKEN_TENANT_NAME = "TenantName";
        public const String AUTHENTICATED_WHO_TOKEN_TOKEN = "Token";
        public const String AUTHENTICATED_WHO_TOKEN_USER_ID = "UserId";
        public const char AUTHENTICATED_WHO_DELIMITER = '=';

        // Service description constants
        public const String SERVICE_DESCRIPTION_VALUE_TABLE_NAME = "TableName";

        // Plugin constants
        public const String SERVICE_REQUEST_FORM_POST_KEY = "ServiceRequest";

        // Authentication constants
        //public const String OBJECT_TYPE_GROUP_AUTHORIZATION_GROUP = "GroupAuthorizationGroup";
        public const String AUTHENTICATION_GROUP_AUTHORIZATION_GROUP_OBJECT_DEVELOPER_NAME = "GroupAuthorizationGroup";
        public const String AUTHENTICATION_GROUP_AUTHORIZATION_USER_OBJECT_DEVELOPER_NAME = "GroupAuthorizationUser";
        //public const String SERVICE_VALUE_AUTHENTICATION_ID = "AuthenticationId";
        public const String AUTHENTICATION_OBJECT_AUTHENTICATION_ID = "AuthenticationId";
        //public const String SERVICE_VALUE_FRIENDLY_NAME = "FriendlyName";
        public const String AUTHENTICATION_OBJECT_FRIENDLY_NAME = "FriendlyName";
        public const String AUTHENTICATION_OBJECT_DEVELOPER_SUMMARY = "DeveloperSummary";

        public const String AUTHENTICATION_ATTRIBUTE_LABEL = "Label";
        public const String AUTHENTICATION_ATTRIBUTE_VALUE = "Value";
        public const String AUTHENTICATION_AUTHENTICATION_ATTRIBUTE_OBJECT_DEVELOPER_NAME = "AuthenticationAttribute";

        // Group Authorization constants
        public const String GROUP_AUTHORIZATION_GLOBAL_AUTHENTICATION_TYPE_PUBIC = "PUBLIC";
        public const String GROUP_AUTHORIZATION_GLOBAL_AUTHENTICATION_TYPE_ALL_USERS = "ALL_USERS";
        public const String GROUP_AUTHORIZATION_GLOBAL_AUTHENTICATION_TYPE_SPECIFIED = "SPECIFIED";
        public const String GROUP_AUTHORIZATION_STREAM_BEHAVIOUR_USE_EXISTING = "USE_EXISTING";
        public const String GROUP_AUTHORIZATION_STREAM_BEHAVIOUR_CREATE_NEW = "CREATE_NEW";
        public const String GROUP_AUTHORIZATION_STREAM_BEHAVIOUR_NONE = "NONE";
        public const String GROUP_AUTHORIZATION_USER = "USER";

        // List Filter Config constants
        public const String LIST_FILTER_CONFIG_ORDER_BY_ASCENDING = "ASC";
        public const String LIST_FILTER_CONFIG_ORDER_BY_DESCENDING = "DESC";
        public const String LIST_FILTER_CONFIG_COMPARISON_TYPE_AND = "AND";
        public const String LIST_FILTER_CONFIG_COMPARISON_TYPE_OR = "OR";

        // Page Container constants
        public const String PAGE_CONTAINER_CONTAINER_TYPE_VERTICAL_FLOW = "VERTICAL_FLOW";
        public const String PAGE_CONTAINER_CONTAINER_TYPE_HORIZONTAL_FLOW = "HORIZONTAL_FLOW";
        public const String PAGE_CONTAINER_CONTAINER_TYPE_GROUP = "GROUP";

        // Constants for property names for objects being returned for user context
        public const String MANYWHO_USER_DEVELOPER_NAME = "ManyWho User";

        public const String MANYWHO_USER_PROPERTY_USER_ID = "User ID";
        public const String MANYWHO_USER_PROPERTY_USERNAME = "Username";
        public const String MANYWHO_USER_PROPERTY_EMAIL = "Email";
        public const String MANYWHO_USER_PROPERTY_FIRST_NAME = "First Name";
        public const String MANYWHO_USER_PROPERTY_LAST_NAME = "Last Name";
        public const String MANYWHO_USER_PROPERTY_LANGUAGE = "Language";
        public const String MANYWHO_USER_PROPERTY_COUNTRY = "Country";
        public const String MANYWHO_USER_PROPERTY_LOCATION = "Location";
        public const String MANYWHO_USER_PROPERTY_DIRECTORY_ID = "Directory Id";
        public const String MANYWHO_USER_PROPERTY_DIRECTORY_NAME = "Directory Name";
        public const String MANYWHO_USER_PROPERTY_STATUS = "Status";
        public const String MANYWHO_USER_PROPERTY_AUTHENTICATION_TYPE = "AuthenticationType";
        public const String MANYWHO_USER_PROPERTY_LOGIN_URL = "LoginUrl";

        public const String MANYWHO_LOCATION_PROPERTY_TIMESTAMP = "Location Timestamp";
        public const String MANYWHO_LOCATION_PROPERTY_LATITUDE = "Current Latitude";
        public const String MANYWHO_LOCATION_PROPERTY_LONGITUDE = "Current Longitude";
        public const String MANYWHO_LOCATION_PROPERTY_ACCURACY = "Location Accuracy";
        public const String MANYWHO_LOCATION_PROPERTY_ALTITUDE = "Current Altitude";
        public const String MANYWHO_LOCATION_PROPERTY_ALTITUDE_ACCURACY = "Altitude Accuracy";
        public const String MANYWHO_LOCATION_PROPERTY_HEADING = "Current Heading";
        public const String MANYWHO_LOCATION_PROPERTY_SPEED = "Current Speed";

        public const String MANYWHO_FILE_DEVELOPER_NAME = "ManyWho File";

        public const String MANYWHO_FILE_PROPERTY_KIND = "Kind";
        public const String MANYWHO_FILE_PROPERTY_ID = "Id";
        public const String MANYWHO_FILE_PROPERTY_MIME_TYPE = "Mime Type";
        public const String MANYWHO_FILE_PROPERTY_NAME = "Name";
        public const String MANYWHO_FILE_PROPERTY_DESCRIPTION = "Description";
        public const String MANYWHO_FILE_PROPERTY_DATE_CREATED = "Date Created";
        public const String MANYWHO_FILE_PROPERTY_DATE_MODIFIED = "Date Modified";
        public const String MANYWHO_FILE_PROPERTY_DOWNLOAD_URI = "Download Uri";
        public const String MANYWHO_FILE_PROPERTY_EMBED_URI = "Embed Uri";
        public const String MANYWHO_FILE_PROPERTY_ICON_URI = "Icon Uri";
        public const String MANYWHO_FILE_PROPERTY_ALLOW_UPLOAD = "Allow Upload";
        public const String MANYWHO_FILE_PROPERTY_ALLOW_DOWNLOAD = "Allow Download";

        public const String AUTHORIZATION_STATUS_NOT_AUTHORIZED = "401";
        public const String AUTHORIZATION_STATUS_AUTHORIZED = "200";

        // The API name for service elements
        public const String SERVICE_ELEMENT_TYPE_IMPLEMENTATION_SERVICE = "SERVICE";

        // The API name for shared elements
        public const String SHARED_ELEMENT_TYPE_IMPLEMENTATION_VALUE = "VALUE";
        public const String SHARED_ELEMENT_TYPE_IMPLEMENTATION_VARIABLE = "VARIABLE";
        public const String SHARED_ELEMENT_TYPE_IMPLEMENTATION_CONSTANT = "CONSTANT";
        public const String SHARED_ELEMENT_TYPE_IMPLEMENTATION_RESOURCE = "RESOURCE";
        public const String SHARED_ELEMENT_TYPE_IMPLEMENTATION_FUNCTION = "FUNCTION";
        public const String SHARED_ELEMENT_TYPE_IMPLEMENTATION_TABLE = "TABLE";
        public const String SHARED_ELEMENT_TYPE_IMPLEMENTATION_CONNECTION = "CONNECTION";

        // Access values for shared elements
        public const String ACCESS_PRIVATE = "PRIVATE";
        public const String ACCESS_INPUT = "INPUT";
        public const String ACCESS_OUTPUT = "OUTPUT";
        public const String ACCESS_INPUT_OUTPUT = "INPUT_OUTPUT";

        // Component types for pages
        public const String COMPONENT_TYPE_CONTENT = "CONTENT";
        public const String COMPONENT_TYPE_INPUTBOX = "INPUT";
        public const String COMPONENT_TYPE_TEXTBOX = "TEXTAREA";
        public const String COMPONENT_TYPE_COMBOBOX = "SELECT";
        public const String COMPONENT_TYPE_CHECKBOX = "CHECKBOX";
        public const String COMPONENT_TYPE_TABLE = "TABLE";
        public const String COMPONENT_TYPE_PRESENTATION = "PRESENTATION";
        public const String COMPONENT_TYPE_TAG = "TAG";
        public const String COMPONENT_TYPE_IMAGE = "IMAGE";
        public const String COMPONENT_TYPE_FILES = "FILES";

        // Container types for pages
        public const String CONTAINER_TYPE_VERTICAL_FLOW = "VERTICAL_FLOW";
        public const String CONTAINER_TYPE_HORIZONTAL_FLOW = "HORIZONTAL_FLOW";
        public const String CONTAINER_TYPE_INLINE_FLOW = "INLINE_FLOW";
        public const String CONTAINER_TYPE_GROUP = "GROUP";

        // Action bindings for map elements
        public const String ACTION_BINDING_SAVE = "SAVE";
        public const String ACTION_BINDING_NO_SAVE = "NO_SAVE";

        // Action types for map elements
        public const String ACTION_TYPE_NEW = "NEW";
        public const String ACTION_TYPE_QUERY = "QUERY";
        public const String ACTION_TYPE_INSERT = "INSERT";
        public const String ACTION_TYPE_UPDATE = "UPDATE";
        public const String ACTION_TYPE_UPSERT = "UPSERT";
        public const String ACTION_TYPE_DELETE = "DELETE";
        public const String ACTION_TYPE_REMOVE = "REMOVE";
        public const String ACTION_TYPE_ADD = "ADD";
        public const String ACTION_TYPE_EDIT = "EDIT";
        public const String ACTION_TYPE_NEXT = "NEXT";
        public const String ACTION_TYPE_BACK = "BACK";
        public const String ACTION_TYPE_DONE = "DONE";
        public const String ACTION_TYPE_SAVE = "SAVE";
        public const String ACTION_TYPE_CANCEL = "CANCEL";
        public const String ACTION_TYPE_APPLY = "APPLY";
        public const String ACTION_TYPE_IMPORT = "IMPORT";
        public const String ACTION_TYPE_CLOSE = "CLOSE";
        public const String ACTION_TYPE_OPEN = "OPEN";
        public const String ACTION_TYPE_SUBMIT = "SUBMIT";
        public const String ACTION_TYPE_ESCALATE = "ESCALATE";
        public const String ACTION_TYPE_REJECT = "REJECT";
        public const String ACTION_TYPE_DELEGATE = "DELEGATE";

        // The API name for page layouts
        public const String UI_ELEMENT_TYPE_IMPLEMENTATION_PAGE_LAYOUT = "PAGE_LAYOUT";

        // The API name for navigations
        public const String UI_ELEMENT_TYPE_IMPLEMENTATION_NAVIGATION = "NAVIGATION";

        // The API name for map elements
        public const String MAP_ELEMENT_TYPE_IMPLEMENTATION_START = "START";
        public const String MAP_ELEMENT_TYPE_IMPLEMENTATION_STEP = "STEP";
        public const String MAP_ELEMENT_TYPE_IMPLEMENTATION_INPUT = "INPUT";
        public const String MAP_ELEMENT_TYPE_IMPLEMENTATION_DECISION = "DECISION";
        public const String MAP_ELEMENT_TYPE_IMPLEMENTATION_OPERATOR = "OPERATOR";
        public const String MAP_ELEMENT_TYPE_IMPLEMENTATION_SUB_FLOW = "SUB_FLOW";
        public const String MAP_ELEMENT_TYPE_IMPLEMENTATION_DATABASE_LOAD = "DATABASE_LOAD";
        public const String MAP_ELEMENT_TYPE_IMPLEMENTATION_DATABASE_SAVE = "DATABASE_SAVE";
        public const String MAP_ELEMENT_TYPE_IMPLEMENTATION_DATABASE_DELETE = "DATABASE_DELETE";
        public const String MAP_ELEMENT_TYPE_IMPLEMENTATION_MESSAGE = "MESSAGE";
        public const String MAP_ELEMENT_TYPE_IMPLEMENTATION_PAGE = "PAGE";

        // The API name for group elements
        public const String GROUP_ELEMENT_TYPE_IMPLEMENTATION_SWIMLANE = "SWIMLANE";

        // The API name for tags
        public const String UI_ELEMENT_TYPE_IMPLEMENTATION_TAG = "TAG";

        // The API name for types
        public const String TYPE_ELEMENT_TYPE_IMPLEMENTATION_TYPE = "TYPE";

        // Post update types
        public const String POST_UPDATE_WHEN_ON_LOAD = "ON_LOAD";
        public const String POST_UPDATE_WHEN_ON_EXIT = "ON_EXIT";

        // Guids for the reserved outcomes for faults and debug
        public static readonly Guid DEBUG_GUID = Guid.Parse("EE6C8827-11E2-486D-B5FA-4D1A0CBB77A3");
        public static readonly Guid FAULT_GUID = Guid.Parse("318B0F3A-A570-4C5D-835C-21C1EEB17787");

        // Outcomes with a fault
        public const String FAULT_DEVELOPER_NAME = "FAULT";

        // The authentication types that are currently supported
        public const String AUTHENTICATION_TYPE_USERNAME_PASSWORD = "USERNAME_PASSWORD";
        public const String AUTHENTICATION_TYPE_OAUTH2 = "OAUTH2";
    }
}
