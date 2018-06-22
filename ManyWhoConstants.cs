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
        #region Engine Invoke

        /// <summary>
        /// Tells the engine that you wish to move forward. This doesn't necessarily mean the engine will move forward if the request fails on page validation OR the author of the flow has put rules against the element that have not evaluated to 'true'.
        /// </summary>
        public const string INVOKE_TYPE_FORWARD = "FORWARD";

        /// <summary>
        /// Tells the caller that the flow has reached the final element in a branch
        /// </summary>
        public const string INVOKE_TYPE_DONE = "DONE";

        /// <summary>
        ///  Tells the engine we want to join the running flow - this is used internally only. "STATUS" is used externally as we infer a "JOIN" from the GET request
        /// </summary>
        public const string INVOKE_TYPE_JOIN = "JOIN";

        /// <summary>
        /// Tells the engine and the caller that the engine is waiting or the external plugin is waiting. As part of the plugin framework a "WAIT" request allows you to send status messages to the user without progressing the flow. When calling the engine from a plugin, if the engine responds with a "WAIT", it means the engine is likely waiting on another event or business rule to fire.
        /// </summary>
        public const string INVOKE_TYPE_WAIT = "WAIT";

        /// <summary>
        /// Tells the caller that the state is currently busy being processed against
        /// </summary>
        public const string INVOKE_TYPE_BUSY = "BUSY";

        /// <summary>
        /// Tells the engine that you wish to get a status update on the flow. This will send back up-to-date page metadata and any new status messages.
        /// </summary>
        public const string INVOKE_TYPE_STATUS = "STATUS";

        /// <summary>
        /// When making asynchronous requests against the engine, a "SUCCESS" response tells the caller that the request was accepted and the caller therefore does not need to continue to make requests against the engine.
        /// </summary>
        public const string INVOKE_TYPE_SUCCESS = "SUCCESS";

        /// <summary>
        /// When making asynchronous requests against the engine, a "TOKEN_COMPLETED" response tells the caller that the request is no longer needed or valid and the caller therefore does not need to continue to make requests against the engine. This can happen if the user has send messages out to multiple systems and the rules to continue forward in the execution of the flow were satisfied by another system response.
        /// </summary>
        public const string INVOKE_TYPE_TOKEN_COMPLETED = "TOKEN_COMPLETED";

        /// <summary>
        /// Tells the engine that you wish to synchronize the data held in the player with that held on the service. This will send back up-to-date page metadata and any new status messages.
        /// </summary>
        public const string INVOKE_TYPE_SYNC = "SYNC";

        /// <summary>
        /// Tells the engine that the user has clicked on something in the navigation as opposed to an outcome
        /// </summary>
        public const string INVOKE_TYPE_NAVIGATE = "NAVIGATE";

        /// <summary>
        /// Tells the engine that the state is waiting on votes to come in
        /// </summary>
        public const string INVOKE_TYPE_WAITING_ON_VOTES = "WAITING_ON_VOTES";

        /// <summary>
        /// Tells the user that they are not allowed to perform any operations - this is to avoid testing "null"
        /// </summary>
        public const string INVOKE_TYPE_NOT_ALLOWED = "NOT_ALLOWED";

        /// <summary>
        /// Tells the engine that it should invoke an inline subflow
        /// </summary>
        public const String INVOKE_TYPE_INLINE_SUBFLOW = "INLINE_SUBFLOW";
        
        /// <summary>
        /// Tells the engine that it should return from an inline subflow to the parent flow
        /// </summary>
        public const String INVOKE_TYPE_RETURN = "RETURN";

        #endregion

        #region Flow Modes

        /// <summary>
        /// Run the flow in full release mode.
        /// </summary>
        public const string MODE_DEFAULT = null;

        /// <summary>
        /// Run the flow with debug information switched on. This will populate the state values in the response so you can see what is ready to be committed and what values have already been committed to the state.
        /// </summary>
        public const string MODE_DEBUG = "DEBUG";

        /// <summary>
        /// Run the flow with debug information switched on, but also step through element by element. This allows you to see exactly what's happening as your flow executes as you are given the opportunity to see steps that are normally not shown to the user and track the path of execution and the state information as the engine executes.
        /// </summary>
        public const string MODE_DEBUG_STEPTHROUGH = "DEBUG_STEPTHROUGH";
        public const string MODE_RECORD = "RECORD";

        #endregion

        #region Reporting Modes

        /// <summary>
        /// Do not store any reporting data for this State.
        /// </summary>
        public const string REPORT_NONE = null;

        /// <summary>
        /// Store only the Values collected in the State as the user went through the Flow. The Values are stored in JSON format.
        /// </summary>
        public const string REPORT_VALUES = "VALUES";

        /// <summary>
        /// Store only the information in the State that pertains to the path the user took through the Flow. This includes location information if provided, as well as which users interacted at which step.
        /// </summary>
        public const string REPORT_PATH = "PATH";

        /// <summary>
        /// Store both PATH and VALUES information.
        /// </summary>
        public const string REPORT_PATH_AND_VALUES = "PATH_AND_VALUES";

        #endregion

        #region Content Value Implementation constants

        /// <summary>
        /// Removes the external identifier from the root Object so that it will not be "remembered" when updating Lists or saving back to a remote Service
        /// </summary>
        public const string CONTENT_VALUE_IMPLEMENTATION_BASE_COMMAND_DETACH = "DETACH";

        /// <summary>
        /// Blanks out the complex object or table with empty values
        /// </summary>
        public const string CONTENT_VALUE_IMPLEMENTATION_BASE_COMMAND_EMPTY = "EMPTY";

        /// <summary>
        /// Creates a new instance of the value
        /// </summary>
        public const string CONTENT_VALUE_IMPLEMENTATION_BASE_COMMAND_NEW = "NEW";

        /// <summary>
        /// Adds an Object to a List value. If the Object exists in the List, the Object is updated. If it is not already in the List, it's added.
        /// </summary>
        public const string CONTENT_VALUE_IMPLEMENTATION_BASE_COMMAND_UPDATE = "ADD";

        /// <summary>
        /// Removes an Object from a List value or subtracts from a value
        /// </summary>
        public const string CONTENT_VALUE_IMPLEMENTATION_BASE_COMMAND_REMOVE = "REMOVE";

        /// <summary>
        /// Gets the first Object from a List value
        /// </summary>
        public const string CONTENT_VALUE_IMPLEMENTATION_BASE_COMMAND_GET_FIRST = "GET_FIRST";

        /// <summary>
        /// Gets the next Object from a List value. List values maintain a "pointer" so that each time the GET_NEXT command is executed in the Flow, the List value remembers which is the next value.
        /// </summary>
        public const string CONTENT_VALUE_IMPLEMENTATION_BASE_COMMAND_GET_NEXT = "GET_NEXT";

        /// <summary>
        /// Executes a filter on a List. For the FILTER command to execute correctly, additional properties must be provided.
        /// </summary>
        public const string CONTENT_VALUE_IMPLEMENTATION_BASE_COMMAND_FILTER = "FILTER";

        /// <summary>
        /// Gets the length of a List, String, Content or Password value
        /// </summary>
        public const string CONTENT_VALUE_IMPLEMENTATION_BASE_COMMAND_GET_LENGTH = "GET_LENGTH";

        /// <summary>
        /// Gets the content value or object data of a value
        /// </summary>
        public const string CONTENT_VALUE_IMPLEMENTATION_BASE_COMMAND_GET_VALUE = "VALUE_OF";

        /// <summary>
        /// Sets the content value or object data of a value
        /// </summary>
        public const string CONTENT_VALUE_IMPLEMENTATION_BASE_COMMAND_SET_EQUAL = "SET_EQUAL";

        // These are the command properties associated with the filter
        public const string CONTENT_VALUE_IMPLEMENTATION_BASE_COMMAND_PROPERTY_FILTER_COLUMN = "COLUMN";
        public const string CONTENT_VALUE_IMPLEMENTATION_BASE_COMMAND_PROPERTY_FILTER_CRITERIA = "CRITERIA";
        public const string CONTENT_VALUE_IMPLEMENTATION_BASE_COMMAND_PROPERTY_FILTER_VALUE = "VALUE";
        public const string CONTENT_VALUE_IMPLEMENTATION_BASE_COMMAND_PROPERTY_FILTER_CONTENT_TYPE = "CONTENT_TYPE";
        public const string CONTENT_VALUE_IMPLEMENTATION_BASE_COMMAND_PROPERTY_FILTER_SHARED_ELEMENT_CONTENT_VALUE_TO_REFERENCE_ID = "SHARED_ELEMENT_CONTENT_VALUE_TO_REFERENCE_ID";
        public const string CONTENT_VALUE_IMPLEMENTATION_BASE_COMMAND_PROPERTY_FILTER_SHARED_ELEMENT_CONTENT_VALUE_TO_REFERENCE_TYPE_ELEMENT_ENTRY_ID = "SHARED_ELEMENT_CONTENT_VALUE_TO_REFERENCE_TYPE_ELEMENT_ENTRY_ID";
        public const string CONTENT_VALUE_IMPLEMENTATION_BASE_COMMAND_PROPERTY_FILTER_SHARED_ELEMENT_CONTENT_VALUE_TO_REFERENCE_COMMAND = "SHARED_ELEMENT_CONTENT_VALUE_TO_REFERENCE_COMMAND";

        #endregion

        #region Criteria for content values

        /// <summary>
        /// {left} is equal to {right}
        /// </summary>
        public const string CONTENT_VALUE_IMPLEMENTATION_CRITERIA_TYPE_EQUAL = "EQUAL";
        
        /// <summary>
        /// All values in {left} are equal to {right}
        /// </summary>
        public const string CONTENT_VALUE_IMPLEMENTATION_CRITERIA_TYPE_ALL_EQUAL = "ALL_EQUAL";
        
        /// <summary>
        /// Any value in {left} is equal to {right}
        /// </summary>
        public const string CONTENT_VALUE_IMPLEMENTATION_CRITERIA_TYPE_ANY_EQUAL = "ANY_EQUAL";

        /// <summary>
        /// {left} is not equal to {right}
        /// </summary>
        public const string CONTENT_VALUE_IMPLEMENTATION_CRITERIA_TYPE_NOT_EQUAL = "NOT_EQUAL";

        /// <summary>
        /// {left} is greater than {right}. For ContentString types, this is done alphabetically.
        /// </summary>
        public const string CONTENT_VALUE_IMPLEMENTATION_CRITERIA_TYPE_GREATER_THAN = "GREATER_THAN";

        /// <summary>
        /// {left} is greater than or equal to {right}. For ContentString types, this is done alphabetically.
        /// </summary>
        public const string CONTENT_VALUE_IMPLEMENTATION_CRITERIA_TYPE_GREATER_THAN_OR_EQUAL = "GREATER_THAN_OR_EQUAL";

        /// <summary>
        /// {left} is less than {right}. For ContentString types, this is done alphabetically.
        /// </summary>
        public const string CONTENT_VALUE_IMPLEMENTATION_CRITERIA_TYPE_LESS_THAN = "LESS_THAN";

        /// <summary>
        /// {left} is less than or equal to {right}. For ContentString types, this is done alphabetically.
        /// </summary>
        public const string CONTENT_VALUE_IMPLEMENTATION_CRITERIA_TYPE_LESS_THAN_OR_EQUAL = "LESS_THAN_OR_EQUAL";

        /// <summary>
        /// {left} contains the characters in {right}. This is only valid for ContentString types and is case insensitive.
        /// </summary>
        public const string CONTENT_VALUE_IMPLEMENTATION_CRITERIA_TYPE_CONTAINS = "CONTAINS";

        /// <summary>
        /// {left} starts with the characters in {right}. This is only valid for ContentString types and is case insensitive.
        /// </summary>
        public const string CONTENT_VALUE_IMPLEMENTATION_CRITERIA_TYPE_STARTS_WITH = "STARTS_WITH";

        /// <summary>
        /// {left} ends with the characters in {right}. This is only valid for ContentString types and is case insensitive.
        /// </summary>
        public const string CONTENT_VALUE_IMPLEMENTATION_CRITERIA_TYPE_ENDS_WITH = "ENDS_WITH";

        /// <summary>
        /// {left} is empty or null. When this criteria type is used, it must be compared with a {right} that is a ContentBoolean.
        /// </summary>
        public const string CONTENT_VALUE_IMPLEMENTATION_CRITERIA_TYPE_IS_EMPTY = "IS_EMPTY";

        #endregion

        #region Content types

        /// <summary>
        /// A datetime value. Using the REST API, the value should be provided in ISO 8601 format.
        /// </summary>
        public const string CONTENT_TYPE_DATETIME = "ContentDateTime";

        /// <summary>
        /// A double number value
        /// </summary>
        public const string CONTENT_TYPE_NUMBER = "ContentNumber";

        /// <summary>
        /// The value is object data based on the ManyWho format. This allows you to pass complex data into ManyWho for processing, including child objects and lists. Any Object Data being passed into the system also needs to have a Type as defined by your Type Elements.
        /// </summary>
        public const string CONTENT_TYPE_OBJECT = "ContentObject";

        /// <summary>
        /// A password value, masked anywhere that is user-visible
        /// </summary>
        public const string CONTENT_TYPE_PASSWORD = "ContentPassword";

        /// <summary>
        /// A simple string value. The contents of this String will also be pasrsed for any value references.
        /// </summary>
        public const string CONTENT_TYPE_STRING = "ContentString";

        /// <summary>
        /// The value is a list of object data based on the ManyWho format. This allows you to pass lists of complex data into ManyWho for processing (of the same Type), including child objects and lists. Any Object Data being passed into the system also needs to have a Type as defined by your Type Elements.
        /// </summary>
        public const string CONTENT_TYPE_LIST = "ContentList";

        /// <summary>
        /// A boolean value
        /// </summary>
        public const string CONTENT_TYPE_BOOLEAN = "ContentBoolean";

        /// <summary>
        /// If you indicate a value is "Content", we typically expect that the content holds HTML formatted String content. The contents of this String will also be pasrsed for any value references.
        /// </summary>
        public const string CONTENT_TYPE_CONTENT = "ContentContent";

        /// <summary>
        /// A string value that is encrypted at rest and never shown to users. The value can be decrypted when sent to a service, if the builder chooses it to be.
        /// </summary>
        public const string CONTENT_TYPE_ENCRYPTED = "ContentEncrypted";

        #endregion

        // Content parser strings
        public const string EMBEDDED_KEY_START_INTERNAL = "flowkey___";
        public const string EMBEDDED_KEY_FINISH_INTERNAL = "___flowkey";
        public const string EMBEDDED_KEY_START_EXTERNAL = "{!";
        public const string EMBEDDED_KEY_FINISH_EXTERNAL = "}";
        public const string EMBEDDED_KEY_ELEMENT_PART_WITH_SPACE_START_EXTERNAL = "[";
        public const string EMBEDDED_KEY_ELEMENT_PART_WITH_SPACE_FINISH_EXTERNAL = "]";
        public const string EMBEDDED_KEY_ELEMENT_PART_SEPARATOR = "].[";

        // Authenticated User constants
        public const string AUTHENTICATED_USER_STATUS_ACCESS_DENIED = "ACCESS_DENIED";
        public const string AUTHENTICATED_USER_STATUS_AUTHENTICATED = "AUTHENTICATED";
        public const string AUTHENTICATED_USER_KEY_TOKEN = "TOKEN";
        public const string AUTHENTICATED_USER_KEY_DIRECTORY_ID = "DIRECTORY_ID";
        public const string AUTHENTICATED_USER_PUBLIC_DIRECTORY_ID = "UNAUTHENTICATED";
        public const string AUTHENTICATED_USER_PUBLIC_DIRECTORY_NAME = "UNKNOWN";
        public const string AUTHENTICATED_USER_PUBLIC_ROLE_ID = "UNAUTHENTICATED";
        public const string AUTHENTICATED_USER_PUBLIC_ROLE_NAME = "UNKNOWN";
        public const string AUTHENTICATED_USER_PUBLIC_PRIMARY_GROUP_ID = "UNAUTHENTICATED";
        public const string AUTHENTICATED_USER_PUBLIC_PRIMARY_GROUP_NAME = "UNKNOWN";
        public const string AUTHENTICATED_USER_PUBLIC_EMAIL = "admin@manywho.com";
        public const string AUTHENTICATED_USER_PUBLIC_TENANT_NAME = "UNKNOWN";
        public const string AUTHENTICATED_USER_PUBLIC_USER_ID = "PUBLIC_USER";
        public const string AUTHENTICATED_USER_PUBLIC_IDENTITY_PROVIDER = "NONE";
        public const string AUTHENTICATED_USER_PUBLIC_STATUS = "UKNOWN";
        public const string AUTHENTICATED_USER_PUBLIC_TOKEN = "NONE";
        public static readonly Guid AUTHENTICATED_USER_PUBLIC_MANYWHO_USER_ID = Guid.Parse("52DF1A90-3826-4508-B7C2-CDE8AA5B72CF");

        public const string AUTHENTICATED_WHO_TOKEN_MANYWHO_TENANT_ID = "ManyWhoTenantId";
        public const string AUTHENTICATED_WHO_TOKEN_MANYWHO_USER_ID = "ManyWhoUserId";
        public const string AUTHENTICATED_WHO_TOKEN_MANYWHO_TOKEN = "ManyWhoToken";
        public const string AUTHENTICATED_WHO_TOKEN_DIRECTORY_ID = "DirectoryId";
        public const string AUTHENTICATED_WHO_TOKEN_DIRECTORY_NAME = "DirectoryName";
        public const string AUTHENTICATED_WHO_TOKEN_ROLE_ID = "RoleId";
        public const string AUTHENTICATED_WHO_TOKEN_ROLE_NAME = "RoleName";
        public const string AUTHENTICATED_WHO_TOKEN_PRIMARY_GROUP_ID = "PrimaryGroupId";
        public const string AUTHENTICATED_WHO_TOKEN_PRIMARY_GROUP_NAME = "PrimaryGroupName";
        public const string AUTHENTICATED_WHO_TOKEN_EMAIL = "Email";
        public const string AUTHENTICATED_WHO_TOKEN_IDENTITY_PROVIDER = "IdentityProvider";
        public const string AUTHENTICATED_WHO_TOKEN_TENANT_NAME = "TenantName";
        public const string AUTHENTICATED_WHO_TOKEN_TOKEN = "Token";
        public const string AUTHENTICATED_WHO_TOKEN_USER_ID = "UserId";
        public const string AUTHENTICATED_WHO_TOKEN_USERNAME = "Username";
        public const string AUTHENTICATED_WHO_TOKEN_FIRST_NAME = "FirstName";
        public const string AUTHENTICATED_WHO_TOKEN_LAST_NAME = "LastName";

        public const char SERIALIZATION_DELIMITER_DELIMITER = '=';

        public const string CULTURE_TOKEN_BRAND = "Brand";
        public const string CULTURE_TOKEN_COUNTRY = "Country";
        public const string CULTURE_TOKEN_LANGUAGE = "Language";
        public const string CULTURE_TOKEN_VARIANT = "Variant";

        public static readonly Guid MANYWHO_JOIN_URI_VALUE_ID = Guid.Parse("E2063196-3C75-4388-8B00-1005B8CD59AD");
        public const string MANYWHO_JOIN_URI_DEVELOPER_NAME = "$JoinUri";

        public static readonly Guid MANYWHO_USER_VALUE_ID = Guid.Parse("03DC41DD-1C6B-4B33-BF61-CBD1D0778FFF");

        public static readonly Guid MANYWHO_TRUE_VALUE_ID = Guid.Parse("BE1BC78E-FD57-40EC-9A86-A815DE2A9E28");
        public const string MANYWHO_TRUE_DEVELOPER_NAME = "$True";

        public static readonly Guid MANYWHO_FALSE_VALUE_ID = Guid.Parse("496FD041-D91F-48FB-AA4F-91C6C9A11CA1");
        public const string MANYWHO_FALSE_DEVELOPER_NAME = "$False";

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
        public static readonly Guid MANYWHO_USER_PROPERTY_ID_ROLE_ID = Guid.Parse("5582D6D3-B673-4972-A65F-9E915C0C10AA");
        public static readonly Guid MANYWHO_USER_PROPERTY_ID_ROLE_NAME = Guid.Parse("D9904FDD-8F19-4f26-96C1-83EC2f58A540");
        public static readonly Guid MANYWHO_USER_PROPERTY_ID_PRIMARY_GROUP_ID = Guid.Parse("CE98CE03-41EE-405D-B849-509974610D7F");
        public static readonly Guid MANYWHO_USER_PROPERTY_ID_PRIMARY_GROUP_NAME = Guid.Parse("F26BA831-B013-4654-8AE3-8EB3AB5E6C1E");
        public static readonly Guid MANYWHO_USER_PROPERTY_ID_STATUS = Guid.Parse("4FA61B46-A370-455E-85ED-D9A0A8723A43");
        public static readonly Guid MANYWHO_USER_PROPERTY_ID_AUTHENTICATION_TYPE = Guid.Parse("4FA61B47-A370-455E-85ED-D9A0A8723A43");
        public static readonly Guid MANYWHO_USER_PROPERTY_ID_LOGIN_URL = Guid.Parse("4FA61B48-A370-455E-85ED-D9A0A8723A43");
        public static readonly Guid MANYWHO_USER_PROPERTY_ID_IP_ADDRESS = Guid.Parse("0dabbcd3-b5b1-47b3-b7e1-535c5b5e1878");

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

        public const string MANYWHO_GROUP_DEVELOPER_NAME = "$Group";
        public const string MANYWHO_GROUP_PROPERTY_GROUP_ID = "Group ID";
        public const string MANYWHO_GROUP_PROPERTY_GROUP_NAME = "Group Name";
        public const string MANYWHO_GROUP_PROPERTY_GROUP_OWNER_USER_ID = "Group Owner User ID";

        public const string MANYWHO_STATE_DEVELOPER_NAME = "$State";
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

        #region Page Conditions

        /// <summary>
        /// The value of the component or value element ID object reference.
        /// </summary>
        public const string META_DATA_VALUE = "VALUE";

        /// <summary>
        /// The enabled status of the component.
        /// </summary>
        public const string META_DATA_ENABLED = "METADATA.ENABLED";

        /// <summary>
        /// The editable status of the component.
        /// </summary>
        public const string META_DATA_EDITABLE = "METADATA.EDITABLE";

        /// <summary>
        /// The visibility status of the component.
        /// </summary>
        public const string META_DATA_VISIBLE = "METADATA.VISIBLE";

        /// <summary>
        /// The required status of the component.
        /// </summary>
        public const string META_DATA_REQUIRED = "METADATA.REQUIRED";

        #endregion

        // Service description constants
        public const string SERVICE_DESCRIPTION_VALUE_TABLE_NAME = "TableName";

        // Plugin constants
        public const string SERVICE_REQUEST_FORM_POST_KEY = "ServiceRequest";
        public const string FILE_DATA_REQUEST_FORM_POST_KEY = "FileDataRequest";
        public const string FILE_DATA_REQUEST_FORM_FILE_NAME = "file";

        // Authentication constants
        //public const String OBJECT_TYPE_GROUP_AUTHORIZATION_GROUP = "GroupAuthorizationGroup";
        public const string AUTHENTICATION_GROUP_AUTHORIZATION_GROUP_OBJECT_DEVELOPER_NAME = "GroupAuthorizationGroup";
        public const string AUTHENTICATION_GROUP_AUTHORIZATION_USER_OBJECT_DEVELOPER_NAME = "GroupAuthorizationUser";
        //public const String SERVICE_VALUE_AUTHENTICATION_ID = "AuthenticationId";
        public const string AUTHENTICATION_OBJECT_AUTHENTICATION_ID = "AuthenticationId";
        //public const String SERVICE_VALUE_FRIENDLY_NAME = "FriendlyName";
        public const string AUTHENTICATION_OBJECT_FRIENDLY_NAME = "FriendlyName";
        public const string AUTHENTICATION_OBJECT_DEVELOPER_SUMMARY = "DeveloperSummary";

        public const string AUTHENTICATION_ATTRIBUTE_LABEL = "Label";
        public const string AUTHENTICATION_ATTRIBUTE_VALUE = "Value";
        public const string AUTHENTICATION_AUTHENTICATION_ATTRIBUTE_OBJECT_DEVELOPER_NAME = "AuthenticationAttribute";

        #region Group Authorization

        /// <summary>
        /// Indicates that the Flow is public and therefore does not need to have a Service assigned to manage the authorization of users. However, if one is provided, it will be used and any identifying user information will be passed forward (e.g. location).
        /// </summary>
        public const string GROUP_AUTHORIZATION_GLOBAL_AUTHENTICATION_TYPE_PUBIC = "PUBLIC";

        /// <summary>
        /// Indicates that the Flow is accessible to all users of a particular directory provided through the Service.
        /// </summary>
        public const string GROUP_AUTHORIZATION_GLOBAL_AUTHENTICATION_TYPE_ALL_USERS = "ALL_USERS";

        /// <summary>
        /// Indicates that the Flow has specific authorization rights that are defined in the groups, users or locations.
        /// </summary>
        public const string GROUP_AUTHORIZATION_GLOBAL_AUTHENTICATION_TYPE_SPECIFIED = "SPECIFIED";

        /// <summary>
        /// Use an existing collaboration stream when the user enters this Flow, or create a new one if one does not yet exist.
        /// </summary>
        public const string GROUP_AUTHORIZATION_STREAM_BEHAVIOUR_USE_EXISTING = "USE_EXISTING";

        /// <summary>
        /// Create a new collaboration stream every time the user enters this Flow.
        /// </summary>
        public const string GROUP_AUTHORIZATION_STREAM_BEHAVIOUR_CREATE_NEW = "CREATE_NEW";

        /// <summary>
        /// Do not provide a collaboration stream for this Flow.
        /// </summary>
        public const string GROUP_AUTHORIZATION_STREAM_BEHAVIOUR_NONE = "NONE";
        public const string GROUP_AUTHORIZATION_USER = "USER";

        #endregion

        #region List Filter Config

        /// <summary>
        /// Order the values with the lowest value appearing first.
        /// </summary>
        public const string LIST_FILTER_CONFIG_ORDER_BY_ASCENDING = "ASC";

        /// <summary>
        /// Order the values with the highest value appearing first
        /// </summary>
        public const string LIST_FILTER_CONFIG_ORDER_BY_DESCENDING = "DESC";

        /// <summary>
        /// Compare the values using 'and'. E.g. this AND that must be true.
        /// </summary>
        public const string LIST_FILTER_CONFIG_COMPARISON_TYPE_AND = "AND";

        /// <summary>
        /// Compare the values using 'or'. E.g. this or that must be true.
        /// </summary>
        public const string LIST_FILTER_CONFIG_COMPARISON_TYPE_OR = "OR";

        #endregion

        // Page Container constants
        public const string PAGE_CONTAINER_CONTAINER_TYPE_VERTICAL_FLOW = "VERTICAL_FLOW";
        public const string PAGE_CONTAINER_CONTAINER_TYPE_HORIZONTAL_FLOW = "HORIZONTAL_FLOW";
        public const string PAGE_CONTAINER_CONTAINER_TYPE_GROUP = "GROUP";

        // Constants for property names for objects being returned for user context
        public const string MANYWHO_USER_DEVELOPER_NAME = "$User";

        public const string MANYWHO_USER_PROPERTY_USER_ID = "User ID";
        public const string MANYWHO_USER_PROPERTY_USERNAME = "Username";
        public const string MANYWHO_USER_PROPERTY_EMAIL = "Email";
        public const string MANYWHO_USER_PROPERTY_FIRST_NAME = "First Name";
        public const string MANYWHO_USER_PROPERTY_LAST_NAME = "Last Name";
        public const string MANYWHO_USER_PROPERTY_LANGUAGE = "Language";
        public const string MANYWHO_USER_PROPERTY_COUNTRY = "Country";
        public const string MANYWHO_USER_PROPERTY_BRAND = "Brand";
        public const string MANYWHO_USER_PROPERTY_VARIANT = "Variant";
        public const string MANYWHO_USER_PROPERTY_LOCATION = "Location";
        public const string MANYWHO_USER_PROPERTY_DIRECTORY_ID = "Directory Id";
        public const string MANYWHO_USER_PROPERTY_DIRECTORY_NAME = "Directory Name";
        public const string MANYWHO_USER_PROPERTY_ROLE_ID = "Role Id";
        public const string MANYWHO_USER_PROPERTY_ROLE_NAME = "Role Name";
        public const string MANYWHO_USER_PROPERTY_PRIMARY_GROUP_ID = "Primary Group Id";
        public const string MANYWHO_USER_PROPERTY_PRIMARY_GROUP_NAME = "Primary Group Name";
        public const string MANYWHO_USER_PROPERTY_STATUS = "Status";
        public const string MANYWHO_USER_PROPERTY_AUTHENTICATION_TYPE = "AuthenticationType";
        public const string MANYWHO_USER_PROPERTY_LOGIN_URL = "LoginUrl";
        public const string MANYWHO_USER_PROPERTY_IP_ADDRESS = "IP Address";

        public const string MANYWHO_LOCATION_DEVELOPER_NAME = "$Location";

        public const string MANYWHO_LOCATION_PROPERTY_TIMESTAMP = "Location Timestamp";
        public const string MANYWHO_LOCATION_PROPERTY_LATITUDE = "Current Latitude";
        public const string MANYWHO_LOCATION_PROPERTY_LONGITUDE = "Current Longitude";
        public const string MANYWHO_LOCATION_PROPERTY_ACCURACY = "Location Accuracy";
        public const string MANYWHO_LOCATION_PROPERTY_ALTITUDE = "Current Altitude";
        public const string MANYWHO_LOCATION_PROPERTY_ALTITUDE_ACCURACY = "Altitude Accuracy";
        public const string MANYWHO_LOCATION_PROPERTY_HEADING = "Current Heading";
        public const string MANYWHO_LOCATION_PROPERTY_SPEED = "Current Speed";

        public const string MANYWHO_FILE_DEVELOPER_NAME = "$File";

        public const string MANYWHO_FILE_PROPERTY_KIND = "Kind";
        public const string MANYWHO_FILE_PROPERTY_ID = "Id";
        public const string MANYWHO_FILE_PROPERTY_MIME_TYPE = "Mime Type";
        public const string MANYWHO_FILE_PROPERTY_NAME = "Name";
        public const string MANYWHO_FILE_PROPERTY_DESCRIPTION = "Description";
        public const string MANYWHO_FILE_PROPERTY_DATE_CREATED = "Date Created";
        public const string MANYWHO_FILE_PROPERTY_DATE_MODIFIED = "Date Modified";
        public const string MANYWHO_FILE_PROPERTY_DOWNLOAD_URI = "Download Uri";
        public const string MANYWHO_FILE_PROPERTY_EMBED_URI = "Embed Uri";
        public const string MANYWHO_FILE_PROPERTY_ICON_URI = "Icon Uri";

        public const string AUTHORIZATION_STATUS_NOT_AUTHORIZED = "401";
        public const string AUTHORIZATION_STATUS_AUTHORIZED = "200";


        /// <summary>
        /// The element is specifically a Service Element
        /// </summary>
        public const string SERVICE_ELEMENT_TYPE_IMPLEMENTATION_SERVICE = "SERVICE";

        // The API name for shared elements
        public const string SHARED_ELEMENT_TYPE_IMPLEMENTATION_VALUE = "VALUE";

        /// <summary>
        /// The Element is specifically a Value Element
        /// </summary>
        public const string SHARED_ELEMENT_TYPE_IMPLEMENTATION_VARIABLE = "VARIABLE";
        public const string SHARED_ELEMENT_TYPE_IMPLEMENTATION_CONSTANT = "CONSTANT";
        public const string SHARED_ELEMENT_TYPE_IMPLEMENTATION_RESOURCE = "RESOURCE";
        public const string SHARED_ELEMENT_TYPE_IMPLEMENTATION_FUNCTION = "FUNCTION";
        public const string SHARED_ELEMENT_TYPE_IMPLEMENTATION_TABLE = "TABLE";
        public const string SHARED_ELEMENT_TYPE_IMPLEMENTATION_CONNECTION = "CONNECTION";
        public const string SHARED_ELEMENT_TYPE_IMPLEMENTATION_MACRO = "MACRO";

        // Access values for shared elements
        public const string ACCESS_PRIVATE = "PRIVATE";
        public const string ACCESS_INPUT = "INPUT";
        public const string ACCESS_OUTPUT = "OUTPUT";
        public const string ACCESS_INPUT_OUTPUT = "INPUT_OUTPUT";

        #region Component types for pages

        /// <summary>
        /// The component accepts rich content. For the standard players, this is in the format of HTML5, however, it can be any rich content. Use this if you expect the user to be producing a formatted document.
        /// </summary>
        public const string COMPONENT_TYPE_CONTENT = "CONTENT";

        /// <summary>
        /// The component accepts basic inputs. This is analagous to standard input fields for things like: First Name, Last Name, etc.
        /// </summary>
        public const string COMPONENT_TYPE_INPUTBOX = "INPUT";

        /// <summary>
        /// The component accepts multi-line, unformatted content. This is analagous to fields for things like: Comments, Description, etc.
        /// </summary>
        public const string COMPONENT_TYPE_TEXTBOX = "TEXTAREA";

        /// <summary>
        /// The component allows the user to select from a set of object data entries. This is analagous to simple combo boxes or multiselection boxes.
        /// </summary>
        public const string COMPONENT_TYPE_COMBOBOX = "SELECT";

        /// <summary>
        /// The component allows the user to tick a box (usually indicating a Yes/No response).
        /// </summary>
        public const string COMPONENT_TYPE_CHECKBOX = "CHECKBOX";

        /// <summary>
        /// The component allows the user to view/select from a set of object data entries. This is normally presented as multicolumn tables, though for mobile use-cases may be shown as a multiproperty list of selections.
        /// </summary>
        public const string COMPONENT_TYPE_TABLE = "TABLE";

        /// <summary>
        /// The component is simply used to present information to the end consumer. This can be formatted content - commonly in HTML5.
        /// </summary>
        public const string COMPONENT_TYPE_PRESENTATION = "PRESENTATION";

        /// <summary>
        /// The component is non-standard and the player should look for a matching widget based on the provided developer name and/or tag metadata.
        /// </summary>
        public const string COMPONENT_TYPE_TAG = "TAG";

        /// <summary>
        /// The component is simply used to present an image to the end consumer. This is normally a URI to the image file.
        /// </summary>
        public const string COMPONENT_TYPE_IMAGE = "IMAGE";

        /// <summary>
        /// The component is used to upload files to a Service.
        /// </summary>
        public const string COMPONENT_TYPE_FILES = "FILES";

        #endregion

        #region Container types for pages

        /// <summary>
        /// The containers or components that are children of this container should be oriented vertically with respect to each other.
        /// </summary>
        public const string CONTAINER_TYPE_VERTICAL_FLOW = "VERTICAL_FLOW";

        /// <summary>
        /// The containers or components that are children of this container should be oriented horizontally and evenly with respect to each other.
        /// </summary>
        public const string CONTAINER_TYPE_HORIZONTAL_FLOW = "HORIZONTAL_FLOW";

        /// <summary>
        /// The containers or components that are children of this container should be oriented horizontally and as close as possible to each other inline.
        /// </summary>
        public const string CONTAINER_TYPE_INLINE_FLOW = "INLINE_FLOW";

        /// <summary>
        /// The containers (components not allowed in the default player) that are children of this container should be treated as sections of the group. This is analagous to UI tabs - where this GROUP container is the tab container and each of the child page containers becomes at tab for the user to switch views.
        /// </summary>
        public const string CONTAINER_TYPE_GROUP = "GROUP";

        #endregion

        #region Map Element Action Bindings

        /// <summary>
        /// The engine should apply all values collected to the state.
        /// </summary>
        public const string ACTION_BINDING_SAVE = "SAVE";

        /// <summary>
        /// The engine should ignore all values collected and not apply anything to the state except the outcome action.
        /// </summary>
        public const string ACTION_BINDING_NO_SAVE = "NO_SAVE";
        public const string ACTION_BINDING_PARTIAL_SAVE = "PARTIAL_SAVE";

        #endregion

        // Action types for map elements
        public const string ACTION_TYPE_NEW = "NEW";
        public const string ACTION_TYPE_QUERY = "QUERY";
        public const string ACTION_TYPE_INSERT = "INSERT";
        public const string ACTION_TYPE_UPDATE = "UPDATE";
        public const string ACTION_TYPE_UPSERT = "UPSERT";
        public const string ACTION_TYPE_DELETE = "DELETE";
        public const string ACTION_TYPE_REMOVE = "REMOVE";
        public const string ACTION_TYPE_ADD = "ADD";
        public const string ACTION_TYPE_EDIT = "EDIT";
        public const string ACTION_TYPE_NEXT = "NEXT";
        public const string ACTION_TYPE_BACK = "BACK";
        public const string ACTION_TYPE_DONE = "DONE";
        public const string ACTION_TYPE_SAVE = "SAVE";
        public const string ACTION_TYPE_CANCEL = "CANCEL";
        public const string ACTION_TYPE_APPLY = "APPLY";
        public const string ACTION_TYPE_IMPORT = "IMPORT";
        public const string ACTION_TYPE_CLOSE = "CLOSE";
        public const string ACTION_TYPE_OPEN = "OPEN";
        public const string ACTION_TYPE_SUBMIT = "SUBMIT";
        public const string ACTION_TYPE_ESCALATE = "ESCALATE";
        public const string ACTION_TYPE_REJECT = "REJECT";
        public const string ACTION_TYPE_DELEGATE = "DELEGATE";

        /// <summary>
        /// The Element is specifically a Page Element
        /// </summary>
        public const string UI_ELEMENT_TYPE_IMPLEMENTATION_PAGE_LAYOUT = "PAGE_LAYOUT";

        // The API name for navigations
        public const string UI_ELEMENT_TYPE_IMPLEMENTATION_NAVIGATION = "NAVIGATION";

        #region Map Elements

        /// <summary>
        /// The Map Element is a Start implementation that can only be used at the beginning of a Flow
        /// </summary>
        public const string MAP_ELEMENT_TYPE_IMPLEMENTATION_START = "START";

        /// <summary>
        /// The Map Element is a Step implementation that can be used for simple steps in your Flow
        /// </summary>
        public const string MAP_ELEMENT_TYPE_IMPLEMENTATION_STEP = "STEP";

        /// <summary>
        /// The Map Element is a Input implementation that can be used to show the user your Page Elements and also execute messages
        /// </summary>
        public const string MAP_ELEMENT_TYPE_IMPLEMENTATION_INPUT = "INPUT";

        /// <summary>
        /// The Map Element is a Decision implementation that can be used to execute logic within your Flow
        /// </summary>
        public const string MAP_ELEMENT_TYPE_IMPLEMENTATION_DECISION = "DECISION";

        /// <summary>
        /// The Map Element is a Operator implementation that can be used to make changes to Values in your Flow
        /// </summary>
        public const string MAP_ELEMENT_TYPE_IMPLEMENTATION_OPERATOR = "OPERATOR";

        /// <summary>
        /// The Map Element can be used to execute a subflow
        /// </summary>
        public const String MAP_ELEMENT_TYPE_IMPLEMENTATION_SUB_FLOW = "SUBFLOW";
        
        /// <summary>
        /// The Map Element can be used to return from a subflow
        /// </summary>
        public const String MAP_ELEMENT_TYPE_IMPLEMENTATION_RETURN = "RETURN";

        /// <summary>
        /// The Map Element is a Database Load implementation that can be used to load data into Values in your Flow from a Service
        /// </summary>
        public const string MAP_ELEMENT_TYPE_IMPLEMENTATION_DATABASE_LOAD = "DATABASE_LOAD";

        /// <summary>
        /// The Map Element is a Database Save implementation that can be used to save data from Values in your Flow to a Service
        /// </summary>
        public const string MAP_ELEMENT_TYPE_IMPLEMENTATION_DATABASE_SAVE = "DATABASE_SAVE";

        /// <summary>
        /// The Map Element is a Database Delete implementation that can be used to delete data using Values in your Flow in a Service
        /// </summary>
        public const string MAP_ELEMENT_TYPE_IMPLEMENTATION_DATABASE_DELETE = "DATABASE_DELETE";

        /// <summary>
        /// The Map Element is a Message implementation that can be used to call APIs on a Service to perform synchronous and asynchronous jobs
        /// </summary>
        public const string MAP_ELEMENT_TYPE_IMPLEMENTATION_MESSAGE = "MESSAGE";

        /// <summary>
        /// The Map Element is a Page implementation that can be used to show the user your Page Elements generated by a service, and can also execute messages
        /// </summary>
        public const string MAP_ELEMENT_TYPE_IMPLEMENTATION_PAGE = "PAGE";

        /// <summary>
        /// The Group Element is a Swimlane implementation that can be used to configure specific authorization rights in parts of your Flow
        /// </summary>
        public const string GROUP_ELEMENT_TYPE_IMPLEMENTATION_SWIMLANE = "SWIMLANE";

        /// <summary>
        /// The Element is specifically a Tag Element
        /// </summary>
        public const string UI_ELEMENT_TYPE_IMPLEMENTATION_TAG = "TAG";

        /// <summary>
        /// The element is specifically a Type Element
        /// </summary>
        public const string TYPE_ELEMENT_TYPE_IMPLEMENTATION_TYPE = "TYPE";

        #endregion

        #region Post Update Types

        /// <summary>
        /// Post an update to the feed associated with this Flow when the Map Element loads.
        /// </summary>
        public const string POST_UPDATE_WHEN_ON_LOAD = "ON_LOAD";

        /// <summary>
        /// Post an update to the feed associated with this Flow when the Map Element is finished and moving to the next Map Element in the Flow.
        /// </summary>
        public const string POST_UPDATE_WHEN_ON_EXIT = "ON_EXIT";

        #endregion

        // Guids for the reserved outcomes for faults and debug
        public static readonly Guid DEBUG_GUID = Guid.Parse("EE6C8827-11E2-486D-B5FA-4D1A0CBB77A3");
        public static readonly Guid FAULT_GUID = Guid.Parse("318B0F3A-A570-4C5D-835C-21C1EEB17787");

        // Outcomes with a fault
        public const string FAULT_DEVELOPER_NAME = "FAULT";

        #region Authentication Types

        /// <summary>
        /// The user should login using username/password authentication credentials
        /// </summary>
        public const string AUTHENTICATION_TYPE_USERNAME_PASSWORD = "USERNAME_PASSWORD";
        
        /// <summary>
        /// The user should login using the supported OAuth1.0 sequence
        /// </summary>
        public const string AUTHENTICATION_TYPE_OAUTH = "OAUTH";

        /// <summary>
        /// The user should login using the supported OAuth2 sequence
        /// </summary>
        public const string AUTHENTICATION_TYPE_OAUTH2 = "OAUTH2";

        /// <summary>
        /// The user should login using SAML authentication
        /// </summary>
        public const string AUTHENTICATION_TYPE_SAML = "SAML";

        public const string PROPERTY_SEARCH = "PROPERTY:";
        public const string EXACT_SEARCH = "EXACT:";

        #endregion

        /// <summary>
        /// The Vote should be based on a fixed number of users that click on a particularly Outcome.
        /// </summary>
        public const string VOTE_TYPE_COUNT = "COUNT";

        /// <summary>
        /// The Vote should be based on the percentage of users that click on a particular Outcome. The percentage is calculated based on the authorization context of the Map Element at the time of execution.
        /// </summary>
        public const string VOTE_TYPE_PERCENT = "PERCENT";

        public const string LISTENER_TYPE_EDIT = "EDIT";
        public const string LISTENER_TYPE_DELETE = "DELETE";

        public const string STATE_LISTEN_TYPE_DONE = "DONE";
        public const string STATE_LISTEN_TYPE_UPDATE = "UPDATE";

        public const string USER_PERMISSION_TYPE_CAN_EDIT_AND_ACTION = "CAN_EDIT_AND_ACTION";
        public const string USER_PERMISSION_TYPE_CAN_ACTION = "CAN_ACTION";
        public const string USER_PERMISSION_TYPE_CAN_EDIT = "CAN_EDIT";
        public const string USER_PERMISSION_TYPE_CAN_VIEW = "CAN_VIEW";
        public const string USER_PERMISSION_TYPE_CAN_COMMENT = "CAN_COMMENT";

        public const string CONTENT_ENCRYPTED_PLACEHOLDER = "__ENCRYPTED__";

        public const string ROLE_BUILDER = "builder";
        public const string ROLE_USER = "user";
    }
}
