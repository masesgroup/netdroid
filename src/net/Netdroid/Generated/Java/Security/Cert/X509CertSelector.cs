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
*  This file is generated by MASES.JNetReflector (ver. 2.5.10.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Security.Cert
{
    #region X509CertSelector declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/java/security/cert/X509CertSelector.html"/>
    /// </summary>
    public partial class X509CertSelector : Java.Security.Cert.CertSelector
    {
        const string _bridgeClassName = "java.security.cert.X509CertSelector";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public X509CertSelector() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public X509CertSelector(params object[] args) : base(args) { }
    
        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
    
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
        /// </summary>
        public override bool IsBridgeAbstract => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
        /// </summary>
        public override bool IsBridgeCloseable => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
        /// </summary>
        public override bool IsBridgeInterface => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;
    
        // TODO: complete the class
    
    }
    #endregion

    #region X509CertSelector implementation
    public partial class X509CertSelector
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
        /// <see href="https://developer.android.com/reference/java/security/cert/X509CertSelector.html#getMatchAllSubjectAltNames()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool GetMatchAllSubjectAltNames()
        {
            return IExecuteWithSignature<bool>("getMatchAllSubjectAltNames", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/cert/X509CertSelector.html#match(java.security.cert.Certificate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.Cert.Certificate"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Match(Java.Security.Cert.Certificate arg0)
        {
            return IExecuteWithSignature<bool>("match", "(Ljava/security/cert/Certificate;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/cert/X509CertSelector.html#getKeyUsage()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool[] GetKeyUsage()
        {
            return IExecuteWithSignatureArray<bool>("getKeyUsage", "()[Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/cert/X509CertSelector.html#getAuthorityKeyIdentifier()"/>
        /// </summary>
        /// <returns><see cref="byte"/></returns>
        public byte[] GetAuthorityKeyIdentifier()
        {
            return IExecuteWithSignatureArray<byte>("getAuthorityKeyIdentifier", "()[B");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/cert/X509CertSelector.html#getIssuerAsBytes()"/>
        /// </summary>
        /// <returns><see cref="byte"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public byte[] GetIssuerAsBytes()
        {
            return IExecuteWithSignatureArray<byte>("getIssuerAsBytes", "()[B");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/cert/X509CertSelector.html#getNameConstraints()"/>
        /// </summary>
        /// <returns><see cref="byte"/></returns>
        public byte[] GetNameConstraints()
        {
            return IExecuteWithSignatureArray<byte>("getNameConstraints", "()[B");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/cert/X509CertSelector.html#getSubjectAsBytes()"/>
        /// </summary>
        /// <returns><see cref="byte"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public byte[] GetSubjectAsBytes()
        {
            return IExecuteWithSignatureArray<byte>("getSubjectAsBytes", "()[B");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/cert/X509CertSelector.html#getSubjectKeyIdentifier()"/>
        /// </summary>
        /// <returns><see cref="byte"/></returns>
        public byte[] GetSubjectKeyIdentifier()
        {
            return IExecuteWithSignatureArray<byte>("getSubjectKeyIdentifier", "()[B");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/cert/X509CertSelector.html#getBasicConstraints()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetBasicConstraints()
        {
            return IExecuteWithSignature<int>("getBasicConstraints", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/cert/X509CertSelector.html#getIssuerAsString()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        [global::System.Obsolete()]
        public Java.Lang.String GetIssuerAsString()
        {
            return IExecuteWithSignature<Java.Lang.String>("getIssuerAsString", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/cert/X509CertSelector.html#getSubjectAsString()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        [global::System.Obsolete()]
        public Java.Lang.String GetSubjectAsString()
        {
            return IExecuteWithSignature<Java.Lang.String>("getSubjectAsString", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/cert/X509CertSelector.html#getSubjectPublicKeyAlgID()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetSubjectPublicKeyAlgID()
        {
            return IExecuteWithSignature<Java.Lang.String>("getSubjectPublicKeyAlgID", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/cert/X509CertSelector.html#getSerialNumber()"/>
        /// </summary>
        /// <returns><see cref="Java.Math.BigInteger"/></returns>
        public Java.Math.BigInteger GetSerialNumber()
        {
            return IExecuteWithSignature<Java.Math.BigInteger>("getSerialNumber", "()Ljava/math/BigInteger;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/cert/X509CertSelector.html#getCertificate()"/>
        /// </summary>
        /// <returns><see cref="Java.Security.Cert.X509Certificate"/></returns>
        public Java.Security.Cert.X509Certificate GetCertificate()
        {
            return IExecuteWithSignature<Java.Security.Cert.X509Certificate>("getCertificate", "()Ljava/security/cert/X509Certificate;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/cert/X509CertSelector.html#getSubjectPublicKey()"/>
        /// </summary>
        /// <returns><see cref="Java.Security.PublicKey"/></returns>
        public Java.Security.PublicKey GetSubjectPublicKey()
        {
            return IExecuteWithSignature<Java.Security.PublicKey>("getSubjectPublicKey", "()Ljava/security/PublicKey;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/cert/X509CertSelector.html#getPathToNames()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Collection"/></returns>
        public Java.Util.Collection<Java.Util.List<object>> GetPathToNames()
        {
            return IExecuteWithSignature<Java.Util.Collection<Java.Util.List<object>>>("getPathToNames", "()Ljava/util/Collection;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/cert/X509CertSelector.html#getSubjectAlternativeNames()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Collection"/></returns>
        public Java.Util.Collection<Java.Util.List<object>> GetSubjectAlternativeNames()
        {
            return IExecuteWithSignature<Java.Util.Collection<Java.Util.List<object>>>("getSubjectAlternativeNames", "()Ljava/util/Collection;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/cert/X509CertSelector.html#getCertificateValid()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Date"/></returns>
        public Java.Util.Date GetCertificateValid()
        {
            return IExecuteWithSignature<Java.Util.Date>("getCertificateValid", "()Ljava/util/Date;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/cert/X509CertSelector.html#getPrivateKeyValid()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Date"/></returns>
        public Java.Util.Date GetPrivateKeyValid()
        {
            return IExecuteWithSignature<Java.Util.Date>("getPrivateKeyValid", "()Ljava/util/Date;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/cert/X509CertSelector.html#getExtendedKeyUsage()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set<Java.Lang.String> GetExtendedKeyUsage()
        {
            return IExecuteWithSignature<Java.Util.Set<Java.Lang.String>>("getExtendedKeyUsage", "()Ljava/util/Set;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/cert/X509CertSelector.html#getPolicy()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set<Java.Lang.String> GetPolicy()
        {
            return IExecuteWithSignature<Java.Util.Set<Java.Lang.String>>("getPolicy", "()Ljava/util/Set;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/cert/X509CertSelector.html#getIssuer()"/>
        /// </summary>
        /// <returns><see cref="Javax.Security.Auth.X500.X500Principal"/></returns>
        public Javax.Security.Auth.X500.X500Principal GetIssuer()
        {
            return IExecuteWithSignature<Javax.Security.Auth.X500.X500Principal>("getIssuer", "()Ljavax/security/auth/x500/X500Principal;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/cert/X509CertSelector.html#getSubject()"/>
        /// </summary>
        /// <returns><see cref="Javax.Security.Auth.X500.X500Principal"/></returns>
        public Javax.Security.Auth.X500.X500Principal GetSubject()
        {
            return IExecuteWithSignature<Javax.Security.Auth.X500.X500Principal>("getSubject", "()Ljavax/security/auth/x500/X500Principal;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/cert/X509CertSelector.html#addPathToName(int,byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="byte"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void AddPathToName(int arg0, byte[] arg1)
        {
            IExecuteWithSignature("addPathToName", "(I[B)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/cert/X509CertSelector.html#addPathToName(int,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void AddPathToName(int arg0, Java.Lang.String arg1)
        {
            IExecuteWithSignature("addPathToName", "(ILjava/lang/String;)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/cert/X509CertSelector.html#addSubjectAlternativeName(int,byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="byte"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void AddSubjectAlternativeName(int arg0, byte[] arg1)
        {
            IExecuteWithSignature("addSubjectAlternativeName", "(I[B)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/cert/X509CertSelector.html#addSubjectAlternativeName(int,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void AddSubjectAlternativeName(int arg0, Java.Lang.String arg1)
        {
            IExecuteWithSignature("addSubjectAlternativeName", "(ILjava/lang/String;)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/cert/X509CertSelector.html#setAuthorityKeyIdentifier(byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        public void SetAuthorityKeyIdentifier(byte[] arg0)
        {
            IExecuteWithSignature("setAuthorityKeyIdentifier", "([B)V", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/cert/X509CertSelector.html#setBasicConstraints(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetBasicConstraints(int arg0)
        {
            IExecuteWithSignature("setBasicConstraints", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/cert/X509CertSelector.html#setCertificate(java.security.cert.X509Certificate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.Cert.X509Certificate"/></param>
        public void SetCertificate(Java.Security.Cert.X509Certificate arg0)
        {
            IExecuteWithSignature("setCertificate", "(Ljava/security/cert/X509Certificate;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/cert/X509CertSelector.html#setCertificateValid(java.util.Date)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Date"/></param>
        public void SetCertificateValid(Java.Util.Date arg0)
        {
            IExecuteWithSignature("setCertificateValid", "(Ljava/util/Date;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/cert/X509CertSelector.html#setExtendedKeyUsage(java.util.Set)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Set"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void SetExtendedKeyUsage(Java.Util.Set<Java.Lang.String> arg0)
        {
            IExecuteWithSignature("setExtendedKeyUsage", "(Ljava/util/Set;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/cert/X509CertSelector.html#setIssuer(byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void SetIssuer(byte[] arg0)
        {
            IExecuteWithSignature("setIssuer", "([B)V", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/cert/X509CertSelector.html#setIssuer(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Java.Io.IOException"/>
        [global::System.Obsolete()]
        public void SetIssuer(Java.Lang.String arg0)
        {
            IExecuteWithSignature("setIssuer", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/cert/X509CertSelector.html#setIssuer(javax.security.auth.x500.X500Principal)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Security.Auth.X500.X500Principal"/></param>
        public void SetIssuer(Javax.Security.Auth.X500.X500Principal arg0)
        {
            IExecuteWithSignature("setIssuer", "(Ljavax/security/auth/x500/X500Principal;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/cert/X509CertSelector.html#setKeyUsage(boolean[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetKeyUsage(bool[] arg0)
        {
            IExecuteWithSignature("setKeyUsage", "([Z)V", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/cert/X509CertSelector.html#setMatchAllSubjectAltNames(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetMatchAllSubjectAltNames(bool arg0)
        {
            IExecuteWithSignature("setMatchAllSubjectAltNames", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/cert/X509CertSelector.html#setNameConstraints(byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void SetNameConstraints(byte[] arg0)
        {
            IExecuteWithSignature("setNameConstraints", "([B)V", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/cert/X509CertSelector.html#setPathToNames(java.util.Collection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void SetPathToNames(Java.Util.Collection<Java.Util.List<object>> arg0)
        {
            IExecuteWithSignature("setPathToNames", "(Ljava/util/Collection;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/cert/X509CertSelector.html#setPolicy(java.util.Set)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Set"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void SetPolicy(Java.Util.Set<Java.Lang.String> arg0)
        {
            IExecuteWithSignature("setPolicy", "(Ljava/util/Set;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/cert/X509CertSelector.html#setPrivateKeyValid(java.util.Date)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Date"/></param>
        public void SetPrivateKeyValid(Java.Util.Date arg0)
        {
            IExecuteWithSignature("setPrivateKeyValid", "(Ljava/util/Date;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/cert/X509CertSelector.html#setSerialNumber(java.math.BigInteger)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Math.BigInteger"/></param>
        public void SetSerialNumber(Java.Math.BigInteger arg0)
        {
            IExecuteWithSignature("setSerialNumber", "(Ljava/math/BigInteger;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/cert/X509CertSelector.html#setSubject(byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void SetSubject(byte[] arg0)
        {
            IExecuteWithSignature("setSubject", "([B)V", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/cert/X509CertSelector.html#setSubject(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Java.Io.IOException"/>
        [global::System.Obsolete()]
        public void SetSubject(Java.Lang.String arg0)
        {
            IExecuteWithSignature("setSubject", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/cert/X509CertSelector.html#setSubject(javax.security.auth.x500.X500Principal)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Security.Auth.X500.X500Principal"/></param>
        public void SetSubject(Javax.Security.Auth.X500.X500Principal arg0)
        {
            IExecuteWithSignature("setSubject", "(Ljavax/security/auth/x500/X500Principal;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/cert/X509CertSelector.html#setSubjectAlternativeNames(java.util.Collection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void SetSubjectAlternativeNames(Java.Util.Collection<Java.Util.List<object>> arg0)
        {
            IExecuteWithSignature("setSubjectAlternativeNames", "(Ljava/util/Collection;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/cert/X509CertSelector.html#setSubjectKeyIdentifier(byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        public void SetSubjectKeyIdentifier(byte[] arg0)
        {
            IExecuteWithSignature("setSubjectKeyIdentifier", "([B)V", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/cert/X509CertSelector.html#setSubjectPublicKey(byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void SetSubjectPublicKey(byte[] arg0)
        {
            IExecuteWithSignature("setSubjectPublicKey", "([B)V", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/cert/X509CertSelector.html#setSubjectPublicKey(java.security.PublicKey)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.PublicKey"/></param>
        public void SetSubjectPublicKey(Java.Security.PublicKey arg0)
        {
            IExecuteWithSignature("setSubjectPublicKey", "(Ljava/security/PublicKey;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/cert/X509CertSelector.html#setSubjectPublicKeyAlgID(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void SetSubjectPublicKeyAlgID(Java.Lang.String arg0)
        {
            IExecuteWithSignature("setSubjectPublicKeyAlgID", "(Ljava/lang/String;)V", arg0);
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}