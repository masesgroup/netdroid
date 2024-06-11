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

namespace Java.Security
{
    #region ICertificate
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface ICertificate
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region Certificate
    public partial class Certificate : Java.Security.ICertificate
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
        /// <see href="https://developer.android.com/reference/java/security/Certificate.html#getFormat()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetFormat()
        {
            return IExecuteWithSignature<Java.Lang.String>("getFormat", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/Certificate.html#toString(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String ToString(bool arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("toString", "(Z)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/Certificate.html#getGuarantor()"/>
        /// </summary>
        /// <returns><see cref="Java.Security.Principal"/></returns>
        public Java.Security.Principal GetGuarantor()
        {
            return IExecuteWithSignature<Java.Security.Principal>("getGuarantor", "()Ljava/security/Principal;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/Certificate.html#getPrincipal()"/>
        /// </summary>
        /// <returns><see cref="Java.Security.Principal"/></returns>
        public Java.Security.Principal GetPrincipal()
        {
            return IExecuteWithSignature<Java.Security.Principal>("getPrincipal", "()Ljava/security/Principal;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/Certificate.html#getPublicKey()"/>
        /// </summary>
        /// <returns><see cref="Java.Security.PublicKey"/></returns>
        public Java.Security.PublicKey GetPublicKey()
        {
            return IExecuteWithSignature<Java.Security.PublicKey>("getPublicKey", "()Ljava/security/PublicKey;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/Certificate.html#decode(java.io.InputStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.InputStream"/></param>
        /// <exception cref="Java.Security.KeyException"/>
        /// <exception cref="Java.Io.IOException"/>
        public void Decode(Java.Io.InputStream arg0)
        {
            IExecuteWithSignature("decode", "(Ljava/io/InputStream;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/Certificate.html#encode(java.io.OutputStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.OutputStream"/></param>
        /// <exception cref="Java.Security.KeyException"/>
        /// <exception cref="Java.Io.IOException"/>
        public void Encode(Java.Io.OutputStream arg0)
        {
            IExecuteWithSignature("encode", "(Ljava/io/OutputStream;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}