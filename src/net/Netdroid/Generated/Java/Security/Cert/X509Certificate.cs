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
*  This file is generated by MASES.JNetReflector (ver. 2.5.6.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Security.Cert
{
    #region X509Certificate
    public partial class X509Certificate
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Security.Cert.X509Certificate"/> to <see cref="Java.Security.Cert.X509Extension"/>
        /// </summary>
        public static implicit operator Java.Security.Cert.X509Extension(Java.Security.Cert.X509Certificate t) => t.Cast<Java.Security.Cert.X509Extension>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/cert/X509Certificate.html#getIssuerUniqueID()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool[] GetIssuerUniqueID()
        {
            return IExecuteWithSignatureArray<bool>("getIssuerUniqueID", "()[Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/cert/X509Certificate.html#getKeyUsage()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool[] GetKeyUsage()
        {
            return IExecuteWithSignatureArray<bool>("getKeyUsage", "()[Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/cert/X509Certificate.html#getSubjectUniqueID()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool[] GetSubjectUniqueID()
        {
            return IExecuteWithSignatureArray<bool>("getSubjectUniqueID", "()[Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/cert/X509Certificate.html#getSigAlgParams()"/>
        /// </summary>
        /// <returns><see cref="byte"/></returns>
        public byte[] GetSigAlgParams()
        {
            return IExecuteWithSignatureArray<byte>("getSigAlgParams", "()[B");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/cert/X509Certificate.html#getSignature()"/>
        /// </summary>
        /// <returns><see cref="byte"/></returns>
        public byte[] GetSignature()
        {
            return IExecuteWithSignatureArray<byte>("getSignature", "()[B");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/cert/X509Certificate.html#getTBSCertificate()"/>
        /// </summary>
        /// <returns><see cref="byte"/></returns>
        /// <exception cref="Java.Security.Cert.CertificateEncodingException"/>
        public byte[] GetTBSCertificate()
        {
            return IExecuteWithSignatureArray<byte>("getTBSCertificate", "()[B");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/cert/X509Certificate.html#getBasicConstraints()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetBasicConstraints()
        {
            return IExecuteWithSignature<int>("getBasicConstraints", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/cert/X509Certificate.html#getVersion()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetVersion()
        {
            return IExecuteWithSignature<int>("getVersion", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/cert/X509Certificate.html#getSigAlgName()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetSigAlgName()
        {
            return IExecuteWithSignature<Java.Lang.String>("getSigAlgName", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/cert/X509Certificate.html#getSigAlgOID()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetSigAlgOID()
        {
            return IExecuteWithSignature<Java.Lang.String>("getSigAlgOID", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/cert/X509Certificate.html#getSerialNumber()"/>
        /// </summary>
        /// <returns><see cref="Java.Math.BigInteger"/></returns>
        public Java.Math.BigInteger GetSerialNumber()
        {
            return IExecuteWithSignature<Java.Math.BigInteger>("getSerialNumber", "()Ljava/math/BigInteger;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/cert/X509Certificate.html#getIssuerDN()"/>
        /// </summary>
        /// <returns><see cref="Java.Security.Principal"/></returns>
        [global::System.Obsolete()]
        public Java.Security.Principal GetIssuerDN()
        {
            return IExecuteWithSignature<Java.Security.Principal>("getIssuerDN", "()Ljava/security/Principal;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/cert/X509Certificate.html#getSubjectDN()"/>
        /// </summary>
        /// <returns><see cref="Java.Security.Principal"/></returns>
        [global::System.Obsolete()]
        public Java.Security.Principal GetSubjectDN()
        {
            return IExecuteWithSignature<Java.Security.Principal>("getSubjectDN", "()Ljava/security/Principal;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/cert/X509Certificate.html#getNotAfter()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Date"/></returns>
        public Java.Util.Date GetNotAfter()
        {
            return IExecuteWithSignature<Java.Util.Date>("getNotAfter", "()Ljava/util/Date;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/cert/X509Certificate.html#getNotBefore()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Date"/></returns>
        public Java.Util.Date GetNotBefore()
        {
            return IExecuteWithSignature<Java.Util.Date>("getNotBefore", "()Ljava/util/Date;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/cert/X509Certificate.html#checkValidity()"/>
        /// </summary>
        /// <exception cref="Java.Security.Cert.CertificateExpiredException"/>
        /// <exception cref="Java.Security.Cert.CertificateNotYetValidException"/>
        public void CheckValidity()
        {
            IExecuteWithSignature("checkValidity", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/cert/X509Certificate.html#checkValidity(java.util.Date)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Date"/></param>
        /// <exception cref="Java.Security.Cert.CertificateExpiredException"/>
        /// <exception cref="Java.Security.Cert.CertificateNotYetValidException"/>
        public void CheckValidity(Java.Util.Date arg0)
        {
            IExecuteWithSignature("checkValidity", "(Ljava/util/Date;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/cert/X509Certificate.html#getIssuerAlternativeNames()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Collection"/></returns>
        /// <exception cref="Java.Security.Cert.CertificateParsingException"/>
        public Java.Util.Collection<Java.Util.List<object>> GetIssuerAlternativeNames()
        {
            return IExecuteWithSignature<Java.Util.Collection<Java.Util.List<object>>>("getIssuerAlternativeNames", "()Ljava/util/Collection;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/cert/X509Certificate.html#getSubjectAlternativeNames()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Collection"/></returns>
        /// <exception cref="Java.Security.Cert.CertificateParsingException"/>
        public Java.Util.Collection<Java.Util.List<object>> GetSubjectAlternativeNames()
        {
            return IExecuteWithSignature<Java.Util.Collection<Java.Util.List<object>>>("getSubjectAlternativeNames", "()Ljava/util/Collection;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/cert/X509Certificate.html#getExtendedKeyUsage()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        /// <exception cref="Java.Security.Cert.CertificateParsingException"/>
        public Java.Util.List<Java.Lang.String> GetExtendedKeyUsage()
        {
            return IExecuteWithSignature<Java.Util.List<Java.Lang.String>>("getExtendedKeyUsage", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/cert/X509Certificate.html#getIssuerX500Principal()"/>
        /// </summary>
        /// <returns><see cref="Javax.Security.Auth.X500.X500Principal"/></returns>
        public Javax.Security.Auth.X500.X500Principal GetIssuerX500Principal()
        {
            return IExecuteWithSignature<Javax.Security.Auth.X500.X500Principal>("getIssuerX500Principal", "()Ljavax/security/auth/x500/X500Principal;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/cert/X509Certificate.html#getSubjectX500Principal()"/>
        /// </summary>
        /// <returns><see cref="Javax.Security.Auth.X500.X500Principal"/></returns>
        public Javax.Security.Auth.X500.X500Principal GetSubjectX500Principal()
        {
            return IExecuteWithSignature<Javax.Security.Auth.X500.X500Principal>("getSubjectX500Principal", "()Ljavax/security/auth/x500/X500Principal;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}