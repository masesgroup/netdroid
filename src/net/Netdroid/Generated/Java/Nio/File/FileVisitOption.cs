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

namespace Java.Nio.File
{
    #region FileVisitOption declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/java/nio/file/FileVisitOption.html"/>
    /// </summary>
    public partial class FileVisitOption : Java.Lang.Enum<Java.Nio.File.FileVisitOption>
    {
        const string _bridgeClassName = "java.nio.file.FileVisitOption";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public FileVisitOption() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public FileVisitOption(params object[] args) : base(args) { }
    
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

    #region FileVisitOption implementation
    public partial class FileVisitOption
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/file/FileVisitOption.html#FOLLOW_LINKS"/>
        /// </summary>
        public static Java.Nio.File.FileVisitOption FOLLOW_LINKS { get { if (!_FOLLOW_LINKSReady) { _FOLLOW_LINKSContent = SGetField<Java.Nio.File.FileVisitOption>(LocalBridgeClazz, "FOLLOW_LINKS"); _FOLLOW_LINKSReady = true; } return _FOLLOW_LINKSContent; } }
        private static Java.Nio.File.FileVisitOption _FOLLOW_LINKSContent = default;
        private static bool _FOLLOW_LINKSReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/file/FileVisitOption.html#valueOf(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Nio.File.FileVisitOption"/></returns>
        public static Java.Nio.File.FileVisitOption ValueOf(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Java.Nio.File.FileVisitOption>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Ljava/nio/file/FileVisitOption;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/file/FileVisitOption.html#values()"/>
        /// </summary>
        /// <returns><see cref="Java.Nio.File.FileVisitOption"/></returns>
        public static Java.Nio.File.FileVisitOption[] Values()
        {
            return SExecuteWithSignatureArray<Java.Nio.File.FileVisitOption>(LocalBridgeClazz, "values", "()[Ljava/nio/file/FileVisitOption;");
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