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

namespace Android.Net.Wifi.Aware
{
    #region AwarePairingConfig
    public partial class AwarePairingConfig
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/aware/AwarePairingConfig.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/aware/AwarePairingConfig.html#PAIRING_BOOTSTRAPPING_NFC_READER"/>
        /// </summary>
        public static int PAIRING_BOOTSTRAPPING_NFC_READER { get { if (!_PAIRING_BOOTSTRAPPING_NFC_READERReady) { _PAIRING_BOOTSTRAPPING_NFC_READERContent = SGetField<int>(LocalBridgeClazz, "PAIRING_BOOTSTRAPPING_NFC_READER"); _PAIRING_BOOTSTRAPPING_NFC_READERReady = true; } return _PAIRING_BOOTSTRAPPING_NFC_READERContent; } }
        private static int _PAIRING_BOOTSTRAPPING_NFC_READERContent = default;
        private static bool _PAIRING_BOOTSTRAPPING_NFC_READERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/aware/AwarePairingConfig.html#PAIRING_BOOTSTRAPPING_NFC_TAG"/>
        /// </summary>
        public static int PAIRING_BOOTSTRAPPING_NFC_TAG { get { if (!_PAIRING_BOOTSTRAPPING_NFC_TAGReady) { _PAIRING_BOOTSTRAPPING_NFC_TAGContent = SGetField<int>(LocalBridgeClazz, "PAIRING_BOOTSTRAPPING_NFC_TAG"); _PAIRING_BOOTSTRAPPING_NFC_TAGReady = true; } return _PAIRING_BOOTSTRAPPING_NFC_TAGContent; } }
        private static int _PAIRING_BOOTSTRAPPING_NFC_TAGContent = default;
        private static bool _PAIRING_BOOTSTRAPPING_NFC_TAGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/aware/AwarePairingConfig.html#PAIRING_BOOTSTRAPPING_OPPORTUNISTIC"/>
        /// </summary>
        public static int PAIRING_BOOTSTRAPPING_OPPORTUNISTIC { get { if (!_PAIRING_BOOTSTRAPPING_OPPORTUNISTICReady) { _PAIRING_BOOTSTRAPPING_OPPORTUNISTICContent = SGetField<int>(LocalBridgeClazz, "PAIRING_BOOTSTRAPPING_OPPORTUNISTIC"); _PAIRING_BOOTSTRAPPING_OPPORTUNISTICReady = true; } return _PAIRING_BOOTSTRAPPING_OPPORTUNISTICContent; } }
        private static int _PAIRING_BOOTSTRAPPING_OPPORTUNISTICContent = default;
        private static bool _PAIRING_BOOTSTRAPPING_OPPORTUNISTICReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/aware/AwarePairingConfig.html#PAIRING_BOOTSTRAPPING_PASSPHRASE_DISPLAY"/>
        /// </summary>
        public static int PAIRING_BOOTSTRAPPING_PASSPHRASE_DISPLAY { get { if (!_PAIRING_BOOTSTRAPPING_PASSPHRASE_DISPLAYReady) { _PAIRING_BOOTSTRAPPING_PASSPHRASE_DISPLAYContent = SGetField<int>(LocalBridgeClazz, "PAIRING_BOOTSTRAPPING_PASSPHRASE_DISPLAY"); _PAIRING_BOOTSTRAPPING_PASSPHRASE_DISPLAYReady = true; } return _PAIRING_BOOTSTRAPPING_PASSPHRASE_DISPLAYContent; } }
        private static int _PAIRING_BOOTSTRAPPING_PASSPHRASE_DISPLAYContent = default;
        private static bool _PAIRING_BOOTSTRAPPING_PASSPHRASE_DISPLAYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/aware/AwarePairingConfig.html#PAIRING_BOOTSTRAPPING_PASSPHRASE_KEYPAD"/>
        /// </summary>
        public static int PAIRING_BOOTSTRAPPING_PASSPHRASE_KEYPAD { get { if (!_PAIRING_BOOTSTRAPPING_PASSPHRASE_KEYPADReady) { _PAIRING_BOOTSTRAPPING_PASSPHRASE_KEYPADContent = SGetField<int>(LocalBridgeClazz, "PAIRING_BOOTSTRAPPING_PASSPHRASE_KEYPAD"); _PAIRING_BOOTSTRAPPING_PASSPHRASE_KEYPADReady = true; } return _PAIRING_BOOTSTRAPPING_PASSPHRASE_KEYPADContent; } }
        private static int _PAIRING_BOOTSTRAPPING_PASSPHRASE_KEYPADContent = default;
        private static bool _PAIRING_BOOTSTRAPPING_PASSPHRASE_KEYPADReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/aware/AwarePairingConfig.html#PAIRING_BOOTSTRAPPING_PIN_CODE_DISPLAY"/>
        /// </summary>
        public static int PAIRING_BOOTSTRAPPING_PIN_CODE_DISPLAY { get { if (!_PAIRING_BOOTSTRAPPING_PIN_CODE_DISPLAYReady) { _PAIRING_BOOTSTRAPPING_PIN_CODE_DISPLAYContent = SGetField<int>(LocalBridgeClazz, "PAIRING_BOOTSTRAPPING_PIN_CODE_DISPLAY"); _PAIRING_BOOTSTRAPPING_PIN_CODE_DISPLAYReady = true; } return _PAIRING_BOOTSTRAPPING_PIN_CODE_DISPLAYContent; } }
        private static int _PAIRING_BOOTSTRAPPING_PIN_CODE_DISPLAYContent = default;
        private static bool _PAIRING_BOOTSTRAPPING_PIN_CODE_DISPLAYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/aware/AwarePairingConfig.html#PAIRING_BOOTSTRAPPING_PIN_CODE_KEYPAD"/>
        /// </summary>
        public static int PAIRING_BOOTSTRAPPING_PIN_CODE_KEYPAD { get { if (!_PAIRING_BOOTSTRAPPING_PIN_CODE_KEYPADReady) { _PAIRING_BOOTSTRAPPING_PIN_CODE_KEYPADContent = SGetField<int>(LocalBridgeClazz, "PAIRING_BOOTSTRAPPING_PIN_CODE_KEYPAD"); _PAIRING_BOOTSTRAPPING_PIN_CODE_KEYPADReady = true; } return _PAIRING_BOOTSTRAPPING_PIN_CODE_KEYPADContent; } }
        private static int _PAIRING_BOOTSTRAPPING_PIN_CODE_KEYPADContent = default;
        private static bool _PAIRING_BOOTSTRAPPING_PIN_CODE_KEYPADReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/aware/AwarePairingConfig.html#PAIRING_BOOTSTRAPPING_QR_DISPLAY"/>
        /// </summary>
        public static int PAIRING_BOOTSTRAPPING_QR_DISPLAY { get { if (!_PAIRING_BOOTSTRAPPING_QR_DISPLAYReady) { _PAIRING_BOOTSTRAPPING_QR_DISPLAYContent = SGetField<int>(LocalBridgeClazz, "PAIRING_BOOTSTRAPPING_QR_DISPLAY"); _PAIRING_BOOTSTRAPPING_QR_DISPLAYReady = true; } return _PAIRING_BOOTSTRAPPING_QR_DISPLAYContent; } }
        private static int _PAIRING_BOOTSTRAPPING_QR_DISPLAYContent = default;
        private static bool _PAIRING_BOOTSTRAPPING_QR_DISPLAYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/aware/AwarePairingConfig.html#PAIRING_BOOTSTRAPPING_QR_SCAN"/>
        /// </summary>
        public static int PAIRING_BOOTSTRAPPING_QR_SCAN { get { if (!_PAIRING_BOOTSTRAPPING_QR_SCANReady) { _PAIRING_BOOTSTRAPPING_QR_SCANContent = SGetField<int>(LocalBridgeClazz, "PAIRING_BOOTSTRAPPING_QR_SCAN"); _PAIRING_BOOTSTRAPPING_QR_SCANReady = true; } return _PAIRING_BOOTSTRAPPING_QR_SCANContent; } }
        private static int _PAIRING_BOOTSTRAPPING_QR_SCANContent = default;
        private static bool _PAIRING_BOOTSTRAPPING_QR_SCANReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/aware/AwarePairingConfig.html#isPairingCacheEnabled()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsPairingCacheEnabled()
        {
            return IExecuteWithSignature<bool>("isPairingCacheEnabled", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/aware/AwarePairingConfig.html#isPairingSetupEnabled()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsPairingSetupEnabled()
        {
            return IExecuteWithSignature<bool>("isPairingSetupEnabled", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/aware/AwarePairingConfig.html#isPairingVerificationEnabled()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsPairingVerificationEnabled()
        {
            return IExecuteWithSignature<bool>("isPairingVerificationEnabled", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/aware/AwarePairingConfig.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/aware/AwarePairingConfig.html#getBootstrappingMethods()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetBootstrappingMethods()
        {
            return IExecuteWithSignature<int>("getBootstrappingMethods", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/aware/AwarePairingConfig.html#writeToParcel(android.os.Parcel,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void WriteToParcel(Android.Os.Parcel arg0, int arg1)
        {
            IExecute("writeToParcel", arg0, arg1);
        }

        #endregion

        #region Nested classes
        #region Builder
        public partial class Builder
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
            /// <see href="https://developer.android.com/reference/android/net/wifi/aware/AwarePairingConfig.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.Net.Wifi.Aware.AwarePairingConfig"/></returns>
            public Android.Net.Wifi.Aware.AwarePairingConfig Build()
            {
                return IExecuteWithSignature<Android.Net.Wifi.Aware.AwarePairingConfig>("build", "()Landroid/net/wifi/aware/AwarePairingConfig;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/wifi/aware/AwarePairingConfig.Builder.html#setBootstrappingMethods(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Net.Wifi.Aware.AwarePairingConfig.Builder"/></returns>
            public Android.Net.Wifi.Aware.AwarePairingConfig.Builder SetBootstrappingMethods(int arg0)
            {
                return IExecuteWithSignature<Android.Net.Wifi.Aware.AwarePairingConfig.Builder>("setBootstrappingMethods", "(I)Landroid/net/wifi/aware/AwarePairingConfig$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/wifi/aware/AwarePairingConfig.Builder.html#setPairingCacheEnabled(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.Net.Wifi.Aware.AwarePairingConfig.Builder"/></returns>
            public Android.Net.Wifi.Aware.AwarePairingConfig.Builder SetPairingCacheEnabled(bool arg0)
            {
                return IExecuteWithSignature<Android.Net.Wifi.Aware.AwarePairingConfig.Builder>("setPairingCacheEnabled", "(Z)Landroid/net/wifi/aware/AwarePairingConfig$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/wifi/aware/AwarePairingConfig.Builder.html#setPairingSetupEnabled(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.Net.Wifi.Aware.AwarePairingConfig.Builder"/></returns>
            public Android.Net.Wifi.Aware.AwarePairingConfig.Builder SetPairingSetupEnabled(bool arg0)
            {
                return IExecuteWithSignature<Android.Net.Wifi.Aware.AwarePairingConfig.Builder>("setPairingSetupEnabled", "(Z)Landroid/net/wifi/aware/AwarePairingConfig$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/wifi/aware/AwarePairingConfig.Builder.html#setPairingVerificationEnabled(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.Net.Wifi.Aware.AwarePairingConfig.Builder"/></returns>
            public Android.Net.Wifi.Aware.AwarePairingConfig.Builder SetPairingVerificationEnabled(bool arg0)
            {
                return IExecuteWithSignature<Android.Net.Wifi.Aware.AwarePairingConfig.Builder>("setPairingVerificationEnabled", "(Z)Landroid/net/wifi/aware/AwarePairingConfig$Builder;", arg0);
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