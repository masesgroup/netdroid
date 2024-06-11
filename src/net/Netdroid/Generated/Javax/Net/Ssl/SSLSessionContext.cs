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
    #region ISSLSessionContext
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface ISSLSessionContext
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region SSLSessionContext
    public partial class SSLSessionContext : Javax.Net.Ssl.ISSLSessionContext
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
        /// <see href="https://developer.android.com/reference/javax/net/ssl/SSLSessionContext.html#getSessionCacheSize()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetSessionCacheSize()
        {
            return IExecuteWithSignature<int>("getSessionCacheSize", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/SSLSessionContext.html#getSessionTimeout()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetSessionTimeout()
        {
            return IExecuteWithSignature<int>("getSessionTimeout", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/SSLSessionContext.html#getIds()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Enumeration"/></returns>
        public Java.Util.Enumeration<byte[]> GetIds()
        {
            return IExecuteWithSignature<Java.Util.Enumeration<byte[]>>("getIds", "()Ljava/util/Enumeration;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/SSLSessionContext.html#getSession(byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <returns><see cref="Javax.Net.Ssl.SSLSession"/></returns>
        public Javax.Net.Ssl.SSLSession GetSession(byte[] arg0)
        {
            return IExecuteWithSignature<Javax.Net.Ssl.SSLSession>("getSession", "([B)Ljavax/net/ssl/SSLSession;", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/SSLSessionContext.html#setSessionCacheSize(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        public void SetSessionCacheSize(int arg0)
        {
            IExecuteWithSignature("setSessionCacheSize", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/SSLSessionContext.html#setSessionTimeout(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        public void SetSessionTimeout(int arg0)
        {
            IExecuteWithSignature("setSessionTimeout", "(I)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}