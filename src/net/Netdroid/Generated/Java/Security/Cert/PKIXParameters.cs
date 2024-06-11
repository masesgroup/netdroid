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

namespace Java.Security.Cert
{
    #region PKIXParameters
    public partial class PKIXParameters
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/cert/PKIXParameters.html#%3Cinit%3E(java.security.KeyStore)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.KeyStore"/></param>
        /// <exception cref="Java.Security.KeyStoreException"/>
        /// <exception cref="Java.Security.InvalidAlgorithmParameterException"/>
        public PKIXParameters(Java.Security.KeyStore arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/cert/PKIXParameters.html#%3Cinit%3E(java.util.Set)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Set"/></param>
        /// <exception cref="Java.Security.InvalidAlgorithmParameterException"/>
        public PKIXParameters(Java.Util.Set<Java.Security.Cert.TrustAnchor> arg0)
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
        /// <see href="https://developer.android.com/reference/java/security/cert/PKIXParameters.html#getPolicyQualifiersRejected()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool GetPolicyQualifiersRejected()
        {
            return IExecuteWithSignature<bool>("getPolicyQualifiersRejected", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/cert/PKIXParameters.html#isAnyPolicyInhibited()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsAnyPolicyInhibited()
        {
            return IExecuteWithSignature<bool>("isAnyPolicyInhibited", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/cert/PKIXParameters.html#isExplicitPolicyRequired()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsExplicitPolicyRequired()
        {
            return IExecuteWithSignature<bool>("isExplicitPolicyRequired", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/cert/PKIXParameters.html#isPolicyMappingInhibited()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsPolicyMappingInhibited()
        {
            return IExecuteWithSignature<bool>("isPolicyMappingInhibited", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/cert/PKIXParameters.html#isRevocationEnabled()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsRevocationEnabled()
        {
            return IExecuteWithSignature<bool>("isRevocationEnabled", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/cert/PKIXParameters.html#getSigProvider()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetSigProvider()
        {
            return IExecuteWithSignature<Java.Lang.String>("getSigProvider", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/cert/PKIXParameters.html#getTargetCertConstraints()"/>
        /// </summary>
        /// <returns><see cref="Java.Security.Cert.CertSelector"/></returns>
        public Java.Security.Cert.CertSelector GetTargetCertConstraints()
        {
            return IExecuteWithSignature<Java.Security.Cert.CertSelector>("getTargetCertConstraints", "()Ljava/security/cert/CertSelector;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/cert/PKIXParameters.html#getDate()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Date"/></returns>
        public Java.Util.Date GetDate()
        {
            return IExecuteWithSignature<Java.Util.Date>("getDate", "()Ljava/util/Date;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/cert/PKIXParameters.html#getCertStores()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Java.Security.Cert.CertStore> GetCertStores()
        {
            return IExecuteWithSignature<Java.Util.List<Java.Security.Cert.CertStore>>("getCertStores", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/cert/PKIXParameters.html#getCertPathCheckers()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Java.Security.Cert.PKIXCertPathChecker> GetCertPathCheckers()
        {
            return IExecuteWithSignature<Java.Util.List<Java.Security.Cert.PKIXCertPathChecker>>("getCertPathCheckers", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/cert/PKIXParameters.html#getInitialPolicies()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set<Java.Lang.String> GetInitialPolicies()
        {
            return IExecuteWithSignature<Java.Util.Set<Java.Lang.String>>("getInitialPolicies", "()Ljava/util/Set;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/cert/PKIXParameters.html#getTrustAnchors()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set<Java.Security.Cert.TrustAnchor> GetTrustAnchors()
        {
            return IExecuteWithSignature<Java.Util.Set<Java.Security.Cert.TrustAnchor>>("getTrustAnchors", "()Ljava/util/Set;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/cert/PKIXParameters.html#addCertPathChecker(java.security.cert.PKIXCertPathChecker)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.Cert.PKIXCertPathChecker"/></param>
        public void AddCertPathChecker(Java.Security.Cert.PKIXCertPathChecker arg0)
        {
            IExecuteWithSignature("addCertPathChecker", "(Ljava/security/cert/PKIXCertPathChecker;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/cert/PKIXParameters.html#addCertStore(java.security.cert.CertStore)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.Cert.CertStore"/></param>
        public void AddCertStore(Java.Security.Cert.CertStore arg0)
        {
            IExecuteWithSignature("addCertStore", "(Ljava/security/cert/CertStore;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/cert/PKIXParameters.html#setAnyPolicyInhibited(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetAnyPolicyInhibited(bool arg0)
        {
            IExecuteWithSignature("setAnyPolicyInhibited", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/cert/PKIXParameters.html#setCertPathCheckers(java.util.List)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.List"/></param>
        public void SetCertPathCheckers(Java.Util.List<Java.Security.Cert.PKIXCertPathChecker> arg0)
        {
            IExecuteWithSignature("setCertPathCheckers", "(Ljava/util/List;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/cert/PKIXParameters.html#setCertStores(java.util.List)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.List"/></param>
        public void SetCertStores(Java.Util.List<Java.Security.Cert.CertStore> arg0)
        {
            IExecuteWithSignature("setCertStores", "(Ljava/util/List;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/cert/PKIXParameters.html#setDate(java.util.Date)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Date"/></param>
        public void SetDate(Java.Util.Date arg0)
        {
            IExecuteWithSignature("setDate", "(Ljava/util/Date;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/cert/PKIXParameters.html#setExplicitPolicyRequired(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetExplicitPolicyRequired(bool arg0)
        {
            IExecuteWithSignature("setExplicitPolicyRequired", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/cert/PKIXParameters.html#setInitialPolicies(java.util.Set)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Set"/></param>
        public void SetInitialPolicies(Java.Util.Set<Java.Lang.String> arg0)
        {
            IExecuteWithSignature("setInitialPolicies", "(Ljava/util/Set;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/cert/PKIXParameters.html#setPolicyMappingInhibited(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetPolicyMappingInhibited(bool arg0)
        {
            IExecuteWithSignature("setPolicyMappingInhibited", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/cert/PKIXParameters.html#setPolicyQualifiersRejected(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetPolicyQualifiersRejected(bool arg0)
        {
            IExecuteWithSignature("setPolicyQualifiersRejected", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/cert/PKIXParameters.html#setRevocationEnabled(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetRevocationEnabled(bool arg0)
        {
            IExecuteWithSignature("setRevocationEnabled", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/cert/PKIXParameters.html#setSigProvider(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void SetSigProvider(Java.Lang.String arg0)
        {
            IExecuteWithSignature("setSigProvider", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/cert/PKIXParameters.html#setTargetCertConstraints(java.security.cert.CertSelector)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.Cert.CertSelector"/></param>
        public void SetTargetCertConstraints(Java.Security.Cert.CertSelector arg0)
        {
            IExecuteWithSignature("setTargetCertConstraints", "(Ljava/security/cert/CertSelector;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/cert/PKIXParameters.html#setTrustAnchors(java.util.Set)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Set"/></param>
        /// <exception cref="Java.Security.InvalidAlgorithmParameterException"/>
        public void SetTrustAnchors(Java.Util.Set<Java.Security.Cert.TrustAnchor> arg0)
        {
            IExecuteWithSignature("setTrustAnchors", "(Ljava/util/Set;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}