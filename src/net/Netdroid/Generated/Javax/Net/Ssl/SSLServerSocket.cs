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
*  This file is generated by MASES.JNetReflector (ver. 2.5.5.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Net.Ssl
{
    #region SSLServerSocket
    public partial class SSLServerSocket
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
        /// <see href="https://developer.android.com/reference/javax/net/ssl/SSLServerSocket.html#getEnableSessionCreation()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool GetEnableSessionCreation()
        {
            return IExecuteWithSignature<bool>("getEnableSessionCreation", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/SSLServerSocket.html#getNeedClientAuth()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool GetNeedClientAuth()
        {
            return IExecuteWithSignature<bool>("getNeedClientAuth", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/SSLServerSocket.html#getUseClientMode()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool GetUseClientMode()
        {
            return IExecuteWithSignature<bool>("getUseClientMode", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/SSLServerSocket.html#getWantClientAuth()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool GetWantClientAuth()
        {
            return IExecuteWithSignature<bool>("getWantClientAuth", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/SSLServerSocket.html#getEnabledCipherSuites()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String[] GetEnabledCipherSuites()
        {
            return IExecuteWithSignatureArray<Java.Lang.String>("getEnabledCipherSuites", "()[Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/SSLServerSocket.html#getEnabledProtocols()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String[] GetEnabledProtocols()
        {
            return IExecuteWithSignatureArray<Java.Lang.String>("getEnabledProtocols", "()[Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/SSLServerSocket.html#getSupportedCipherSuites()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String[] GetSupportedCipherSuites()
        {
            return IExecuteWithSignatureArray<Java.Lang.String>("getSupportedCipherSuites", "()[Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/SSLServerSocket.html#getSupportedProtocols()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String[] GetSupportedProtocols()
        {
            return IExecuteWithSignatureArray<Java.Lang.String>("getSupportedProtocols", "()[Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/SSLServerSocket.html#setEnabledCipherSuites(java.lang.String[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void SetEnabledCipherSuites(Java.Lang.String[] arg0)
        {
            IExecuteWithSignature("setEnabledCipherSuites", "([Ljava/lang/String;)V", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/SSLServerSocket.html#setEnabledProtocols(java.lang.String[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void SetEnabledProtocols(Java.Lang.String[] arg0)
        {
            IExecuteWithSignature("setEnabledProtocols", "([Ljava/lang/String;)V", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/SSLServerSocket.html#setEnableSessionCreation(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetEnableSessionCreation(bool arg0)
        {
            IExecuteWithSignature("setEnableSessionCreation", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/SSLServerSocket.html#setNeedClientAuth(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetNeedClientAuth(bool arg0)
        {
            IExecuteWithSignature("setNeedClientAuth", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/SSLServerSocket.html#setUseClientMode(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetUseClientMode(bool arg0)
        {
            IExecuteWithSignature("setUseClientMode", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/SSLServerSocket.html#setWantClientAuth(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetWantClientAuth(bool arg0)
        {
            IExecuteWithSignature("setWantClientAuth", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/SSLServerSocket.html#getSSLParameters()"/>
        /// </summary>
        /// <returns><see cref="Javax.Net.Ssl.SSLParameters"/></returns>
        public Javax.Net.Ssl.SSLParameters GetSSLParameters()
        {
            return IExecuteWithSignature<Javax.Net.Ssl.SSLParameters>("getSSLParameters", "()Ljavax/net/ssl/SSLParameters;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/SSLServerSocket.html#setSSLParameters(javax.net.ssl.SSLParameters)"/>
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