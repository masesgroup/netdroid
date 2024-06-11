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
*  This file is generated by MASES.JNetReflector (ver. 2.5.2.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Net.Ssl
{
    #region HttpsURLConnection
    public partial class HttpsURLConnection
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/HttpsURLConnection.html#getDefaultHostnameVerifier()"/>
        /// </summary>
        /// <returns><see cref="Javax.Net.Ssl.HostnameVerifier"/></returns>
        public static Javax.Net.Ssl.HostnameVerifier GetDefaultHostnameVerifier()
        {
            return SExecuteWithSignature<Javax.Net.Ssl.HostnameVerifier>(LocalBridgeClazz, "getDefaultHostnameVerifier", "()Ljavax/net/ssl/HostnameVerifier;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/HttpsURLConnection.html#getDefaultSSLSocketFactory()"/>
        /// </summary>
        /// <returns><see cref="Javax.Net.Ssl.SSLSocketFactory"/></returns>
        public static Javax.Net.Ssl.SSLSocketFactory GetDefaultSSLSocketFactory()
        {
            return SExecuteWithSignature<Javax.Net.Ssl.SSLSocketFactory>(LocalBridgeClazz, "getDefaultSSLSocketFactory", "()Ljavax/net/ssl/SSLSocketFactory;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/HttpsURLConnection.html#setDefaultHostnameVerifier(javax.net.ssl.HostnameVerifier)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Net.Ssl.HostnameVerifier"/></param>
        public static void SetDefaultHostnameVerifier(Javax.Net.Ssl.HostnameVerifier arg0)
        {
            SExecuteWithSignature(LocalBridgeClazz, "setDefaultHostnameVerifier", "(Ljavax/net/ssl/HostnameVerifier;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/HttpsURLConnection.html#setDefaultSSLSocketFactory(javax.net.ssl.SSLSocketFactory)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Net.Ssl.SSLSocketFactory"/></param>
        public static void SetDefaultSSLSocketFactory(Javax.Net.Ssl.SSLSocketFactory arg0)
        {
            SExecuteWithSignature(LocalBridgeClazz, "setDefaultSSLSocketFactory", "(Ljavax/net/ssl/SSLSocketFactory;)V", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/HttpsURLConnection.html#getCipherSuite()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetCipherSuite()
        {
            return IExecuteWithSignature<Java.Lang.String>("getCipherSuite", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/HttpsURLConnection.html#getLocalCertificates()"/>
        /// </summary>
        /// <returns><see cref="Java.Security.Cert.Certificate"/></returns>
        public Java.Security.Cert.Certificate[] GetLocalCertificates()
        {
            return IExecuteWithSignatureArray<Java.Security.Cert.Certificate>("getLocalCertificates", "()[Ljava/security/cert/Certificate;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/HttpsURLConnection.html#getServerCertificates()"/>
        /// </summary>
        /// <returns><see cref="Java.Security.Cert.Certificate"/></returns>
        /// <exception cref="Javax.Net.Ssl.SSLPeerUnverifiedException"/>
        public Java.Security.Cert.Certificate[] GetServerCertificates()
        {
            return IExecuteWithSignatureArray<Java.Security.Cert.Certificate>("getServerCertificates", "()[Ljava/security/cert/Certificate;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/HttpsURLConnection.html#getLocalPrincipal()"/>
        /// </summary>
        /// <returns><see cref="Java.Security.Principal"/></returns>
        public Java.Security.Principal GetLocalPrincipal()
        {
            return IExecuteWithSignature<Java.Security.Principal>("getLocalPrincipal", "()Ljava/security/Principal;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/HttpsURLConnection.html#getPeerPrincipal()"/>
        /// </summary>
        /// <returns><see cref="Java.Security.Principal"/></returns>
        /// <exception cref="Javax.Net.Ssl.SSLPeerUnverifiedException"/>
        public Java.Security.Principal GetPeerPrincipal()
        {
            return IExecuteWithSignature<Java.Security.Principal>("getPeerPrincipal", "()Ljava/security/Principal;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/HttpsURLConnection.html#getSSLSession()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Optional"/></returns>
        public Java.Util.Optional<Javax.Net.Ssl.SSLSession> GetSSLSession()
        {
            return IExecuteWithSignature<Java.Util.Optional<Javax.Net.Ssl.SSLSession>>("getSSLSession", "()Ljava/util/Optional;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/HttpsURLConnection.html#getHostnameVerifier()"/>
        /// </summary>
        /// <returns><see cref="Javax.Net.Ssl.HostnameVerifier"/></returns>
        public Javax.Net.Ssl.HostnameVerifier GetHostnameVerifier()
        {
            return IExecuteWithSignature<Javax.Net.Ssl.HostnameVerifier>("getHostnameVerifier", "()Ljavax/net/ssl/HostnameVerifier;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/HttpsURLConnection.html#getSSLSocketFactory()"/>
        /// </summary>
        /// <returns><see cref="Javax.Net.Ssl.SSLSocketFactory"/></returns>
        public Javax.Net.Ssl.SSLSocketFactory GetSSLSocketFactory()
        {
            return IExecuteWithSignature<Javax.Net.Ssl.SSLSocketFactory>("getSSLSocketFactory", "()Ljavax/net/ssl/SSLSocketFactory;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/HttpsURLConnection.html#setHostnameVerifier(javax.net.ssl.HostnameVerifier)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Net.Ssl.HostnameVerifier"/></param>
        public void SetHostnameVerifier(Javax.Net.Ssl.HostnameVerifier arg0)
        {
            IExecuteWithSignature("setHostnameVerifier", "(Ljavax/net/ssl/HostnameVerifier;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/HttpsURLConnection.html#setSSLSocketFactory(javax.net.ssl.SSLSocketFactory)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Net.Ssl.SSLSocketFactory"/></param>
        public void SetSSLSocketFactory(Javax.Net.Ssl.SSLSocketFactory arg0)
        {
            IExecuteWithSignature("setSSLSocketFactory", "(Ljavax/net/ssl/SSLSocketFactory;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}