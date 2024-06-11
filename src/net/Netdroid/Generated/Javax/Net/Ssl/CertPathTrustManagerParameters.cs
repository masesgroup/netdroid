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
    #region CertPathTrustManagerParameters
    public partial class CertPathTrustManagerParameters
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/CertPathTrustManagerParameters.html#%3Cinit%3E(java.security.cert.CertPathParameters)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.Cert.CertPathParameters"/></param>
        public CertPathTrustManagerParameters(Java.Security.Cert.CertPathParameters arg0)
            : base(arg0)
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
        /// <see href="https://developer.android.com/reference/javax/net/ssl/CertPathTrustManagerParameters.html#getParameters()"/>
        /// </summary>
        /// <returns><see cref="Java.Security.Cert.CertPathParameters"/></returns>
        public Java.Security.Cert.CertPathParameters GetParameters()
        {
            return IExecuteWithSignature<Java.Security.Cert.CertPathParameters>("getParameters", "()Ljava/security/cert/CertPathParameters;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}