using System;

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
        // Tells the response caller that the engine is currently busy processing against the state
        public const String INVOKE_TYPE_BUSY = "BUSY";
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
        // Tells the engine that the state is waiting on votes to come in
        public const String INVOKE_TYPE_WAITING_ON_VOTES = "WAITING_ON_VOTES";
        // Tells the user that they are not allowed to perform any operations - this is to avoid testing "null"
        public const String INVOKE_TYPE_NOT_ALLOWED = "NOT_ALLOWED";

        // Engine mode constants
        public const String MODE_DEFAULT = null;
        public const String MODE_LOG = "LOG";
        public const String MODE_DEBUG = "DEBUG";
        public const String MODE_DEBUG_STEPTHROUGH = "DEBUG_STEPTHROUGH";

        // Reporting mode constants
        public const String REPORT_NONE = null;
        public const String REPORT_VALUES = "VALUES";
        public const String REPORT_PATH = "PATH";
        public const String REPORT_PATH_AND_VALUES = "PATH_AND_VALUES";

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
        public static readonly Guid AUTHENTICATED_USER_PUBLIC_MANYWHO_USER_ID = Guid.Parse("52DF1A90-3826-4508-B7C2-CDE8AA5B72CF");

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
        public const String AUTHENTICATED_WHO_TOKEN_USERNAME = "Username";
        public const String AUTHENTICATED_WHO_TOKEN_FIRST_NAME = "FirstName";
        public const String AUTHENTICATED_WHO_TOKEN_LAST_NAME = "LastName";

        public const char SERIALIZATION_DELIMITER_DELIMITER = '=';

        public const String CULTURE_TOKEN_BRAND = "Brand";
        public const String CULTURE_TOKEN_COUNTRY = "Country";
        public const String CULTURE_TOKEN_LANGUAGE = "Language";
        public const String CULTURE_TOKEN_VARIANT = "Variant";

        public static readonly Guid MANYWHO_JOIN_URI_VALUE_ID = Guid.Parse("E2063196-3C75-4388-8B00-1005B8CD59AD");
        public const String MANYWHO_JOIN_URI_DEVELOPER_NAME = "$JoinUri";

        public static readonly Guid MANYWHO_USER_VALUE_ID = Guid.Parse("03DC41DD-1C6B-4B33-BF61-CBD1D0778FFF");

        public static readonly Guid MANYWHO_TRUE_VALUE_ID = Guid.Parse("BE1BC78E-FD57-40EC-9A86-A815DE2A9E28");
        public const String MANYWHO_TRUE_DEVELOPER_NAME = "$True";

        public static readonly Guid MANYWHO_FALSE_VALUE_ID = Guid.Parse("496FD041-D91F-48FB-AA4F-91C6C9A11CA1");
        public const String MANYWHO_FALSE_DEVELOPER_NAME = "$False";

        public static readonly Guid MANYWHO_USER_TYPE_ELEMENT_ID = Guid.Parse("2674CE95-DD99-42C6-96FC-AD12E1B48A69");
        public static readonly Guid MANYWHO_USER_PROPERTY_ID_USER_ID = Guid.Parse("90262141-02B2-4F2C-8107-B14CF859DE4D");
        public static readonly Guid MANYWHO_USER_PROPERTY_ID_USERNAME = Guid.Parse("D8839B46-C43B-4435-9395-BD00491DA16E");
        public static readonly Guid MANYWHO_USER_PROPERTY_ID_EMAIL = Guid.Parse("601DDC6A-FFF4-478B-ABE4-C4E65BC901C6");
        public static readonly Guid MANYWHO_USER_PROPERTY_ID_FIRST_NAME = Guid.Parse("6E1D4D49-AB0D-4475-9488-CF4A71D36BEB");
        public static readonly Guid MANYWHO_USER_PROPERTY_ID_LAST_NAME = Guid.Parse("E525AAAE-C900-47FC-9A20-D10C52CFC203");
        public static readonly Guid MANYWHO_USER_PROPERTY_ID_LANGUAGE = Guid.Parse("88EC74A3-B75D-4C1C-89E4-D142159FD5E4");
        public static readonly Guid MANYWHO_USER_PROPERTY_ID_BRAND = Guid.Parse("641F4870-8BF6-4CD9-9654-2AA04C542F43");
        public static readonly Guid MANYWHO_USER_PROPERTY_ID_VARIANT = Guid.Parse("A20A1786-7318-4688-81EC-738337442C56");
        public static readonly Guid MANYWHO_USER_PROPERTY_ID_COUNTRY = Guid.Parse("4FB64B42-A370-455E-85ED-D9A0A8723A43");
        public static readonly Guid MANYWHO_USER_PROPERTY_ID_LOCATION = Guid.Parse("4FA61B42-A370-455E-85ED-D9A0A8723A43");
        public static readonly Guid MANYWHO_USER_PROPERTY_ID_DIRECTORY_ID = Guid.Parse("4FA61B52-A370-455E-85ED-D9A0A8723A43");
        public static readonly Guid MANYWHO_USER_PROPERTY_ID_DIRECTORY_NAME = Guid.Parse("4FA61B45-A370-455E-85ED-D9A0A8723A43");
        public static readonly Guid MANYWHO_USER_PROPERTY_ID_STATUS = Guid.Parse("4FA61B46-A370-455E-85ED-D9A0A8723A43");
        public static readonly Guid MANYWHO_USER_PROPERTY_ID_AUTHENTICATION_TYPE = Guid.Parse("4FA61B47-A370-455E-85ED-D9A0A8723A43");
        public static readonly Guid MANYWHO_USER_PROPERTY_ID_LOGIN_URL = Guid.Parse("4FA61B48-A370-455E-85ED-D9A0A8723A43");

        public static readonly Guid MANYWHO_LOCATION_TYPE_ELEMENT_ID = Guid.Parse("7834CE95-DD99-42C6-96FC-AD12E1B48A69");
        public static readonly Guid MANYWHO_LOCATION_PROPERTY_ID_TIMESTAMP = Guid.Parse("FFC4CBD6-FA28-4141-95A4-DA9BACDB0203");
        public static readonly Guid MANYWHO_LOCATION_PROPERTY_ID_LATITUDE = Guid.Parse("9270A449-9AD5-4C57-B952-DC4551210ABA");
        public static readonly Guid MANYWHO_LOCATION_PROPERTY_ID_LONGITUDE = Guid.Parse("0A198B4B-1890-4B3B-B09C-E215C7C1458B");
        public static readonly Guid MANYWHO_LOCATION_PROPERTY_ID_ACCURACY = Guid.Parse("4DB3CE7A-E758-4202-B2E5-E2A21C2A25FD");
        public static readonly Guid MANYWHO_LOCATION_PROPERTY_ID_ALTITUDE = Guid.Parse("6242AA3F-2796-42ED-9262-EF77EE7405E2");
        public static readonly Guid MANYWHO_LOCATION_PROPERTY_ID_ALTITUDE_ACCURACY = Guid.Parse("A68965D6-0461-4EFE-8F63-F05C406E6F2B");
        public static readonly Guid MANYWHO_LOCATION_PROPERTY_ID_HEADING = Guid.Parse("6F0BEE99-ECFB-4B63-A034-F7807244C2B8");
        public static readonly Guid MANYWHO_LOCATION_PROPERTY_ID_SPEED = Guid.Parse("22C772BF-7BC2-4EC3-A44A-F8387751D32C");

        public static readonly Guid MANYWHO_FILE_TYPE_ELEMENT_ID = Guid.Parse("AF48E652-7DEC-4739-9C98-586318E0AD7D");
        public static readonly Guid MANYWHO_FILE_PROPERTY_ID_KIND = Guid.Parse("71D7AAC8-B7E5-4256-9798-103A1E52A12E");
        public static readonly Guid MANYWHO_FILE_PROPERTY_ID_ID = Guid.Parse("DC10DDB5-2215-45AE-8DED-18C698B01FF3");
        public static readonly Guid MANYWHO_FILE_PROPERTY_ID_MIME_TYPE = Guid.Parse("F92D410D-7F94-4995-A20E-1A58791D0D65");
        public static readonly Guid MANYWHO_FILE_PROPERTY_ID_NAME = Guid.Parse("CC134A57-EB16-47C0-A455-22CA0D1581F9");
        public static readonly Guid MANYWHO_FILE_PROPERTY_ID_DESCRIPTION = Guid.Parse("7E57D810-F4E0-4D54-8066-2C017180E0FF");
        public static readonly Guid MANYWHO_FILE_PROPERTY_ID_DATE_CREATED = Guid.Parse("82D5584D-0B6B-4D30-85E0-2F4A947324E7");
        public static readonly Guid MANYWHO_FILE_PROPERTY_ID_DATE_MODIFIED = Guid.Parse("A942BC5C-D59D-4010-86D0-31F23F822855");
        public static readonly Guid MANYWHO_FILE_PROPERTY_ID_DOWNLOAD_URI = Guid.Parse("6611067A-7C86-4696-8845-3CDC79C73289");
        public static readonly Guid MANYWHO_FILE_PROPERTY_ID_EMBED_URI = Guid.Parse("C063EC28-9053-4D0B-A93B-4470F6CE4B8C");
        public static readonly Guid MANYWHO_FILE_PROPERTY_ID_ICON_URI = Guid.Parse("DC906ACB-A270-4E95-9118-463FA8B5726C");

        public static readonly Guid MANYWHO_GROUP_TYPE_ELEMENT_ID = Guid.Parse("82DE6847-03D6-4ACE-91CC-26CD80AEA9FC");
        public static readonly Guid MANYWHO_GROUP_PROPERTY_ID_GROUP_ID = Guid.Parse("1CADAB68-658C-4F52-972E-FAB83F168D87");
        public static readonly Guid MANYWHO_GROUP_PROPERTY_ID_GROUP_NAME = Guid.Parse("D04652C0-B87C-400D-BEAC-FBC2420774BC");
        public static readonly Guid MANYWHO_GROUP_PROPERTY_ID_GROUP_OWNER_USER_ID = Guid.Parse("3B74EB51-74A8-43B3-96EF-FEEB938D35D2");

        public const String MANYWHO_GROUP_DEVELOPER_NAME = "$Group";
        public const String MANYWHO_GROUP_PROPERTY_GROUP_ID = "Group ID";
        public const String MANYWHO_GROUP_PROPERTY_GROUP_NAME = "Group Name";
        public const String MANYWHO_GROUP_PROPERTY_GROUP_OWNER_USER_ID = "Group Owner User ID";

        public static readonly string MANYWHO_STATE_DEVELOPER_NAME = "$State";
        public static readonly Guid MANYWHO_STATE_VALUE_ID = Guid.Parse("1F2A56FD-E14B-460C-AABD-9FBF344B84F3");

        public static readonly string MANYWHO_STATE_PROPERTY_ID = "ID";
        public static readonly string MANYWHO_STATE_PROPERTY_PARENT_ID = "Parent ID";
        public static readonly string MANYWHO_STATE_PROPERTY_EXTERNAL_ID = "External ID";
        public static readonly string MANYWHO_STATE_PROPERTY_FLOW_ID = "Flow ID";
        public static readonly string MANYWHO_STATE_PROPERTY_FLOW_VERSION_ID = "Flow Version ID";
        public static readonly string MANYWHO_STATE_PROPERTY_FLOW_DEVELOPER_NAME = "Flow Developer Name";
        public static readonly string MANYWHO_STATE_PROPERTY_IS_DONE = "Is Done?";
        public static readonly string MANYWHO_STATE_PROPERTY_OWNER_ID = "Owner ID";
        public static readonly string MANYWHO_STATE_PROPERTY_OWNER_USER_ID = "Owner User ID";
        public static readonly string MANYWHO_STATE_PROPERTY_OWNER_FIRST_NAME = "Owner First Name";
        public static readonly string MANYWHO_STATE_PROPERTY_OWNER_LAST_NAME = "Owner Last Name";
        public static readonly string MANYWHO_STATE_PROPERTY_OWNER_USERNAME = "Owner Username";
        public static readonly string MANYWHO_STATE_PROPERTY_OWNER_EMAIL = "Owner Email";
        public static readonly string MANYWHO_STATE_PROPERTY_OWNER_NAME = "Owner Name";
        public static readonly string MANYWHO_STATE_PROPERTY_DATE_CREATED = "Date Created";
        public static readonly string MANYWHO_STATE_PROPERTY_DATE_MODIFIED = "Date Modified";
        public static readonly string MANYWHO_STATE_PROPERTY_CURRENT_MAP_ELEMENT_ID = "Current Map Element ID";
        public static readonly string MANYWHO_STATE_PROPERTY_CURRENT_MAP_ELEMENT_DEVELOPER_NAME = "Current Map Element Developer Name";
        public static readonly string MANYWHO_STATE_PROPERTY_JOIN_URI = "Join URI";

        public static readonly Guid MANYWHO_STATE_TYPE_ELEMENT_ID = Guid.Parse("6F5844B9-B79F-49CE-BA65-843DC754D1B6");
        public static readonly Guid MANYWHO_STATE_PROPERTY_ID_ID = Guid.Parse("A4368EA1-F120-47A1-A67B-A8CE9452C127");
        public static readonly Guid MANYWHO_STATE_PROPERTY_ID_PARENT_ID = Guid.Parse("C0986C48-DBC5-43C6-9222-3F8F3D4E2247");
        public static readonly Guid MANYWHO_STATE_PROPERTY_ID_EXTERNAL_ID = Guid.Parse("6BA0852D-CED1-428E-BE7E-6F80D4B85F1F");
        public static readonly Guid MANYWHO_STATE_PROPERTY_ID_FLOW_ID = Guid.Parse("5BB41D1F-8F1D-4028-AE44-763617537338");
        public static readonly Guid MANYWHO_STATE_PROPERTY_ID_FLOW_VERSION_ID = Guid.Parse("B43B6AFA-2E56-461A-AD96-2B74BC92C90D");
        public static readonly Guid MANYWHO_STATE_PROPERTY_ID_FLOW_DEVELOPER_NAME = Guid.Parse("45BB98B0-9C3D-47F2-B708-1327E5CD1DCA");
        public static readonly Guid MANYWHO_STATE_PROPERTY_ID_IS_DONE = Guid.Parse("43FF2B25-78D8-4279-B517-3F82A888084C");
        public static readonly Guid MANYWHO_STATE_PROPERTY_ID_OWNER_ID = Guid.Parse("EB621350-D117-4C16-848E-0DCE15021093");
        public static readonly Guid MANYWHO_STATE_PROPERTY_ID_OWNER_USER_ID = Guid.Parse("EAE019C3-EA80-4DAC-844E-BAFD1A90861F");
        public static readonly Guid MANYWHO_STATE_PROPERTY_ID_OWNER_FIRST_NAME = Guid.Parse("8D39A782-3A8A-4816-A660-823CFDAF190D");
        public static readonly Guid MANYWHO_STATE_PROPERTY_ID_OWNER_LAST_NAME = Guid.Parse("1E453F03-6365-452C-BE93-43E37B270ADD");
        public static readonly Guid MANYWHO_STATE_PROPERTY_ID_OWNER_USERNAME = Guid.Parse("F72489D4-2175-4095-B4D0-113FB489F0D9");
        public static readonly Guid MANYWHO_STATE_PROPERTY_ID_OWNER_EMAIL = Guid.Parse("329A5FC0-F665-44F0-B5A9-A4DD39040FF2");
        public static readonly Guid MANYWHO_STATE_PROPERTY_ID_OWNER_NAME = Guid.Parse("0289AFC0-4F92-4C5A-A07D-3AF40B8F2F00");
        public static readonly Guid MANYWHO_STATE_PROPERTY_ID_DATE_CREATED = Guid.Parse("DCF75168-8F6E-4FBC-9E9D-543793BC4AFD");
        public static readonly Guid MANYWHO_STATE_PROPERTY_ID_DATE_MODIFIED = Guid.Parse("23F6B3CA-E136-4908-8028-AC6F975441FA");
        public static readonly Guid MANYWHO_STATE_PROPERTY_ID_CURRENT_MAP_ELEMENT_ID = Guid.Parse("81707A21-EDD7-48D5-AD80-FFCFA3471B6C");
        public static readonly Guid MANYWHO_STATE_PROPERTY_ID_CURRENT_MAP_ELEMENT_DEVELOPER_NAME = Guid.Parse("AE1EB1E1-1760-41EA-9A02-919781BFF313");
        public static readonly Guid MANYWHO_STATE_PROPERTY_ID_JOIN_URI = Guid.Parse("1A3B4FC9-912C-486E-A0FC-FF0D9F9796B7");

        // Service description constants
        public const String SERVICE_DESCRIPTION_VALUE_TABLE_NAME = "TableName";

        // Plugin constants
        public const String SERVICE_REQUEST_FORM_POST_KEY = "ServiceRequest";
        public const String FILE_DATA_REQUEST_FORM_POST_KEY = "FileDataRequest";

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
        public const String MANYWHO_USER_DEVELOPER_NAME = "$User";

        public const String MANYWHO_USER_PROPERTY_USER_ID = "User ID";
        public const String MANYWHO_USER_PROPERTY_USERNAME = "Username";
        public const String MANYWHO_USER_PROPERTY_EMAIL = "Email";
        public const String MANYWHO_USER_PROPERTY_FIRST_NAME = "First Name";
        public const String MANYWHO_USER_PROPERTY_LAST_NAME = "Last Name";
        public const String MANYWHO_USER_PROPERTY_LANGUAGE = "Language";
        public const String MANYWHO_USER_PROPERTY_COUNTRY = "Country";
        public const String MANYWHO_USER_PROPERTY_BRAND = "Brand";
        public const String MANYWHO_USER_PROPERTY_VARIANT = "Variant";
        public const String MANYWHO_USER_PROPERTY_LOCATION = "Location";
        public const String MANYWHO_USER_PROPERTY_DIRECTORY_ID = "Directory Id";
        public const String MANYWHO_USER_PROPERTY_DIRECTORY_NAME = "Directory Name";
        public const String MANYWHO_USER_PROPERTY_STATUS = "Status";
        public const String MANYWHO_USER_PROPERTY_AUTHENTICATION_TYPE = "AuthenticationType";
        public const String MANYWHO_USER_PROPERTY_LOGIN_URL = "LoginUrl";

        public const String MANYWHO_LOCATION_DEVELOPER_NAME = "$Location";

        public const String MANYWHO_LOCATION_PROPERTY_TIMESTAMP = "Location Timestamp";
        public const String MANYWHO_LOCATION_PROPERTY_LATITUDE = "Current Latitude";
        public const String MANYWHO_LOCATION_PROPERTY_LONGITUDE = "Current Longitude";
        public const String MANYWHO_LOCATION_PROPERTY_ACCURACY = "Location Accuracy";
        public const String MANYWHO_LOCATION_PROPERTY_ALTITUDE = "Current Altitude";
        public const String MANYWHO_LOCATION_PROPERTY_ALTITUDE_ACCURACY = "Altitude Accuracy";
        public const String MANYWHO_LOCATION_PROPERTY_HEADING = "Current Heading";
        public const String MANYWHO_LOCATION_PROPERTY_SPEED = "Current Speed";

        public const String MANYWHO_FILE_DEVELOPER_NAME = "$File";

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
        public const String SHARED_ELEMENT_TYPE_IMPLEMENTATION_MACRO = "MACRO";

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
        public const String ACTION_BINDING_PARTIAL_SAVE = "PARTIAL_SAVE";

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

        public const String PROPERTY_SEARCH = "PROPERTY:";
        public const String EXACT_SEARCH = "EXACT:";

        // The settings for the types of user registration
        public const String USER_REGISTRATION_TYPE_SELF = "SELF";
        public const String USER_REGISTRATION_TYPE_REQUEST = "REQUEST";
        public const String USER_REGISTRATION_TYPE_MANUAL = "MANUAL";

        public const String USER_REGISTRATION_NOTIFY_ALL = "ALL";
        public const String USER_REGISTRATION_NOTIFY_SPECIFIC = "SPECIFIC";
        public const String USER_REGISTRATION_NOTIFY_NONE = "NONE";

        public const String VOTE_TYPE_COUNT = "COUNT";
        public const String VOTE_TYPE_PERCENT = "PERCENT";

        public const String LISTENER_TYPE_EDIT = "EDIT";
        public const String LISTENER_TYPE_DELETE = "DELETE";

        public const String STATE_LISTEN_TYPE_DONE = "DONE";
        public const String STATE_LISTEN_TYPE_UPDATE = "UPDATE";

        public const String USER_PERMISSION_TYPE_CAN_EDIT_AND_ACTION = "CAN_EDIT_AND_ACTION";
        public const String USER_PERMISSION_TYPE_CAN_ACTION = "CAN_ACTION";
        public const String USER_PERMISSION_TYPE_CAN_EDIT = "CAN_EDIT";
        public const String USER_PERMISSION_TYPE_CAN_VIEW = "CAN_VIEW";
        public const String USER_PERMISSION_TYPE_CAN_COMMENT = "CAN_COMMENT";
    }
}
