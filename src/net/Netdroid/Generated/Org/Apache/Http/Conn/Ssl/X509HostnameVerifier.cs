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
*  This file is generated by MASES.JNetReflector (ver. 2.5.1.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Http.Conn.Ssl
{
    #region IX509HostnameVerifier
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IX509HostnameVerifier : Javax.Net.Ssl.IHostnameVerifier
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region X509HostnameVerifier
    public partial class X509HostnameVerifier : Org.Apache.Http.Conn.Ssl.IX509HostnameVerifier
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
        /// <see href="https://developer.android.com/reference/org/apache/http/conn/ssl/X509HostnameVerifier.html#verify(java.lang.String,javax.net.ssl.SSLSession)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Javax.Net.Ssl.SSLSession"/></param>
        /// <returns><see cref="bool"/></returns>
        [System.Obsolete()]
        public bool Verify(Java.Lang.String arg0, Javax.Net.Ssl.SSLSession arg1)
        {
            return IExecute<bool>("verify", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/apache/http/conn/ssl/X509HostnameVerifier.html#verify(java.lang.String,java.lang.String[],java.lang.String[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Javax.Net.Ssl.SSLException"/>
        [System.Obsolete()]
        public void Verify(Java.Lang.String arg0, Java.Lang.String[] arg1, Java.Lang.String[] arg2)
        {
            IExecute("verify", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/apache/http/conn/ssl/X509HostnameVerifier.html#verify(java.lang.String,java.security.cert.X509Certificate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Security.Cert.X509Certificate"/></param>
        /// <exception cref="Javax.Net.Ssl.SSLException"/>
        [System.Obsolete()]
        public void Verify(Java.Lang.String arg0, Java.Security.Cert.X509Certificate arg1)
        {
            IExecute("verify", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/apache/http/conn/ssl/X509HostnameVerifier.html#verify(java.lang.String,javax.net.ssl.SSLSocket)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Javax.Net.Ssl.SSLSocket"/></param>
        /// <exception cref="Java.Io.IOException"/>
        [System.Obsolete()]
        public void Verify(Java.Lang.String arg0, Javax.Net.Ssl.SSLSocket arg1)
        {
            IExecute("verify", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}