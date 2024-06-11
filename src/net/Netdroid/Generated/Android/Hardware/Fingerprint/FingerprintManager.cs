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

namespace Android.Hardware.Fingerprint
{
    #region FingerprintManager
    public partial class FingerprintManager
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/fingerprint/FingerprintManager.html#FINGERPRINT_ACQUIRED_GOOD"/>
        /// </summary>
        public static int FINGERPRINT_ACQUIRED_GOOD { get { if (!_FINGERPRINT_ACQUIRED_GOODReady) { _FINGERPRINT_ACQUIRED_GOODContent = SGetField<int>(LocalBridgeClazz, "FINGERPRINT_ACQUIRED_GOOD"); _FINGERPRINT_ACQUIRED_GOODReady = true; } return _FINGERPRINT_ACQUIRED_GOODContent; } }
        private static int _FINGERPRINT_ACQUIRED_GOODContent = default;
        private static bool _FINGERPRINT_ACQUIRED_GOODReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/fingerprint/FingerprintManager.html#FINGERPRINT_ACQUIRED_IMAGER_DIRTY"/>
        /// </summary>
        public static int FINGERPRINT_ACQUIRED_IMAGER_DIRTY { get { if (!_FINGERPRINT_ACQUIRED_IMAGER_DIRTYReady) { _FINGERPRINT_ACQUIRED_IMAGER_DIRTYContent = SGetField<int>(LocalBridgeClazz, "FINGERPRINT_ACQUIRED_IMAGER_DIRTY"); _FINGERPRINT_ACQUIRED_IMAGER_DIRTYReady = true; } return _FINGERPRINT_ACQUIRED_IMAGER_DIRTYContent; } }
        private static int _FINGERPRINT_ACQUIRED_IMAGER_DIRTYContent = default;
        private static bool _FINGERPRINT_ACQUIRED_IMAGER_DIRTYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/fingerprint/FingerprintManager.html#FINGERPRINT_ACQUIRED_INSUFFICIENT"/>
        /// </summary>
        public static int FINGERPRINT_ACQUIRED_INSUFFICIENT { get { if (!_FINGERPRINT_ACQUIRED_INSUFFICIENTReady) { _FINGERPRINT_ACQUIRED_INSUFFICIENTContent = SGetField<int>(LocalBridgeClazz, "FINGERPRINT_ACQUIRED_INSUFFICIENT"); _FINGERPRINT_ACQUIRED_INSUFFICIENTReady = true; } return _FINGERPRINT_ACQUIRED_INSUFFICIENTContent; } }
        private static int _FINGERPRINT_ACQUIRED_INSUFFICIENTContent = default;
        private static bool _FINGERPRINT_ACQUIRED_INSUFFICIENTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/fingerprint/FingerprintManager.html#FINGERPRINT_ACQUIRED_PARTIAL"/>
        /// </summary>
        public static int FINGERPRINT_ACQUIRED_PARTIAL { get { if (!_FINGERPRINT_ACQUIRED_PARTIALReady) { _FINGERPRINT_ACQUIRED_PARTIALContent = SGetField<int>(LocalBridgeClazz, "FINGERPRINT_ACQUIRED_PARTIAL"); _FINGERPRINT_ACQUIRED_PARTIALReady = true; } return _FINGERPRINT_ACQUIRED_PARTIALContent; } }
        private static int _FINGERPRINT_ACQUIRED_PARTIALContent = default;
        private static bool _FINGERPRINT_ACQUIRED_PARTIALReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/fingerprint/FingerprintManager.html#FINGERPRINT_ACQUIRED_TOO_FAST"/>
        /// </summary>
        public static int FINGERPRINT_ACQUIRED_TOO_FAST { get { if (!_FINGERPRINT_ACQUIRED_TOO_FASTReady) { _FINGERPRINT_ACQUIRED_TOO_FASTContent = SGetField<int>(LocalBridgeClazz, "FINGERPRINT_ACQUIRED_TOO_FAST"); _FINGERPRINT_ACQUIRED_TOO_FASTReady = true; } return _FINGERPRINT_ACQUIRED_TOO_FASTContent; } }
        private static int _FINGERPRINT_ACQUIRED_TOO_FASTContent = default;
        private static bool _FINGERPRINT_ACQUIRED_TOO_FASTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/fingerprint/FingerprintManager.html#FINGERPRINT_ACQUIRED_TOO_SLOW"/>
        /// </summary>
        public static int FINGERPRINT_ACQUIRED_TOO_SLOW { get { if (!_FINGERPRINT_ACQUIRED_TOO_SLOWReady) { _FINGERPRINT_ACQUIRED_TOO_SLOWContent = SGetField<int>(LocalBridgeClazz, "FINGERPRINT_ACQUIRED_TOO_SLOW"); _FINGERPRINT_ACQUIRED_TOO_SLOWReady = true; } return _FINGERPRINT_ACQUIRED_TOO_SLOWContent; } }
        private static int _FINGERPRINT_ACQUIRED_TOO_SLOWContent = default;
        private static bool _FINGERPRINT_ACQUIRED_TOO_SLOWReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/fingerprint/FingerprintManager.html#FINGERPRINT_ERROR_CANCELED"/>
        /// </summary>
        public static int FINGERPRINT_ERROR_CANCELED { get { if (!_FINGERPRINT_ERROR_CANCELEDReady) { _FINGERPRINT_ERROR_CANCELEDContent = SGetField<int>(LocalBridgeClazz, "FINGERPRINT_ERROR_CANCELED"); _FINGERPRINT_ERROR_CANCELEDReady = true; } return _FINGERPRINT_ERROR_CANCELEDContent; } }
        private static int _FINGERPRINT_ERROR_CANCELEDContent = default;
        private static bool _FINGERPRINT_ERROR_CANCELEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/fingerprint/FingerprintManager.html#FINGERPRINT_ERROR_HW_NOT_PRESENT"/>
        /// </summary>
        public static int FINGERPRINT_ERROR_HW_NOT_PRESENT { get { if (!_FINGERPRINT_ERROR_HW_NOT_PRESENTReady) { _FINGERPRINT_ERROR_HW_NOT_PRESENTContent = SGetField<int>(LocalBridgeClazz, "FINGERPRINT_ERROR_HW_NOT_PRESENT"); _FINGERPRINT_ERROR_HW_NOT_PRESENTReady = true; } return _FINGERPRINT_ERROR_HW_NOT_PRESENTContent; } }
        private static int _FINGERPRINT_ERROR_HW_NOT_PRESENTContent = default;
        private static bool _FINGERPRINT_ERROR_HW_NOT_PRESENTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/fingerprint/FingerprintManager.html#FINGERPRINT_ERROR_HW_UNAVAILABLE"/>
        /// </summary>
        public static int FINGERPRINT_ERROR_HW_UNAVAILABLE { get { if (!_FINGERPRINT_ERROR_HW_UNAVAILABLEReady) { _FINGERPRINT_ERROR_HW_UNAVAILABLEContent = SGetField<int>(LocalBridgeClazz, "FINGERPRINT_ERROR_HW_UNAVAILABLE"); _FINGERPRINT_ERROR_HW_UNAVAILABLEReady = true; } return _FINGERPRINT_ERROR_HW_UNAVAILABLEContent; } }
        private static int _FINGERPRINT_ERROR_HW_UNAVAILABLEContent = default;
        private static bool _FINGERPRINT_ERROR_HW_UNAVAILABLEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/fingerprint/FingerprintManager.html#FINGERPRINT_ERROR_LOCKOUT"/>
        /// </summary>
        public static int FINGERPRINT_ERROR_LOCKOUT { get { if (!_FINGERPRINT_ERROR_LOCKOUTReady) { _FINGERPRINT_ERROR_LOCKOUTContent = SGetField<int>(LocalBridgeClazz, "FINGERPRINT_ERROR_LOCKOUT"); _FINGERPRINT_ERROR_LOCKOUTReady = true; } return _FINGERPRINT_ERROR_LOCKOUTContent; } }
        private static int _FINGERPRINT_ERROR_LOCKOUTContent = default;
        private static bool _FINGERPRINT_ERROR_LOCKOUTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/fingerprint/FingerprintManager.html#FINGERPRINT_ERROR_LOCKOUT_PERMANENT"/>
        /// </summary>
        public static int FINGERPRINT_ERROR_LOCKOUT_PERMANENT { get { if (!_FINGERPRINT_ERROR_LOCKOUT_PERMANENTReady) { _FINGERPRINT_ERROR_LOCKOUT_PERMANENTContent = SGetField<int>(LocalBridgeClazz, "FINGERPRINT_ERROR_LOCKOUT_PERMANENT"); _FINGERPRINT_ERROR_LOCKOUT_PERMANENTReady = true; } return _FINGERPRINT_ERROR_LOCKOUT_PERMANENTContent; } }
        private static int _FINGERPRINT_ERROR_LOCKOUT_PERMANENTContent = default;
        private static bool _FINGERPRINT_ERROR_LOCKOUT_PERMANENTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/fingerprint/FingerprintManager.html#FINGERPRINT_ERROR_NO_FINGERPRINTS"/>
        /// </summary>
        public static int FINGERPRINT_ERROR_NO_FINGERPRINTS { get { if (!_FINGERPRINT_ERROR_NO_FINGERPRINTSReady) { _FINGERPRINT_ERROR_NO_FINGERPRINTSContent = SGetField<int>(LocalBridgeClazz, "FINGERPRINT_ERROR_NO_FINGERPRINTS"); _FINGERPRINT_ERROR_NO_FINGERPRINTSReady = true; } return _FINGERPRINT_ERROR_NO_FINGERPRINTSContent; } }
        private static int _FINGERPRINT_ERROR_NO_FINGERPRINTSContent = default;
        private static bool _FINGERPRINT_ERROR_NO_FINGERPRINTSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/fingerprint/FingerprintManager.html#FINGERPRINT_ERROR_NO_SPACE"/>
        /// </summary>
        public static int FINGERPRINT_ERROR_NO_SPACE { get { if (!_FINGERPRINT_ERROR_NO_SPACEReady) { _FINGERPRINT_ERROR_NO_SPACEContent = SGetField<int>(LocalBridgeClazz, "FINGERPRINT_ERROR_NO_SPACE"); _FINGERPRINT_ERROR_NO_SPACEReady = true; } return _FINGERPRINT_ERROR_NO_SPACEContent; } }
        private static int _FINGERPRINT_ERROR_NO_SPACEContent = default;
        private static bool _FINGERPRINT_ERROR_NO_SPACEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/fingerprint/FingerprintManager.html#FINGERPRINT_ERROR_TIMEOUT"/>
        /// </summary>
        public static int FINGERPRINT_ERROR_TIMEOUT { get { if (!_FINGERPRINT_ERROR_TIMEOUTReady) { _FINGERPRINT_ERROR_TIMEOUTContent = SGetField<int>(LocalBridgeClazz, "FINGERPRINT_ERROR_TIMEOUT"); _FINGERPRINT_ERROR_TIMEOUTReady = true; } return _FINGERPRINT_ERROR_TIMEOUTContent; } }
        private static int _FINGERPRINT_ERROR_TIMEOUTContent = default;
        private static bool _FINGERPRINT_ERROR_TIMEOUTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/fingerprint/FingerprintManager.html#FINGERPRINT_ERROR_UNABLE_TO_PROCESS"/>
        /// </summary>
        public static int FINGERPRINT_ERROR_UNABLE_TO_PROCESS { get { if (!_FINGERPRINT_ERROR_UNABLE_TO_PROCESSReady) { _FINGERPRINT_ERROR_UNABLE_TO_PROCESSContent = SGetField<int>(LocalBridgeClazz, "FINGERPRINT_ERROR_UNABLE_TO_PROCESS"); _FINGERPRINT_ERROR_UNABLE_TO_PROCESSReady = true; } return _FINGERPRINT_ERROR_UNABLE_TO_PROCESSContent; } }
        private static int _FINGERPRINT_ERROR_UNABLE_TO_PROCESSContent = default;
        private static bool _FINGERPRINT_ERROR_UNABLE_TO_PROCESSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/fingerprint/FingerprintManager.html#FINGERPRINT_ERROR_USER_CANCELED"/>
        /// </summary>
        public static int FINGERPRINT_ERROR_USER_CANCELED { get { if (!_FINGERPRINT_ERROR_USER_CANCELEDReady) { _FINGERPRINT_ERROR_USER_CANCELEDContent = SGetField<int>(LocalBridgeClazz, "FINGERPRINT_ERROR_USER_CANCELED"); _FINGERPRINT_ERROR_USER_CANCELEDReady = true; } return _FINGERPRINT_ERROR_USER_CANCELEDContent; } }
        private static int _FINGERPRINT_ERROR_USER_CANCELEDContent = default;
        private static bool _FINGERPRINT_ERROR_USER_CANCELEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/fingerprint/FingerprintManager.html#FINGERPRINT_ERROR_VENDOR"/>
        /// </summary>
        public static int FINGERPRINT_ERROR_VENDOR { get { if (!_FINGERPRINT_ERROR_VENDORReady) { _FINGERPRINT_ERROR_VENDORContent = SGetField<int>(LocalBridgeClazz, "FINGERPRINT_ERROR_VENDOR"); _FINGERPRINT_ERROR_VENDORReady = true; } return _FINGERPRINT_ERROR_VENDORContent; } }
        private static int _FINGERPRINT_ERROR_VENDORContent = default;
        private static bool _FINGERPRINT_ERROR_VENDORReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/fingerprint/FingerprintManager.html#hasEnrolledFingerprints()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        [global::System.Obsolete()]
        public bool HasEnrolledFingerprints()
        {
            return IExecuteWithSignature<bool>("hasEnrolledFingerprints", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/fingerprint/FingerprintManager.html#isHardwareDetected()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        [global::System.Obsolete()]
        public bool IsHardwareDetected()
        {
            return IExecuteWithSignature<bool>("isHardwareDetected", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/fingerprint/FingerprintManager.html#authenticate(android.hardware.fingerprint.FingerprintManager.CryptoObject,android.os.CancellationSignal,int,android.hardware.fingerprint.FingerprintManager.AuthenticationCallback,android.os.Handler)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Hardware.Fingerprint.FingerprintManager.CryptoObject"/></param>
        /// <param name="arg1"><see cref="Android.Os.CancellationSignal"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="Android.Hardware.Fingerprint.FingerprintManager.AuthenticationCallback"/></param>
        /// <param name="arg4"><see cref="Android.Os.Handler"/></param>
        [global::System.Obsolete()]
        public void Authenticate(Android.Hardware.Fingerprint.FingerprintManager.CryptoObject arg0, Android.Os.CancellationSignal arg1, int arg2, Android.Hardware.Fingerprint.FingerprintManager.AuthenticationCallback arg3, Android.Os.Handler arg4)
        {
            IExecute("authenticate", arg0, arg1, arg2, arg3, arg4);
        }

        #endregion

        #region Nested classes
        #region AuthenticationCallback
        public partial class AuthenticationCallback
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
            /// <see href="https://developer.android.com/reference/android/hardware/fingerprint/FingerprintManager.AuthenticationCallback.html#onAuthenticationError(int,java.lang.CharSequence)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <param name="arg1"><see cref="Java.Lang.CharSequence"/></param>
            [global::System.Obsolete()]
            public void OnAuthenticationError(int arg0, Java.Lang.CharSequence arg1)
            {
                IExecute("onAuthenticationError", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/hardware/fingerprint/FingerprintManager.AuthenticationCallback.html#onAuthenticationFailed()"/>
            /// </summary>
            [global::System.Obsolete()]
            public void OnAuthenticationFailed()
            {
                IExecuteWithSignature("onAuthenticationFailed", "()V");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/hardware/fingerprint/FingerprintManager.AuthenticationCallback.html#onAuthenticationHelp(int,java.lang.CharSequence)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <param name="arg1"><see cref="Java.Lang.CharSequence"/></param>
            [global::System.Obsolete()]
            public void OnAuthenticationHelp(int arg0, Java.Lang.CharSequence arg1)
            {
                IExecute("onAuthenticationHelp", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/hardware/fingerprint/FingerprintManager.AuthenticationCallback.html#onAuthenticationSucceeded(android.hardware.fingerprint.FingerprintManager.AuthenticationResult)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Hardware.Fingerprint.FingerprintManager.AuthenticationResult"/></param>
            [global::System.Obsolete()]
            public void OnAuthenticationSucceeded(Android.Hardware.Fingerprint.FingerprintManager.AuthenticationResult arg0)
            {
                IExecuteWithSignature("onAuthenticationSucceeded", "(Landroid/hardware/fingerprint/FingerprintManager$AuthenticationResult;)V", arg0);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region AuthenticationResult
        public partial class AuthenticationResult
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
            /// <see href="https://developer.android.com/reference/android/hardware/fingerprint/FingerprintManager.AuthenticationResult.html#getCryptoObject()"/>
            /// </summary>
            /// <returns><see cref="Android.Hardware.Fingerprint.FingerprintManager.CryptoObject"/></returns>
            [global::System.Obsolete()]
            public Android.Hardware.Fingerprint.FingerprintManager.CryptoObject GetCryptoObject()
            {
                return IExecuteWithSignature<Android.Hardware.Fingerprint.FingerprintManager.CryptoObject>("getCryptoObject", "()Landroid/hardware/fingerprint/FingerprintManager$CryptoObject;");
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region CryptoObject
        public partial class CryptoObject
        {
            #region Constructors
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/hardware/fingerprint/FingerprintManager.CryptoObject.html#%3Cinit%3E(java.security.Signature)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Security.Signature"/></param>
            [global::System.Obsolete()]
            public CryptoObject(Java.Security.Signature arg0)
                : base(arg0)
            {
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/hardware/fingerprint/FingerprintManager.CryptoObject.html#%3Cinit%3E(javax.crypto.Cipher)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Crypto.Cipher"/></param>
            [global::System.Obsolete()]
            public CryptoObject(Javax.Crypto.Cipher arg0)
                : base(arg0)
            {
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/hardware/fingerprint/FingerprintManager.CryptoObject.html#%3Cinit%3E(javax.crypto.Mac)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Crypto.Mac"/></param>
            [global::System.Obsolete()]
            public CryptoObject(Javax.Crypto.Mac arg0)
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
            /// <see href="https://developer.android.com/reference/android/hardware/fingerprint/FingerprintManager.CryptoObject.html#getSignature()"/>
            /// </summary>
            /// <returns><see cref="Java.Security.Signature"/></returns>
            [global::System.Obsolete()]
            public Java.Security.Signature GetSignature()
            {
                return IExecuteWithSignature<Java.Security.Signature>("getSignature", "()Ljava/security/Signature;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/hardware/fingerprint/FingerprintManager.CryptoObject.html#getCipher()"/>
            /// </summary>
            /// <returns><see cref="Javax.Crypto.Cipher"/></returns>
            [global::System.Obsolete()]
            public Javax.Crypto.Cipher GetCipher()
            {
                return IExecuteWithSignature<Javax.Crypto.Cipher>("getCipher", "()Ljavax/crypto/Cipher;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/hardware/fingerprint/FingerprintManager.CryptoObject.html#getMac()"/>
            /// </summary>
            /// <returns><see cref="Javax.Crypto.Mac"/></returns>
            [global::System.Obsolete()]
            public Javax.Crypto.Mac GetMac()
            {
                return IExecuteWithSignature<Javax.Crypto.Mac>("getMac", "()Ljavax/crypto/Mac;");
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