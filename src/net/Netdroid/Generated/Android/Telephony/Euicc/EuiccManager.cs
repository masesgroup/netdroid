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

namespace Android.Telephony.Euicc
{
    #region EuiccManager
    public partial class EuiccManager
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/euicc/EuiccManager.html#EMBEDDED_SUBSCRIPTION_RESULT_ERROR"/>
        /// </summary>
        public static int EMBEDDED_SUBSCRIPTION_RESULT_ERROR { get { if (!_EMBEDDED_SUBSCRIPTION_RESULT_ERRORReady) { _EMBEDDED_SUBSCRIPTION_RESULT_ERRORContent = SGetField<int>(LocalBridgeClazz, "EMBEDDED_SUBSCRIPTION_RESULT_ERROR"); _EMBEDDED_SUBSCRIPTION_RESULT_ERRORReady = true; } return _EMBEDDED_SUBSCRIPTION_RESULT_ERRORContent; } }
        private static int _EMBEDDED_SUBSCRIPTION_RESULT_ERRORContent = default;
        private static bool _EMBEDDED_SUBSCRIPTION_RESULT_ERRORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/euicc/EuiccManager.html#EMBEDDED_SUBSCRIPTION_RESULT_OK"/>
        /// </summary>
        public static int EMBEDDED_SUBSCRIPTION_RESULT_OK { get { if (!_EMBEDDED_SUBSCRIPTION_RESULT_OKReady) { _EMBEDDED_SUBSCRIPTION_RESULT_OKContent = SGetField<int>(LocalBridgeClazz, "EMBEDDED_SUBSCRIPTION_RESULT_OK"); _EMBEDDED_SUBSCRIPTION_RESULT_OKReady = true; } return _EMBEDDED_SUBSCRIPTION_RESULT_OKContent; } }
        private static int _EMBEDDED_SUBSCRIPTION_RESULT_OKContent = default;
        private static bool _EMBEDDED_SUBSCRIPTION_RESULT_OKReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/euicc/EuiccManager.html#EMBEDDED_SUBSCRIPTION_RESULT_RESOLVABLE_ERROR"/>
        /// </summary>
        public static int EMBEDDED_SUBSCRIPTION_RESULT_RESOLVABLE_ERROR { get { if (!_EMBEDDED_SUBSCRIPTION_RESULT_RESOLVABLE_ERRORReady) { _EMBEDDED_SUBSCRIPTION_RESULT_RESOLVABLE_ERRORContent = SGetField<int>(LocalBridgeClazz, "EMBEDDED_SUBSCRIPTION_RESULT_RESOLVABLE_ERROR"); _EMBEDDED_SUBSCRIPTION_RESULT_RESOLVABLE_ERRORReady = true; } return _EMBEDDED_SUBSCRIPTION_RESULT_RESOLVABLE_ERRORContent; } }
        private static int _EMBEDDED_SUBSCRIPTION_RESULT_RESOLVABLE_ERRORContent = default;
        private static bool _EMBEDDED_SUBSCRIPTION_RESULT_RESOLVABLE_ERRORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/euicc/EuiccManager.html#ERROR_ADDRESS_MISSING"/>
        /// </summary>
        public static int ERROR_ADDRESS_MISSING { get { if (!_ERROR_ADDRESS_MISSINGReady) { _ERROR_ADDRESS_MISSINGContent = SGetField<int>(LocalBridgeClazz, "ERROR_ADDRESS_MISSING"); _ERROR_ADDRESS_MISSINGReady = true; } return _ERROR_ADDRESS_MISSINGContent; } }
        private static int _ERROR_ADDRESS_MISSINGContent = default;
        private static bool _ERROR_ADDRESS_MISSINGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/euicc/EuiccManager.html#ERROR_CARRIER_LOCKED"/>
        /// </summary>
        public static int ERROR_CARRIER_LOCKED { get { if (!_ERROR_CARRIER_LOCKEDReady) { _ERROR_CARRIER_LOCKEDContent = SGetField<int>(LocalBridgeClazz, "ERROR_CARRIER_LOCKED"); _ERROR_CARRIER_LOCKEDReady = true; } return _ERROR_CARRIER_LOCKEDContent; } }
        private static int _ERROR_CARRIER_LOCKEDContent = default;
        private static bool _ERROR_CARRIER_LOCKEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/euicc/EuiccManager.html#ERROR_CERTIFICATE_ERROR"/>
        /// </summary>
        public static int ERROR_CERTIFICATE_ERROR { get { if (!_ERROR_CERTIFICATE_ERRORReady) { _ERROR_CERTIFICATE_ERRORContent = SGetField<int>(LocalBridgeClazz, "ERROR_CERTIFICATE_ERROR"); _ERROR_CERTIFICATE_ERRORReady = true; } return _ERROR_CERTIFICATE_ERRORContent; } }
        private static int _ERROR_CERTIFICATE_ERRORContent = default;
        private static bool _ERROR_CERTIFICATE_ERRORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/euicc/EuiccManager.html#ERROR_CONNECTION_ERROR"/>
        /// </summary>
        public static int ERROR_CONNECTION_ERROR { get { if (!_ERROR_CONNECTION_ERRORReady) { _ERROR_CONNECTION_ERRORContent = SGetField<int>(LocalBridgeClazz, "ERROR_CONNECTION_ERROR"); _ERROR_CONNECTION_ERRORReady = true; } return _ERROR_CONNECTION_ERRORContent; } }
        private static int _ERROR_CONNECTION_ERRORContent = default;
        private static bool _ERROR_CONNECTION_ERRORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/euicc/EuiccManager.html#ERROR_DISALLOWED_BY_PPR"/>
        /// </summary>
        public static int ERROR_DISALLOWED_BY_PPR { get { if (!_ERROR_DISALLOWED_BY_PPRReady) { _ERROR_DISALLOWED_BY_PPRContent = SGetField<int>(LocalBridgeClazz, "ERROR_DISALLOWED_BY_PPR"); _ERROR_DISALLOWED_BY_PPRReady = true; } return _ERROR_DISALLOWED_BY_PPRContent; } }
        private static int _ERROR_DISALLOWED_BY_PPRContent = default;
        private static bool _ERROR_DISALLOWED_BY_PPRReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/euicc/EuiccManager.html#ERROR_EUICC_INSUFFICIENT_MEMORY"/>
        /// </summary>
        public static int ERROR_EUICC_INSUFFICIENT_MEMORY { get { if (!_ERROR_EUICC_INSUFFICIENT_MEMORYReady) { _ERROR_EUICC_INSUFFICIENT_MEMORYContent = SGetField<int>(LocalBridgeClazz, "ERROR_EUICC_INSUFFICIENT_MEMORY"); _ERROR_EUICC_INSUFFICIENT_MEMORYReady = true; } return _ERROR_EUICC_INSUFFICIENT_MEMORYContent; } }
        private static int _ERROR_EUICC_INSUFFICIENT_MEMORYContent = default;
        private static bool _ERROR_EUICC_INSUFFICIENT_MEMORYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/euicc/EuiccManager.html#ERROR_EUICC_MISSING"/>
        /// </summary>
        public static int ERROR_EUICC_MISSING { get { if (!_ERROR_EUICC_MISSINGReady) { _ERROR_EUICC_MISSINGContent = SGetField<int>(LocalBridgeClazz, "ERROR_EUICC_MISSING"); _ERROR_EUICC_MISSINGReady = true; } return _ERROR_EUICC_MISSINGContent; } }
        private static int _ERROR_EUICC_MISSINGContent = default;
        private static bool _ERROR_EUICC_MISSINGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/euicc/EuiccManager.html#ERROR_INCOMPATIBLE_CARRIER"/>
        /// </summary>
        public static int ERROR_INCOMPATIBLE_CARRIER { get { if (!_ERROR_INCOMPATIBLE_CARRIERReady) { _ERROR_INCOMPATIBLE_CARRIERContent = SGetField<int>(LocalBridgeClazz, "ERROR_INCOMPATIBLE_CARRIER"); _ERROR_INCOMPATIBLE_CARRIERReady = true; } return _ERROR_INCOMPATIBLE_CARRIERContent; } }
        private static int _ERROR_INCOMPATIBLE_CARRIERContent = default;
        private static bool _ERROR_INCOMPATIBLE_CARRIERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/euicc/EuiccManager.html#ERROR_INSTALL_PROFILE"/>
        /// </summary>
        public static int ERROR_INSTALL_PROFILE { get { if (!_ERROR_INSTALL_PROFILEReady) { _ERROR_INSTALL_PROFILEContent = SGetField<int>(LocalBridgeClazz, "ERROR_INSTALL_PROFILE"); _ERROR_INSTALL_PROFILEReady = true; } return _ERROR_INSTALL_PROFILEContent; } }
        private static int _ERROR_INSTALL_PROFILEContent = default;
        private static bool _ERROR_INSTALL_PROFILEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/euicc/EuiccManager.html#ERROR_INVALID_ACTIVATION_CODE"/>
        /// </summary>
        public static int ERROR_INVALID_ACTIVATION_CODE { get { if (!_ERROR_INVALID_ACTIVATION_CODEReady) { _ERROR_INVALID_ACTIVATION_CODEContent = SGetField<int>(LocalBridgeClazz, "ERROR_INVALID_ACTIVATION_CODE"); _ERROR_INVALID_ACTIVATION_CODEReady = true; } return _ERROR_INVALID_ACTIVATION_CODEContent; } }
        private static int _ERROR_INVALID_ACTIVATION_CODEContent = default;
        private static bool _ERROR_INVALID_ACTIVATION_CODEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/euicc/EuiccManager.html#ERROR_INVALID_CONFIRMATION_CODE"/>
        /// </summary>
        public static int ERROR_INVALID_CONFIRMATION_CODE { get { if (!_ERROR_INVALID_CONFIRMATION_CODEReady) { _ERROR_INVALID_CONFIRMATION_CODEContent = SGetField<int>(LocalBridgeClazz, "ERROR_INVALID_CONFIRMATION_CODE"); _ERROR_INVALID_CONFIRMATION_CODEReady = true; } return _ERROR_INVALID_CONFIRMATION_CODEContent; } }
        private static int _ERROR_INVALID_CONFIRMATION_CODEContent = default;
        private static bool _ERROR_INVALID_CONFIRMATION_CODEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/euicc/EuiccManager.html#ERROR_INVALID_PORT"/>
        /// </summary>
        public static int ERROR_INVALID_PORT { get { if (!_ERROR_INVALID_PORTReady) { _ERROR_INVALID_PORTContent = SGetField<int>(LocalBridgeClazz, "ERROR_INVALID_PORT"); _ERROR_INVALID_PORTReady = true; } return _ERROR_INVALID_PORTContent; } }
        private static int _ERROR_INVALID_PORTContent = default;
        private static bool _ERROR_INVALID_PORTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/euicc/EuiccManager.html#ERROR_INVALID_RESPONSE"/>
        /// </summary>
        public static int ERROR_INVALID_RESPONSE { get { if (!_ERROR_INVALID_RESPONSEReady) { _ERROR_INVALID_RESPONSEContent = SGetField<int>(LocalBridgeClazz, "ERROR_INVALID_RESPONSE"); _ERROR_INVALID_RESPONSEReady = true; } return _ERROR_INVALID_RESPONSEContent; } }
        private static int _ERROR_INVALID_RESPONSEContent = default;
        private static bool _ERROR_INVALID_RESPONSEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/euicc/EuiccManager.html#ERROR_NO_PROFILES_AVAILABLE"/>
        /// </summary>
        public static int ERROR_NO_PROFILES_AVAILABLE { get { if (!_ERROR_NO_PROFILES_AVAILABLEReady) { _ERROR_NO_PROFILES_AVAILABLEContent = SGetField<int>(LocalBridgeClazz, "ERROR_NO_PROFILES_AVAILABLE"); _ERROR_NO_PROFILES_AVAILABLEReady = true; } return _ERROR_NO_PROFILES_AVAILABLEContent; } }
        private static int _ERROR_NO_PROFILES_AVAILABLEContent = default;
        private static bool _ERROR_NO_PROFILES_AVAILABLEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/euicc/EuiccManager.html#ERROR_OPERATION_BUSY"/>
        /// </summary>
        public static int ERROR_OPERATION_BUSY { get { if (!_ERROR_OPERATION_BUSYReady) { _ERROR_OPERATION_BUSYContent = SGetField<int>(LocalBridgeClazz, "ERROR_OPERATION_BUSY"); _ERROR_OPERATION_BUSYReady = true; } return _ERROR_OPERATION_BUSYContent; } }
        private static int _ERROR_OPERATION_BUSYContent = default;
        private static bool _ERROR_OPERATION_BUSYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/euicc/EuiccManager.html#ERROR_SIM_MISSING"/>
        /// </summary>
        public static int ERROR_SIM_MISSING { get { if (!_ERROR_SIM_MISSINGReady) { _ERROR_SIM_MISSINGContent = SGetField<int>(LocalBridgeClazz, "ERROR_SIM_MISSING"); _ERROR_SIM_MISSINGReady = true; } return _ERROR_SIM_MISSINGContent; } }
        private static int _ERROR_SIM_MISSINGContent = default;
        private static bool _ERROR_SIM_MISSINGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/euicc/EuiccManager.html#ERROR_TIME_OUT"/>
        /// </summary>
        public static int ERROR_TIME_OUT { get { if (!_ERROR_TIME_OUTReady) { _ERROR_TIME_OUTContent = SGetField<int>(LocalBridgeClazz, "ERROR_TIME_OUT"); _ERROR_TIME_OUTReady = true; } return _ERROR_TIME_OUTContent; } }
        private static int _ERROR_TIME_OUTContent = default;
        private static bool _ERROR_TIME_OUTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/euicc/EuiccManager.html#ERROR_UNSUPPORTED_VERSION"/>
        /// </summary>
        public static int ERROR_UNSUPPORTED_VERSION { get { if (!_ERROR_UNSUPPORTED_VERSIONReady) { _ERROR_UNSUPPORTED_VERSIONContent = SGetField<int>(LocalBridgeClazz, "ERROR_UNSUPPORTED_VERSION"); _ERROR_UNSUPPORTED_VERSIONReady = true; } return _ERROR_UNSUPPORTED_VERSIONContent; } }
        private static int _ERROR_UNSUPPORTED_VERSIONContent = default;
        private static bool _ERROR_UNSUPPORTED_VERSIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/euicc/EuiccManager.html#OPERATION_APDU"/>
        /// </summary>
        public static int OPERATION_APDU { get { if (!_OPERATION_APDUReady) { _OPERATION_APDUContent = SGetField<int>(LocalBridgeClazz, "OPERATION_APDU"); _OPERATION_APDUReady = true; } return _OPERATION_APDUContent; } }
        private static int _OPERATION_APDUContent = default;
        private static bool _OPERATION_APDUReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/euicc/EuiccManager.html#OPERATION_DOWNLOAD"/>
        /// </summary>
        public static int OPERATION_DOWNLOAD { get { if (!_OPERATION_DOWNLOADReady) { _OPERATION_DOWNLOADContent = SGetField<int>(LocalBridgeClazz, "OPERATION_DOWNLOAD"); _OPERATION_DOWNLOADReady = true; } return _OPERATION_DOWNLOADContent; } }
        private static int _OPERATION_DOWNLOADContent = default;
        private static bool _OPERATION_DOWNLOADReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/euicc/EuiccManager.html#OPERATION_EUICC_CARD"/>
        /// </summary>
        public static int OPERATION_EUICC_CARD { get { if (!_OPERATION_EUICC_CARDReady) { _OPERATION_EUICC_CARDContent = SGetField<int>(LocalBridgeClazz, "OPERATION_EUICC_CARD"); _OPERATION_EUICC_CARDReady = true; } return _OPERATION_EUICC_CARDContent; } }
        private static int _OPERATION_EUICC_CARDContent = default;
        private static bool _OPERATION_EUICC_CARDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/euicc/EuiccManager.html#OPERATION_EUICC_GSMA"/>
        /// </summary>
        public static int OPERATION_EUICC_GSMA { get { if (!_OPERATION_EUICC_GSMAReady) { _OPERATION_EUICC_GSMAContent = SGetField<int>(LocalBridgeClazz, "OPERATION_EUICC_GSMA"); _OPERATION_EUICC_GSMAReady = true; } return _OPERATION_EUICC_GSMAContent; } }
        private static int _OPERATION_EUICC_GSMAContent = default;
        private static bool _OPERATION_EUICC_GSMAReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/euicc/EuiccManager.html#OPERATION_HTTP"/>
        /// </summary>
        public static int OPERATION_HTTP { get { if (!_OPERATION_HTTPReady) { _OPERATION_HTTPContent = SGetField<int>(LocalBridgeClazz, "OPERATION_HTTP"); _OPERATION_HTTPReady = true; } return _OPERATION_HTTPContent; } }
        private static int _OPERATION_HTTPContent = default;
        private static bool _OPERATION_HTTPReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/euicc/EuiccManager.html#OPERATION_METADATA"/>
        /// </summary>
        public static int OPERATION_METADATA { get { if (!_OPERATION_METADATAReady) { _OPERATION_METADATAContent = SGetField<int>(LocalBridgeClazz, "OPERATION_METADATA"); _OPERATION_METADATAReady = true; } return _OPERATION_METADATAContent; } }
        private static int _OPERATION_METADATAContent = default;
        private static bool _OPERATION_METADATAReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/euicc/EuiccManager.html#OPERATION_SIM_SLOT"/>
        /// </summary>
        public static int OPERATION_SIM_SLOT { get { if (!_OPERATION_SIM_SLOTReady) { _OPERATION_SIM_SLOTContent = SGetField<int>(LocalBridgeClazz, "OPERATION_SIM_SLOT"); _OPERATION_SIM_SLOTReady = true; } return _OPERATION_SIM_SLOTContent; } }
        private static int _OPERATION_SIM_SLOTContent = default;
        private static bool _OPERATION_SIM_SLOTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/euicc/EuiccManager.html#OPERATION_SMDX"/>
        /// </summary>
        public static int OPERATION_SMDX { get { if (!_OPERATION_SMDXReady) { _OPERATION_SMDXContent = SGetField<int>(LocalBridgeClazz, "OPERATION_SMDX"); _OPERATION_SMDXReady = true; } return _OPERATION_SMDXContent; } }
        private static int _OPERATION_SMDXContent = default;
        private static bool _OPERATION_SMDXReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/euicc/EuiccManager.html#OPERATION_SMDX_SUBJECT_REASON_CODE"/>
        /// </summary>
        public static int OPERATION_SMDX_SUBJECT_REASON_CODE { get { if (!_OPERATION_SMDX_SUBJECT_REASON_CODEReady) { _OPERATION_SMDX_SUBJECT_REASON_CODEContent = SGetField<int>(LocalBridgeClazz, "OPERATION_SMDX_SUBJECT_REASON_CODE"); _OPERATION_SMDX_SUBJECT_REASON_CODEReady = true; } return _OPERATION_SMDX_SUBJECT_REASON_CODEContent; } }
        private static int _OPERATION_SMDX_SUBJECT_REASON_CODEContent = default;
        private static bool _OPERATION_SMDX_SUBJECT_REASON_CODEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/euicc/EuiccManager.html#OPERATION_SWITCH"/>
        /// </summary>
        public static int OPERATION_SWITCH { get { if (!_OPERATION_SWITCHReady) { _OPERATION_SWITCHContent = SGetField<int>(LocalBridgeClazz, "OPERATION_SWITCH"); _OPERATION_SWITCHReady = true; } return _OPERATION_SWITCHContent; } }
        private static int _OPERATION_SWITCHContent = default;
        private static bool _OPERATION_SWITCHReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/euicc/EuiccManager.html#OPERATION_SYSTEM"/>
        /// </summary>
        public static int OPERATION_SYSTEM { get { if (!_OPERATION_SYSTEMReady) { _OPERATION_SYSTEMContent = SGetField<int>(LocalBridgeClazz, "OPERATION_SYSTEM"); _OPERATION_SYSTEMReady = true; } return _OPERATION_SYSTEMContent; } }
        private static int _OPERATION_SYSTEMContent = default;
        private static bool _OPERATION_SYSTEMReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/euicc/EuiccManager.html#ACTION_MANAGE_EMBEDDED_SUBSCRIPTIONS"/>
        /// </summary>
        public static Java.Lang.String ACTION_MANAGE_EMBEDDED_SUBSCRIPTIONS { get { if (!_ACTION_MANAGE_EMBEDDED_SUBSCRIPTIONSReady) { _ACTION_MANAGE_EMBEDDED_SUBSCRIPTIONSContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ACTION_MANAGE_EMBEDDED_SUBSCRIPTIONS"); _ACTION_MANAGE_EMBEDDED_SUBSCRIPTIONSReady = true; } return _ACTION_MANAGE_EMBEDDED_SUBSCRIPTIONSContent; } }
        private static Java.Lang.String _ACTION_MANAGE_EMBEDDED_SUBSCRIPTIONSContent = default;
        private static bool _ACTION_MANAGE_EMBEDDED_SUBSCRIPTIONSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/euicc/EuiccManager.html#ACTION_NOTIFY_CARRIER_SETUP_INCOMPLETE"/>
        /// </summary>
        public static Java.Lang.String ACTION_NOTIFY_CARRIER_SETUP_INCOMPLETE { get { if (!_ACTION_NOTIFY_CARRIER_SETUP_INCOMPLETEReady) { _ACTION_NOTIFY_CARRIER_SETUP_INCOMPLETEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ACTION_NOTIFY_CARRIER_SETUP_INCOMPLETE"); _ACTION_NOTIFY_CARRIER_SETUP_INCOMPLETEReady = true; } return _ACTION_NOTIFY_CARRIER_SETUP_INCOMPLETEContent; } }
        private static Java.Lang.String _ACTION_NOTIFY_CARRIER_SETUP_INCOMPLETEContent = default;
        private static bool _ACTION_NOTIFY_CARRIER_SETUP_INCOMPLETEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/euicc/EuiccManager.html#ACTION_START_EUICC_ACTIVATION"/>
        /// </summary>
        public static Java.Lang.String ACTION_START_EUICC_ACTIVATION { get { if (!_ACTION_START_EUICC_ACTIVATIONReady) { _ACTION_START_EUICC_ACTIVATIONContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ACTION_START_EUICC_ACTIVATION"); _ACTION_START_EUICC_ACTIVATIONReady = true; } return _ACTION_START_EUICC_ACTIVATIONContent; } }
        private static Java.Lang.String _ACTION_START_EUICC_ACTIVATIONContent = default;
        private static bool _ACTION_START_EUICC_ACTIVATIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/euicc/EuiccManager.html#EXTRA_EMBEDDED_SUBSCRIPTION_DETAILED_CODE"/>
        /// </summary>
        public static Java.Lang.String EXTRA_EMBEDDED_SUBSCRIPTION_DETAILED_CODE { get { if (!_EXTRA_EMBEDDED_SUBSCRIPTION_DETAILED_CODEReady) { _EXTRA_EMBEDDED_SUBSCRIPTION_DETAILED_CODEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_EMBEDDED_SUBSCRIPTION_DETAILED_CODE"); _EXTRA_EMBEDDED_SUBSCRIPTION_DETAILED_CODEReady = true; } return _EXTRA_EMBEDDED_SUBSCRIPTION_DETAILED_CODEContent; } }
        private static Java.Lang.String _EXTRA_EMBEDDED_SUBSCRIPTION_DETAILED_CODEContent = default;
        private static bool _EXTRA_EMBEDDED_SUBSCRIPTION_DETAILED_CODEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/euicc/EuiccManager.html#EXTRA_EMBEDDED_SUBSCRIPTION_DOWNLOADABLE_SUBSCRIPTION"/>
        /// </summary>
        public static Java.Lang.String EXTRA_EMBEDDED_SUBSCRIPTION_DOWNLOADABLE_SUBSCRIPTION { get { if (!_EXTRA_EMBEDDED_SUBSCRIPTION_DOWNLOADABLE_SUBSCRIPTIONReady) { _EXTRA_EMBEDDED_SUBSCRIPTION_DOWNLOADABLE_SUBSCRIPTIONContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_EMBEDDED_SUBSCRIPTION_DOWNLOADABLE_SUBSCRIPTION"); _EXTRA_EMBEDDED_SUBSCRIPTION_DOWNLOADABLE_SUBSCRIPTIONReady = true; } return _EXTRA_EMBEDDED_SUBSCRIPTION_DOWNLOADABLE_SUBSCRIPTIONContent; } }
        private static Java.Lang.String _EXTRA_EMBEDDED_SUBSCRIPTION_DOWNLOADABLE_SUBSCRIPTIONContent = default;
        private static bool _EXTRA_EMBEDDED_SUBSCRIPTION_DOWNLOADABLE_SUBSCRIPTIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/euicc/EuiccManager.html#EXTRA_EMBEDDED_SUBSCRIPTION_ERROR_CODE"/>
        /// </summary>
        public static Java.Lang.String EXTRA_EMBEDDED_SUBSCRIPTION_ERROR_CODE { get { if (!_EXTRA_EMBEDDED_SUBSCRIPTION_ERROR_CODEReady) { _EXTRA_EMBEDDED_SUBSCRIPTION_ERROR_CODEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_EMBEDDED_SUBSCRIPTION_ERROR_CODE"); _EXTRA_EMBEDDED_SUBSCRIPTION_ERROR_CODEReady = true; } return _EXTRA_EMBEDDED_SUBSCRIPTION_ERROR_CODEContent; } }
        private static Java.Lang.String _EXTRA_EMBEDDED_SUBSCRIPTION_ERROR_CODEContent = default;
        private static bool _EXTRA_EMBEDDED_SUBSCRIPTION_ERROR_CODEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/euicc/EuiccManager.html#EXTRA_EMBEDDED_SUBSCRIPTION_OPERATION_CODE"/>
        /// </summary>
        public static Java.Lang.String EXTRA_EMBEDDED_SUBSCRIPTION_OPERATION_CODE { get { if (!_EXTRA_EMBEDDED_SUBSCRIPTION_OPERATION_CODEReady) { _EXTRA_EMBEDDED_SUBSCRIPTION_OPERATION_CODEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_EMBEDDED_SUBSCRIPTION_OPERATION_CODE"); _EXTRA_EMBEDDED_SUBSCRIPTION_OPERATION_CODEReady = true; } return _EXTRA_EMBEDDED_SUBSCRIPTION_OPERATION_CODEContent; } }
        private static Java.Lang.String _EXTRA_EMBEDDED_SUBSCRIPTION_OPERATION_CODEContent = default;
        private static bool _EXTRA_EMBEDDED_SUBSCRIPTION_OPERATION_CODEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/euicc/EuiccManager.html#EXTRA_EMBEDDED_SUBSCRIPTION_SMDX_REASON_CODE"/>
        /// </summary>
        public static Java.Lang.String EXTRA_EMBEDDED_SUBSCRIPTION_SMDX_REASON_CODE { get { if (!_EXTRA_EMBEDDED_SUBSCRIPTION_SMDX_REASON_CODEReady) { _EXTRA_EMBEDDED_SUBSCRIPTION_SMDX_REASON_CODEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_EMBEDDED_SUBSCRIPTION_SMDX_REASON_CODE"); _EXTRA_EMBEDDED_SUBSCRIPTION_SMDX_REASON_CODEReady = true; } return _EXTRA_EMBEDDED_SUBSCRIPTION_SMDX_REASON_CODEContent; } }
        private static Java.Lang.String _EXTRA_EMBEDDED_SUBSCRIPTION_SMDX_REASON_CODEContent = default;
        private static bool _EXTRA_EMBEDDED_SUBSCRIPTION_SMDX_REASON_CODEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/euicc/EuiccManager.html#EXTRA_EMBEDDED_SUBSCRIPTION_SMDX_SUBJECT_CODE"/>
        /// </summary>
        public static Java.Lang.String EXTRA_EMBEDDED_SUBSCRIPTION_SMDX_SUBJECT_CODE { get { if (!_EXTRA_EMBEDDED_SUBSCRIPTION_SMDX_SUBJECT_CODEReady) { _EXTRA_EMBEDDED_SUBSCRIPTION_SMDX_SUBJECT_CODEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_EMBEDDED_SUBSCRIPTION_SMDX_SUBJECT_CODE"); _EXTRA_EMBEDDED_SUBSCRIPTION_SMDX_SUBJECT_CODEReady = true; } return _EXTRA_EMBEDDED_SUBSCRIPTION_SMDX_SUBJECT_CODEContent; } }
        private static Java.Lang.String _EXTRA_EMBEDDED_SUBSCRIPTION_SMDX_SUBJECT_CODEContent = default;
        private static bool _EXTRA_EMBEDDED_SUBSCRIPTION_SMDX_SUBJECT_CODEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/euicc/EuiccManager.html#EXTRA_USE_QR_SCANNER"/>
        /// </summary>
        public static Java.Lang.String EXTRA_USE_QR_SCANNER { get { if (!_EXTRA_USE_QR_SCANNERReady) { _EXTRA_USE_QR_SCANNERContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_USE_QR_SCANNER"); _EXTRA_USE_QR_SCANNERReady = true; } return _EXTRA_USE_QR_SCANNERContent; } }
        private static Java.Lang.String _EXTRA_USE_QR_SCANNERContent = default;
        private static bool _EXTRA_USE_QR_SCANNERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/euicc/EuiccManager.html#META_DATA_CARRIER_ICON"/>
        /// </summary>
        public static Java.Lang.String META_DATA_CARRIER_ICON { get { if (!_META_DATA_CARRIER_ICONReady) { _META_DATA_CARRIER_ICONContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "META_DATA_CARRIER_ICON"); _META_DATA_CARRIER_ICONReady = true; } return _META_DATA_CARRIER_ICONContent; } }
        private static Java.Lang.String _META_DATA_CARRIER_ICONContent = default;
        private static bool _META_DATA_CARRIER_ICONReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/euicc/EuiccManager.html#getEid()"/> 
        /// </summary>
        public Java.Lang.String Eid
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getEid", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/euicc/EuiccManager.html#getEuiccInfo()"/> 
        /// </summary>
        public Android.Telephony.Euicc.EuiccInfo EuiccInfo
        {
            get { return IExecuteWithSignature<Android.Telephony.Euicc.EuiccInfo>("getEuiccInfo", "()Landroid/telephony/euicc/EuiccInfo;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/euicc/EuiccManager.html#createForCardId(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Android.Telephony.Euicc.EuiccManager"/></returns>
        public Android.Telephony.Euicc.EuiccManager CreateForCardId(int arg0)
        {
            return IExecuteWithSignature<Android.Telephony.Euicc.EuiccManager>("createForCardId", "(I)Landroid/telephony/euicc/EuiccManager;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/euicc/EuiccManager.html#isEnabled()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsEnabled()
        {
            return IExecuteWithSignature<bool>("isEnabled", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/euicc/EuiccManager.html#isSimPortAvailable(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsSimPortAvailable(int arg0)
        {
            return IExecuteWithSignature<bool>("isSimPortAvailable", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/euicc/EuiccManager.html#deleteSubscription(int,android.app.PendingIntent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Android.App.PendingIntent"/></param>
        public void DeleteSubscription(int arg0, Android.App.PendingIntent arg1)
        {
            IExecute("deleteSubscription", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/euicc/EuiccManager.html#downloadSubscription(android.telephony.euicc.DownloadableSubscription,boolean,android.app.PendingIntent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Telephony.Euicc.DownloadableSubscription"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <param name="arg2"><see cref="Android.App.PendingIntent"/></param>
        public void DownloadSubscription(Android.Telephony.Euicc.DownloadableSubscription arg0, bool arg1, Android.App.PendingIntent arg2)
        {
            IExecute("downloadSubscription", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/euicc/EuiccManager.html#startResolutionActivity(android.app.Activity,int,android.content.Intent,android.app.PendingIntent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.App.Activity"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Android.Content.Intent"/></param>
        /// <param name="arg3"><see cref="Android.App.PendingIntent"/></param>
        /// <exception cref="Android.Content.IntentSender.SendIntentException"/>
        public void StartResolutionActivity(Android.App.Activity arg0, int arg1, Android.Content.Intent arg2, Android.App.PendingIntent arg3)
        {
            IExecute("startResolutionActivity", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/euicc/EuiccManager.html#switchToSubscription(int,android.app.PendingIntent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Android.App.PendingIntent"/></param>
        public void SwitchToSubscription(int arg0, Android.App.PendingIntent arg1)
        {
            IExecute("switchToSubscription", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/euicc/EuiccManager.html#switchToSubscription(int,int,android.app.PendingIntent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Android.App.PendingIntent"/></param>
        public void SwitchToSubscription(int arg0, int arg1, Android.App.PendingIntent arg2)
        {
            IExecute("switchToSubscription", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/euicc/EuiccManager.html#updateSubscriptionNickname(int,java.lang.String,android.app.PendingIntent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Android.App.PendingIntent"/></param>
        public void UpdateSubscriptionNickname(int arg0, Java.Lang.String arg1, Android.App.PendingIntent arg2)
        {
            IExecute("updateSubscriptionNickname", arg0, arg1, arg2);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}