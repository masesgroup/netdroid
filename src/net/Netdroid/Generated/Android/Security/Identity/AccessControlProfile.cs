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

namespace Android.Security.Identity
{
    #region AccessControlProfile
    public partial class AccessControlProfile
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

        #endregion

        #region Nested classes
        #region Builder
        public partial class Builder
        {
            #region Constructors
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/security/identity/AccessControlProfile.Builder.html#%3Cinit%3E(android.security.identity.AccessControlProfileId)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Security.Identity.AccessControlProfileId"/></param>
            public Builder(Android.Security.Identity.AccessControlProfileId arg0)
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
            /// <see href="https://developer.android.com/reference/android/security/identity/AccessControlProfile.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.Security.Identity.AccessControlProfile"/></returns>
            public Android.Security.Identity.AccessControlProfile Build()
            {
                return IExecuteWithSignature<Android.Security.Identity.AccessControlProfile>("build", "()Landroid/security/identity/AccessControlProfile;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/security/identity/AccessControlProfile.Builder.html#setReaderCertificate(java.security.cert.X509Certificate)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Security.Cert.X509Certificate"/></param>
            /// <returns><see cref="Android.Security.Identity.AccessControlProfile.Builder"/></returns>
            public Android.Security.Identity.AccessControlProfile.Builder SetReaderCertificate(Java.Security.Cert.X509Certificate arg0)
            {
                return IExecuteWithSignature<Android.Security.Identity.AccessControlProfile.Builder>("setReaderCertificate", "(Ljava/security/cert/X509Certificate;)Landroid/security/identity/AccessControlProfile$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/security/identity/AccessControlProfile.Builder.html#setUserAuthenticationRequired(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.Security.Identity.AccessControlProfile.Builder"/></returns>
            public Android.Security.Identity.AccessControlProfile.Builder SetUserAuthenticationRequired(bool arg0)
            {
                return IExecuteWithSignature<Android.Security.Identity.AccessControlProfile.Builder>("setUserAuthenticationRequired", "(Z)Landroid/security/identity/AccessControlProfile$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/security/identity/AccessControlProfile.Builder.html#setUserAuthenticationTimeout(long)"/>
            /// </summary>
            /// <param name="arg0"><see cref="long"/></param>
            /// <returns><see cref="Android.Security.Identity.AccessControlProfile.Builder"/></returns>
            public Android.Security.Identity.AccessControlProfile.Builder SetUserAuthenticationTimeout(long arg0)
            {
                return IExecuteWithSignature<Android.Security.Identity.AccessControlProfile.Builder>("setUserAuthenticationTimeout", "(J)Landroid/security/identity/AccessControlProfile$Builder;", arg0);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

    
        #endregion

        // TODO: complete the class
    }
    #endregion
}