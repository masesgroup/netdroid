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

namespace Java.Security
{
    #region Policy declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/java/security/Policy.html"/>
    /// </summary>
    [global::System.Obsolete()]
    public partial class Policy : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Policy>
    {
        const string _bridgeClassName = "java.security.Policy";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("Policy class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public Policy() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("Policy class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public Policy(params object[] args) : base(args) { }
    
        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
    
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
        /// </summary>
        public override bool IsBridgeAbstract => true;
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
        #region Parameters declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/Policy.Parameters.html"/>
        /// </summary>
        [global::System.Obsolete()]
        public partial class Parameters : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Parameters>
        {
            const string _bridgeClassName = "java.security.Policy$Parameters";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            [global::System.Obsolete("Parameters class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
            public Parameters() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            [global::System.Obsolete("Parameters class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
            public Parameters(params object[] args) : base(args) { }
        
            private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
            private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
        
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
            /// </summary>
            public override string BridgeClassName => _bridgeClassName;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
            /// </summary>
            public override bool IsBridgeAbstract => true;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
            /// </summary>
            public override bool IsBridgeCloseable => false;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
            /// </summary>
            public override bool IsBridgeInterface => true;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
            /// </summary>
            public override bool IsBridgeStatic => true;
        
            // TODO: complete the class
        
        }
        #endregion

    
    }
    #endregion

    #region Policy implementation
    public partial class Policy
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/Policy.html#UNSUPPORTED_EMPTY_COLLECTION"/>
        /// </summary>
        public static Java.Security.PermissionCollection UNSUPPORTED_EMPTY_COLLECTION { get { if (!_UNSUPPORTED_EMPTY_COLLECTIONReady) { _UNSUPPORTED_EMPTY_COLLECTIONContent = SGetField<Java.Security.PermissionCollection>(LocalBridgeClazz, "UNSUPPORTED_EMPTY_COLLECTION"); _UNSUPPORTED_EMPTY_COLLECTIONReady = true; } return _UNSUPPORTED_EMPTY_COLLECTIONContent; } }
        private static Java.Security.PermissionCollection _UNSUPPORTED_EMPTY_COLLECTIONContent = default;
        private static bool _UNSUPPORTED_EMPTY_COLLECTIONReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/Policy.html#getInstance(java.lang.String,java.security.Policy.Parameters,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Security.Policy.Parameters"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Security.Policy"/></returns>
        /// <exception cref="Java.Security.NoSuchProviderException"/>
        /// <exception cref="Java.Security.NoSuchAlgorithmException"/>
        public static Java.Security.Policy GetInstance(Java.Lang.String arg0, Java.Security.Policy.Parameters arg1, Java.Lang.String arg2)
        {
            return SExecute<Java.Security.Policy>(LocalBridgeClazz, "getInstance", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/Policy.html#getInstance(java.lang.String,java.security.Policy.Parameters,java.security.Provider)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Security.Policy.Parameters"/></param>
        /// <param name="arg2"><see cref="Java.Security.Provider"/></param>
        /// <returns><see cref="Java.Security.Policy"/></returns>
        /// <exception cref="Java.Security.NoSuchAlgorithmException"/>
        public static Java.Security.Policy GetInstance(Java.Lang.String arg0, Java.Security.Policy.Parameters arg1, Java.Security.Provider arg2)
        {
            return SExecute<Java.Security.Policy>(LocalBridgeClazz, "getInstance", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/Policy.html#getInstance(java.lang.String,java.security.Policy.Parameters)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Security.Policy.Parameters"/></param>
        /// <returns><see cref="Java.Security.Policy"/></returns>
        /// <exception cref="Java.Security.NoSuchAlgorithmException"/>
        public static Java.Security.Policy GetInstance(Java.Lang.String arg0, Java.Security.Policy.Parameters arg1)
        {
            return SExecute<Java.Security.Policy>(LocalBridgeClazz, "getInstance", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/Policy.html#getPolicy()"/>
        /// </summary>
        /// <returns><see cref="Java.Security.Policy"/></returns>
        public static Java.Security.Policy GetPolicy()
        {
            return SExecuteWithSignature<Java.Security.Policy>(LocalBridgeClazz, "getPolicy", "()Ljava/security/Policy;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/Policy.html#setPolicy(java.security.Policy)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.Policy"/></param>
        public static void SetPolicy(Java.Security.Policy arg0)
        {
            SExecuteWithSignature(LocalBridgeClazz, "setPolicy", "(Ljava/security/Policy;)V", arg0);
        }
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/Policy.html#implies(java.security.ProtectionDomain,java.security.Permission)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.ProtectionDomain"/></param>
        /// <param name="arg1"><see cref="Java.Security.Permission"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Implies(Java.Security.ProtectionDomain arg0, Java.Security.Permission arg1)
        {
            return IExecute<bool>("implies", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/Policy.html#getType()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetType()
        {
            return IExecuteWithSignature<Java.Lang.String>("getType", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/Policy.html#getPermissions(java.security.CodeSource)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.CodeSource"/></param>
        /// <returns><see cref="Java.Security.PermissionCollection"/></returns>
        public Java.Security.PermissionCollection GetPermissions(Java.Security.CodeSource arg0)
        {
            return IExecuteWithSignature<Java.Security.PermissionCollection>("getPermissions", "(Ljava/security/CodeSource;)Ljava/security/PermissionCollection;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/Policy.html#getPermissions(java.security.ProtectionDomain)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.ProtectionDomain"/></param>
        /// <returns><see cref="Java.Security.PermissionCollection"/></returns>
        public Java.Security.PermissionCollection GetPermissions(Java.Security.ProtectionDomain arg0)
        {
            return IExecuteWithSignature<Java.Security.PermissionCollection>("getPermissions", "(Ljava/security/ProtectionDomain;)Ljava/security/PermissionCollection;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/Policy.html#getParameters()"/>
        /// </summary>
        /// <returns><see cref="Java.Security.Policy.Parameters"/></returns>
        public Java.Security.Policy.Parameters GetParameters()
        {
            return IExecuteWithSignature<Java.Security.Policy.Parameters>("getParameters", "()Ljava/security/Policy$Parameters;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/Policy.html#getProvider()"/>
        /// </summary>
        /// <returns><see cref="Java.Security.Provider"/></returns>
        public Java.Security.Provider GetProvider()
        {
            return IExecuteWithSignature<Java.Security.Provider>("getProvider", "()Ljava/security/Provider;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/Policy.html#refresh()"/>
        /// </summary>
        public void Refresh()
        {
            IExecuteWithSignature("refresh", "()V");
        }
    
        #endregion
    
        #region Nested classes
        #region Parameters implementation
        public partial class Parameters
        {
            #region Constructors
        
            #endregion
        
            #region Class/Interface conversion operators
        
            #endregion
        
            #region Fields
        
            #endregion
        
            #region Static methods
        
            #endregion
        
            #region Instance methods
        
            #endregion
        
            #region Nested classes
        
            #endregion
        
            // TODO: complete the class
        }
        #endregion

    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}