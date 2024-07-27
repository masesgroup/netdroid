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
*  This file is generated by MASES.JNetReflector (ver. 2.5.4.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Nfc
{
    #region NfcAdapter
    public partial class NfcAdapter
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/NfcAdapter.html#FLAG_LISTEN_DISABLE"/>
        /// </summary>
        public static int FLAG_LISTEN_DISABLE { get { if (!_FLAG_LISTEN_DISABLEReady) { _FLAG_LISTEN_DISABLEContent = SGetField<int>(LocalBridgeClazz, "FLAG_LISTEN_DISABLE"); _FLAG_LISTEN_DISABLEReady = true; } return _FLAG_LISTEN_DISABLEContent; } }
        private static int _FLAG_LISTEN_DISABLEContent = default;
        private static bool _FLAG_LISTEN_DISABLEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/NfcAdapter.html#FLAG_LISTEN_KEEP"/>
        /// </summary>
        public static int FLAG_LISTEN_KEEP { get { if (!_FLAG_LISTEN_KEEPReady) { _FLAG_LISTEN_KEEPContent = SGetField<int>(LocalBridgeClazz, "FLAG_LISTEN_KEEP"); _FLAG_LISTEN_KEEPReady = true; } return _FLAG_LISTEN_KEEPContent; } }
        private static int _FLAG_LISTEN_KEEPContent = default;
        private static bool _FLAG_LISTEN_KEEPReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/NfcAdapter.html#FLAG_LISTEN_NFC_PASSIVE_A"/>
        /// </summary>
        public static int FLAG_LISTEN_NFC_PASSIVE_A { get { if (!_FLAG_LISTEN_NFC_PASSIVE_AReady) { _FLAG_LISTEN_NFC_PASSIVE_AContent = SGetField<int>(LocalBridgeClazz, "FLAG_LISTEN_NFC_PASSIVE_A"); _FLAG_LISTEN_NFC_PASSIVE_AReady = true; } return _FLAG_LISTEN_NFC_PASSIVE_AContent; } }
        private static int _FLAG_LISTEN_NFC_PASSIVE_AContent = default;
        private static bool _FLAG_LISTEN_NFC_PASSIVE_AReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/NfcAdapter.html#FLAG_LISTEN_NFC_PASSIVE_B"/>
        /// </summary>
        public static int FLAG_LISTEN_NFC_PASSIVE_B { get { if (!_FLAG_LISTEN_NFC_PASSIVE_BReady) { _FLAG_LISTEN_NFC_PASSIVE_BContent = SGetField<int>(LocalBridgeClazz, "FLAG_LISTEN_NFC_PASSIVE_B"); _FLAG_LISTEN_NFC_PASSIVE_BReady = true; } return _FLAG_LISTEN_NFC_PASSIVE_BContent; } }
        private static int _FLAG_LISTEN_NFC_PASSIVE_BContent = default;
        private static bool _FLAG_LISTEN_NFC_PASSIVE_BReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/NfcAdapter.html#FLAG_LISTEN_NFC_PASSIVE_F"/>
        /// </summary>
        public static int FLAG_LISTEN_NFC_PASSIVE_F { get { if (!_FLAG_LISTEN_NFC_PASSIVE_FReady) { _FLAG_LISTEN_NFC_PASSIVE_FContent = SGetField<int>(LocalBridgeClazz, "FLAG_LISTEN_NFC_PASSIVE_F"); _FLAG_LISTEN_NFC_PASSIVE_FReady = true; } return _FLAG_LISTEN_NFC_PASSIVE_FContent; } }
        private static int _FLAG_LISTEN_NFC_PASSIVE_FContent = default;
        private static bool _FLAG_LISTEN_NFC_PASSIVE_FReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/NfcAdapter.html#FLAG_READER_DISABLE"/>
        /// </summary>
        public static int FLAG_READER_DISABLE { get { if (!_FLAG_READER_DISABLEReady) { _FLAG_READER_DISABLEContent = SGetField<int>(LocalBridgeClazz, "FLAG_READER_DISABLE"); _FLAG_READER_DISABLEReady = true; } return _FLAG_READER_DISABLEContent; } }
        private static int _FLAG_READER_DISABLEContent = default;
        private static bool _FLAG_READER_DISABLEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/NfcAdapter.html#FLAG_READER_KEEP"/>
        /// </summary>
        public static int FLAG_READER_KEEP { get { if (!_FLAG_READER_KEEPReady) { _FLAG_READER_KEEPContent = SGetField<int>(LocalBridgeClazz, "FLAG_READER_KEEP"); _FLAG_READER_KEEPReady = true; } return _FLAG_READER_KEEPContent; } }
        private static int _FLAG_READER_KEEPContent = default;
        private static bool _FLAG_READER_KEEPReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/NfcAdapter.html#FLAG_READER_NFC_A"/>
        /// </summary>
        public static int FLAG_READER_NFC_A { get { if (!_FLAG_READER_NFC_AReady) { _FLAG_READER_NFC_AContent = SGetField<int>(LocalBridgeClazz, "FLAG_READER_NFC_A"); _FLAG_READER_NFC_AReady = true; } return _FLAG_READER_NFC_AContent; } }
        private static int _FLAG_READER_NFC_AContent = default;
        private static bool _FLAG_READER_NFC_AReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/NfcAdapter.html#FLAG_READER_NFC_B"/>
        /// </summary>
        public static int FLAG_READER_NFC_B { get { if (!_FLAG_READER_NFC_BReady) { _FLAG_READER_NFC_BContent = SGetField<int>(LocalBridgeClazz, "FLAG_READER_NFC_B"); _FLAG_READER_NFC_BReady = true; } return _FLAG_READER_NFC_BContent; } }
        private static int _FLAG_READER_NFC_BContent = default;
        private static bool _FLAG_READER_NFC_BReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/NfcAdapter.html#FLAG_READER_NFC_BARCODE"/>
        /// </summary>
        public static int FLAG_READER_NFC_BARCODE { get { if (!_FLAG_READER_NFC_BARCODEReady) { _FLAG_READER_NFC_BARCODEContent = SGetField<int>(LocalBridgeClazz, "FLAG_READER_NFC_BARCODE"); _FLAG_READER_NFC_BARCODEReady = true; } return _FLAG_READER_NFC_BARCODEContent; } }
        private static int _FLAG_READER_NFC_BARCODEContent = default;
        private static bool _FLAG_READER_NFC_BARCODEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/NfcAdapter.html#FLAG_READER_NFC_F"/>
        /// </summary>
        public static int FLAG_READER_NFC_F { get { if (!_FLAG_READER_NFC_FReady) { _FLAG_READER_NFC_FContent = SGetField<int>(LocalBridgeClazz, "FLAG_READER_NFC_F"); _FLAG_READER_NFC_FReady = true; } return _FLAG_READER_NFC_FContent; } }
        private static int _FLAG_READER_NFC_FContent = default;
        private static bool _FLAG_READER_NFC_FReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/NfcAdapter.html#FLAG_READER_NFC_V"/>
        /// </summary>
        public static int FLAG_READER_NFC_V { get { if (!_FLAG_READER_NFC_VReady) { _FLAG_READER_NFC_VContent = SGetField<int>(LocalBridgeClazz, "FLAG_READER_NFC_V"); _FLAG_READER_NFC_VReady = true; } return _FLAG_READER_NFC_VContent; } }
        private static int _FLAG_READER_NFC_VContent = default;
        private static bool _FLAG_READER_NFC_VReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/NfcAdapter.html#FLAG_READER_NO_PLATFORM_SOUNDS"/>
        /// </summary>
        public static int FLAG_READER_NO_PLATFORM_SOUNDS { get { if (!_FLAG_READER_NO_PLATFORM_SOUNDSReady) { _FLAG_READER_NO_PLATFORM_SOUNDSContent = SGetField<int>(LocalBridgeClazz, "FLAG_READER_NO_PLATFORM_SOUNDS"); _FLAG_READER_NO_PLATFORM_SOUNDSReady = true; } return _FLAG_READER_NO_PLATFORM_SOUNDSContent; } }
        private static int _FLAG_READER_NO_PLATFORM_SOUNDSContent = default;
        private static bool _FLAG_READER_NO_PLATFORM_SOUNDSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/NfcAdapter.html#FLAG_READER_SKIP_NDEF_CHECK"/>
        /// </summary>
        public static int FLAG_READER_SKIP_NDEF_CHECK { get { if (!_FLAG_READER_SKIP_NDEF_CHECKReady) { _FLAG_READER_SKIP_NDEF_CHECKContent = SGetField<int>(LocalBridgeClazz, "FLAG_READER_SKIP_NDEF_CHECK"); _FLAG_READER_SKIP_NDEF_CHECKReady = true; } return _FLAG_READER_SKIP_NDEF_CHECKContent; } }
        private static int _FLAG_READER_SKIP_NDEF_CHECKContent = default;
        private static bool _FLAG_READER_SKIP_NDEF_CHECKReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/NfcAdapter.html#PREFERRED_PAYMENT_CHANGED"/>
        /// </summary>
        public static int PREFERRED_PAYMENT_CHANGED { get { if (!_PREFERRED_PAYMENT_CHANGEDReady) { _PREFERRED_PAYMENT_CHANGEDContent = SGetField<int>(LocalBridgeClazz, "PREFERRED_PAYMENT_CHANGED"); _PREFERRED_PAYMENT_CHANGEDReady = true; } return _PREFERRED_PAYMENT_CHANGEDContent; } }
        private static int _PREFERRED_PAYMENT_CHANGEDContent = default;
        private static bool _PREFERRED_PAYMENT_CHANGEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/NfcAdapter.html#PREFERRED_PAYMENT_LOADED"/>
        /// </summary>
        public static int PREFERRED_PAYMENT_LOADED { get { if (!_PREFERRED_PAYMENT_LOADEDReady) { _PREFERRED_PAYMENT_LOADEDContent = SGetField<int>(LocalBridgeClazz, "PREFERRED_PAYMENT_LOADED"); _PREFERRED_PAYMENT_LOADEDReady = true; } return _PREFERRED_PAYMENT_LOADEDContent; } }
        private static int _PREFERRED_PAYMENT_LOADEDContent = default;
        private static bool _PREFERRED_PAYMENT_LOADEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/NfcAdapter.html#PREFERRED_PAYMENT_UPDATED"/>
        /// </summary>
        public static int PREFERRED_PAYMENT_UPDATED { get { if (!_PREFERRED_PAYMENT_UPDATEDReady) { _PREFERRED_PAYMENT_UPDATEDContent = SGetField<int>(LocalBridgeClazz, "PREFERRED_PAYMENT_UPDATED"); _PREFERRED_PAYMENT_UPDATEDReady = true; } return _PREFERRED_PAYMENT_UPDATEDContent; } }
        private static int _PREFERRED_PAYMENT_UPDATEDContent = default;
        private static bool _PREFERRED_PAYMENT_UPDATEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/NfcAdapter.html#STATE_OFF"/>
        /// </summary>
        public static int STATE_OFF { get { if (!_STATE_OFFReady) { _STATE_OFFContent = SGetField<int>(LocalBridgeClazz, "STATE_OFF"); _STATE_OFFReady = true; } return _STATE_OFFContent; } }
        private static int _STATE_OFFContent = default;
        private static bool _STATE_OFFReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/NfcAdapter.html#STATE_ON"/>
        /// </summary>
        public static int STATE_ON { get { if (!_STATE_ONReady) { _STATE_ONContent = SGetField<int>(LocalBridgeClazz, "STATE_ON"); _STATE_ONReady = true; } return _STATE_ONContent; } }
        private static int _STATE_ONContent = default;
        private static bool _STATE_ONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/NfcAdapter.html#STATE_TURNING_OFF"/>
        /// </summary>
        public static int STATE_TURNING_OFF { get { if (!_STATE_TURNING_OFFReady) { _STATE_TURNING_OFFContent = SGetField<int>(LocalBridgeClazz, "STATE_TURNING_OFF"); _STATE_TURNING_OFFReady = true; } return _STATE_TURNING_OFFContent; } }
        private static int _STATE_TURNING_OFFContent = default;
        private static bool _STATE_TURNING_OFFReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/NfcAdapter.html#STATE_TURNING_ON"/>
        /// </summary>
        public static int STATE_TURNING_ON { get { if (!_STATE_TURNING_ONReady) { _STATE_TURNING_ONContent = SGetField<int>(LocalBridgeClazz, "STATE_TURNING_ON"); _STATE_TURNING_ONReady = true; } return _STATE_TURNING_ONContent; } }
        private static int _STATE_TURNING_ONContent = default;
        private static bool _STATE_TURNING_ONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/NfcAdapter.html#ACTION_ADAPTER_STATE_CHANGED"/>
        /// </summary>
        public static Java.Lang.String ACTION_ADAPTER_STATE_CHANGED { get { if (!_ACTION_ADAPTER_STATE_CHANGEDReady) { _ACTION_ADAPTER_STATE_CHANGEDContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ACTION_ADAPTER_STATE_CHANGED"); _ACTION_ADAPTER_STATE_CHANGEDReady = true; } return _ACTION_ADAPTER_STATE_CHANGEDContent; } }
        private static Java.Lang.String _ACTION_ADAPTER_STATE_CHANGEDContent = default;
        private static bool _ACTION_ADAPTER_STATE_CHANGEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/NfcAdapter.html#ACTION_NDEF_DISCOVERED"/>
        /// </summary>
        public static Java.Lang.String ACTION_NDEF_DISCOVERED { get { if (!_ACTION_NDEF_DISCOVEREDReady) { _ACTION_NDEF_DISCOVEREDContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ACTION_NDEF_DISCOVERED"); _ACTION_NDEF_DISCOVEREDReady = true; } return _ACTION_NDEF_DISCOVEREDContent; } }
        private static Java.Lang.String _ACTION_NDEF_DISCOVEREDContent = default;
        private static bool _ACTION_NDEF_DISCOVEREDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/NfcAdapter.html#ACTION_PREFERRED_PAYMENT_CHANGED"/>
        /// </summary>
        public static Java.Lang.String ACTION_PREFERRED_PAYMENT_CHANGED { get { if (!_ACTION_PREFERRED_PAYMENT_CHANGEDReady) { _ACTION_PREFERRED_PAYMENT_CHANGEDContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ACTION_PREFERRED_PAYMENT_CHANGED"); _ACTION_PREFERRED_PAYMENT_CHANGEDReady = true; } return _ACTION_PREFERRED_PAYMENT_CHANGEDContent; } }
        private static Java.Lang.String _ACTION_PREFERRED_PAYMENT_CHANGEDContent = default;
        private static bool _ACTION_PREFERRED_PAYMENT_CHANGEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/NfcAdapter.html#ACTION_TAG_DISCOVERED"/>
        /// </summary>
        public static Java.Lang.String ACTION_TAG_DISCOVERED { get { if (!_ACTION_TAG_DISCOVEREDReady) { _ACTION_TAG_DISCOVEREDContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ACTION_TAG_DISCOVERED"); _ACTION_TAG_DISCOVEREDReady = true; } return _ACTION_TAG_DISCOVEREDContent; } }
        private static Java.Lang.String _ACTION_TAG_DISCOVEREDContent = default;
        private static bool _ACTION_TAG_DISCOVEREDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/NfcAdapter.html#ACTION_TECH_DISCOVERED"/>
        /// </summary>
        public static Java.Lang.String ACTION_TECH_DISCOVERED { get { if (!_ACTION_TECH_DISCOVEREDReady) { _ACTION_TECH_DISCOVEREDContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ACTION_TECH_DISCOVERED"); _ACTION_TECH_DISCOVEREDReady = true; } return _ACTION_TECH_DISCOVEREDContent; } }
        private static Java.Lang.String _ACTION_TECH_DISCOVEREDContent = default;
        private static bool _ACTION_TECH_DISCOVEREDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/NfcAdapter.html#ACTION_TRANSACTION_DETECTED"/>
        /// </summary>
        public static Java.Lang.String ACTION_TRANSACTION_DETECTED { get { if (!_ACTION_TRANSACTION_DETECTEDReady) { _ACTION_TRANSACTION_DETECTEDContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ACTION_TRANSACTION_DETECTED"); _ACTION_TRANSACTION_DETECTEDReady = true; } return _ACTION_TRANSACTION_DETECTEDContent; } }
        private static Java.Lang.String _ACTION_TRANSACTION_DETECTEDContent = default;
        private static bool _ACTION_TRANSACTION_DETECTEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/NfcAdapter.html#EXTRA_ADAPTER_STATE"/>
        /// </summary>
        public static Java.Lang.String EXTRA_ADAPTER_STATE { get { if (!_EXTRA_ADAPTER_STATEReady) { _EXTRA_ADAPTER_STATEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_ADAPTER_STATE"); _EXTRA_ADAPTER_STATEReady = true; } return _EXTRA_ADAPTER_STATEContent; } }
        private static Java.Lang.String _EXTRA_ADAPTER_STATEContent = default;
        private static bool _EXTRA_ADAPTER_STATEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/NfcAdapter.html#EXTRA_AID"/>
        /// </summary>
        public static Java.Lang.String EXTRA_AID { get { if (!_EXTRA_AIDReady) { _EXTRA_AIDContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_AID"); _EXTRA_AIDReady = true; } return _EXTRA_AIDContent; } }
        private static Java.Lang.String _EXTRA_AIDContent = default;
        private static bool _EXTRA_AIDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/NfcAdapter.html#EXTRA_DATA"/>
        /// </summary>
        public static Java.Lang.String EXTRA_DATA { get { if (!_EXTRA_DATAReady) { _EXTRA_DATAContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_DATA"); _EXTRA_DATAReady = true; } return _EXTRA_DATAContent; } }
        private static Java.Lang.String _EXTRA_DATAContent = default;
        private static bool _EXTRA_DATAReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/NfcAdapter.html#EXTRA_ID"/>
        /// </summary>
        public static Java.Lang.String EXTRA_ID { get { if (!_EXTRA_IDReady) { _EXTRA_IDContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_ID"); _EXTRA_IDReady = true; } return _EXTRA_IDContent; } }
        private static Java.Lang.String _EXTRA_IDContent = default;
        private static bool _EXTRA_IDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/NfcAdapter.html#EXTRA_NDEF_MESSAGES"/>
        /// </summary>
        public static Java.Lang.String EXTRA_NDEF_MESSAGES { get { if (!_EXTRA_NDEF_MESSAGESReady) { _EXTRA_NDEF_MESSAGESContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_NDEF_MESSAGES"); _EXTRA_NDEF_MESSAGESReady = true; } return _EXTRA_NDEF_MESSAGESContent; } }
        private static Java.Lang.String _EXTRA_NDEF_MESSAGESContent = default;
        private static bool _EXTRA_NDEF_MESSAGESReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/NfcAdapter.html#EXTRA_PREFERRED_PAYMENT_CHANGED_REASON"/>
        /// </summary>
        public static Java.Lang.String EXTRA_PREFERRED_PAYMENT_CHANGED_REASON { get { if (!_EXTRA_PREFERRED_PAYMENT_CHANGED_REASONReady) { _EXTRA_PREFERRED_PAYMENT_CHANGED_REASONContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_PREFERRED_PAYMENT_CHANGED_REASON"); _EXTRA_PREFERRED_PAYMENT_CHANGED_REASONReady = true; } return _EXTRA_PREFERRED_PAYMENT_CHANGED_REASONContent; } }
        private static Java.Lang.String _EXTRA_PREFERRED_PAYMENT_CHANGED_REASONContent = default;
        private static bool _EXTRA_PREFERRED_PAYMENT_CHANGED_REASONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/NfcAdapter.html#EXTRA_READER_PRESENCE_CHECK_DELAY"/>
        /// </summary>
        public static Java.Lang.String EXTRA_READER_PRESENCE_CHECK_DELAY { get { if (!_EXTRA_READER_PRESENCE_CHECK_DELAYReady) { _EXTRA_READER_PRESENCE_CHECK_DELAYContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_READER_PRESENCE_CHECK_DELAY"); _EXTRA_READER_PRESENCE_CHECK_DELAYReady = true; } return _EXTRA_READER_PRESENCE_CHECK_DELAYContent; } }
        private static Java.Lang.String _EXTRA_READER_PRESENCE_CHECK_DELAYContent = default;
        private static bool _EXTRA_READER_PRESENCE_CHECK_DELAYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/NfcAdapter.html#EXTRA_SECURE_ELEMENT_NAME"/>
        /// </summary>
        public static Java.Lang.String EXTRA_SECURE_ELEMENT_NAME { get { if (!_EXTRA_SECURE_ELEMENT_NAMEReady) { _EXTRA_SECURE_ELEMENT_NAMEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_SECURE_ELEMENT_NAME"); _EXTRA_SECURE_ELEMENT_NAMEReady = true; } return _EXTRA_SECURE_ELEMENT_NAMEContent; } }
        private static Java.Lang.String _EXTRA_SECURE_ELEMENT_NAMEContent = default;
        private static bool _EXTRA_SECURE_ELEMENT_NAMEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/NfcAdapter.html#EXTRA_TAG"/>
        /// </summary>
        public static Java.Lang.String EXTRA_TAG { get { if (!_EXTRA_TAGReady) { _EXTRA_TAGContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_TAG"); _EXTRA_TAGReady = true; } return _EXTRA_TAGContent; } }
        private static Java.Lang.String _EXTRA_TAGContent = default;
        private static bool _EXTRA_TAGReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/NfcAdapter.html#getDefaultAdapter(android.content.Context)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <returns><see cref="Android.Nfc.NfcAdapter"/></returns>
        public static Android.Nfc.NfcAdapter GetDefaultAdapter(Android.Content.Context arg0)
        {
            return SExecuteWithSignature<Android.Nfc.NfcAdapter>(LocalBridgeClazz, "getDefaultAdapter", "(Landroid/content/Context;)Landroid/nfc/NfcAdapter;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/NfcAdapter.html#getNfcAntennaInfo()"/>
        /// </summary>
        /// <returns><see cref="Android.Nfc.NfcAntennaInfo"/></returns>
        public Android.Nfc.NfcAntennaInfo GetNfcAntennaInfo()
        {
            return IExecuteWithSignature<Android.Nfc.NfcAntennaInfo>("getNfcAntennaInfo", "()Landroid/nfc/NfcAntennaInfo;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/NfcAdapter.html#ignore(android.nfc.Tag,int,android.nfc.NfcAdapter.OnTagRemovedListener,android.os.Handler)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Nfc.Tag"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Android.Nfc.NfcAdapter.OnTagRemovedListener"/></param>
        /// <param name="arg3"><see cref="Android.Os.Handler"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Ignore(Android.Nfc.Tag arg0, int arg1, Android.Nfc.NfcAdapter.OnTagRemovedListener arg2, Android.Os.Handler arg3)
        {
            return IExecute<bool>("ignore", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/NfcAdapter.html#isEnabled()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsEnabled()
        {
            return IExecuteWithSignature<bool>("isEnabled", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/NfcAdapter.html#isObserveModeEnabled()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsObserveModeEnabled()
        {
            return IExecuteWithSignature<bool>("isObserveModeEnabled", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/NfcAdapter.html#isObserveModeSupported()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsObserveModeSupported()
        {
            return IExecuteWithSignature<bool>("isObserveModeSupported", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/NfcAdapter.html#isReaderOptionEnabled()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsReaderOptionEnabled()
        {
            return IExecuteWithSignature<bool>("isReaderOptionEnabled", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/NfcAdapter.html#isReaderOptionSupported()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsReaderOptionSupported()
        {
            return IExecuteWithSignature<bool>("isReaderOptionSupported", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/NfcAdapter.html#isSecureNfcEnabled()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsSecureNfcEnabled()
        {
            return IExecuteWithSignature<bool>("isSecureNfcEnabled", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/NfcAdapter.html#isSecureNfcSupported()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsSecureNfcSupported()
        {
            return IExecuteWithSignature<bool>("isSecureNfcSupported", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/NfcAdapter.html#setObserveModeEnabled(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool SetObserveModeEnabled(bool arg0)
        {
            return IExecuteWithSignature<bool>("setObserveModeEnabled", "(Z)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/NfcAdapter.html#disableForegroundDispatch(android.app.Activity)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.App.Activity"/></param>
        public void DisableForegroundDispatch(Android.App.Activity arg0)
        {
            IExecuteWithSignature("disableForegroundDispatch", "(Landroid/app/Activity;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/NfcAdapter.html#disableReaderMode(android.app.Activity)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.App.Activity"/></param>
        public void DisableReaderMode(Android.App.Activity arg0)
        {
            IExecuteWithSignature("disableReaderMode", "(Landroid/app/Activity;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/NfcAdapter.html#enableForegroundDispatch(android.app.Activity,android.app.PendingIntent,android.content.IntentFilter[],java.lang.String[][])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.App.Activity"/></param>
        /// <param name="arg1"><see cref="Android.App.PendingIntent"/></param>
        /// <param name="arg2"><see cref="Android.Content.IntentFilter"/></param>
        /// <param name="arg3"><see cref="Java.Lang.String"/></param>
        public void EnableForegroundDispatch(Android.App.Activity arg0, Android.App.PendingIntent arg1, Android.Content.IntentFilter[] arg2, Java.Lang.String[][] arg3)
        {
            IExecute("enableForegroundDispatch", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/NfcAdapter.html#enableReaderMode(android.app.Activity,android.nfc.NfcAdapter.ReaderCallback,int,android.os.Bundle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.App.Activity"/></param>
        /// <param name="arg1"><see cref="Android.Nfc.NfcAdapter.ReaderCallback"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="Android.Os.Bundle"/></param>
        public void EnableReaderMode(Android.App.Activity arg0, Android.Nfc.NfcAdapter.ReaderCallback arg1, int arg2, Android.Os.Bundle arg3)
        {
            IExecute("enableReaderMode", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/NfcAdapter.html#resetDiscoveryTechnology(android.app.Activity)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.App.Activity"/></param>
        public void ResetDiscoveryTechnology(Android.App.Activity arg0)
        {
            IExecuteWithSignature("resetDiscoveryTechnology", "(Landroid/app/Activity;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/NfcAdapter.html#setDiscoveryTechnology(android.app.Activity,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.App.Activity"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public void SetDiscoveryTechnology(Android.App.Activity arg0, int arg1, int arg2)
        {
            IExecute("setDiscoveryTechnology", arg0, arg1, arg2);
        }

        #endregion

        #region Nested classes
        #region CreateBeamUrisCallback
        public partial class CreateBeamUrisCallback
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
            /// <see href="https://developer.android.com/reference/android/nfc/NfcAdapter.CreateBeamUrisCallback.html#createBeamUris(android.nfc.NfcEvent)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Nfc.NfcEvent"/></param>
            /// <returns><see cref="Android.Net.Uri"/></returns>
            [global::System.Obsolete()]
            public Android.Net.Uri[] CreateBeamUris(Android.Nfc.NfcEvent arg0)
            {
                return IExecuteWithSignatureArray<Android.Net.Uri>("createBeamUris", "(Landroid/nfc/NfcEvent;)[Landroid/net/Uri;", arg0);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region CreateNdefMessageCallback
        public partial class CreateNdefMessageCallback
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
            /// <see href="https://developer.android.com/reference/android/nfc/NfcAdapter.CreateNdefMessageCallback.html#createNdefMessage(android.nfc.NfcEvent)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Nfc.NfcEvent"/></param>
            /// <returns><see cref="Android.Nfc.NdefMessage"/></returns>
            [global::System.Obsolete()]
            public Android.Nfc.NdefMessage CreateNdefMessage(Android.Nfc.NfcEvent arg0)
            {
                return IExecuteWithSignature<Android.Nfc.NdefMessage>("createNdefMessage", "(Landroid/nfc/NfcEvent;)Landroid/nfc/NdefMessage;", arg0);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region OnNdefPushCompleteCallback
        public partial class OnNdefPushCompleteCallback
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
            /// <see href="https://developer.android.com/reference/android/nfc/NfcAdapter.OnNdefPushCompleteCallback.html#onNdefPushComplete(android.nfc.NfcEvent)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Nfc.NfcEvent"/></param>
            [global::System.Obsolete()]
            public void OnNdefPushComplete(Android.Nfc.NfcEvent arg0)
            {
                IExecuteWithSignature("onNdefPushComplete", "(Landroid/nfc/NfcEvent;)V", arg0);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region OnTagRemovedListener
        public partial class OnTagRemovedListener
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
            /// Handlers initializer for <see cref="OnTagRemovedListener"/>
            /// </summary>
            protected virtual void InitializeHandlers()
            {
                AddEventHandler("onTagRemoved", new global::System.EventHandler<CLRListenerEventArgs<CLREventData>>(OnTagRemovedEventHandler));

            }

            /// <summary>
            /// Handler for <see href="https://developer.android.com/reference/android/nfc/NfcAdapter.OnTagRemovedListener.html#onTagRemoved()"/>
            /// </summary>
            /// <remarks>If <see cref="OnOnTagRemoved"/> has a value it takes precedence over corresponding class method</remarks>
            public global::System.Action OnOnTagRemoved { get; set; } = null;

            void OnTagRemovedEventHandler(object sender, CLRListenerEventArgs<CLREventData> data)
            {
                var methodToExecute = (OnOnTagRemoved != null) ? OnOnTagRemoved : OnTagRemoved;
                methodToExecute.Invoke();
            }

            /// <summary>
            /// <see href="https://developer.android.com/reference/android/nfc/NfcAdapter.OnTagRemovedListener.html#onTagRemoved()"/>
            /// </summary>
            public virtual void OnTagRemoved()
            {
                
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region OnTagRemovedListenerDirect
        public partial class OnTagRemovedListenerDirect
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
            /// <see href="https://developer.android.com/reference/android/nfc/NfcAdapter.OnTagRemovedListener.html#onTagRemoved()"/>
            /// </summary>
            public override void OnTagRemoved()
            {
                IExecuteWithSignature("onTagRemoved", "()V");
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region ReaderCallback
        public partial class ReaderCallback
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
            /// <see href="https://developer.android.com/reference/android/nfc/NfcAdapter.ReaderCallback.html#onTagDiscovered(android.nfc.Tag)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Nfc.Tag"/></param>
            public void OnTagDiscovered(Android.Nfc.Tag arg0)
            {
                IExecuteWithSignature("onTagDiscovered", "(Landroid/nfc/Tag;)V", arg0);
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