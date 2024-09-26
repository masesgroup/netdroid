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

namespace Android.Net.Ssl
{
    #region SSLSockets declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/net/ssl/SSLSockets.html"/>
    /// </summary>
    public partial class SSLSockets : MASES.JCOBridge.C2JBridge.JVMBridgeBase<SSLSockets>
    {
        const string _bridgeClassName = "android.net.ssl.SSLSockets";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public SSLSockets() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public SSLSockets(params object[] args) : base(args) { }

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

    #region SSLSockets implementation
    public partial class SSLSockets
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/ssl/SSLSockets.html#isSupportedSocket(javax.net.ssl.SSLSocket)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Net.Ssl.SSLSocket"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsSupportedSocket(Javax.Net.Ssl.SSLSocket arg0)
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "isSupportedSocket", "(Ljavax/net/ssl/SSLSocket;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/ssl/SSLSockets.html#exportKeyingMaterial(javax.net.ssl.SSLSocket,java.lang.String,byte[],int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Net.Ssl.SSLSocket"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="byte"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <returns><see cref="byte"/></returns>
        /// <exception cref="Javax.Net.Ssl.SSLException"/>
        public static byte[] ExportKeyingMaterial(Javax.Net.Ssl.SSLSocket arg0, Java.Lang.String arg1, byte[] arg2, int arg3)
        {
            return SExecuteWithSignatureArray<byte>(LocalBridgeClazz, "exportKeyingMaterial", "(Ljavax/net/ssl/SSLSocket;Ljava/lang/String;[BI)[B", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/ssl/SSLSockets.html#setUseSessionTickets(javax.net.ssl.SSLSocket,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Net.Ssl.SSLSocket"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        public static void SetUseSessionTickets(Javax.Net.Ssl.SSLSocket arg0, bool arg1)
        {
            SExecuteWithSignature(LocalBridgeClazz, "setUseSessionTickets", "(Ljavax/net/ssl/SSLSocket;Z)V", arg0, arg1);
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