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

namespace Android.Webkit
{
    #region ClientCertRequest
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
            IExecute("proceed", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}