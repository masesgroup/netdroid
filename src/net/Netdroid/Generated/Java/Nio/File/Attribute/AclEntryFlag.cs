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
*  This file is generated by MASES.JNetReflector (ver. 2.5.9.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Nio.File.Attribute
{
    #region AclEntryFlag declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/java/nio/file/attribute/AclEntryFlag.html"/>
    /// </summary>
    public partial class AclEntryFlag : Java.Lang.Enum<Java.Nio.File.Attribute.AclEntryFlag>
    {
        const string _bridgeClassName = "java.nio.file.attribute.AclEntryFlag";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public AclEntryFlag() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public AclEntryFlag(params object[] args) : base(args) { }

        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
        /// </summary>
        public override bool IsBridgeAbstract => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
        /// </summary>
        public override bool IsBridgeCloseable => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
        /// </summary>
        public override bool IsBridgeInterface => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;

        // TODO: complete the class

    }
    #endregion

    #region AclEntryFlag implementation
    public partial class AclEntryFlag
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/file/attribute/AclEntryFlag.html#DIRECTORY_INHERIT"/>
        /// </summary>
        public static Java.Nio.File.Attribute.AclEntryFlag DIRECTORY_INHERIT { get { if (!_DIRECTORY_INHERITReady) { _DIRECTORY_INHERITContent = SGetField<Java.Nio.File.Attribute.AclEntryFlag>(LocalBridgeClazz, "DIRECTORY_INHERIT"); _DIRECTORY_INHERITReady = true; } return _DIRECTORY_INHERITContent; } }
        private static Java.Nio.File.Attribute.AclEntryFlag _DIRECTORY_INHERITContent = default;
        private static bool _DIRECTORY_INHERITReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/file/attribute/AclEntryFlag.html#FILE_INHERIT"/>
        /// </summary>
        public static Java.Nio.File.Attribute.AclEntryFlag FILE_INHERIT { get { if (!_FILE_INHERITReady) { _FILE_INHERITContent = SGetField<Java.Nio.File.Attribute.AclEntryFlag>(LocalBridgeClazz, "FILE_INHERIT"); _FILE_INHERITReady = true; } return _FILE_INHERITContent; } }
        private static Java.Nio.File.Attribute.AclEntryFlag _FILE_INHERITContent = default;
        private static bool _FILE_INHERITReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/file/attribute/AclEntryFlag.html#INHERIT_ONLY"/>
        /// </summary>
        public static Java.Nio.File.Attribute.AclEntryFlag INHERIT_ONLY { get { if (!_INHERIT_ONLYReady) { _INHERIT_ONLYContent = SGetField<Java.Nio.File.Attribute.AclEntryFlag>(LocalBridgeClazz, "INHERIT_ONLY"); _INHERIT_ONLYReady = true; } return _INHERIT_ONLYContent; } }
        private static Java.Nio.File.Attribute.AclEntryFlag _INHERIT_ONLYContent = default;
        private static bool _INHERIT_ONLYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/file/attribute/AclEntryFlag.html#NO_PROPAGATE_INHERIT"/>
        /// </summary>
        public static Java.Nio.File.Attribute.AclEntryFlag NO_PROPAGATE_INHERIT { get { if (!_NO_PROPAGATE_INHERITReady) { _NO_PROPAGATE_INHERITContent = SGetField<Java.Nio.File.Attribute.AclEntryFlag>(LocalBridgeClazz, "NO_PROPAGATE_INHERIT"); _NO_PROPAGATE_INHERITReady = true; } return _NO_PROPAGATE_INHERITContent; } }
        private static Java.Nio.File.Attribute.AclEntryFlag _NO_PROPAGATE_INHERITContent = default;
        private static bool _NO_PROPAGATE_INHERITReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/file/attribute/AclEntryFlag.html#valueOf(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Nio.File.Attribute.AclEntryFlag"/></returns>
        public static Java.Nio.File.Attribute.AclEntryFlag ValueOf(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Java.Nio.File.Attribute.AclEntryFlag>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Ljava/nio/file/attribute/AclEntryFlag;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/file/attribute/AclEntryFlag.html#values()"/>
        /// </summary>
        /// <returns><see cref="Java.Nio.File.Attribute.AclEntryFlag"/></returns>
        public static Java.Nio.File.Attribute.AclEntryFlag[] Values()
        {
            return SExecuteWithSignatureArray<Java.Nio.File.Attribute.AclEntryFlag>(LocalBridgeClazz, "values", "()[Ljava/nio/file/attribute/AclEntryFlag;");
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