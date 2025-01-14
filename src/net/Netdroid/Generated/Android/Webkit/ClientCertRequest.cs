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
*  This file is generated by MASES.JNetReflector (ver. 2.5.10.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Webkit
{
    #region ClientCertRequest declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/webkit/ClientCertRequest.html"/>
    /// </summary>
    public partial class ClientCertRequest : MASES.JCOBridge.C2JBridge.JVMBridgeBase<ClientCertRequest>
    {
        const string _bridgeClassName = "android.webkit.ClientCertRequest";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("ClientCertRequest class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public ClientCertRequest() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("ClientCertRequest class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public ClientCertRequest(params object[] args) : base(args) { }
    
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
    
    }
    #endregion

    #region ClientCertRequest implementation
    public partial class ClientCertRequest
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
        /// <see href="https://developer.android.com/reference/android/webkit/ClientCertRequest.html#getPort()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetPort()
        {
            return IExecuteWithSignature<int>("getPort", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/ClientCertRequest.html#getHost()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetHost()
        {
            return IExecuteWithSignature<Java.Lang.String>("getHost", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/ClientCertRequest.html#getKeyTypes()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String[] GetKeyTypes()
        {
            return IExecuteWithSignatureArray<Java.Lang.String>("getKeyTypes", "()[Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/ClientCertRequest.html#getPrincipals()"/>
        /// </summary>
        /// <returns><see cref="Java.Security.Principal"/></returns>
        public Java.Security.Principal[] GetPrincipals()
        {
            return IExecuteWithSignatureArray<Java.Security.Principal>("getPrincipals", "()[Ljava/security/Principal;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/ClientCertRequest.html#cancel()"/>
        /// </summary>
        public void Cancel()
        {
            IExecuteWithSignature("cancel", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/ClientCertRequest.html#ignore()"/>
        /// </summary>
        public void Ignore()
        {
            IExecuteWithSignature("ignore", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/ClientCertRequest.html#proceed(java.security.PrivateKey,java.security.cert.X509Certificate[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.PrivateKey"/></param>
        /// <param name="arg1"><see cref="Java.Security.Cert.X509Certificate"/></param>
        public void Proceed(Java.Security.PrivateKey arg0, Java.Security.Cert.X509Certificate[] arg1)
        {
            IExecuteWithSignature("proceed", "(Ljava/security/PrivateKey;[Ljava/security/cert/X509Certificate;)V", arg0, arg1);
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}