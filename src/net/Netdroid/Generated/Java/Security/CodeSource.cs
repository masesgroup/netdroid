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

namespace Java.Security
{
    #region CodeSource
    public partial class CodeSource
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/CodeSource.html#%3Cinit%3E(java.net.URL,java.security.cert.Certificate[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.URL"/></param>
        /// <param name="arg1"><see cref="Java.Security.Cert.Certificate"/></param>
        public CodeSource(Java.Net.URL arg0, Java.Security.Cert.Certificate[] arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/CodeSource.html#%3Cinit%3E(java.net.URL,java.security.CodeSigner[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.URL"/></param>
        /// <param name="arg1"><see cref="Java.Security.CodeSigner"/></param>
        public CodeSource(Java.Net.URL arg0, Java.Security.CodeSigner[] arg1)
            : base(arg0, arg1)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/CodeSource.html#implies(java.security.CodeSource)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.CodeSource"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Implies(Java.Security.CodeSource arg0)
        {
            return IExecuteWithSignature<bool>("implies", "(Ljava/security/CodeSource;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/CodeSource.html#getLocation()"/>
        /// </summary>
        /// <returns><see cref="Java.Net.URL"/></returns>
        public Java.Net.URL GetLocation()
        {
            return IExecuteWithSignature<Java.Net.URL>("getLocation", "()Ljava/net/URL;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/CodeSource.html#getCertificates()"/>
        /// </summary>
        /// <returns><see cref="Java.Security.Cert.Certificate"/></returns>
        public Java.Security.Cert.Certificate[] GetCertificates()
        {
            return IExecuteWithSignatureArray<Java.Security.Cert.Certificate>("getCertificates", "()[Ljava/security/cert/Certificate;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/CodeSource.html#getCodeSigners()"/>
        /// </summary>
        /// <returns><see cref="Java.Security.CodeSigner"/></returns>
        public Java.Security.CodeSigner[] GetCodeSigners()
        {
            return IExecuteWithSignatureArray<Java.Security.CodeSigner>("getCodeSigners", "()[Ljava/security/CodeSigner;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}