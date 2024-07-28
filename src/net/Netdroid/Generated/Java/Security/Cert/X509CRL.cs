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

namespace Java.Security.Cert
{
    #region X509CRL
    public partial class X509CRL
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Security.Cert.X509CRL"/> to <see cref="Java.Security.Cert.X509Extension"/>
        /// </summary>
        public static implicit operator Java.Security.Cert.X509Extension(Java.Security.Cert.X509CRL t) => t.Cast<Java.Security.Cert.X509Extension>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/cert/X509CRL.html#getEncoded()"/>
        /// </summary>
        /// <returns><see cref="byte"/></returns>
        /// <exception cref="Java.Security.Cert.CRLException"/>
        public byte[] GetEncoded()
        {
            return IExecuteWithSignatureArray<byte>("getEncoded", "()[B");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/cert/X509CRL.html#getSigAlgParams()"/>
        /// </summary>
        /// <returns><see cref="byte"/></returns>
        public byte[] GetSigAlgParams()
        {
            return IExecuteWithSignatureArray<byte>("getSigAlgParams", "()[B");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/cert/X509CRL.html#getSignature()"/>
        /// </summary>
        /// <returns><see cref="byte"/></returns>
        public byte[] GetSignature()
        {
            return IExecuteWithSignatureArray<byte>("getSignature", "()[B");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/cert/X509CRL.html#getTBSCertList()"/>
        /// </summary>
        /// <returns><see cref="byte"/></returns>
        /// <exception cref="Java.Security.Cert.CRLException"/>
        public byte[] GetTBSCertList()
        {
            return IExecuteWithSignatureArray<byte>("getTBSCertList", "()[B");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/cert/X509CRL.html#getVersion()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetVersion()
        {
            return IExecuteWithSignature<int>("getVersion", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/cert/X509CRL.html#getSigAlgName()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetSigAlgName()
        {
            return IExecuteWithSignature<Java.Lang.String>("getSigAlgName", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/cert/X509CRL.html#getSigAlgOID()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetSigAlgOID()
        {
            return IExecuteWithSignature<Java.Lang.String>("getSigAlgOID", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/cert/X509CRL.html#getRevokedCertificate(java.math.BigInteger)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Math.BigInteger"/></param>
        /// <returns><see cref="Java.Security.Cert.X509CRLEntry"/></returns>
        public Java.Security.Cert.X509CRLEntry GetRevokedCertificate(Java.Math.BigInteger arg0)
        {
            return IExecuteWithSignature<Java.Security.Cert.X509CRLEntry>("getRevokedCertificate", "(Ljava/math/BigInteger;)Ljava/security/cert/X509CRLEntry;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/cert/X509CRL.html#getIssuerDN()"/>
        /// </summary>
        /// <returns><see cref="Java.Security.Principal"/></returns>
        [global::System.Obsolete()]
        public Java.Security.Principal GetIssuerDN()
        {
            return IExecuteWithSignature<Java.Security.Principal>("getIssuerDN", "()Ljava/security/Principal;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/cert/X509CRL.html#getNextUpdate()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Date"/></returns>
        public Java.Util.Date GetNextUpdate()
        {
            return IExecuteWithSignature<Java.Util.Date>("getNextUpdate", "()Ljava/util/Date;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/cert/X509CRL.html#getThisUpdate()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Date"/></returns>
        public Java.Util.Date GetThisUpdate()
        {
            return IExecuteWithSignature<Java.Util.Date>("getThisUpdate", "()Ljava/util/Date;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/cert/X509CRL.html#getRevokedCertificates()"/>
        /// </summary>
        /// <typeparam name="ReturnExtendsJava_Security_Cert_X509CRLEntry"><see cref="Java.Security.Cert.X509CRLEntry"/></typeparam>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set<ReturnExtendsJava_Security_Cert_X509CRLEntry> GetRevokedCertificates<ReturnExtendsJava_Security_Cert_X509CRLEntry>() where ReturnExtendsJava_Security_Cert_X509CRLEntry : Java.Security.Cert.X509CRLEntry
        {
            return IExecuteWithSignature<Java.Util.Set<ReturnExtendsJava_Security_Cert_X509CRLEntry>>("getRevokedCertificates", "()Ljava/util/Set;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/cert/X509CRL.html#verify(java.security.PublicKey,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.PublicKey"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Java.Security.Cert.CRLException"/>
        /// <exception cref="Java.Security.NoSuchAlgorithmException"/>
        /// <exception cref="Java.Security.InvalidKeyException"/>
        /// <exception cref="Java.Security.NoSuchProviderException"/>
        /// <exception cref="Java.Security.SignatureException"/>
        public void Verify(Java.Security.PublicKey arg0, Java.Lang.String arg1)
        {
            IExecute("verify", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/cert/X509CRL.html#verify(java.security.PublicKey)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.PublicKey"/></param>
        /// <exception cref="Java.Security.Cert.CRLException"/>
        /// <exception cref="Java.Security.NoSuchAlgorithmException"/>
        /// <exception cref="Java.Security.InvalidKeyException"/>
        /// <exception cref="Java.Security.NoSuchProviderException"/>
        /// <exception cref="Java.Security.SignatureException"/>
        public void Verify(Java.Security.PublicKey arg0)
        {
            IExecuteWithSignature("verify", "(Ljava/security/PublicKey;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/cert/X509CRL.html#getRevokedCertificate(java.security.cert.X509Certificate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.Cert.X509Certificate"/></param>
        /// <returns><see cref="Java.Security.Cert.X509CRLEntry"/></returns>
        public Java.Security.Cert.X509CRLEntry GetRevokedCertificate(Java.Security.Cert.X509Certificate arg0)
        {
            return IExecuteWithSignature<Java.Security.Cert.X509CRLEntry>("getRevokedCertificate", "(Ljava/security/cert/X509Certificate;)Ljava/security/cert/X509CRLEntry;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/cert/X509CRL.html#getIssuerX500Principal()"/>
        /// </summary>
        /// <returns><see cref="Javax.Security.Auth.X500.X500Principal"/></returns>
        public Javax.Security.Auth.X500.X500Principal GetIssuerX500Principal()
        {
            return IExecuteWithSignature<Javax.Security.Auth.X500.X500Principal>("getIssuerX500Principal", "()Ljavax/security/auth/x500/X500Principal;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/cert/X509CRL.html#verify(java.security.PublicKey,java.security.Provider)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.PublicKey"/></param>
        /// <param name="arg1"><see cref="Java.Security.Provider"/></param>
        /// <exception cref="Java.Security.Cert.CRLException"/>
        /// <exception cref="Java.Security.NoSuchAlgorithmException"/>
        /// <exception cref="Java.Security.InvalidKeyException"/>
        /// <exception cref="Java.Security.SignatureException"/>
        public void Verify(Java.Security.PublicKey arg0, Java.Security.Provider arg1)
        {
            IExecute("verify", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}