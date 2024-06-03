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
    #region ICertPathChecker
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface ICertPathChecker
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region CertPathChecker
    public partial class CertPathChecker : Java.Security.Cert.ICertPathChecker
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
        /// <see href="https://developer.android.com/reference/java/security/cert/CertPathChecker.html#isForwardCheckingSupported()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsForwardCheckingSupported()
        {
            return IExecuteWithSignature<bool>("isForwardCheckingSupported", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/cert/CertPathChecker.html#check(java.security.cert.Certificate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.Cert.Certificate"/></param>
        /// <exception cref="Java.Security.Cert.CertPathValidatorException"/>
        public void Check(Java.Security.Cert.Certificate arg0)
        {
            IExecuteWithSignature("check", "(Ljava/security/cert/Certificate;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/cert/CertPathChecker.html#init(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <exception cref="Java.Security.Cert.CertPathValidatorException"/>
        public void Init(bool arg0)
        {
            IExecuteWithSignature("init", "(Z)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}