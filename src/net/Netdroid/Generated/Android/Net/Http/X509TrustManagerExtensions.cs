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
*  This file is generated by MASES.JNetReflector (ver. 2.5.9.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Net.Http
{
    #region X509TrustManagerExtensions declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/net/http/X509TrustManagerExtensions.html"/>
    /// </summary>
    public partial class X509TrustManagerExtensions : MASES.JCOBridge.C2JBridge.JVMBridgeBase<X509TrustManagerExtensions>
    {
        const string _bridgeClassName = "android.net.http.X509TrustManagerExtensions";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public X509TrustManagerExtensions() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public X509TrustManagerExtensions(params object[] args) : base(args) { }
    
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

    #region X509TrustManagerExtensions implementation
    public partial class X509TrustManagerExtensions
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/http/X509TrustManagerExtensions.html#%3Cinit%3E(javax.net.ssl.X509TrustManager)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Net.Ssl.X509TrustManager"/></param>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        public X509TrustManagerExtensions(Javax.Net.Ssl.X509TrustManager arg0)
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
        /// <see href="https://developer.android.com/reference/android/net/http/X509TrustManagerExtensions.html#isSameTrustConfiguration(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsSameTrustConfiguration(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            return IExecute<bool>("isSameTrustConfiguration", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/http/X509TrustManagerExtensions.html#isUserAddedCertificate(java.security.cert.X509Certificate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.Cert.X509Certificate"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsUserAddedCertificate(Java.Security.Cert.X509Certificate arg0)
        {
            return IExecuteWithSignature<bool>("isUserAddedCertificate", "(Ljava/security/cert/X509Certificate;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/http/X509TrustManagerExtensions.html#checkServerTrusted(java.security.cert.X509Certificate[],java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.Cert.X509Certificate"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Util.List"/></returns>
        /// <exception cref="Java.Security.Cert.CertificateException"/>
        public Java.Util.List<Java.Security.Cert.X509Certificate> CheckServerTrusted(Java.Security.Cert.X509Certificate[] arg0, Java.Lang.String arg1, Java.Lang.String arg2)
        {
            return IExecute<Java.Util.List<Java.Security.Cert.X509Certificate>>("checkServerTrusted", arg0, arg1, arg2);
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}