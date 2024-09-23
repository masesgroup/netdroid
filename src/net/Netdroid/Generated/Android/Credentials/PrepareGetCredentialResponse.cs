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

namespace Android.Credentials
{
    #region PrepareGetCredentialResponse declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/credentials/PrepareGetCredentialResponse.html"/>
    /// </summary>
    public partial class PrepareGetCredentialResponse : MASES.JCOBridge.C2JBridge.JVMBridgeBase<PrepareGetCredentialResponse>
    {
        const string _bridgeClassName = "android.credentials.PrepareGetCredentialResponse";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public PrepareGetCredentialResponse() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public PrepareGetCredentialResponse(params object[] args) : base(args) { }
    
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
        #region PendingGetCredentialHandle declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/credentials/PrepareGetCredentialResponse.PendingGetCredentialHandle.html"/>
        /// </summary>
        public partial class PendingGetCredentialHandle : MASES.JCOBridge.C2JBridge.JVMBridgeBase<PendingGetCredentialHandle>
        {
            const string _bridgeClassName = "android.credentials.PrepareGetCredentialResponse$PendingGetCredentialHandle";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public PendingGetCredentialHandle() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public PendingGetCredentialHandle(params object[] args) : base(args) { }
        
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
            public override bool IsBridgeStatic => true;
        
            // TODO: complete the class
        
        }
        #endregion

    
    }
    #endregion

    #region PrepareGetCredentialResponse implementation
    public partial class PrepareGetCredentialResponse
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
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/credentials/PrepareGetCredentialResponse.html#getPendingGetCredentialHandle()"/>
        /// </summary>
        /// <returns><see cref="Android.Credentials.PrepareGetCredentialResponse.PendingGetCredentialHandle"/></returns>
        public Android.Credentials.PrepareGetCredentialResponse.PendingGetCredentialHandle GetPendingGetCredentialHandle()
        {
            return IExecuteWithSignature<Android.Credentials.PrepareGetCredentialResponse.PendingGetCredentialHandle>("getPendingGetCredentialHandle", "()Landroid/credentials/PrepareGetCredentialResponse$PendingGetCredentialHandle;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/credentials/PrepareGetCredentialResponse.html#hasAuthenticationResults()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasAuthenticationResults()
        {
            return IExecuteWithSignature<bool>("hasAuthenticationResults", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/credentials/PrepareGetCredentialResponse.html#hasCredentialResults(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool HasCredentialResults(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<bool>("hasCredentialResults", "(Ljava/lang/String;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/credentials/PrepareGetCredentialResponse.html#hasRemoteResults()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasRemoteResults()
        {
            return IExecuteWithSignature<bool>("hasRemoteResults", "()Z");
        }
    
        #endregion
    
        #region Nested classes
        #region PendingGetCredentialHandle implementation
        public partial class PendingGetCredentialHandle
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