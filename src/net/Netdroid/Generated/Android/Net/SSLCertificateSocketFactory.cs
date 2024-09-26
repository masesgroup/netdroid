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

namespace Android.Net
{
    #region SSLCertificateSocketFactory declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/net/SSLCertificateSocketFactory.html"/>
    /// </summary>
    [global::System.Obsolete()]
    public partial class SSLCertificateSocketFactory : Javax.Net.Ssl.SSLSocketFactory
    {
        const string _bridgeClassName = "android.net.SSLCertificateSocketFactory";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public SSLCertificateSocketFactory() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public SSLCertificateSocketFactory(params object[] args) : base(args) { }

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

    #region SSLCertificateSocketFactory implementation
    public partial class SSLCertificateSocketFactory
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/SSLCertificateSocketFactory.html#%3Cinit%3E(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        [global::System.Obsolete()]
        public SSLCertificateSocketFactory(int arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/SSLCertificateSocketFactory.html#getDefault(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Javax.Net.SocketFactory"/></returns>
        [global::System.Obsolete()]
        public static Javax.Net.SocketFactory GetDefault(int arg0)
        {
            return SExecuteWithSignature<Javax.Net.SocketFactory>(LocalBridgeClazz, "getDefault", "(I)Ljavax/net/SocketFactory;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/SSLCertificateSocketFactory.html#getDefault(int,android.net.SSLSessionCache)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Android.Net.SSLSessionCache"/></param>
        /// <returns><see cref="Javax.Net.Ssl.SSLSocketFactory"/></returns>
        [global::System.Obsolete()]
        public static Javax.Net.Ssl.SSLSocketFactory GetDefault(int arg0, Android.Net.SSLSessionCache arg1)
        {
            return SExecuteWithSignature<Javax.Net.Ssl.SSLSocketFactory>(LocalBridgeClazz, "getDefault", "(ILandroid/net/SSLSessionCache;)Ljavax/net/ssl/SSLSocketFactory;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/SSLCertificateSocketFactory.html#getInsecure(int,android.net.SSLSessionCache)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Android.Net.SSLSessionCache"/></param>
        /// <returns><see cref="Javax.Net.Ssl.SSLSocketFactory"/></returns>
        [global::System.Obsolete()]
        public static Javax.Net.Ssl.SSLSocketFactory GetInsecure(int arg0, Android.Net.SSLSessionCache arg1)
        {
            return SExecuteWithSignature<Javax.Net.Ssl.SSLSocketFactory>(LocalBridgeClazz, "getInsecure", "(ILandroid/net/SSLSessionCache;)Ljavax/net/ssl/SSLSocketFactory;", arg0, arg1);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/SSLCertificateSocketFactory.html#getNpnSelectedProtocol(java.net.Socket)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.Socket"/></param>
        /// <returns><see cref="byte"/></returns>
        [global::System.Obsolete()]
        public byte[] GetNpnSelectedProtocol(Java.Net.Socket arg0)
        {
            return IExecuteWithSignatureArray<byte>("getNpnSelectedProtocol", "(Ljava/net/Socket;)[B", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/SSLCertificateSocketFactory.html#setHostname(java.net.Socket,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.Socket"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        [global::System.Obsolete()]
        public void SetHostname(Java.Net.Socket arg0, Java.Lang.String arg1)
        {
            IExecuteWithSignature("setHostname", "(Ljava/net/Socket;Ljava/lang/String;)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/SSLCertificateSocketFactory.html#setKeyManagers(javax.net.ssl.KeyManager[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Net.Ssl.KeyManager"/></param>
        [global::System.Obsolete()]
        public void SetKeyManagers(Javax.Net.Ssl.KeyManager[] arg0)
        {
            IExecuteWithSignature("setKeyManagers", "([Ljavax/net/ssl/KeyManager;)V", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/SSLCertificateSocketFactory.html#setNpnProtocols(byte[][])"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        [global::System.Obsolete()]
        public void SetNpnProtocols(byte[][] arg0)
        {
            IExecuteWithSignature("setNpnProtocols", "([[B)V", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/SSLCertificateSocketFactory.html#setTrustManagers(javax.net.ssl.TrustManager[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Net.Ssl.TrustManager"/></param>
        [global::System.Obsolete()]
        public void SetTrustManagers(Javax.Net.Ssl.TrustManager[] arg0)
        {
            IExecuteWithSignature("setTrustManagers", "([Ljavax/net/ssl/TrustManager;)V", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/SSLCertificateSocketFactory.html#setUseSessionTickets(java.net.Socket,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.Socket"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        [global::System.Obsolete()]
        public void SetUseSessionTickets(Java.Net.Socket arg0, bool arg1)
        {
            IExecuteWithSignature("setUseSessionTickets", "(Ljava/net/Socket;Z)V", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}