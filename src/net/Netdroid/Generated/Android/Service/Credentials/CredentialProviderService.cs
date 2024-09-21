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

namespace Android.Service.Credentials
{
    #region CredentialProviderService declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/service/credentials/CredentialProviderService.html"/>
    /// </summary>
    public partial class CredentialProviderService : Android.App.Service
    {
        const string _bridgeClassName = "android.service.credentials.CredentialProviderService";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("CredentialProviderService class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public CredentialProviderService() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("CredentialProviderService class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public CredentialProviderService(params object[] args) : base(args) { }

        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
        /// </summary>
        public override bool IsBridgeAbstract => true;
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

    #region CredentialProviderService implementation
    public partial class CredentialProviderService
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/credentials/CredentialProviderService.html#EXTRA_BEGIN_GET_CREDENTIAL_REQUEST"/>
        /// </summary>
        public static Java.Lang.String EXTRA_BEGIN_GET_CREDENTIAL_REQUEST { get { if (!_EXTRA_BEGIN_GET_CREDENTIAL_REQUESTReady) { _EXTRA_BEGIN_GET_CREDENTIAL_REQUESTContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_BEGIN_GET_CREDENTIAL_REQUEST"); _EXTRA_BEGIN_GET_CREDENTIAL_REQUESTReady = true; } return _EXTRA_BEGIN_GET_CREDENTIAL_REQUESTContent; } }
        private static Java.Lang.String _EXTRA_BEGIN_GET_CREDENTIAL_REQUESTContent = default;
        private static bool _EXTRA_BEGIN_GET_CREDENTIAL_REQUESTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/credentials/CredentialProviderService.html#EXTRA_BEGIN_GET_CREDENTIAL_RESPONSE"/>
        /// </summary>
        public static Java.Lang.String EXTRA_BEGIN_GET_CREDENTIAL_RESPONSE { get { if (!_EXTRA_BEGIN_GET_CREDENTIAL_RESPONSEReady) { _EXTRA_BEGIN_GET_CREDENTIAL_RESPONSEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_BEGIN_GET_CREDENTIAL_RESPONSE"); _EXTRA_BEGIN_GET_CREDENTIAL_RESPONSEReady = true; } return _EXTRA_BEGIN_GET_CREDENTIAL_RESPONSEContent; } }
        private static Java.Lang.String _EXTRA_BEGIN_GET_CREDENTIAL_RESPONSEContent = default;
        private static bool _EXTRA_BEGIN_GET_CREDENTIAL_RESPONSEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/credentials/CredentialProviderService.html#EXTRA_CREATE_CREDENTIAL_EXCEPTION"/>
        /// </summary>
        public static Java.Lang.String EXTRA_CREATE_CREDENTIAL_EXCEPTION { get { if (!_EXTRA_CREATE_CREDENTIAL_EXCEPTIONReady) { _EXTRA_CREATE_CREDENTIAL_EXCEPTIONContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_CREATE_CREDENTIAL_EXCEPTION"); _EXTRA_CREATE_CREDENTIAL_EXCEPTIONReady = true; } return _EXTRA_CREATE_CREDENTIAL_EXCEPTIONContent; } }
        private static Java.Lang.String _EXTRA_CREATE_CREDENTIAL_EXCEPTIONContent = default;
        private static bool _EXTRA_CREATE_CREDENTIAL_EXCEPTIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/credentials/CredentialProviderService.html#EXTRA_CREATE_CREDENTIAL_REQUEST"/>
        /// </summary>
        public static Java.Lang.String EXTRA_CREATE_CREDENTIAL_REQUEST { get { if (!_EXTRA_CREATE_CREDENTIAL_REQUESTReady) { _EXTRA_CREATE_CREDENTIAL_REQUESTContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_CREATE_CREDENTIAL_REQUEST"); _EXTRA_CREATE_CREDENTIAL_REQUESTReady = true; } return _EXTRA_CREATE_CREDENTIAL_REQUESTContent; } }
        private static Java.Lang.String _EXTRA_CREATE_CREDENTIAL_REQUESTContent = default;
        private static bool _EXTRA_CREATE_CREDENTIAL_REQUESTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/credentials/CredentialProviderService.html#EXTRA_CREATE_CREDENTIAL_RESPONSE"/>
        /// </summary>
        public static Java.Lang.String EXTRA_CREATE_CREDENTIAL_RESPONSE { get { if (!_EXTRA_CREATE_CREDENTIAL_RESPONSEReady) { _EXTRA_CREATE_CREDENTIAL_RESPONSEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_CREATE_CREDENTIAL_RESPONSE"); _EXTRA_CREATE_CREDENTIAL_RESPONSEReady = true; } return _EXTRA_CREATE_CREDENTIAL_RESPONSEContent; } }
        private static Java.Lang.String _EXTRA_CREATE_CREDENTIAL_RESPONSEContent = default;
        private static bool _EXTRA_CREATE_CREDENTIAL_RESPONSEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/credentials/CredentialProviderService.html#EXTRA_GET_CREDENTIAL_EXCEPTION"/>
        /// </summary>
        public static Java.Lang.String EXTRA_GET_CREDENTIAL_EXCEPTION { get { if (!_EXTRA_GET_CREDENTIAL_EXCEPTIONReady) { _EXTRA_GET_CREDENTIAL_EXCEPTIONContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_GET_CREDENTIAL_EXCEPTION"); _EXTRA_GET_CREDENTIAL_EXCEPTIONReady = true; } return _EXTRA_GET_CREDENTIAL_EXCEPTIONContent; } }
        private static Java.Lang.String _EXTRA_GET_CREDENTIAL_EXCEPTIONContent = default;
        private static bool _EXTRA_GET_CREDENTIAL_EXCEPTIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/credentials/CredentialProviderService.html#EXTRA_GET_CREDENTIAL_REQUEST"/>
        /// </summary>
        public static Java.Lang.String EXTRA_GET_CREDENTIAL_REQUEST { get { if (!_EXTRA_GET_CREDENTIAL_REQUESTReady) { _EXTRA_GET_CREDENTIAL_REQUESTContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_GET_CREDENTIAL_REQUEST"); _EXTRA_GET_CREDENTIAL_REQUESTReady = true; } return _EXTRA_GET_CREDENTIAL_REQUESTContent; } }
        private static Java.Lang.String _EXTRA_GET_CREDENTIAL_REQUESTContent = default;
        private static bool _EXTRA_GET_CREDENTIAL_REQUESTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/credentials/CredentialProviderService.html#EXTRA_GET_CREDENTIAL_RESPONSE"/>
        /// </summary>
        public static Java.Lang.String EXTRA_GET_CREDENTIAL_RESPONSE { get { if (!_EXTRA_GET_CREDENTIAL_RESPONSEReady) { _EXTRA_GET_CREDENTIAL_RESPONSEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_GET_CREDENTIAL_RESPONSE"); _EXTRA_GET_CREDENTIAL_RESPONSEReady = true; } return _EXTRA_GET_CREDENTIAL_RESPONSEContent; } }
        private static Java.Lang.String _EXTRA_GET_CREDENTIAL_RESPONSEContent = default;
        private static bool _EXTRA_GET_CREDENTIAL_RESPONSEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/credentials/CredentialProviderService.html#SERVICE_INTERFACE"/>
        /// </summary>
        public static Java.Lang.String SERVICE_INTERFACE { get { if (!_SERVICE_INTERFACEReady) { _SERVICE_INTERFACEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "SERVICE_INTERFACE"); _SERVICE_INTERFACEReady = true; } return _SERVICE_INTERFACEContent; } }
        private static Java.Lang.String _SERVICE_INTERFACEContent = default;
        private static bool _SERVICE_INTERFACEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/credentials/CredentialProviderService.html#SERVICE_META_DATA"/>
        /// </summary>
        public static Java.Lang.String SERVICE_META_DATA { get { if (!_SERVICE_META_DATAReady) { _SERVICE_META_DATAContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "SERVICE_META_DATA"); _SERVICE_META_DATAReady = true; } return _SERVICE_META_DATAContent; } }
        private static Java.Lang.String _SERVICE_META_DATAContent = default;
        private static bool _SERVICE_META_DATAReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/credentials/CredentialProviderService.html#onBeginCreateCredential(android.service.credentials.BeginCreateCredentialRequest,android.os.CancellationSignal,android.os.OutcomeReceiver)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Service.Credentials.BeginCreateCredentialRequest"/></param>
        /// <param name="arg1"><see cref="Android.Os.CancellationSignal"/></param>
        /// <param name="arg2"><see cref="Android.Os.OutcomeReceiver"/></param>
        public void OnBeginCreateCredential(Android.Service.Credentials.BeginCreateCredentialRequest arg0, Android.Os.CancellationSignal arg1, Android.Os.OutcomeReceiver<Android.Service.Credentials.BeginCreateCredentialResponse, Android.Credentials.CreateCredentialException> arg2)
        {
            IExecute("onBeginCreateCredential", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/credentials/CredentialProviderService.html#onBeginGetCredential(android.service.credentials.BeginGetCredentialRequest,android.os.CancellationSignal,android.os.OutcomeReceiver)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Service.Credentials.BeginGetCredentialRequest"/></param>
        /// <param name="arg1"><see cref="Android.Os.CancellationSignal"/></param>
        /// <param name="arg2"><see cref="Android.Os.OutcomeReceiver"/></param>
        public void OnBeginGetCredential(Android.Service.Credentials.BeginGetCredentialRequest arg0, Android.Os.CancellationSignal arg1, Android.Os.OutcomeReceiver<Android.Service.Credentials.BeginGetCredentialResponse, Android.Credentials.GetCredentialException> arg2)
        {
            IExecute("onBeginGetCredential", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/credentials/CredentialProviderService.html#onClearCredentialState(android.service.credentials.ClearCredentialStateRequest,android.os.CancellationSignal,android.os.OutcomeReceiver)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Service.Credentials.ClearCredentialStateRequest"/></param>
        /// <param name="arg1"><see cref="Android.Os.CancellationSignal"/></param>
        /// <param name="arg2"><see cref="Android.Os.OutcomeReceiver"/></param>
        public void OnClearCredentialState(Android.Service.Credentials.ClearCredentialStateRequest arg0, Android.Os.CancellationSignal arg1, Android.Os.OutcomeReceiver<Java.Lang.Void, Android.Credentials.ClearCredentialStateException> arg2)
        {
            IExecute("onClearCredentialState", arg0, arg1, arg2);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}