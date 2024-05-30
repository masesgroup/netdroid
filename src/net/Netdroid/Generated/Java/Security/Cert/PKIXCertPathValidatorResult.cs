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

namespace Java.Security.Cert
{
    #region PKIXCertPathValidatorResult
    public partial class PKIXCertPathValidatorResult
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/security/cert/PKIXCertPathValidatorResult.html#%3Cinit%3E(java.security.cert.TrustAnchor,java.security.cert.PolicyNode,java.security.PublicKey)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.Cert.TrustAnchor"/></param>
        /// <param name="arg1"><see cref="Java.Security.Cert.PolicyNode"/></param>
        /// <param name="arg2"><see cref="Java.Security.PublicKey"/></param>
        public PKIXCertPathValidatorResult(Java.Security.Cert.TrustAnchor arg0, Java.Security.Cert.PolicyNode arg1, Java.Security.PublicKey arg2)
            : base(arg0, arg1, arg2)
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
        /// <see href="https://developer.android.com/reference/java.base/java/security/cert/PKIXCertPathValidatorResult.html#getPolicyTree()"/> 
        /// </summary>
        public Java.Security.Cert.PolicyNode PolicyTree
        {
            get { return IExecuteWithSignature<Java.Security.Cert.PolicyNode>("getPolicyTree", "()Ljava/security/cert/PolicyNode;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/security/cert/PKIXCertPathValidatorResult.html#getPublicKey()"/> 
        /// </summary>
        public Java.Security.PublicKey PublicKey
        {
            get { return IExecuteWithSignature<Java.Security.PublicKey>("getPublicKey", "()Ljava/security/PublicKey;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/security/cert/PKIXCertPathValidatorResult.html#getTrustAnchor()"/> 
        /// </summary>
        public Java.Security.Cert.TrustAnchor TrustAnchor
        {
            get { return IExecuteWithSignature<Java.Security.Cert.TrustAnchor>("getTrustAnchor", "()Ljava/security/cert/TrustAnchor;"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}