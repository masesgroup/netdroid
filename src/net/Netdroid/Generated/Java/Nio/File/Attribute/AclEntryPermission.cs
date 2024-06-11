/*
*  Copyright 2024 MASES s.r.l.
*
*  Licensed under the Apache License, Version 2.0 (the "License");
*  you may not use this file except in compliance with the License.
*  You may obtain a copy of the License at
*
*  http://www.apache.org/licenses/LICENSE-2.0
*
*  Unless required by applicable law or agreed to in writing, software
*  distributed under the License is distributed on an "AS IS" BASIS,
*  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
*  See the License for the specific language governing permissions and
*  limitations under the License.
*
*  Refer to LICENSE for more information.
*/

/*
*  This file is generated by MASES.JNetReflector (ver. 2.5.2.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Nio.File.Attribute
{
    #region AclEntryPermission
    public partial class AclEntryPermission
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/file/attribute/AclEntryPermission.html#ADD_FILE"/>
        /// </summary>
        public static Java.Nio.File.Attribute.AclEntryPermission ADD_FILE { get { if (!_ADD_FILEReady) { _ADD_FILEContent = SGetField<Java.Nio.File.Attribute.AclEntryPermission>(LocalBridgeClazz, "ADD_FILE"); _ADD_FILEReady = true; } return _ADD_FILEContent; } }
        private static Java.Nio.File.Attribute.AclEntryPermission _ADD_FILEContent = default;
        private static bool _ADD_FILEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/file/attribute/AclEntryPermission.html#ADD_SUBDIRECTORY"/>
        /// </summary>
        public static Java.Nio.File.Attribute.AclEntryPermission ADD_SUBDIRECTORY { get { if (!_ADD_SUBDIRECTORYReady) { _ADD_SUBDIRECTORYContent = SGetField<Java.Nio.File.Attribute.AclEntryPermission>(LocalBridgeClazz, "ADD_SUBDIRECTORY"); _ADD_SUBDIRECTORYReady = true; } return _ADD_SUBDIRECTORYContent; } }
        private static Java.Nio.File.Attribute.AclEntryPermission _ADD_SUBDIRECTORYContent = default;
        private static bool _ADD_SUBDIRECTORYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/file/attribute/AclEntryPermission.html#APPEND_DATA"/>
        /// </summary>
        public static Java.Nio.File.Attribute.AclEntryPermission APPEND_DATA { get { if (!_APPEND_DATAReady) { _APPEND_DATAContent = SGetField<Java.Nio.File.Attribute.AclEntryPermission>(LocalBridgeClazz, "APPEND_DATA"); _APPEND_DATAReady = true; } return _APPEND_DATAContent; } }
        private static Java.Nio.File.Attribute.AclEntryPermission _APPEND_DATAContent = default;
        private static bool _APPEND_DATAReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/file/attribute/AclEntryPermission.html#DELETE"/>
        /// </summary>
        public static Java.Nio.File.Attribute.AclEntryPermission DELETE { get { if (!_DELETEReady) { _DELETEContent = SGetField<Java.Nio.File.Attribute.AclEntryPermission>(LocalBridgeClazz, "DELETE"); _DELETEReady = true; } return _DELETEContent; } }
        private static Java.Nio.File.Attribute.AclEntryPermission _DELETEContent = default;
        private static bool _DELETEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/file/attribute/AclEntryPermission.html#DELETE_CHILD"/>
        /// </summary>
        public static Java.Nio.File.Attribute.AclEntryPermission DELETE_CHILD { get { if (!_DELETE_CHILDReady) { _DELETE_CHILDContent = SGetField<Java.Nio.File.Attribute.AclEntryPermission>(LocalBridgeClazz, "DELETE_CHILD"); _DELETE_CHILDReady = true; } return _DELETE_CHILDContent; } }
        private static Java.Nio.File.Attribute.AclEntryPermission _DELETE_CHILDContent = default;
        private static bool _DELETE_CHILDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/file/attribute/AclEntryPermission.html#EXECUTE"/>
        /// </summary>
        public static Java.Nio.File.Attribute.AclEntryPermission EXECUTE { get { if (!_EXECUTEReady) { _EXECUTEContent = SGetField<Java.Nio.File.Attribute.AclEntryPermission>(LocalBridgeClazz, "EXECUTE"); _EXECUTEReady = true; } return _EXECUTEContent; } }
        private static Java.Nio.File.Attribute.AclEntryPermission _EXECUTEContent = default;
        private static bool _EXECUTEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/file/attribute/AclEntryPermission.html#LIST_DIRECTORY"/>
        /// </summary>
        public static Java.Nio.File.Attribute.AclEntryPermission LIST_DIRECTORY { get { if (!_LIST_DIRECTORYReady) { _LIST_DIRECTORYContent = SGetField<Java.Nio.File.Attribute.AclEntryPermission>(LocalBridgeClazz, "LIST_DIRECTORY"); _LIST_DIRECTORYReady = true; } return _LIST_DIRECTORYContent; } }
        private static Java.Nio.File.Attribute.AclEntryPermission _LIST_DIRECTORYContent = default;
        private static bool _LIST_DIRECTORYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/file/attribute/AclEntryPermission.html#READ_ACL"/>
        /// </summary>
        public static Java.Nio.File.Attribute.AclEntryPermission READ_ACL { get { if (!_READ_ACLReady) { _READ_ACLContent = SGetField<Java.Nio.File.Attribute.AclEntryPermission>(LocalBridgeClazz, "READ_ACL"); _READ_ACLReady = true; } return _READ_ACLContent; } }
        private static Java.Nio.File.Attribute.AclEntryPermission _READ_ACLContent = default;
        private static bool _READ_ACLReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/file/attribute/AclEntryPermission.html#READ_ATTRIBUTES"/>
        /// </summary>
        public static Java.Nio.File.Attribute.AclEntryPermission READ_ATTRIBUTES { get { if (!_READ_ATTRIBUTESReady) { _READ_ATTRIBUTESContent = SGetField<Java.Nio.File.Attribute.AclEntryPermission>(LocalBridgeClazz, "READ_ATTRIBUTES"); _READ_ATTRIBUTESReady = true; } return _READ_ATTRIBUTESContent; } }
        private static Java.Nio.File.Attribute.AclEntryPermission _READ_ATTRIBUTESContent = default;
        private static bool _READ_ATTRIBUTESReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/file/attribute/AclEntryPermission.html#READ_DATA"/>
        /// </summary>
        public static Java.Nio.File.Attribute.AclEntryPermission READ_DATA { get { if (!_READ_DATAReady) { _READ_DATAContent = SGetField<Java.Nio.File.Attribute.AclEntryPermission>(LocalBridgeClazz, "READ_DATA"); _READ_DATAReady = true; } return _READ_DATAContent; } }
        private static Java.Nio.File.Attribute.AclEntryPermission _READ_DATAContent = default;
        private static bool _READ_DATAReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/file/attribute/AclEntryPermission.html#READ_NAMED_ATTRS"/>
        /// </summary>
        public static Java.Nio.File.Attribute.AclEntryPermission READ_NAMED_ATTRS { get { if (!_READ_NAMED_ATTRSReady) { _READ_NAMED_ATTRSContent = SGetField<Java.Nio.File.Attribute.AclEntryPermission>(LocalBridgeClazz, "READ_NAMED_ATTRS"); _READ_NAMED_ATTRSReady = true; } return _READ_NAMED_ATTRSContent; } }
        private static Java.Nio.File.Attribute.AclEntryPermission _READ_NAMED_ATTRSContent = default;
        private static bool _READ_NAMED_ATTRSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/file/attribute/AclEntryPermission.html#SYNCHRONIZE"/>
        /// </summary>
        public static Java.Nio.File.Attribute.AclEntryPermission SYNCHRONIZE { get { if (!_SYNCHRONIZEReady) { _SYNCHRONIZEContent = SGetField<Java.Nio.File.Attribute.AclEntryPermission>(LocalBridgeClazz, "SYNCHRONIZE"); _SYNCHRONIZEReady = true; } return _SYNCHRONIZEContent; } }
        private static Java.Nio.File.Attribute.AclEntryPermission _SYNCHRONIZEContent = default;
        private static bool _SYNCHRONIZEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/file/attribute/AclEntryPermission.html#WRITE_ACL"/>
        /// </summary>
        public static Java.Nio.File.Attribute.AclEntryPermission WRITE_ACL { get { if (!_WRITE_ACLReady) { _WRITE_ACLContent = SGetField<Java.Nio.File.Attribute.AclEntryPermission>(LocalBridgeClazz, "WRITE_ACL"); _WRITE_ACLReady = true; } return _WRITE_ACLContent; } }
        private static Java.Nio.File.Attribute.AclEntryPermission _WRITE_ACLContent = default;
        private static bool _WRITE_ACLReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/file/attribute/AclEntryPermission.html#WRITE_ATTRIBUTES"/>
        /// </summary>
        public static Java.Nio.File.Attribute.AclEntryPermission WRITE_ATTRIBUTES { get { if (!_WRITE_ATTRIBUTESReady) { _WRITE_ATTRIBUTESContent = SGetField<Java.Nio.File.Attribute.AclEntryPermission>(LocalBridgeClazz, "WRITE_ATTRIBUTES"); _WRITE_ATTRIBUTESReady = true; } return _WRITE_ATTRIBUTESContent; } }
        private static Java.Nio.File.Attribute.AclEntryPermission _WRITE_ATTRIBUTESContent = default;
        private static bool _WRITE_ATTRIBUTESReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/file/attribute/AclEntryPermission.html#WRITE_DATA"/>
        /// </summary>
        public static Java.Nio.File.Attribute.AclEntryPermission WRITE_DATA { get { if (!_WRITE_DATAReady) { _WRITE_DATAContent = SGetField<Java.Nio.File.Attribute.AclEntryPermission>(LocalBridgeClazz, "WRITE_DATA"); _WRITE_DATAReady = true; } return _WRITE_DATAContent; } }
        private static Java.Nio.File.Attribute.AclEntryPermission _WRITE_DATAContent = default;
        private static bool _WRITE_DATAReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/file/attribute/AclEntryPermission.html#WRITE_NAMED_ATTRS"/>
        /// </summary>
        public static Java.Nio.File.Attribute.AclEntryPermission WRITE_NAMED_ATTRS { get { if (!_WRITE_NAMED_ATTRSReady) { _WRITE_NAMED_ATTRSContent = SGetField<Java.Nio.File.Attribute.AclEntryPermission>(LocalBridgeClazz, "WRITE_NAMED_ATTRS"); _WRITE_NAMED_ATTRSReady = true; } return _WRITE_NAMED_ATTRSContent; } }
        private static Java.Nio.File.Attribute.AclEntryPermission _WRITE_NAMED_ATTRSContent = default;
        private static bool _WRITE_NAMED_ATTRSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/file/attribute/AclEntryPermission.html#WRITE_OWNER"/>
        /// </summary>
        public static Java.Nio.File.Attribute.AclEntryPermission WRITE_OWNER { get { if (!_WRITE_OWNERReady) { _WRITE_OWNERContent = SGetField<Java.Nio.File.Attribute.AclEntryPermission>(LocalBridgeClazz, "WRITE_OWNER"); _WRITE_OWNERReady = true; } return _WRITE_OWNERContent; } }
        private static Java.Nio.File.Attribute.AclEntryPermission _WRITE_OWNERContent = default;
        private static bool _WRITE_OWNERReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/file/attribute/AclEntryPermission.html#valueOf(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Nio.File.Attribute.AclEntryPermission"/></returns>
        public static Java.Nio.File.Attribute.AclEntryPermission ValueOf(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Java.Nio.File.Attribute.AclEntryPermission>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Ljava/nio/file/attribute/AclEntryPermission;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/file/attribute/AclEntryPermission.html#values()"/>
        /// </summary>
        /// <returns><see cref="Java.Nio.File.Attribute.AclEntryPermission"/></returns>
        public static Java.Nio.File.Attribute.AclEntryPermission[] Values()
        {
            return SExecuteWithSignatureArray<Java.Nio.File.Attribute.AclEntryPermission>(LocalBridgeClazz, "values", "()[Ljava/nio/file/attribute/AclEntryPermission;");
        }

        #endregion

        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}