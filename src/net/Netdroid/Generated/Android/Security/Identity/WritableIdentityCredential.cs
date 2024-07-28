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

namespace Android.Security.Identity
{
    #region WritableIdentityCredential
    public partial class WritableIdentityCredential
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
        /// <see href="https://developer.android.com/reference/android/security/identity/WritableIdentityCredential.html#personalize(android.security.identity.PersonalizationData)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Security.Identity.PersonalizationData"/></param>
        /// <returns><see cref="byte"/></returns>
        public byte[] Personalize(Android.Security.Identity.PersonalizationData arg0)
        {
            return IExecuteWithSignatureArray<byte>("personalize", "(Landroid/security/identity/PersonalizationData;)[B", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/identity/WritableIdentityCredential.html#getCredentialKeyCertificateChain(byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <returns><see cref="Java.Util.Collection"/></returns>
        public Java.Util.Collection<Java.Security.Cert.X509Certificate> GetCredentialKeyCertificateChain(byte[] arg0)
        {
            return IExecuteWithSignature<Java.Util.Collection<Java.Security.Cert.X509Certificate>>("getCredentialKeyCertificateChain", "([B)Ljava/util/Collection;", new object[] { arg0 });
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}