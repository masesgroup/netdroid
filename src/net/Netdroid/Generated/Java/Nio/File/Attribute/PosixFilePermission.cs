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
*  This file is generated by MASES.JNetReflector (ver. 2.5.1.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Nio.File.Attribute
{
    #region PosixFilePermission
    public partial class PosixFilePermission
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/nio/file/attribute/PosixFilePermission.html#GROUP_EXECUTE"/>
        /// </summary>
        public static Java.Nio.File.Attribute.PosixFilePermission GROUP_EXECUTE { get { if (!_GROUP_EXECUTEReady) { _GROUP_EXECUTEContent = SGetField<Java.Nio.File.Attribute.PosixFilePermission>(LocalBridgeClazz, "GROUP_EXECUTE"); _GROUP_EXECUTEReady = true; } return _GROUP_EXECUTEContent; } }
        private static Java.Nio.File.Attribute.PosixFilePermission _GROUP_EXECUTEContent = default;
        private static bool _GROUP_EXECUTEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/nio/file/attribute/PosixFilePermission.html#GROUP_READ"/>
        /// </summary>
        public static Java.Nio.File.Attribute.PosixFilePermission GROUP_READ { get { if (!_GROUP_READReady) { _GROUP_READContent = SGetField<Java.Nio.File.Attribute.PosixFilePermission>(LocalBridgeClazz, "GROUP_READ"); _GROUP_READReady = true; } return _GROUP_READContent; } }
        private static Java.Nio.File.Attribute.PosixFilePermission _GROUP_READContent = default;
        private static bool _GROUP_READReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/nio/file/attribute/PosixFilePermission.html#GROUP_WRITE"/>
        /// </summary>
        public static Java.Nio.File.Attribute.PosixFilePermission GROUP_WRITE { get { if (!_GROUP_WRITEReady) { _GROUP_WRITEContent = SGetField<Java.Nio.File.Attribute.PosixFilePermission>(LocalBridgeClazz, "GROUP_WRITE"); _GROUP_WRITEReady = true; } return _GROUP_WRITEContent; } }
        private static Java.Nio.File.Attribute.PosixFilePermission _GROUP_WRITEContent = default;
        private static bool _GROUP_WRITEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/nio/file/attribute/PosixFilePermission.html#OTHERS_EXECUTE"/>
        /// </summary>
        public static Java.Nio.File.Attribute.PosixFilePermission OTHERS_EXECUTE { get { if (!_OTHERS_EXECUTEReady) { _OTHERS_EXECUTEContent = SGetField<Java.Nio.File.Attribute.PosixFilePermission>(LocalBridgeClazz, "OTHERS_EXECUTE"); _OTHERS_EXECUTEReady = true; } return _OTHERS_EXECUTEContent; } }
        private static Java.Nio.File.Attribute.PosixFilePermission _OTHERS_EXECUTEContent = default;
        private static bool _OTHERS_EXECUTEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/nio/file/attribute/PosixFilePermission.html#OTHERS_READ"/>
        /// </summary>
        public static Java.Nio.File.Attribute.PosixFilePermission OTHERS_READ { get { if (!_OTHERS_READReady) { _OTHERS_READContent = SGetField<Java.Nio.File.Attribute.PosixFilePermission>(LocalBridgeClazz, "OTHERS_READ"); _OTHERS_READReady = true; } return _OTHERS_READContent; } }
        private static Java.Nio.File.Attribute.PosixFilePermission _OTHERS_READContent = default;
        private static bool _OTHERS_READReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/nio/file/attribute/PosixFilePermission.html#OTHERS_WRITE"/>
        /// </summary>
        public static Java.Nio.File.Attribute.PosixFilePermission OTHERS_WRITE { get { if (!_OTHERS_WRITEReady) { _OTHERS_WRITEContent = SGetField<Java.Nio.File.Attribute.PosixFilePermission>(LocalBridgeClazz, "OTHERS_WRITE"); _OTHERS_WRITEReady = true; } return _OTHERS_WRITEContent; } }
        private static Java.Nio.File.Attribute.PosixFilePermission _OTHERS_WRITEContent = default;
        private static bool _OTHERS_WRITEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/nio/file/attribute/PosixFilePermission.html#OWNER_EXECUTE"/>
        /// </summary>
        public static Java.Nio.File.Attribute.PosixFilePermission OWNER_EXECUTE { get { if (!_OWNER_EXECUTEReady) { _OWNER_EXECUTEContent = SGetField<Java.Nio.File.Attribute.PosixFilePermission>(LocalBridgeClazz, "OWNER_EXECUTE"); _OWNER_EXECUTEReady = true; } return _OWNER_EXECUTEContent; } }
        private static Java.Nio.File.Attribute.PosixFilePermission _OWNER_EXECUTEContent = default;
        private static bool _OWNER_EXECUTEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/nio/file/attribute/PosixFilePermission.html#OWNER_READ"/>
        /// </summary>
        public static Java.Nio.File.Attribute.PosixFilePermission OWNER_READ { get { if (!_OWNER_READReady) { _OWNER_READContent = SGetField<Java.Nio.File.Attribute.PosixFilePermission>(LocalBridgeClazz, "OWNER_READ"); _OWNER_READReady = true; } return _OWNER_READContent; } }
        private static Java.Nio.File.Attribute.PosixFilePermission _OWNER_READContent = default;
        private static bool _OWNER_READReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/nio/file/attribute/PosixFilePermission.html#OWNER_WRITE"/>
        /// </summary>
        public static Java.Nio.File.Attribute.PosixFilePermission OWNER_WRITE { get { if (!_OWNER_WRITEReady) { _OWNER_WRITEContent = SGetField<Java.Nio.File.Attribute.PosixFilePermission>(LocalBridgeClazz, "OWNER_WRITE"); _OWNER_WRITEReady = true; } return _OWNER_WRITEContent; } }
        private static Java.Nio.File.Attribute.PosixFilePermission _OWNER_WRITEContent = default;
        private static bool _OWNER_WRITEReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/nio/file/attribute/PosixFilePermission.html#valueOf(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Nio.File.Attribute.PosixFilePermission"/></returns>
        public static Java.Nio.File.Attribute.PosixFilePermission ValueOf(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Java.Nio.File.Attribute.PosixFilePermission>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Ljava/nio/file/attribute/PosixFilePermission;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/nio/file/attribute/PosixFilePermission.html#values()"/>
        /// </summary>
        /// <returns><see cref="Java.Nio.File.Attribute.PosixFilePermission"/></returns>
        public static Java.Nio.File.Attribute.PosixFilePermission[] Values()
        {
            return SExecuteWithSignatureArray<Java.Nio.File.Attribute.PosixFilePermission>(LocalBridgeClazz, "values", "()[Ljava/nio/file/attribute/PosixFilePermission;");
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