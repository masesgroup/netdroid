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

namespace Javax.Net.Ssl
{
    #region SSLSocket declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/javax/net/ssl/SSLSocket.html"/>
    /// </summary>
    public partial class SSLSocket : Java.Net.Socket
    {
        const string _bridgeClassName = "javax.net.ssl.SSLSocket";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("SSLSocket class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public SSLSocket() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("SSLSocket class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public SSLSocket(params object[] args) : base(args) { }
    
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

    #region SSLSocket implementation
    public partial class SSLSocket
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
        /// <see href="https://developer.android.com/reference/javax/net/ssl/SSLSocket.html#getEnableSessionCreation()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool GetEnableSessionCreation()
        {
            return IExecuteWithSignature<bool>("getEnableSessionCreation", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/SSLSocket.html#getNeedClientAuth()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool GetNeedClientAuth()
        {
            return IExecuteWithSignature<bool>("getNeedClientAuth", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/SSLSocket.html#getUseClientMode()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool GetUseClientMode()
        {
            return IExecuteWithSignature<bool>("getUseClientMode", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/SSLSocket.html#getWantClientAuth()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool GetWantClientAuth()
        {
            return IExecuteWithSignature<bool>("getWantClientAuth", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/SSLSocket.html#getEnabledCipherSuites()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String[] GetEnabledCipherSuites()
        {
            return IExecuteWithSignatureArray<Java.Lang.String>("getEnabledCipherSuites", "()[Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/SSLSocket.html#getEnabledProtocols()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String[] GetEnabledProtocols()
        {
            return IExecuteWithSignatureArray<Java.Lang.String>("getEnabledProtocols", "()[Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/SSLSocket.html#getSupportedCipherSuites()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String[] GetSupportedCipherSuites()
        {
            return IExecuteWithSignatureArray<Java.Lang.String>("getSupportedCipherSuites", "()[Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/SSLSocket.html#getSupportedProtocols()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String[] GetSupportedProtocols()
        {
            return IExecuteWithSignatureArray<Java.Lang.String>("getSupportedProtocols", "()[Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/SSLSocket.html#getSession()"/>
        /// </summary>
        /// <returns><see cref="Javax.Net.Ssl.SSLSession"/></returns>
        public Javax.Net.Ssl.SSLSession GetSession()
        {
            return IExecuteWithSignature<Javax.Net.Ssl.SSLSession>("getSession", "()Ljavax/net/ssl/SSLSession;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/SSLSocket.html#addHandshakeCompletedListener(javax.net.ssl.HandshakeCompletedListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Net.Ssl.HandshakeCompletedListener"/></param>
        public void AddHandshakeCompletedListener(Javax.Net.Ssl.HandshakeCompletedListener arg0)
        {
            IExecuteWithSignature("addHandshakeCompletedListener", "(Ljavax/net/ssl/HandshakeCompletedListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/SSLSocket.html#removeHandshakeCompletedListener(javax.net.ssl.HandshakeCompletedListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Net.Ssl.HandshakeCompletedListener"/></param>
        public void RemoveHandshakeCompletedListener(Javax.Net.Ssl.HandshakeCompletedListener arg0)
        {
            IExecuteWithSignature("removeHandshakeCompletedListener", "(Ljavax/net/ssl/HandshakeCompletedListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/SSLSocket.html#setEnabledCipherSuites(java.lang.String[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void SetEnabledCipherSuites(Java.Lang.String[] arg0)
        {
            IExecuteWithSignature("setEnabledCipherSuites", "([Ljava/lang/String;)V", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/SSLSocket.html#setEnabledProtocols(java.lang.String[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void SetEnabledProtocols(Java.Lang.String[] arg0)
        {
            IExecuteWithSignature("setEnabledProtocols", "([Ljava/lang/String;)V", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/SSLSocket.html#setEnableSessionCreation(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetEnableSessionCreation(bool arg0)
        {
            IExecuteWithSignature("setEnableSessionCreation", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/SSLSocket.html#setNeedClientAuth(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetNeedClientAuth(bool arg0)
        {
            IExecuteWithSignature("setNeedClientAuth", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/SSLSocket.html#setUseClientMode(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetUseClientMode(bool arg0)
        {
            IExecuteWithSignature("setUseClientMode", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/SSLSocket.html#setWantClientAuth(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetWantClientAuth(bool arg0)
        {
            IExecuteWithSignature("setWantClientAuth", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/SSLSocket.html#startHandshake()"/>
        /// </summary>
        /// <exception cref="Java.Io.IOException"/>
        public void StartHandshake()
        {
            IExecuteWithSignature("startHandshake", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/SSLSocket.html#getApplicationProtocol()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetApplicationProtocol()
        {
            return IExecuteWithSignature<Java.Lang.String>("getApplicationProtocol", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/SSLSocket.html#getHandshakeApplicationProtocol()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetHandshakeApplicationProtocol()
        {
            return IExecuteWithSignature<Java.Lang.String>("getHandshakeApplicationProtocol", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/SSLSocket.html#getHandshakeApplicationProtocolSelector()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Function.BiFunction"/></returns>
        public Java.Util.Function.BiFunction<Javax.Net.Ssl.SSLSocket, Java.Util.List<Java.Lang.String>, Java.Lang.String> GetHandshakeApplicationProtocolSelector()
        {
            return IExecuteWithSignature<Java.Util.Function.BiFunction<Javax.Net.Ssl.SSLSocket, Java.Util.List<Java.Lang.String>, Java.Lang.String>>("getHandshakeApplicationProtocolSelector", "()Ljava/util/function/BiFunction;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/SSLSocket.html#getHandshakeApplicationProtocolSelector()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Function.BiFunction"/></returns>
        public Java.Util.Function.BiFunction<Javax.Net.Ssl.SSLSocket, Java.Util.List<Java.Lang.String>, Java.Lang.String> GetHandshakeApplicationProtocolSelectorDirect()
        {
            return IExecuteWithSignature<Java.Util.Function.BiFunctionDirect<Javax.Net.Ssl.SSLSocket, Java.Util.List<Java.Lang.String>, Java.Lang.String>, Java.Util.Function.BiFunction<Javax.Net.Ssl.SSLSocket, Java.Util.List<Java.Lang.String>, Java.Lang.String>>("getHandshakeApplicationProtocolSelector", "()Ljava/util/function/BiFunction;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/SSLSocket.html#getSSLParameters()"/>
        /// </summary>
        /// <returns><see cref="Javax.Net.Ssl.SSLParameters"/></returns>
        public Javax.Net.Ssl.SSLParameters GetSSLParameters()
        {
            return IExecuteWithSignature<Javax.Net.Ssl.SSLParameters>("getSSLParameters", "()Ljavax/net/ssl/SSLParameters;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/SSLSocket.html#getHandshakeSession()"/>
        /// </summary>
        /// <returns><see cref="Javax.Net.Ssl.SSLSession"/></returns>
        public Javax.Net.Ssl.SSLSession GetHandshakeSession()
        {
            return IExecuteWithSignature<Javax.Net.Ssl.SSLSession>("getHandshakeSession", "()Ljavax/net/ssl/SSLSession;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/SSLSocket.html#setHandshakeApplicationProtocolSelector(java.util.function.BiFunction)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.BiFunction"/></param>
        public void SetHandshakeApplicationProtocolSelector(Java.Util.Function.BiFunction<Javax.Net.Ssl.SSLSocket, Java.Util.List<Java.Lang.String>, Java.Lang.String> arg0)
        {
            IExecuteWithSignature("setHandshakeApplicationProtocolSelector", "(Ljava/util/function/BiFunction;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/SSLSocket.html#setSSLParameters(javax.net.ssl.SSLParameters)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Net.Ssl.SSLParameters"/></param>
        public void SetSSLParameters(Javax.Net.Ssl.SSLParameters arg0)
        {
            IExecuteWithSignature("setSSLParameters", "(Ljavax/net/ssl/SSLParameters;)V", arg0);
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}