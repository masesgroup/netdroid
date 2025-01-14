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

namespace Android.Net.Sip
{
    #region SipErrorCode declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/net/sip/SipErrorCode.html"/>
    /// </summary>
    [global::System.Obsolete()]
    public partial class SipErrorCode : MASES.JCOBridge.C2JBridge.JVMBridgeBase<SipErrorCode>
    {
        const string _bridgeClassName = "android.net.sip.SipErrorCode";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public SipErrorCode() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public SipErrorCode(params object[] args) : base(args) { }
    
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

    #region SipErrorCode implementation
    public partial class SipErrorCode
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/sip/SipErrorCode.html#CLIENT_ERROR"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int CLIENT_ERROR { get { if (!_CLIENT_ERRORReady) { _CLIENT_ERRORContent = SGetField<int>(LocalBridgeClazz, "CLIENT_ERROR"); _CLIENT_ERRORReady = true; } return _CLIENT_ERRORContent; } }
        private static int _CLIENT_ERRORContent = default;
        private static bool _CLIENT_ERRORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/sip/SipErrorCode.html#CROSS_DOMAIN_AUTHENTICATION"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int CROSS_DOMAIN_AUTHENTICATION { get { if (!_CROSS_DOMAIN_AUTHENTICATIONReady) { _CROSS_DOMAIN_AUTHENTICATIONContent = SGetField<int>(LocalBridgeClazz, "CROSS_DOMAIN_AUTHENTICATION"); _CROSS_DOMAIN_AUTHENTICATIONReady = true; } return _CROSS_DOMAIN_AUTHENTICATIONContent; } }
        private static int _CROSS_DOMAIN_AUTHENTICATIONContent = default;
        private static bool _CROSS_DOMAIN_AUTHENTICATIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/sip/SipErrorCode.html#DATA_CONNECTION_LOST"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int DATA_CONNECTION_LOST { get { if (!_DATA_CONNECTION_LOSTReady) { _DATA_CONNECTION_LOSTContent = SGetField<int>(LocalBridgeClazz, "DATA_CONNECTION_LOST"); _DATA_CONNECTION_LOSTReady = true; } return _DATA_CONNECTION_LOSTContent; } }
        private static int _DATA_CONNECTION_LOSTContent = default;
        private static bool _DATA_CONNECTION_LOSTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/sip/SipErrorCode.html#IN_PROGRESS"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int IN_PROGRESS { get { if (!_IN_PROGRESSReady) { _IN_PROGRESSContent = SGetField<int>(LocalBridgeClazz, "IN_PROGRESS"); _IN_PROGRESSReady = true; } return _IN_PROGRESSContent; } }
        private static int _IN_PROGRESSContent = default;
        private static bool _IN_PROGRESSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/sip/SipErrorCode.html#INVALID_CREDENTIALS"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int INVALID_CREDENTIALS { get { if (!_INVALID_CREDENTIALSReady) { _INVALID_CREDENTIALSContent = SGetField<int>(LocalBridgeClazz, "INVALID_CREDENTIALS"); _INVALID_CREDENTIALSReady = true; } return _INVALID_CREDENTIALSContent; } }
        private static int _INVALID_CREDENTIALSContent = default;
        private static bool _INVALID_CREDENTIALSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/sip/SipErrorCode.html#INVALID_REMOTE_URI"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int INVALID_REMOTE_URI { get { if (!_INVALID_REMOTE_URIReady) { _INVALID_REMOTE_URIContent = SGetField<int>(LocalBridgeClazz, "INVALID_REMOTE_URI"); _INVALID_REMOTE_URIReady = true; } return _INVALID_REMOTE_URIContent; } }
        private static int _INVALID_REMOTE_URIContent = default;
        private static bool _INVALID_REMOTE_URIReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/sip/SipErrorCode.html#NO_ERROR"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int NO_ERROR { get { if (!_NO_ERRORReady) { _NO_ERRORContent = SGetField<int>(LocalBridgeClazz, "NO_ERROR"); _NO_ERRORReady = true; } return _NO_ERRORContent; } }
        private static int _NO_ERRORContent = default;
        private static bool _NO_ERRORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/sip/SipErrorCode.html#PEER_NOT_REACHABLE"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int PEER_NOT_REACHABLE { get { if (!_PEER_NOT_REACHABLEReady) { _PEER_NOT_REACHABLEContent = SGetField<int>(LocalBridgeClazz, "PEER_NOT_REACHABLE"); _PEER_NOT_REACHABLEReady = true; } return _PEER_NOT_REACHABLEContent; } }
        private static int _PEER_NOT_REACHABLEContent = default;
        private static bool _PEER_NOT_REACHABLEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/sip/SipErrorCode.html#SERVER_ERROR"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int SERVER_ERROR { get { if (!_SERVER_ERRORReady) { _SERVER_ERRORContent = SGetField<int>(LocalBridgeClazz, "SERVER_ERROR"); _SERVER_ERRORReady = true; } return _SERVER_ERRORContent; } }
        private static int _SERVER_ERRORContent = default;
        private static bool _SERVER_ERRORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/sip/SipErrorCode.html#SERVER_UNREACHABLE"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int SERVER_UNREACHABLE { get { if (!_SERVER_UNREACHABLEReady) { _SERVER_UNREACHABLEContent = SGetField<int>(LocalBridgeClazz, "SERVER_UNREACHABLE"); _SERVER_UNREACHABLEReady = true; } return _SERVER_UNREACHABLEContent; } }
        private static int _SERVER_UNREACHABLEContent = default;
        private static bool _SERVER_UNREACHABLEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/sip/SipErrorCode.html#SOCKET_ERROR"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int SOCKET_ERROR { get { if (!_SOCKET_ERRORReady) { _SOCKET_ERRORContent = SGetField<int>(LocalBridgeClazz, "SOCKET_ERROR"); _SOCKET_ERRORReady = true; } return _SOCKET_ERRORContent; } }
        private static int _SOCKET_ERRORContent = default;
        private static bool _SOCKET_ERRORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/sip/SipErrorCode.html#TIME_OUT"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int TIME_OUT { get { if (!_TIME_OUTReady) { _TIME_OUTContent = SGetField<int>(LocalBridgeClazz, "TIME_OUT"); _TIME_OUTReady = true; } return _TIME_OUTContent; } }
        private static int _TIME_OUTContent = default;
        private static bool _TIME_OUTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/sip/SipErrorCode.html#TRANSACTION_TERMINTED"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int TRANSACTION_TERMINTED { get { if (!_TRANSACTION_TERMINTEDReady) { _TRANSACTION_TERMINTEDContent = SGetField<int>(LocalBridgeClazz, "TRANSACTION_TERMINTED"); _TRANSACTION_TERMINTEDReady = true; } return _TRANSACTION_TERMINTEDContent; } }
        private static int _TRANSACTION_TERMINTEDContent = default;
        private static bool _TRANSACTION_TERMINTEDReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/sip/SipErrorCode.html#toString(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        [global::System.Obsolete()]
        public static Java.Lang.String ToString(int arg0)
        {
            return SExecuteWithSignature<Java.Lang.String>(LocalBridgeClazz, "toString", "(I)Ljava/lang/String;", arg0);
        }
    
        #endregion
    
        #region Instance methods
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}